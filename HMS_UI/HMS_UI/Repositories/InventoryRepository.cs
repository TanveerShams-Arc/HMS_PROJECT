using System.Net.Http.Headers;
using System.Text;
using System.Web;
using HMS_API.Dtos;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Newtonsoft.Json;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace HMS_UI.Repositories
{
    class InventoryRepository : IInventoryRepository
    {
        public async Task<bool> CreateInventoryAsync(string? medicineName, string? selectedManufacturer, int medQuantity, DateTime expiryDate)
        {
            var obj = new
            {
                medicine = medicineName,
                medicineQuantity = medQuantity,
                manufacturer = selectedManufacturer,
                expiryDate
            };

            string jsonContent = JsonConvert.SerializeObject(obj, Formatting.Indented);
            var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
            HttpResponseMessage response = await HttpClientSingleton.Instance.PostAsync("/api/inventory", content);


            string responseContent = await response.Content.ReadAsStringAsync();

            MessageBox.Show(responseContent, "Response", MessageBoxButtons.OK, MessageBoxIcon.Information);


            return response.IsSuccessStatusCode;
        }


        public async Task<bool> DeleteRecordAsync(int inventoryId)
        {
            HttpResponseMessage response = await HttpClientSingleton.Instance.DeleteAsync($"/api/inventory/{inventoryId}");
            return response.IsSuccessStatusCode;
        }



        public async Task<List<InventoryDto>?> GetInventoryAsync(string? medicineName, int pageNumber, int pageSize,
            string? selectedManufacturer, DateTime? expiryDate)
        {
            try
            {
                var queryParams = HttpUtility.ParseQueryString(string.Empty);
                queryParams["PageNumber"] = pageNumber.ToString();
                queryParams["PageSize"] = pageSize.ToString();

                if (!string.IsNullOrEmpty(medicineName))
                    queryParams["medicine"] = medicineName;
                if (expiryDate != null)
                    queryParams["expiryDate"] = expiryDate.ToString();

                if (expiryDate.HasValue)
                    queryParams["expiryDate"] = DateOnly.FromDateTime(expiryDate.Value).ToString();

                if (!string.IsNullOrEmpty(selectedManufacturer))
                    queryParams["Manufacturer"] = selectedManufacturer;

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());

                HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync($"/api/inventory?{queryParams}");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<InventoryDto>>(jsonResponse) ?? new List<InventoryDto>();
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
