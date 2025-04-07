using System.Net;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace PasswordValidationFunction
{
    public class ValidatePassword
    {
        private readonly ILogger<ValidatePassword> _logger;

        public ValidatePassword(ILogger<ValidatePassword> logger)
        {
            _logger = logger;
        }

        [Function("ValidatePassword")]
        public static async Task<HttpResponseData> Run(
            [HttpTrigger(AuthorizationLevel.Function, "post", Route = "validatepassword")] HttpRequestData req,
            FunctionContext executionContext)
        {
            var logger = executionContext.GetLogger("ValidatePassword");
            logger.LogInformation("Processing password validation request.");

            var requestBody = await req.ReadAsStringAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            string password = data?.password;

            if (string.IsNullOrEmpty(password))
            {
                var errorResponse = req.CreateResponse(HttpStatusCode.BadRequest);
                await errorResponse.WriteAsJsonAsync(new { message = "Password is required." });
                return errorResponse;
            }

            var validationResults = ValidatePasswordStrength(password);

            if (validationResults.IsValid)
            {
                var successResponse = req.CreateResponse(HttpStatusCode.OK);
                await successResponse.WriteAsJsonAsync(new { message = "Password is valid." });
                return successResponse;
            }

            var errorResponseWithValidation = req.CreateResponse(HttpStatusCode.BadRequest);
            await errorResponseWithValidation.WriteAsJsonAsync(new { errors = validationResults.Errors });
            return errorResponseWithValidation;
        }


        private static (bool IsValid, string[] Errors) ValidatePasswordStrength(string password)
        {
            var errors = new List<string>();

            if (password.Length < 8)
            {
                errors.Add("Password must be at least 8 characters long.");
            }

            if (!Regex.IsMatch(password, @"[A-Z]"))
            {
                errors.Add("Password must contain at least one uppercase letter.");
            }

            if (!Regex.IsMatch(password, @"[a-z]"))
            {
                errors.Add("Password must contain at least one lowercase letter.");
            }

            if (!Regex.IsMatch(password, @"[0-9]"))
            {
                errors.Add("Password must contain at least one digit.");
            }

            if (!Regex.IsMatch(password, @"[\W_]"))
            {
                errors.Add("Password must contain at least one special character (e.g., @, #, $, etc.).");
            }

            return (errors.Count == 0, errors.ToArray());
        }

    }
}
