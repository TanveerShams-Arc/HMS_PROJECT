using HMS_UI.Enums;

namespace HMS_UI.HelperFunctions
{
    public static class AppointmentHelpers
    {

        public static void ConvertComboBoxToTextColumn(ref DataGridView appointmentData,
            ref Button editButton, ref Button cancelButton, ref Button saveButton)
        {
            if (appointmentData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to save.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = appointmentData.SelectedRows[0].Index;
            int columnIndex = 3;


            object selectedValue = appointmentData.Rows[selectedRowIndex].Cells[columnIndex].Value ?? "";


            DataGridViewTextBoxCell textCell = new()
            {
                Value = selectedValue
            };

            appointmentData.Rows[selectedRowIndex].Cells[columnIndex] = textCell;

            appointmentData.ReadOnly = true;

            editButton.Enabled = true;
            editButton.Visible = true;

            saveButton.Enabled = false;
            saveButton.Visible = false;

            cancelButton.Enabled = false;
            cancelButton.Visible = false;
        }

        public static void SetupComboBoxColumn(ref DataGridView appointmentData,
            ref Button cancelButton, ref Button saveButton)
        {

            if (appointmentData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to edit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int selectedRowIndex = appointmentData.SelectedRows[0].Index;
            int columnIndex = appointmentData.Columns["Status"]!.Index;
            string currentValue = appointmentData.Rows[selectedRowIndex].Cells[columnIndex].Value?.ToString() ?? "";

            DataGridViewComboBoxCell comboBoxCell = new();
            comboBoxCell.Items.AddRange(Enum.GetNames<apStatus>());
            comboBoxCell.Value = currentValue;

            appointmentData.ReadOnly = false;

            foreach (DataGridViewRow row in appointmentData.Rows)
            {
                if (row.Index == selectedRowIndex)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex != columnIndex)
                        {
                            cell.ReadOnly = true;
                        }
                    }
                    continue;
                }
                row.ReadOnly = true;
            }

            appointmentData.Rows[selectedRowIndex].Cells[columnIndex] = comboBoxCell;

            saveButton.Enabled = true;
            saveButton.Visible = true;

            cancelButton.Enabled = true;
            cancelButton.Visible = true;
        }

        public static bool ValidateCreateApointment(ref DataGridView doctorData, ref DataGridView patientData,
            ref DateTimePicker apDdateTimePicker, ComboBox statusComboBox)
        {
            if (doctorData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (patientData.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select the patient.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!apDdateTimePicker.Checked)
            {
                MessageBox.Show("Date and Time must be selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if ((apStatus)statusComboBox.SelectedItem! == apStatus.Cancelled)
            {
                MessageBox.Show("New appointment status cannot be 'Cancelled'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

    }

}
