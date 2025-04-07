using System.Net.Http.Headers;
using System.Text;
using System.Web;
using HMS_API.Dtos;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Newtonsoft.Json;

namespace HMS_UI.Repositories
{
    class RecordRepository : IRecordRepository
    {
        public async Task<bool> CreateRecordAsync(int patientID, string recordType, string recordData, DateTime recordCreatedOn)
        {

            var obj = new
            {
                patientID,
                recordType,
                recordData,
                recordCreatedOn
            };

            string jsonContent = JsonConvert.SerializeObject(obj, Formatting.Indented);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
            HttpResponseMessage response = await HttpClientSingleton.Instance.PostAsync("/api/medicalrecords", content);

            return response.IsSuccessStatusCode;

        }


        public async Task<bool> DeleteRecordAsync(int recordId)
        {
            HttpResponseMessage response = await HttpClientSingleton.Instance.DeleteAsync($"/api/medicalrecords/{recordId}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<MedicalRecordsDto>> GetRecordsAsync(string? patientName, int pageNumber, int pageSize, string recordType, DateTime? recordCreatedOn)
        {
            try
            {
                var queryParams = HttpUtility.ParseQueryString(string.Empty);
                queryParams["pageNumber"] = pageNumber.ToString();
                queryParams["pageSize"] = pageSize.ToString();

                if (!string.IsNullOrEmpty(patientName))
                    queryParams["PatientName"] = patientName;
                if (recordCreatedOn != null)
                    queryParams["RecordDate"] = recordCreatedOn.ToString();
                if (!string.IsNullOrEmpty(recordType))
                    queryParams["RecordType"] = recordType;

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());

                HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync($"/api/medicalrecords");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<MedicalRecordsDto>>(jsonResponse) ?? new List<MedicalRecordsDto>();
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
