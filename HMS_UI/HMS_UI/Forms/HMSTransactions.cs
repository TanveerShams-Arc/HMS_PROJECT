using HMS_API.Dtos;
using HMS_API.HelperFunctions.QueryObjects;
using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI.Forms
{
    public partial class HMSTransactions : Form
    {
        private readonly IHMSTransactionServices _transactionServices;
        private static int _pageNumber = 1;
        private static int _pageSize = 20;
        public HMSTransactions(IHMSTransactionServices transactionServices)
        {
            InitializeComponent();
            _transactionServices = transactionServices;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Dashboard dash = DIContainer.ServiceProvider.GetRequiredService<Dashboard>();
            dash.Show();
            Close();
        }

        private async void HMSTransactions_Load(object sender, EventArgs e)
        {
            TransactionStatusComboBox.DataSource = Enum.GetValues<TransactionStatus>();
            TransactionStatusComboBox.SelectedIndex = -1;
            await GetData();
        }

        private async Task GetData()
        {
            try
            {
                var queryObject = new TransactionQueryObject
                {
                    PageNumber = _pageNumber,
                    PageSize = _pageSize,
                    Status = TransactionStatusComboBox.SelectedItem?.ToString() ?? null,
                    TransactionDate = TransactionDateTimePicker.Checked ? TransactionDateTimePicker.Value : (DateTime?)null,
                    PatientName = !string.IsNullOrWhiteSpace(PatientTextBox.Text) ? PatientTextBox.Text : null,
                    Amount = !string.IsNullOrWhiteSpace(AmountTextBox.Text) ? int.Parse(AmountTextBox.Text) : null,
                    PaidAmount = !string.IsNullOrWhiteSpace(PaidTextBox.Text) ? int.Parse(PaidTextBox.Text) : null,
                };

                List<HMSTransactionParDto>? transacts = await _transactionServices.GetTransactionsAsync(queryObject);

                if (transacts != null)
                {

                    BindingSource bindingSource = new BindingSource();
                    bindingSource.DataSource = transacts;
                    TransactionData.DataSource = bindingSource;


                    //appointmentData.DataSource = appointments;
                    DataFormatters.FormatTransactionView(ref TransactionData);
                }
                else
                {
                    MessageBox.Show("No Transaction found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            CreateTransaction cTransact = DIContainer.ServiceProvider.GetService<CreateTransaction>();
            cTransact.Show();
            Close();
        }

        private async void AmountTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void PatientTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void PaidTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void TransactionStatusComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void pageSize_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(pageSize.Text, out int pSize))
            {
                _pageSize = pSize;
            }
            else
            {
                _pageSize = 20;
            }
            pageSize.Text = _pageSize.ToString();
            await GetData();
        }

        private async void pageNumber_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void rightArrowButton1_Click(object sender, EventArgs e)
        {
            _pageNumber += 1;
            pageNumber.Text = _pageNumber.ToString();
            await GetData();
        }

        private async void leftArrowButton1_Click(object sender, EventArgs e)
        {
            if (_pageNumber > 1)
            {
                _pageNumber -= 1;
                pageNumber.Text = _pageNumber.ToString();
                await GetData();
            }
        }

        private async void TransactionDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {

        }
    }
}
