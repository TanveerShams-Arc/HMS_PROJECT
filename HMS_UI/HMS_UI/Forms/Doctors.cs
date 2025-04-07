using HMS_API.Dtos;
using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI
{
    public partial class Doctors : Form
    {

        private readonly IDoctorServices _doctorServices;
        public Doctors(IDoctorServices doctorServices)
        {
            InitializeComponent();
            _doctorServices = doctorServices;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void Doctors_Load(object sender, EventArgs e)
        {
            SpecializationComboBox.DataSource = Enum.GetValues(typeof(DoctorSpecialization));

            SpecializationComboBox.SelectedIndex = -1;
            await GetData();
        }


        public async Task GetDoctorData()
        {
            try
            {
                string doctorName = DoctorNameTextBox.Text;
                int pageNumber = 1, pageSize = 20;
                var _allDoctors = await _doctorServices.GetDoctorAsync(doctorName, pageNumber, pageSize, null, null);

                doctorData.DataSource = _allDoctors;
                DataFormatters.FormatDoctorView(ref doctorData, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private async Task GetData()
        {
            try
            {
                string doctorName = DoctorNameTextBox.Text;
                int pageNumber = 1, pageSize = 20;
                int? doctorExperience = null;
                string? doctorSpecialization = null;
                if (!string.IsNullOrEmpty(pageNumberTextBox.Text))
                    pageNumber = int.Parse(pageNumberTextBox.Text);
                if (!string.IsNullOrEmpty(PageSizeTextBox.Text))
                    pageSize = int.Parse(PageSizeTextBox.Text);
                if (!string.IsNullOrEmpty(DoctorExpTextBox.Text))
                    doctorExperience = int.Parse(DoctorExpTextBox.Text);

                if (SpecializationComboBox.SelectedItem != null)
                {
                    doctorSpecialization = SpecializationComboBox.SelectedItem.ToString();
                }


                var _allDoctors = await _doctorServices.GetDoctorAsync(doctorName, pageNumber, pageSize, doctorExperience,
                    doctorSpecialization);

                doctorData.DataSource = _allDoctors;
                DataFormatters.FormatDoctorView(ref doctorData, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void pageNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void PageSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void DoctorNameTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void DoctorExpTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void SpecializationComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            SessionManager.PreviousForm = this;
            CreateDoctor cdoc = DIContainer.ServiceProvider!.GetRequiredService<CreateDoctor>();
            cdoc.Show();

            Hide();
        }

        private async void SpecializationComboBox_TextChanged(object sender, EventArgs e)
        {
            if (SpecializationComboBox.Text == "")
            {
                SpecializationComboBox.SelectedIndex = -1;
                await GetData();
            }
        }
        private void doctorData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && doctorData.Columns[e.ColumnIndex].Name == "Delete")
            {
                doctorData.Cursor = Cursors.Hand;
            }
        }

        private void doctorData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && doctorData.Columns[e.ColumnIndex].Name == "Delete")
            {
                doctorData.Cursor = Cursors.Default;
            }
        }

        private async void doctorData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == doctorData.Columns["Delete"]!.Index && e.RowIndex >= 0)
            {
                var selectedDoctor = (DoctorDto)doctorData.Rows[e.RowIndex].DataBoundItem!;

                if (selectedDoctor != null)
                {
                    var confirm = MessageBox.Show(
                        $"Are you sure you want to delete doctor {selectedDoctor.FullName}?",
                        "Confirm Delete",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning
                    );

                    if (confirm == DialogResult.Yes)
                    {
                        bool isSuccess = await _doctorServices.DeleteDoctorAsync(selectedDoctor.DoctorId);

                        if (isSuccess)
                        {
                            MessageBox.Show("Doctor deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            await GetData();
                        }
                        else
                        {
                            MessageBox.Show("Failed to delete doctor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Dashboard dash = DIContainer.ServiceProvider.GetService<Dashboard>();
            dash.Show();
            Close();
        }
    }
}
