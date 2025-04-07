using System.Net.Http.Headers;
using System.Text;
using System.Web;
using HMS_API.Dtos;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Newtonsoft.Json;

namespace HMS_UI.Repositories
{
    public class AppointmentRepository : IAppointmentRepository
    {
        public async Task<bool> CreateAppointmentAsync(object appointment)
        {
            string jsonContent = JsonConvert.SerializeObject(appointment);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
            HttpResponseMessage response = await HttpClientSingleton.Instance.PostAsync("/api/appointments", content);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeleteAppointmentAsync(int appointmentId)
        {
            HttpResponseMessage response = await HttpClientSingleton.Instance.DeleteAsync($"/api/appointments/{appointmentId}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<AppointmentDto>?> GetAppointmentsAsync(AppointmentQueryObject query)
        {
            try
            {
                var queryParams = HttpUtility.ParseQueryString(string.Empty);

                queryParams["pageNumber"] = !string.IsNullOrWhiteSpace(query.PageNumber) ? query.PageNumber : "1";
                queryParams["pageSize"] = !string.IsNullOrWhiteSpace(query.PageSize) ? query.PageSize : "20";

                if (!string.IsNullOrWhiteSpace(query.Status) && query.Status != "All")
                    queryParams["Status"] = query.Status;

                if (query.AppointmentDate.HasValue)
                    queryParams["AppointmentDate"] = DateOnly.FromDateTime(query.AppointmentDate.Value).ToString();

                if (!string.IsNullOrWhiteSpace(query.DoctorName))
                    queryParams["DoctorName"] = query.DoctorName;

                if (!string.IsNullOrWhiteSpace(query.PatientName))
                    queryParams["PatientName"] = query.PatientName;

                if (!string.IsNullOrWhiteSpace(query.ReceptionistName))
                    queryParams["ReceptionistName"] = query.ReceptionistName;

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
                HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync($"/api/appointments?{queryParams}");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<AppointmentDto>>(jsonResponse);
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API Error: {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in GetAppointmentsAsync: {ex.Message}");
            }
        }




        public async Task<bool> UpdateAppointmentStatusAsync(int appointmentId, string status)
        {
            try
            {
                var content = new StringContent($"\"{status}\"", Encoding.UTF8, "application/json");

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
                HttpResponseMessage response = await HttpClientSingleton.Instance.PutAsync($"/api/appointments/update-status/{appointmentId}", content);

                if (response.IsSuccessStatusCode)
                    return true;
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API Error: {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in UpdateAppointmentStatusAsync: {ex.Message}");
            }
        }
    }
}
