using System.Net.Http.Headers;
using System.Web;
using HMS_API.Dtos;
using HMS_UI.Interfaces;
using Newtonsoft.Json;

namespace HMS_UI.Services
{
    class PatientServices : IPatientServices
    {
        public async Task<List<PatientDto>> GetPatientsAsync(string patientName, int patientPageNumber, int patientPageSize)
        {
            try
            {
                var queryParams = HttpUtility.ParseQueryString(string.Empty);
                queryParams["pageNumber"] = patientPageNumber.ToString();
                queryParams["pageSize"] = patientPageSize.ToString();

                if (!string.IsNullOrEmpty(patientName))
                    queryParams["PatientName"] = patientName; // Ensure correct parameter name

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());

                HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync($"/api/patient?{queryParams}");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<PatientDto>>(jsonResponse) ?? new List<PatientDto>();
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error fetching patients: {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error: {ex.Message}", ex);
            }
        }
    }
}
