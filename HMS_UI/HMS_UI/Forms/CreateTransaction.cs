using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI.Forms
{
    public partial class CreateTransaction : Form
    {
        private readonly IHMSTransactionServices _transactionServices;
        private readonly IPatientServices _patientServices;
        public static int patientPageNumber = 1;
        public static int patientPageSize = 15;
        public CreateTransaction(IHMSTransactionServices transactionServices, IPatientServices patientServices)
        {
            InitializeComponent();

            _transactionServices = transactionServices;
            _patientServices = patientServices;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            HMSTransactions transact = DIContainer.ServiceProvider.GetRequiredService<HMSTransactions>();
            transact.Show();
            Close();
        }

        private async void CreateTransaction_Load(object sender, EventArgs e)
        {
            await GetPatientData();
            statusComboBox.DataSource = Enum.GetValues<TransactionStatus>();
        }

        public async Task GetPatientData()
        {
            try
            {
                string patientName = PatientTextBox.Text.Trim();
                var _allPatients = await _patientServices.GetPatientsAsync(null, patientPageNumber, patientPageSize);

                patientData.DataSource = _allPatients;
                DataFormatters.FormatPatientView(ref patientData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddPatientBtn_Click_1(object sender, EventArgs e)
        {
            CreatePatient cpt = DIContainer.ServiceProvider!.GetRequiredService<CreatePatient>();
            cpt.Show();
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

        private async void createButton_Click(object sender, EventArgs e)
        {
            if (!TransactionHelpers.ValidateTransaction(ref patientData,
             ref TransactDateTimePicker, ref statusComboBox, AmountTextBox.Text, PaidTextBox.Text))
                return;

            try
            {
                string? patientId = patientData.SelectedRows[0].Cells[0].Value?.ToString();
                DateTime transactionDate = TransactDateTimePicker.Value;
                string status = statusComboBox.SelectedItem!.ToString()!;
                decimal amount = decimal.Parse(AmountTextBox.Text);
                decimal paidAmount = decimal.Parse(PaidTextBox.Text);
                bool isSuccess = await _transactionServices.CreateTransactionAsync(patientId, amount, paidAmount, status, transactionDate);

                if (isSuccess)
                {
                    MessageBox.Show("Transaction Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    HMSTransactions ap = DIContainer.ServiceProvider!.GetRequiredService<HMSTransactions>();
                    ap.Show();

                    Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\n{ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void PatientTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetPatientData();
        }

        private void AmountTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
