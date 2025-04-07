using System.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI.HelperFunctions
{
    class Utilities
    {
        public static void CheckAndExitApplication(object sender, FormClosedEventArgs e)
        {
            int visibleForms = Application.OpenForms.Cast<Form>().Count(f => f.Visible);

            Console.WriteLine($"DEBUG: {sender.GetType().Name} closed. Visible forms count: {visibleForms}");

            if (visibleForms == 0)
            {
                Console.WriteLine("DEBUG: No visible forms. Forcing application exit...");
                Environment.Exit(0);
            }
        }

        public static void GoToLogin()
        {
            Login loginForm = DIContainer.ServiceProvider.GetRequiredService<Login>();
            loginForm.Show();
            loginForm.FormClosed += Utilities.CheckAndExitApplication;
        }



        public static string GetEnumDescription(Enum value)
        {
            var field = value.GetType().GetField(value.ToString());
            var attribute = (DescriptionAttribute?)Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute));
            return attribute != null ? attribute.Description : value.ToString();
        }


    }
}
