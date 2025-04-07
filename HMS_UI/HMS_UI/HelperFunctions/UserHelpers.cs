namespace HMS_UI.HelperFunctions
{
    public static class UserHelpers
    {
        public static void UpdateFieldVisibility(ref ComboBox RoleComboBox, ref TextBox docExpTextBox, ref ComboBox DoctorSpecializationComboBox,
            ref ComboBox PatientBloodComboBox, ref DateTimePicker PatientDateTimePicker, ref TextBox patientAddressTextBox,
            ref Label doctorExpLabel, ref Label doctorSpecLabel, ref Label patientDOBLabel, ref Label patientBloodLabel,
            ref Label patientAdrsLabel)
        {
            string? selectedRole = RoleComboBox.SelectedItem?.ToString();



            if (selectedRole == "Doctor")
            {
                docExpTextBox.Enabled = true;
                DoctorSpecializationComboBox.Enabled = true;

                PatientBloodComboBox.Enabled = false;
                PatientDateTimePicker.Enabled = false;
                patientAddressTextBox.Enabled = false;


                docExpTextBox.Visible = true;
                DoctorSpecializationComboBox.Visible = true;

                PatientBloodComboBox.Visible = false;
                PatientDateTimePicker.Visible = false;
                patientAddressTextBox.Visible = false;


                doctorSpecLabel.Visible = true;
                doctorExpLabel.Visible = true;

                patientAdrsLabel.Visible = false;
                patientDOBLabel.Visible = false;
                patientBloodLabel.Visible = false;
            }

            else if (selectedRole == "Patient")
            {
                PatientBloodComboBox.Enabled = true;
                PatientDateTimePicker.Enabled = true;
                patientAddressTextBox.Enabled = true;

                docExpTextBox.Enabled = false;
                DoctorSpecializationComboBox.Enabled = false;

                PatientBloodComboBox.Visible = true;
                PatientDateTimePicker.Visible = true;
                patientAddressTextBox.Visible = true;

                docExpTextBox.Visible = false;
                DoctorSpecializationComboBox.Visible = false;


                doctorSpecLabel.Visible = false;
                doctorExpLabel.Visible = false;

                patientAdrsLabel.Visible = true;
                patientDOBLabel.Visible = true;
                patientBloodLabel.Visible = true;
            }
            else
            {
                docExpTextBox.Enabled = false;
                DoctorSpecializationComboBox.Enabled = false;

                PatientBloodComboBox.Enabled = false;
                PatientDateTimePicker.Enabled = false;
                patientAddressTextBox.Enabled = false;


                docExpTextBox.Visible = false;
                DoctorSpecializationComboBox.Visible = false;

                PatientBloodComboBox.Visible = false;
                PatientDateTimePicker.Visible = false;
                patientAddressTextBox.Visible = false;



                doctorSpecLabel.Visible = false;
                doctorExpLabel.Visible = false;

                patientAdrsLabel.Visible = false;
                patientDOBLabel.Visible = false;
                patientBloodLabel.Visible = false;
            }

        }

    }
}
