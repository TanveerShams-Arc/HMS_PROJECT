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
    public class ReceptionistRepository : IReceptionistRepository
    {



        private readonly ITokenService _tokenService;
        private readonly AppDBContext _context;
        private readonly UserManager<AppUser> _userManager;

        public ReceptionistRepository(AppDBContext context, ITokenService tokenService, UserManager<AppUser> userManager)
        {
            _context = context;
            _tokenService = tokenService;
            _userManager = userManager;
        }




        public async Task<Receptionist> CreateAsync(Receptionist receptionistModel)
        {
            try
            {
                await _context.Receptionist.AddAsync(receptionistModel);
                await _context.SaveChangesAsync();
                return receptionistModel;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving patient: {ex.Message}");
                throw new Exception("An error occurred while creating the patient.");
            }
        }

        public async Task<Receptionist?> DeleteAsync(int id)
        {
            var receptionist = await _context.Receptionist.FirstOrDefaultAsync(x => x.ReceptionistId == id);
            if (receptionist == null) return null;


            var appUser = await _userManager.FindByIdAsync(receptionist.AppUserId);
            if (appUser == null) return null;


            var userClaims = await _userManager.GetClaimsAsync(appUser);
            await _userManager.RemoveClaimsAsync(appUser, userClaims);

            var userRoles = await _userManager.GetRolesAsync(appUser);
            foreach (var role in userRoles)
            {
                await _userManager.RemoveFromRoleAsync(appUser, role);
            }

            _context.Receptionist.Remove(receptionist);
            await _context.SaveChangesAsync();

            var deleteUserResult = await _userManager.DeleteAsync(appUser);
            if (!deleteUserResult.Succeeded) return null;

            return receptionist;
        }

        public async Task<bool> ReceptionistExistsAsync(int id)
        {
            return await _context.Receptionist.AnyAsync(d => d.ReceptionistId == id);
        }

        public async Task<List<Receptionist>> GetAllAsync(ReceptionistQueryObject query)
        {
            var receptionist = _context.Receptionist.Include(d => d.AppUser).AsQueryable();

            var skipNumber = (query.PageNumber - 1) * query.PageSize;

            return await receptionist.Skip(skipNumber).Take(query.PageSize).ToListAsync();
        }

        public async Task<Receptionist?> GetByIdAsync(int id)
        {
            return await _context.Receptionist.Include(d => d.AppUser).FirstOrDefaultAsync(i => i.ReceptionistId == id);
        }

        public async Task<(Receptionist? updatedReceptionist, string newToken)> UpdateAsync(int id, UpdateReceptionistDto receptionistDto)
        {
            var existingReceptionist = await _context.Receptionist.Include(d => d.AppUser).FirstOrDefaultAsync(x => x.ReceptionistId == id);
            if (existingReceptionist == null) return (null, "");

            if (!string.IsNullOrEmpty(receptionistDto.FullName))
                existingReceptionist.AppUser.FullName = receptionistDto.FullName;
            if (!string.IsNullOrEmpty(receptionistDto.PhoneNumber))
                existingReceptionist.AppUser.PhoneNumber = receptionistDto.PhoneNumber;
            if (!string.IsNullOrEmpty(receptionistDto.Email))
                existingReceptionist.AppUser.Email = receptionistDto.Email;

            await _context.SaveChangesAsync();
            var newToken = await _tokenService.UpdateUserClaims(existingReceptionist.AppUser);
            return (existingReceptionist, newToken);
        }
    }
}
