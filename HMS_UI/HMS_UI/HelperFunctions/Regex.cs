namespace HMS_UI.HelperFunctions
{
    class Regex
    {
        public static string emailPattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
        public static string passPattern = "(?=^.{12,}$)((?=.*\\d)|(?=.*\\W+))(?![.\\n])(?=.*[A-Z])(?=.*[a-z]).*$";

        public static bool IsValidEmail(string email)
        {
            return !string.IsNullOrEmpty(email) && System.Text.RegularExpressions.Regex
                .IsMatch(email, emailPattern);
        }

        public static bool IsValidPassword(string password)
        {
            return !string.IsNullOrEmpty(password) && System.Text.RegularExpressions.Regex
                .IsMatch(password, passPattern);
        }

    }
}
