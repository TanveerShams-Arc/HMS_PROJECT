using System.Security.Cryptography;
using System.Text;

namespace HMS_UI.Services
{

    public static class SessionManager
    {

        public static Form? PreviousForm { get; set; }

        private static readonly string FilePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "secure_token.dat");
        public static string? JwtToken { get; set; }

        public static void SaveToken(string token)
        {
            if (string.IsNullOrEmpty(token)) return;

            byte[] encryptedData = ProtectedData.Protect(
                Encoding.UTF8.GetBytes(token),
                null,
                DataProtectionScope.CurrentUser
            );

            File.WriteAllBytes(FilePath, encryptedData);
        }


        public static string GetToken()
        {
            if (!File.Exists(FilePath)) return null;

            byte[] encryptedData = File.ReadAllBytes(FilePath);
            byte[] decryptedData = ProtectedData.Unprotect(
                encryptedData,
                null,
                DataProtectionScope.CurrentUser
            );

            return Encoding.UTF8.GetString(decryptedData);
        }


        public static void ClearToken()
        {
            if (File.Exists(FilePath))
            {
                File.Delete(FilePath);
            }
        }
    }
}
