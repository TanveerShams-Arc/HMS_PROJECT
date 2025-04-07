using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_API.Models;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Newtonsoft.Json;

namespace HMS_UI.Repositories
{
    internal class PrescriptionRepository : IPrescriptionRepository

    {
        public async Task<bool> CreatePrescriptionAsync(object Prescription)
        {
            string jsonContent = JsonConvert.SerializeObject(Prescription);
            var content = new StringContent(jsonContent, Encoding.UTF8, "Prescription/json");

            HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
            HttpResponseMessage response = await HttpClientSingleton.Instance.PostAsync("/api/Prescription", content);

            return response.IsSuccessStatusCode;
        }

        public async Task<bool> DeletePrescriptionAsync(int PrescriptionId)
        {
            HttpResponseMessage response = await HttpClientSingleton.Instance.DeleteAsync($"/api/Prescriptions/{PrescriptionId}");
            return response.IsSuccessStatusCode;
        }

        public async Task<List<PrescriptionDto>?> GetPrescriptionAsync(PrescriptionQueryObject query)
        {
            try
            {
                var queryParams = HttpUtility.ParseQueryString(string.Empty);

                queryParams["pageNumber"] = query.PageNumber == null ? query.PageNumber.ToString() : "1";
                queryParams["pageSize"] = query.PageSize == null ? query.PageSize.ToString() : "1";

                if (query.prescribedDate.HasValue)
                    queryParams["PrescribedDate"] = query.prescribedDate.Value.ToString();

                if (!string.IsNullOrWhiteSpace(query.DoctorName))
                    queryParams["DoctorName"] = query.DoctorName;

                if (!string.IsNullOrWhiteSpace(query.PatientName))
                    queryParams["PatientName"] = query.PatientName;

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
                HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync($"/api/prescriptions?{queryParams}");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<PrescriptionDto>>(jsonResponse);
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API Error: {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in GetPrescriptionAsync: {ex.Message}");
            }
        }

        public async Task<bool> UpdatePrescriptionAsync(int prescriptionId, string status)
        {
            try
            {
                var content = new StringContent($"\"{status}\"", Encoding.UTF8, "Prescription/json");

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
                HttpResponseMessage response = await HttpClientSingleton.Instance.PutAsync($"/api/prescriptions/update-status/{prescriptionId}", content);

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
                throw new Exception($"Exception in UpdatePrescriptionAsync: {ex.Message}");
            }
        }
    }
}
