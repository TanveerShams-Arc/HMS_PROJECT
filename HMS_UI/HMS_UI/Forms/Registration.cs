using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;

namespace HMS_UI
{
    public partial class Registration : Form
    {
        private readonly IUserService _userService;

        public Registration(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }


        private void Registration_Load(object sender, EventArgs e)
        {
            PatientBloodComboBox.DataSource = Enum.GetValues(typeof(BloodGroup))
                .Cast<BloodGroup>()
                .Select(b => new { Value = b, Display = Utilities.GetEnumDescription(b) })
                .ToList();

            PatientBloodComboBox.DisplayMember = "Display";
            PatientBloodComboBox.ValueMember = "Value";


            DoctorSpecializationComboBox.DataSource = Enum.GetValues(typeof(DoctorSpecialization));
            //PopulateSpecializationComboBox();

            RoleComboBox.DataSource = Enum.GetValues(typeof(Role));
            RoleComboBox.SelectedIndexChanged += RoleComboBox_SelectedIndexChanged;

            UserHelpers.UpdateFieldVisibility(ref RoleComboBox, ref docExpTextBox, ref DoctorSpecializationComboBox,
            ref PatientBloodComboBox, ref PatientDateTimePicker, ref patientAddressTextBox, ref doctorExpLabel,
                    ref doctorSpecLabel, ref patientDOBLabel, ref patientBloodLabel, ref patientAdrsLabel);

        }






        private void RoleComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            UserHelpers.UpdateFieldVisibility(ref RoleComboBox, ref docExpTextBox, ref DoctorSpecializationComboBox,
                    ref PatientBloodComboBox, ref PatientDateTimePicker, ref patientAddressTextBox, ref doctorExpLabel,
                    ref doctorSpecLabel, ref patientDOBLabel, ref patientBloodLabel, ref patientAdrsLabel);
        }

        private void DoctorSpecializationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private void PatientBloodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private async void registerBtn_Click(object sender, EventArgs e)
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

            if (!int.TryParse(phoneTextBox.Text, out _))
            {
                errorProvider4.SetError(emailTextBox, "Phone Number Must Be Numeric!");
            }


            errorProvider4.Clear();
            errorProvider5.Clear();
            errorProvider3.Clear();

            try
            {
                BloodGroup selectedGroup = (BloodGroup)PatientBloodComboBox.SelectedValue!;
                string selectedBloodGroup = Utilities.GetEnumDescription(selectedGroup);
                string roleSelect = RoleComboBox.SelectedItem!.ToString()!;

                string? doctorSpecialization = roleSelect == "Doctor" ? DoctorSpecializationComboBox.SelectedItem.ToString() : null;
                string? doctorExperience = roleSelect == "Doctor" ? docExpTextBox.Text : null;
                DateOnly? patientDOB = roleSelect == "Patient" ? (DateOnly?)DateOnly.FromDateTime(PatientDateTimePicker.Value) : null;
                string? patientBloodGroup = roleSelect == "Patient" ? selectedBloodGroup : null;
                string? patientAddress = roleSelect == "Patient" ? patientAddressTextBox.Text : null;

                string token = await _userService.RegisterUserAsync(
                    userNameTextBox.Text, fullNameTextBox.Text, emailTextBox.Text, phoneTextBox.Text, passwordTextBox.Text,
                    roleSelect, doctorSpecialization, doctorExperience, patientDOB, patientBloodGroup, patientAddress
                );

                MessageBox.Show($"Registration Successful!\nToken: {token}", "Success");
                Utilities.GoToLogin();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPassCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !showPassCheckBox.Checked;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            Utilities.GoToLogin();
            this.Close();
        }
    }
}
