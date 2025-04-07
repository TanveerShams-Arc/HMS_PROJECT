using System.Net;
using HMS_API.Dtos;
using HMS_UI.Interfaces;
using Newtonsoft.Json;

namespace HMS_UI.Services
{
    class UserService : IUserService
    {

        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }



        public async Task<ReceptionistDto> GetUserDataAsync()
        {
            return await _userRepository.GetUserDataAsync();
        }


        public async Task<string> LoginAsync(string username, string password)
        {
            var response = await _userRepository.LoginAsync(username, password);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var userDto = JsonConvert.DeserializeObject<NewUserDto>(responseData);


                string jwtToken = userDto.Token;
                SessionManager.JwtToken = jwtToken;
                SessionManager.SaveToken(jwtToken);

                return jwtToken;
            }
            else if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                throw new UnauthorizedAccessException("Invalid username or password.");
            }
            else if (response.StatusCode == HttpStatusCode.NotFound)
            {
                throw new Exception("User not found.");
            }
            else if (response.StatusCode == HttpStatusCode.BadRequest)
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Invalid request: {errorResponse}");
            }
            else if (response.StatusCode == HttpStatusCode.InternalServerError)
            {
                throw new Exception("Server error. Please try again later.");
            }
            else
            {
                throw new Exception($"Unexpected error: {response.ReasonPhrase}");
            }
        }



        public async Task<string> RegisterUserAsync(string username, string fullname, string email, string phone, string password,
        string role, string? doctorSpecialization, string? doctorExperience, DateOnly? patientDOB, string? patientBloodGroup, string? patientAddress)
        {
            var registrationDto = new
            {
                username,
                fullname,
                email,
                phone,
                password,
                role,
                doctorSpecialization,
                doctorExperience,
                patientDOB,
                patientBloodGroup,
                patientAddress
            };

            HttpResponseMessage response = await _userRepository.RegisterUserAsync(registrationDto);

            if (response.IsSuccessStatusCode)
            {
                string responseData = await response.Content.ReadAsStringAsync();
                var userDto = JsonConvert.DeserializeObject<NewUserDto>(responseData);

                return userDto.Token;
            }
            else
            {
                string errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Registration failed: {errorResponse}");
            }
        }


    }
}
