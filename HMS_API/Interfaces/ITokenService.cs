using System.Security.Claims;
using HMS_API.Models.Persons;

namespace HMS_API.Interfaces
{
    public interface ITokenService
    {
        string CreateToken(AppUser user, List<Claim> claims);
        Task<string> UpdateUserClaims(AppUser user);
    }
}
