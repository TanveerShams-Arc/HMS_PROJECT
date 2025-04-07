using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Services;

namespace HMS_UI
{
    public partial class CreatePatient : Form
    {

        private readonly IUserService _userService;

        public CreatePatient(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();
        }

        private void CreatePatient_Load(object sender, EventArgs e)
        {
            PatientBloodComboBox.DataSource = Enum.GetValues(typeof(BloodGroup))
                .Cast<BloodGroup>()
                .Select(b => new { Value = b, Display = Utilities.GetEnumDescription(b) })
                .ToList();
            PatientBloodComboBox.DisplayMember = "Display";
            PatientBloodComboBox.ValueMember = "Value";
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
            this.Close();
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
                BloodGroup selectedGroup = (BloodGroup)PatientBloodComboBox.SelectedValue!;
                string selectedBloodGroup = Utilities.GetEnumDescription(selectedGroup);
                string roleSelect = "Patient";

                string? doctorSpecialization = null;
                string? doctorExperience = null;
                DateOnly? patientDOB = (DateOnly?)DateOnly.FromDateTime(PatientDateTimePicker.Value);
                string? patientBloodGroup = selectedBloodGroup;
                string? patientAddress = patientAddressTextBox.Text;

                string token = await _userService.RegisterUserAsync(
                    userNameTextBox.Text, fullNameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, passwordTextBox.Text,
                    roleSelect, doctorSpecialization, doctorExperience, patientDOB, patientBloodGroup, patientAddress
                );

                MessageBox.Show($"Patient Added Successfully!\nToken: {token}", "Success");

                if (SessionManager.PreviousForm != null)
                {
                    SessionManager.PreviousForm.Show();
                    this.Close();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Patient Creation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
