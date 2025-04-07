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
    public class DoctorRepository : IDoctorRepository
    {
        private readonly ITokenService _tokenService;
        private readonly AppDBContext _context;
        private readonly UserManager<AppUser> _userManager;

        public DoctorRepository(AppDBContext context, ITokenService tokenService, UserManager<AppUser> userManager)
        {
            _context = context;
            _tokenService = tokenService;
            _userManager = userManager;
        }

        public async Task<Doctor> CreateAsync(Doctor doctorModel)
        {
            await _context.Doctor.AddAsync(doctorModel);
            await _context.SaveChangesAsync();
            return doctorModel;
        }

        public async Task<Doctor?> DeleteAsync(int id)
        {
            var doctor = await _context.Doctor.FirstOrDefaultAsync(x => x.DoctorId == id);
            if (doctor == null) return null;

            var appUser = await _userManager.FindByIdAsync(doctor.AppUserId);
            if (appUser == null) return null;

            var userClaims = await _userManager.GetClaimsAsync(appUser);
            await _userManager.RemoveClaimsAsync(appUser, userClaims);

            var userRoles = await _userManager.GetRolesAsync(appUser);
            foreach (var role in userRoles)
            {
                await _userManager.RemoveFromRoleAsync(appUser, role);
            }

            _context.Doctor.Remove(doctor);
            await _context.SaveChangesAsync();

            var deleteUserResult = await _userManager.DeleteAsync(appUser);
            if (!deleteUserResult.Succeeded) return null;

            return doctor;
        }

        public async Task<List<Doctor>> GetAllAsync(DoctorQueryObject query)
        {
            return await _context.Doctor.Include(d => d.AppUser).ToListAsync();
        }

        public async Task<Doctor?> GetByIdAsync(int id)
        {
            return await _context.Doctor.Include(d => d.AppUser).FirstOrDefaultAsync(i => i.DoctorId == id);
        }

        public async Task<bool> DoctorExistsAsync(int id)
        {
            return await _context.Doctor.AnyAsync(d => d.DoctorId == id);
        }

        public async Task<(Doctor? updatedDoctor, string newToken)> UpdateAsync(int id, UpdateDoctorDto doctorDto)
        {
            var existingDoctor = await _context.Doctor.Include(d => d.AppUser).FirstOrDefaultAsync(x => x.DoctorId == id);
            if (existingDoctor == null) return (null, "");

            if (!string.IsNullOrEmpty(doctorDto.FullName))
                existingDoctor.AppUser.FullName = doctorDto.FullName;
            if (!string.IsNullOrEmpty(doctorDto.PhoneNumber))
                existingDoctor.AppUser.PhoneNumber = doctorDto.PhoneNumber;
            if (!string.IsNullOrEmpty(doctorDto.Email))
                existingDoctor.AppUser.Email = doctorDto.Email;

            existingDoctor.DoctorSpecialization = doctorDto.DoctorSpecialization;
            existingDoctor.DoctorExperience = doctorDto.DoctorExperience;

            await _context.SaveChangesAsync();

            var newToken = await _tokenService.UpdateUserClaims(existingDoctor.AppUser);

            return (existingDoctor, newToken);
        }
    }
}
