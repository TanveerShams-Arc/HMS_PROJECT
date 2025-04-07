using HMS_API.Dtos;
using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI
{
    public partial class CreateAppointment : Form
    {
        private ReceptionistDto? receptionist;
        private readonly IDoctorServices _doctorServices;
        private readonly IPatientServices _patientServices;
        private readonly IUserService _userServices;
        private readonly IAppointmentServices _appointmentServices;

        public static int doctorPageNumber = 1;
        public static int patientPageNumber = 1;

        public static int doctorPageSize = 15;
        public static int patientPageSize = 15;

        public CreateAppointment(IDoctorServices doctorServices, IPatientServices patientServices, IUserService userServices,
            IAppointmentServices appointmentServices)
        {
            InitializeComponent();
            _doctorServices = doctorServices;
            _patientServices = patientServices;
            _userServices = userServices;
            _appointmentServices = appointmentServices;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();

        }


        private async void CreateAppointment_Load(object sender, EventArgs e)
        {
            await GetDoctorData();
            await GetPatientData();
            await GetUserData();
            statusComboBox.DataSource = Enum.GetValues<apStatus>();
        }



        private async void PatientTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetPatientData();
        }

        private async void DoctorTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetDoctorData();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

            Appointment ap = DIContainer.ServiceProvider.GetRequiredService<Appointment>();
            ap.Show();

            this.Close();
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            if (!AppointmentHelpers.ValidateCreateApointment(ref doctorData, ref patientData,
                         ref apDdateTimePicker, statusComboBox))
                return;

            try
            {
                string? patientId = patientData.SelectedRows[0].Cells[0].Value?.ToString();
                string? doctorId = doctorData.SelectedRows[0].Cells[0].Value?.ToString();
                DateTime appointmentDate = apDdateTimePicker.Value;
                string? status = statusComboBox.SelectedItem?.ToString();
                int receptionistId = receptionist?.ReceptionistId ?? -1;

                bool isSuccess = await _appointmentServices.CreateAppointmentAsync(patientId, doctorId, appointmentDate, status, receptionistId);

                if (isSuccess)
                {
                    MessageBox.Show("Appointment Created Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    Appointment ap = DIContainer.ServiceProvider!.GetRequiredService<Appointment>();
                    ap.Show();

                    Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task GetPatientData()
        {
            try
            {
                string patientName = PatientTextBox.Text.Trim();
                var _allPatients = await _patientServices.GetPatientsAsync(patientName, patientPageNumber, patientPageSize);

                patientData.DataSource = _allPatients;
                DataFormatters.FormatPatientView(ref patientData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public async Task GetDoctorData()
        {
            try
            {
                string doctorName = DoctorTextBox.Text;
                var _allDoctors = await _doctorServices.GetDoctorAsync(doctorName, doctorPageNumber, doctorPageSize, null, null);

                doctorData.DataSource = _allDoctors;
                DataFormatters.FormatDoctorView(ref doctorData, this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public async Task GetUserData()
        {
            try
            {
                receptionist = await _userServices.GetUserDataAsync();
                bindingSource.DataSource = receptionist;

                nameTextBox.DataBindings.Clear();
                emailTextBox.DataBindings.Clear();
                phoneTextBox.DataBindings.Clear();

                nameTextBox.DataBindings.Add("Text", bindingSource, "FullName");
                emailTextBox.DataBindings.Add("Text", bindingSource, "Email");
                phoneTextBox.DataBindings.Add("Text", bindingSource, "PhoneNumber");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            CreatePatient cpt = DIContainer.ServiceProvider!.GetRequiredService<CreatePatient>();
            cpt.Show();
            SessionManager.PreviousForm = this;
            Hide();
        }

        private void CreateDoctorBtn_Click(object sender, EventArgs e)
        {
            CreateDoctor cdoc = DIContainer.ServiceProvider!.GetRequiredService<CreateDoctor>();
            cdoc.Show();
            SessionManager.PreviousForm = this;
            Hide();
        }

        private async void patientPageDown_Click(object sender, EventArgs e)
        {
            if (patientPageNumber > 1)
            {
                patientPageNumber--;
                await GetPatientData();
            }
            if (patientPageNumber == 1)
                patientPageDown.Enabled = false;
        }

        private async void PatientPageUp_Click(object sender, EventArgs e)
        {
            patientPageNumber++;
            patientPageDown.Enabled = true;
            await GetPatientData();
        }

        private async void DoctorPageDown_Click(object sender, EventArgs e)
        {
            if (doctorPageNumber > 1)
            {
                doctorPageNumber--;
                await GetDoctorData();
            }
            if (doctorPageNumber == 1)
                DoctorPageDown.Enabled = false;
        }

        private async void DoctorPageUp_Click(object sender, EventArgs e)
        {
            doctorPageNumber++;
            DoctorPageDown.Enabled = true;
            await GetDoctorData();
        }
    }
}


