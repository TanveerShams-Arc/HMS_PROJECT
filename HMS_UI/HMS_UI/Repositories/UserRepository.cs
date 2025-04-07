using System.Net.Http.Headers;
using System.Text;
using HMS_API.Dtos;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HMS_UI.Repositories
{
    class UserRepository : IUserRepository
    {

        public async Task<HttpResponseMessage> LoginAsync(string username, string password)
        {
            var loginData = new
            {
                userName = username,
                passWord = password
            };

            string jsonContent = JsonConvert.SerializeObject(loginData);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            return await HttpClientSingleton.Instance.PostAsync("api/Account/login", content);
        }


        public async Task<ReceptionistDto> GetUserDataAsync()
        {

            try
            {
                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());

                HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync("/api/Account/me");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    //ReceptionistDto receptionist = JsonConvert.DeserializeObject<ReceptionistDto>(jsonResponse) ?? new ReceptionistDto();
                    JObject jsonObj = JObject.Parse(jsonResponse);
                    JObject appUserObj = (JObject?)jsonObj["appUser"] ?? [];
                    ReceptionistDto? receptionist = appUserObj.ToObject<ReceptionistDto>();
                    receptionist.ReceptionistId = jsonObj["receptionistId"]?.Value<int>() ?? 0;
                    return receptionist;
                }

                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error fetching user data: {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error: {ex.Message}", ex);
            }
        }



        public async Task<HttpResponseMessage> RegisterUserAsync(object registrationDto)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(registrationDto, Formatting.Indented);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                return await HttpClientSingleton.Instance.PostAsync("api/Account/register", content);
            }
            catch (Exception ex)
            {
                throw new Exception($"Error sending registration request: {ex.Message}", ex);
            }
        }


    }
}
