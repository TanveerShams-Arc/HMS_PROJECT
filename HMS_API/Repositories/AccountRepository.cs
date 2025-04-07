using HMS_API.DB;
using HMS_API.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace HMS_API.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly AppDBContext _context;

        public AccountRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<T?> GetAsync<T>(string appUserId) where T : class
        {
            try
            {
                var query = _context.Set<T>().AsQueryable();
                if (_context.Model.FindEntityType(typeof(T))?.FindNavigation("AppUser") != null)
                {
                    query = query.Include("AppUser");
                }
                return await query.FirstOrDefaultAsync(e => EF.Property<string>(e, "AppUserId") == appUserId);
            }
            catch (DbUpdateException dbEx)
            {
                return null; 
            }
            catch (Exception ex)
            {
                return null; 
            }
        }
    }
}
