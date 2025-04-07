using System.Net.Http.Headers;
using System.Web;
using HMS_API.Dtos;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Newtonsoft.Json;

namespace HMS_UI.Repositories
{
    class DoctorRepository : IDoctorRepository
    {
        public async Task<bool> DeleteDoctorAsync(int doctorId)
        {
            if (doctorId <= 0)
                throw new ArgumentException("Invalid Doctor ID.");

            HttpResponseMessage response = await HttpClientSingleton.Instance.DeleteAsync($"/api/doctor/{doctorId}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<DoctorDto>> GetDoctorAsync(string doctorName, int doctorPageNumber, int doctorPageSize, int? doctorExperience, string? doctorSpecialization)
        {
            try
            {
                var queryParams = HttpUtility.ParseQueryString(string.Empty);
                queryParams["pageNumber"] = doctorPageNumber.ToString();
                queryParams["pageSize"] = doctorPageSize.ToString();

                if (!string.IsNullOrEmpty(doctorName))
                    queryParams["DoctortName"] = doctorName;
                if (doctorExperience != null)
                    queryParams["DoctorExperience"] = doctorExperience.ToString();
                if (!string.IsNullOrEmpty(doctorSpecialization))
                    queryParams["DoctorSpecialization"] = doctorSpecialization;

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());

                HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync($"/api/doctor?{queryParams}");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<DoctorDto>>(jsonResponse) ?? new List<DoctorDto>();
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"Error fetching doctors: {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Unexpected error: {ex.Message}", ex);
            }
        }
    }
}
