using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using HMS_API.Interfaces;
using HMS_API.Models.Persons;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;

namespace HMS_API.Service
{
    public class TokenService : ITokenService
    {

        private readonly IConfiguration _config;

        private readonly SymmetricSecurityKey _key;
        private readonly UserManager<AppUser> _userManager;

        public TokenService(IConfiguration config, UserManager<AppUser> userManager)
        {
            _config = config;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["JWT:SigningKey"]));
            _userManager = userManager;
        }

        public string CreateToken(AppUser user, List<Claim> claims)
        {

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(7),
                SigningCredentials = creds,
                Issuer = _config["JWT:Issuer"],
                Audience = _config["JWT:Audience"]
            };

            var tokenHandler = new JwtSecurityTokenHandler();

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);

        }


        public async Task<string> UpdateUserClaims(AppUser user)
        {
            var claims = new List<Claim>
            {
                    new Claim(ClaimTypes.NameIdentifier, user.Id),
                    new Claim(ClaimTypes.Name, user.FullName),
                    new Claim(ClaimTypes.Email, user.Email)
            };

            if (user.Doctor != null)
            {
                claims.Add(new Claim("UserType", "doctor"));
                claims.Add(new Claim("DoctorSpecialization", user.Doctor.DoctorSpecialization));
            }
            else if (user.Patient != null)
            {
                claims.Add(new Claim("UserType", "patient"));
                claims.Add(new Claim("PatientBloodGroup", user.Patient.PatientBloodGroup));
            }
            else if (user.Receptionist != null)
                claims.Add(new Claim("UserType", "receptionist"));

            var existingClaims = await _userManager.GetClaimsAsync(user);
            await _userManager.RemoveClaimsAsync(user, existingClaims);
            await _userManager.AddClaimsAsync(user, claims);

            return CreateToken(user, claims);

        }


    }
}
