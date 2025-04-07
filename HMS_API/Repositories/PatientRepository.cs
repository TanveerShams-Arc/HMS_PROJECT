using HMS_API.DB;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Interfaces;
using HMS_API.Models;
using HMS_API.Models.Persons;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace HMS_API.Repositories
{
    public class PatientRepository : IPatientRepository
    {


        private readonly ITokenService _tokenService;
        private readonly AppDBContext _context;
        private readonly UserManager<AppUser> _userManager;

        public PatientRepository(AppDBContext context, ITokenService tokenService, UserManager<AppUser> userManager)
        {
            _context = context;
            _tokenService = tokenService;
            _userManager = userManager;
        }



        public async Task<Patient> CreateAsync(Patient patientModel)
        {
            try
            {
                await _context.Patient.AddAsync(patientModel);
                await _context.SaveChangesAsync();
                return patientModel;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving patient: {ex.Message}");
                throw new Exception("An error occurred while creating the patient.");
            }
        }




        public async Task<Patient?> DeleteAsync(int id)
        {
            var patient = await _context.Patient.FirstOrDefaultAsync(x => x.PatientId == id);
            if (patient == null) return null;


            var appUser = await _userManager.FindByIdAsync(patient.AppUserId);
            if (appUser == null) return null;


            var userClaims = await _userManager.GetClaimsAsync(appUser);
            await _userManager.RemoveClaimsAsync(appUser, userClaims);

            var userRoles = await _userManager.GetRolesAsync(appUser);
            foreach (var role in userRoles)
            {
                await _userManager.RemoveFromRoleAsync(appUser, role);
            }

            _context.Patient.Remove(patient);
            await _context.SaveChangesAsync();

            var deleteUserResult = await _userManager.DeleteAsync(appUser);
            if (!deleteUserResult.Succeeded) return null;

            return patient;
        }



        public async Task<List<Patient>> GetAllAsync(PatientQueryObject query)
        {
            return await _context.Patient.Include(d => d.AppUser).ToListAsync();

        }

        public async Task<Patient?> GetByIdAsync(int id)
        {
            return await _context.Patient.Include(d => d.AppUser).FirstOrDefaultAsync(i => i.PatientId == id);
        }

        public async Task<bool> PatientExistsAsync(int id)
        {
            return await _context.Patient.AnyAsync(d => d.PatientId == id);
        }

        public async Task<(Patient? updatedPatient, string newToken)> UpdateAsync(int id, UpdatePatientDto patientDto)
        {
            var existingPatient = await _context.Patient.Include(d => d.AppUser).FirstOrDefaultAsync(x => x.PatientId == id);
            if (existingPatient == null) return (null, "");

            if (!string.IsNullOrEmpty(patientDto.FullName))
                existingPatient.AppUser.FullName = patientDto.FullName;
            if (!string.IsNullOrEmpty(patientDto.PhoneNumber))
                existingPatient.AppUser.PhoneNumber = patientDto.PhoneNumber;
            if (!string.IsNullOrEmpty(patientDto.Email))
                existingPatient.AppUser.Email = patientDto.Email;

            existingPatient.PatientDOB = patientDto.PatientDOB;
            existingPatient.PatientBloodGroup = patientDto.PatientBloodGroup;
            existingPatient.PatientAddress = patientDto.PatientAddress;

            await _context.SaveChangesAsync();

            var newToken = await _tokenService.UpdateUserClaims(existingPatient.AppUser);

            return (existingPatient, newToken);
        }
    }
}
