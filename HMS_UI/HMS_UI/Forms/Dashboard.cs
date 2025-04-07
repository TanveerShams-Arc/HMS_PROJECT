using HMS_UI.Forms;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI
{
    public partial class Dashboard : Form
    {


        private readonly IUserService _userServices;
        public Dashboard(IUserService userServices)
        {
            InitializeComponent();
            _userServices = userServices;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            await GetUserData();
        }


        public async Task GetUserData()
        {
            try
            {
                var user = await _userServices.GetUserDataAsync();
                NameBindingSource.DataSource = user;
                nameLabel.DataBindings.Clear();
                nameLabel.DataBindings.Add("Text", NameBindingSource, "FullName");

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AppointmentButton_Click(object sender, EventArgs e)
        {
            Appointment ap = DIContainer.ServiceProvider.GetRequiredService<Appointment>();
            ap.FormClosed += Utilities.CheckAndExitApplication;
            ap.Show();
            this.Close();
        }

        private void DoctorButton_Click(object sender, EventArgs e)
        {
            Doctors doc = DIContainer.ServiceProvider.GetRequiredService<Doctors>();
            doc.Show();
            this.Close();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            MedicalRecords mrec = DIContainer.ServiceProvider.GetRequiredService<MedicalRecords>();
            mrec.Show();
            this.Close();
        }

        private void InventoryButton_Click(object sender, EventArgs e)
        {
            Inventory inv = DIContainer.ServiceProvider.GetRequiredService<Inventory>();
            inv.Show();
            this.Close();
        }

        private void LogOutButton_Click(object sender, EventArgs e)
        {
            SessionManager.ClearToken();

            AuthService.Instance.SetToken(null);
            SessionManager.JwtToken = null;

            MessageBox.Show("You have been logged out.", "Logout");

            Login loginForm = DIContainer.ServiceProvider.GetRequiredService<Login>();
            loginForm.isLoggedIn = false;
            loginForm.FormClosed += Utilities.CheckAndExitApplication;
            loginForm.Show();

            this.Close();
        }

        private void TransactionButton_Click(object sender, EventArgs e)
        {
            HMSTransactions transact = DIContainer.ServiceProvider.GetRequiredService<HMSTransactions>();
            transact.Show();
            Close();
        }
    }
}
