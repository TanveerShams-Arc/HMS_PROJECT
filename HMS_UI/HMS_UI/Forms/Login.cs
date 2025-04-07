using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI
{
    public partial class Login : Form
    {

        private static string? _jwtToken;
        public bool isLoggedIn = false;
        public static bool IsNavigatingToRegistration = false;
        private readonly IUserService _userService;

        public Login(IUserService userService)
        {
            InitializeComponent();
            _jwtToken = SessionManager.GetToken();

            _userService = userService;
        }


        private void Login_Load(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(_jwtToken))
            {
                AuthService.Instance.SetToken(_jwtToken);
                SessionManager.JwtToken = _jwtToken;

                isLoggedIn = true;

                //DialogResult = DialogResult.OK;

                Close();
                //Appointment ap = DIContainer.ServiceProvider.GetRequiredService<Appointment>();;
                //ap.Show();
            }
        }


        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPassCheckBox.Checked;
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = userNameTextBox.Text;
                string password = passwordTextBox.Text;

                string token = await _userService.LoginAsync(username, password);

                errorProvider1.Clear();
                errorProvider2.Clear();

                MessageBox.Show($"Login Successful!\nToken: {token}", "Success");

                //Appointment ap = DIContainer.ServiceProvider.GetRequiredService<Appointment>();
                //ap.FormClosed += Utilities.CheckAndExitApplication;
                //ap.Show();


                Dashboard ds = DIContainer.ServiceProvider.GetRequiredService<Dashboard>();
                ds.Show();


                this.Hide();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show($"Network error: {ex.Message}", "Network Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Invalid username or password.", "Unauthorized", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                errorProvider1.SetError(userNameTextBox, "Invalid username or password!");
                errorProvider2.SetError(passwordTextBox, "Invalid username or password!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void signUpButton_Click(object sender, EventArgs e)
        {
            IsNavigatingToRegistration = true;
            // MessageBox.Show("DEBUG: IsNavigatingToRegistration set to TRUE");


            this.Hide();

            Registration regForm = DIContainer.ServiceProvider.GetRequiredService<Registration>();
            regForm.FormClosed += Utilities.CheckAndExitApplication;
            regForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Appointment ap = DIContainer.ServiceProvider.GetRequiredService<Appointment>();
            ap.Show();
            this.Hide();
            //this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
