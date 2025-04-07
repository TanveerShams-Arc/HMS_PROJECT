using System.Net.Http.Headers;
using System.Text;
using System.Web;
using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Newtonsoft.Json;

namespace HMS_UI.Repositories
{
    public class HMSTransactionRepository : IHMSTransactionRepository
    {
        public async Task<List<HMSTransactionParDto>?> GetTransactionsAsync(TransactionQueryObject query)
        {
            try
            {
                var queryParams = HttpUtility.ParseQueryString(string.Empty);

                queryParams["pageNumber"] = query.PageNumber.ToString();
                queryParams["pageSize"] = query.PageSize.ToString();

                if (!string.IsNullOrWhiteSpace(query.Status) && query.Status != "All")
                    queryParams["Status"] = query.Status;

                if (query.TransactionDate.HasValue)
                    queryParams["TransactionDate"] = DateOnly.FromDateTime(query.TransactionDate.Value).ToString();

                if (!string.IsNullOrWhiteSpace(query.PatientName))
                    queryParams["PatientName"] = query.PatientName;

                if (query.Amount.HasValue)
                    queryParams["Amount"] = query.Amount.ToString();

                if (query.PaidAmount.HasValue)
                    queryParams["PaidAmount"] = query.PaidAmount.ToString();

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
                HttpResponseMessage response = await HttpClientSingleton.Instance.GetAsync($"/api/HMSTransactionPar?{queryParams}");

                if (response.IsSuccessStatusCode)
                {
                    string jsonResponse = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<List<HMSTransactionParDto>>(jsonResponse);
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception($"API Error: {errorResponse}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in GetTransactionsAsync: {ex.Message}");
            }
        }

        public async Task<bool> CreateTransactionAsync(CreateHMSTransactionParDto transaction)
        {
            try
            {
                string jsonContent = JsonConvert.SerializeObject(transaction);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
                HttpResponseMessage response = await HttpClientSingleton.Instance.PostAsync("/api/HMSTransactionPar", content);

                if (response.IsSuccessStatusCode)
                    return true;
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    MessageBox.Show($"API Error: {errorResponse}", "API Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw new Exception($"API Error: {errorResponse}");

                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Exception in CreateTransactionAsync: {ex.Message}\n{ex.StackTrace}");
            }
        }

        public async Task<bool> UpdateTransactionAsync(int transactionId, decimal amount, decimal paidAmount, string status)
        {
            try
            {
                var updateData = new
                {
                    Amount = amount,
                    PaidAmount = paidAmount,
                    Status = status
                };

                string jsonContent = JsonConvert.SerializeObject(updateData);
                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
                HttpResponseMessage response = await HttpClientSingleton.Instance.PutAsync($"/api/HMSTransactionPar/{transactionId}", content);

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
                throw new Exception($"Exception in UpdateTransactionAsync: {ex.Message}");
            }
        }

        public async Task<bool> DeleteTransactionAsync(int transactionId)
        {
            try
            {
                HttpClientSingleton.Instance.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", SessionManager.GetToken());
                HttpResponseMessage response = await HttpClientSingleton.Instance.DeleteAsync($"/api/transactions/{transactionId}");

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
                throw new Exception($"Exception in DeleteTransactionAsync: {ex.Message}");
            }
        }
    }
}
