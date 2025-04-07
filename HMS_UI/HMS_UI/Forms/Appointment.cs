using HMS_API.Dtos;
using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI
{
    public partial class Appointment : Form
    {
        private bool isEditing = false;
        private int selectedRowIndex = -1;
        private readonly IAppointmentServices _appointmentServices;

        private static int ApPageNumber = 1;

        public Appointment(IAppointmentServices appointmentServices)
        {
            InitializeComponent();
            _appointmentServices = appointmentServices;

            pageNumber.Text = ApPageNumber.ToString();

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();
        }

        private async void GetAppointmentButton_Click(object sender, EventArgs e)
        {
            await GetData();
        }


        private void Appointment_Load(object sender, EventArgs e)
        {
            AppointmentStatusComboBox.DataSource = Enum.GetValues<apStatus>();
        }

        private async void AppointmentStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void AppointmentDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void PatientTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
            //SearchInAppointments(PatientTextBox.Text);
        }

        private async void DoctorTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void ReceptionistTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void PageNumber_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void PageSize_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private void AppointmentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            AppointmentHelpers.SetupComboBoxColumn(ref appointmentData, ref cancelButton, ref saveButton);
            isEditing = true;
        }

        private async void SaveButton_Click(object sender, EventArgs e)
        {
            await SaveDataAsync();
        }

        private async void CancelButton_Click(object sender, EventArgs e)
        {
            isEditing = false;
            AppointmentHelpers.ConvertComboBoxToTextColumn(ref appointmentData,
                    ref editButton, ref cancelButton, ref saveButton);
            await GetData();
        }

        private void AppointmentData_SelectionChanged(object sender, EventArgs e)
        {
            if (isEditing && selectedRowIndex != -1)
            {
                // Keep the selected row locked
                if (appointmentData.SelectedRows.Count == 0 ||
                    appointmentData.SelectedRows[0].Index != selectedRowIndex)
                {
                    appointmentData.ClearSelection();
                    appointmentData.Rows[selectedRowIndex].Selected = true;
                }
            }
            else
            {
                if (appointmentData.SelectedRows.Count > 0)
                {
                    selectedRowIndex = appointmentData.SelectedRows[0].Index;
                }
            }
        }

        private void AppointmentData_CurrentCellChanged(object sender, EventArgs e)
        {
            if (isEditing && selectedRowIndex != -1)
            {
                if (appointmentData.SelectedRows.Count == 0 ||
                    appointmentData.SelectedRows[0].Index != selectedRowIndex)
                {
                    appointmentData.ClearSelection();
                    appointmentData.Rows[selectedRowIndex].Selected = true;
                }
            }
            else
            {
                if (appointmentData.SelectedRows.Count > 0)
                {
                    selectedRowIndex = appointmentData.SelectedRows[0].Index;
                }
            }
        }

        private void CreatelButton_Click(object sender, EventArgs e)
        {
            CreateAppointment cap = DIContainer.ServiceProvider.GetRequiredService<CreateAppointment>();
            cap.FormClosed += Utilities.CheckAndExitApplication;
            cap.Show();
            Close();
        }

        //private void LogoutButton_Click(object sender, EventArgs e)
        //{
        //    SessionManager.ClearToken();

        //    AuthService.Instance.SetToken(null);
        //    SessionManager.JwtToken = null;

        //    MessageBox.Show("You have been logged out.", "Logout");

        //    Login loginForm = DIContainer.ServiceProvider.GetRequiredService<Login>();
        //    loginForm.isLoggedIn = false;
        //    loginForm.FormClosed += Utilities.CheckAndExitApplication;
        //    loginForm.Show();

        //    this.Close();
        //}

        public async Task SaveDataAsync()
        {
            try
            {
                if (appointmentData.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select an appointment.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int selectedRowIndex = appointmentData.SelectedRows[0].Index;
                string? id = appointmentData.Rows[selectedRowIndex].Cells["EventId"].Value?.ToString();

                string? status = appointmentData.Rows[selectedRowIndex].Cells["Status"].Value?.ToString();

                isEditing = false;
                AppointmentHelpers.ConvertComboBoxToTextColumn(ref appointmentData,
                        ref editButton, ref cancelButton, ref saveButton);

                bool success = await _appointmentServices.UpdateAppointmentStatusAsync(id, status);

                if (success)
                {
                    await GetData(); // Refresh data
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unexpected error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //public void SearchInAppointments(string searchString)
        //{
        //    searchString = searchString.Trim().ToLower(); // Preprocess input

        //    var bindingSource = (BindingSource)appointmentData.DataSource;
        //    var originalList = (List<AppointmentDto>)bindingSource.DataSource;

        //    // Filter the list
        //    var filteredList = originalList
        //        .Where(a => a.PatientFullname?.ToLower().Contains(searchString) == true ||
        //                    a.DoctorFullname?.ToLower().Contains(searchString) == true ||
        //                    a.ReceptionistFullname?.ToLower().Contains(searchString) == true ||
        //                    a.Status?.ToLower().Contains(searchString) == true ||
        //                    a.doctorSpecialization?.ToLower().Contains(searchString) == true ||
        //                    a.AppointmentDate.ToString("yyyy-MM-dd").Contains(searchString))
        //        .ToList();
        //    bindingSource.DataSource = filteredList;
        //}



        public async Task GetData()
        {
            try
            {
                var queryObject = new AppointmentQueryObject
                {
                    PageNumber = !string.IsNullOrWhiteSpace(pageNumber.Text) ? pageNumber.Text : "1",
                    PageSize = !string.IsNullOrWhiteSpace(pageSize.Text) ? pageSize.Text : "20",
                    Status = AppointmentStatusComboBox.SelectedItem?.ToString() ?? "All",
                    AppointmentDate = AppointmentDateTimePicker.Checked ? AppointmentDateTimePicker.Value : (DateTime?)null,
                    DoctorName = !string.IsNullOrWhiteSpace(DoctorTextBox.Text) ? DoctorTextBox.Text : null,
                    PatientName = !string.IsNullOrWhiteSpace(PatientTextBox.Text) ? PatientTextBox.Text : null,
                    ReceptionistName = !string.IsNullOrWhiteSpace(ReceptionistTextBox.Text) ? ReceptionistTextBox.Text : null
                };

                List<AppointmentDto>? appointments = await _appointmentServices.GetData(queryObject);

                if (appointments != null)
                {

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = appointments;
                    appointmentData.DataSource = bindingSource;


                    //appointmentData.DataSource = appointments;
                    DataFormatters.FormatAppointmenView(ref appointmentData);
                }
                else
                {
                    MessageBox.Show("No appointments found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }




        private async void leftArrowButton1_Click(object sender, EventArgs e)
        {
            if (ApPageNumber > 1)
            {
                ApPageNumber--;
                pageNumber.Text = ApPageNumber.ToString();
                await GetData();
            }
            if (ApPageNumber == 1)
                leftArrowButton1.Enabled = false;
        }

        private async void rightArrowButton1_Click(object sender, EventArgs e)
        {
            ApPageNumber++;
            pageNumber.Text = ApPageNumber.ToString();
            leftArrowButton1.Enabled = true;
            await GetData();
        }

        private async void appointmentData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == appointmentData.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                var selectedAppointment = (AppointmentDto)appointmentData.Rows[e.RowIndex].DataBoundItem;

                if (selectedAppointment != null)
                {
                    var confirm = MessageBox.Show(
                        $"Are you sure you want to delete the appointment for {selectedAppointment.PatientFullname}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        bool isSuccess = await _appointmentServices.DeleteAppointmentAsync(selectedAppointment.EventId);

                        if (isSuccess)
                        {
                            MessageBox.Show("Appointment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            await GetData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete the appointment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void appointmentData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && appointmentData.Columns[e.ColumnIndex].Name == "Delete")
            {
                appointmentData.Cursor = Cursors.Hand;
            }
        }

        private void appointmentData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && appointmentData.Columns[e.ColumnIndex].Name == "Delete")
            {
                appointmentData.Cursor = Cursors.Default;
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Dashboard dash = DIContainer.ServiceProvider.GetService<Dashboard>();
            dash.Show();
            Close();
        }

        private void appointmentData_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void AppointmentStatusComboBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }
    }
}

