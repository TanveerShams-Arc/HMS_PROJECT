using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Services;

namespace HMS_UI
{
    public partial class CreateDoctor : Form
    {
        private readonly IUserService _userService;

        public CreateDoctor(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();
        }


        private void CreateDoctor_Load(object sender, EventArgs e)
        {
            DoctorSpecializationComboBox.DataSource = Enum.GetValues(typeof(DoctorSpecialization));
        }

        private async void CreateBtn_Click(object sender, EventArgs e)
        {
            var email = emailTextBox.Text;
            var pass = passwordTextBox.Text;

            if (!Regex.IsValidEmail(email))
            {
                errorProvider3.SetError(emailTextBox, "Invalid Email! Please Fix to Continue!");
                return;
            }
            if (!Regex.IsValidPassword(pass))
            {
                errorProvider5.SetError(passwordTextBox, "Password Requirements Not Met!");
                return;
            }

            errorProvider5.Clear();
            errorProvider3.Clear();

            try
            {
                string roleSelect = "Doctor";

                string? doctorSpecialization = DoctorSpecializationComboBox.SelectedItem.ToString();
                string? doctorExperience = docExpTextBox.Text;
                DateOnly? patientDOB = null;
                string? patientBloodGroup = null;
                string? patientAddress = null;

                string token = await _userService.RegisterUserAsync(
                    userNameTextBox.Text, fullNameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, passwordTextBox.Text,
                    roleSelect, doctorSpecialization, doctorExperience, patientDOB, patientBloodGroup, patientAddress
                );

                MessageBox.Show($"Doctor Added Successfully!\nToken: {token}", "Success");

                //CreateAppointment cap = DIContainer.ServiceProvider!.GetRequiredService<CreateAppointment>();
                //cap.Show();
                if (SessionManager.PreviousForm != null)
                {
                    SessionManager.PreviousForm.Show();
                    this.Close();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Doctor Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPassCheckBox.Checked;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (SessionManager.PreviousForm != null)
            {
                SessionManager.PreviousForm.Show();
                this.Close();
            }
            Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
