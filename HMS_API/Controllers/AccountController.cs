using System.Security.Claims;
using System.Text;
using AutoMapper;
using HMS_API.Dtos;
using HMS_API.Interfaces;
using HMS_API.Models;
using HMS_API.Models.Persons;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace HMS_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IDoctorRepository _doctorRepository;
        private readonly IPatientRepository _patientRepository;
        private readonly IReceptionistRepository _receptionistRepository;
        private readonly IAccountRepository _accountRepository;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;
        private readonly SignInManager<AppUser> _signInManager;

        private readonly IHttpClientFactory _httpClientFactory;

        public AccountController(UserManager<AppUser> userManager, IMapper mapper, IDoctorRepository doctorRepository,
            ITokenService tokenService, SignInManager<AppUser> signInManager, IPatientRepository patientRepository,
            IReceptionistRepository receptionistRepository, IAccountRepository accountRepository, IHttpClientFactory httpClientFactory)
        {
            _doctorRepository = doctorRepository;
            _mapper = mapper;
            _userManager = userManager;
            _tokenService = tokenService;
            _signInManager = signInManager;
            _patientRepository = patientRepository;
            _receptionistRepository = receptionistRepository;
            _accountRepository = accountRepository;
            _httpClientFactory = httpClientFactory;

        }

        [HttpPut("Edit")]
        public async Task<IActionResult> EditUser([FromBody] EditUserDto model)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                if (model == null || string.IsNullOrEmpty(model.UserName))
                {
                    return BadRequest("Invalid user data.");
                }

                var user = await _userManager.FindByNameAsync(model.UserName);
                if (user == null)
                {
                    return NotFound("User not found.");
                }

                user.Email = model.Email ?? user.Email;
                user.PhoneNumber = model.PhoneNumber ?? user.PhoneNumber;
                user.FullName = model.FullName ?? user.FullName;

                var result = await _userManager.UpdateAsync(user);
                if (!result.Succeeded)
                {
                    return BadRequest(result.Errors);
                }

                var roles = await _userManager.GetRolesAsync(user);
                var role = roles.FirstOrDefault();

                var existingClaims = await _userManager.GetClaimsAsync(user);

                var newClaims = new List<Claim>
                {
                        new Claim(ClaimTypes.Name, user.FullName),
                        new Claim(ClaimTypes.Email, user.Email),
                };

                var nameClaim = existingClaims.FirstOrDefault(c => c.Type == ClaimTypes.Name);
                var emailClaim = existingClaims.FirstOrDefault(c => c.Type == ClaimTypes.Email);

                if (nameClaim != null)
                {
                    await _userManager.RemoveClaimAsync(user, nameClaim);
                }

                if (emailClaim != null)
                {
                    await _userManager.RemoveClaimAsync(user, emailClaim);
                }

                await _userManager.AddClaimsAsync(user, newClaims);
                await _signInManager.RefreshSignInAsync(user);

                var claims = await _userManager.GetClaimsAsync(user);

                return Ok(
                            new NewUserDto
                            {
                                UserName = user.UserName,
                                Email = user.Email,
                                Token = _tokenService.CreateToken(user, (List<Claim>)claims)
                            }
                         );
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }


        private async Task<bool> ValidatePasswordAsync(string password)
        {
            var client = _httpClientFactory.CreateClient();

            var requestBody = new
            {
                password
            };
            var jsonContent = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

            var response = await client.PostAsync("http://localhost:7207/api/validatepassword", jsonContent);

            if (response.IsSuccessStatusCode)
            {
                return true;
            }
            return false;
        }



        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody] RegisterDto registerDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);


                var isPasswordValid = await ValidatePasswordAsync(registerDto.Password);

                if (!isPasswordValid)
                {
                    return BadRequest("Password does not meet the required criteria.");
                }


                var appUser = new AppUser
                {
                    UserName = registerDto.Username,
                    Email = registerDto.Email,
                    FullName = registerDto.FullName,
                    PhoneNumber = registerDto.Phone
                };

                var createUser = await _userManager.CreateAsync(appUser, registerDto.Password);

                if (!createUser.Succeeded)
                    return StatusCode(500, createUser.Errors);

                var roleResult = await _userManager.AddToRoleAsync(appUser, registerDto.Role);
                if (!roleResult.Succeeded)
                {
                    return StatusCode(500, roleResult.Errors);
                }

                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.NameIdentifier, appUser.Id),
                    new Claim(ClaimTypes.Name, appUser.FullName),
                    new Claim(ClaimTypes.Email, appUser.Email),
                    new Claim("UserType", registerDto.Role.ToLower())
                };

                if (registerDto.Role.ToLower() == "doctor")
                {
                    if (string.IsNullOrEmpty(registerDto.DoctorSpecialization) || registerDto.DoctorExperience == null)
                        return BadRequest("Doctor details are required for a doctor role.");

                    var doctorDto = new CreateDoctorDto
                    {
                        AppUserId = appUser.Id,
                        DoctorSpecialization = registerDto.DoctorSpecialization,
                        DoctorExperience = registerDto.DoctorExperience.Value
                    };

                    var doctor = _mapper.Map<Doctor>(doctorDto);
                    await _doctorRepository.CreateAsync(doctor);

                    claims.Add(new Claim("DoctorSpecialization", registerDto.DoctorSpecialization));
                    await _userManager.AddClaimsAsync(appUser, claims);
                }

                if (registerDto.Role.ToLower() == "patient")
                {
                    if (registerDto.PatientDOB == null ||
                        string.IsNullOrEmpty(registerDto.PatientBloodGroup) ||
                        string.IsNullOrEmpty(registerDto.PatientAddress))
                    {
                        return BadRequest("Patient details are required for patient registration.");
                    }

                    var patientDto = new CreatePatientDto
                    {
                        AppUserId = appUser.Id,
                        PatientDOB = (DateOnly)registerDto.PatientDOB,
                        PatientBloodGroup = registerDto.PatientBloodGroup,
                        PatientAddress = registerDto.PatientAddress
                    };

                    var patient = _mapper.Map<Patient>(patientDto);
                    var createdPatient = await _patientRepository.CreateAsync(patient);

                    if (createdPatient == null)
                    {
                        return StatusCode(500, "Failed to create patient.");
                    }

                    claims.Add(new Claim("PatientBloodGroup", registerDto.PatientBloodGroup));
                    await _userManager.AddClaimsAsync(appUser, claims);
                }

                if (registerDto.Role.ToLower() == "receptionist")
                {
                    var receptionistDto = new CreateReceptionistDto
                    {
                        AppUserId = appUser.Id,
                    };

                    var receptionist = _mapper.Map<Receptionist>(receptionistDto);
                    var createdReceptionist = await _receptionistRepository.CreateAsync(receptionist);

                    if (createdReceptionist == null)
                    {
                        return StatusCode(500, "Failed to create receptionist.");
                    }

                    await _userManager.AddClaimsAsync(appUser, claims);
                }

                return Ok(
                new NewUserDto
                {
                    UserName = appUser.UserName,
                    Email = appUser.Email,
                    Token = _tokenService.CreateToken(appUser, claims)
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginDto loginDto)
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var user = await _userManager.Users.FirstOrDefaultAsync(x => x.UserName.ToLower() == loginDto.Username.ToLower());

                if (user == null) return Unauthorized("Invalid username or email!");

                var result = await _signInManager.CheckPasswordSignInAsync(user, loginDto.Password, false);

                if (!result.Succeeded)
                    return Unauthorized("username or password not found!");

                var roles = await _userManager.GetRolesAsync(user);
                var claims = (await _userManager.GetClaimsAsync(user)).ToList();

                if (!claims.Any(c => c.Type == "UserType") && roles.Any())
                {
                    claims.Add(new Claim("UserType", roles.First().ToLower()));
                }

                return Ok(new NewUserDto
                {
                    UserName = user.UserName,
                    Email = user.Email,
                    Token = _tokenService.CreateToken(user, claims)
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

        [HttpGet("me")]
        public async Task<IActionResult> GetUser()
        {

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            try
            {
                var appUserId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
                if (string.IsNullOrEmpty(appUserId))
                    return Unauthorized("Invalid token");

                var userType = User.FindFirst("UserType")?.Value;
                if (string.IsNullOrEmpty(userType))
                    return BadRequest("User type not found");

                object? user = userType.ToLower() switch
                {
                    "receptionist" => await _accountRepository.GetAsync<Receptionist>(appUserId),
                    "doctor" => await _accountRepository.GetAsync<Doctor>(appUserId),
                    "patient" => await _accountRepository.GetAsync<Patient>(appUserId),
                    _ => null
                };

                if (user == null)
                    return NotFound("User not found");

                return Ok(user);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }
    }
}
