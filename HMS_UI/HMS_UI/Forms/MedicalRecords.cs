using HMS_API.Dtos;
using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace HMS_UI
{
    public partial class MedicalRecords : Form
    {

        private readonly IRecordServices _recordServices;

        public MedicalRecords(IRecordServices recordServices)
        {
            InitializeComponent();

            _recordServices = recordServices;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();
        }


        private async void MedicalRecords_Load(object sender, EventArgs e)
        {
            recordComboBox.DataSource = Enum.GetValues(typeof(MedicalRecordType));

            recordComboBox.SelectedIndex = -1;
            await GetData();
        }


        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateRecord rec = DIContainer.ServiceProvider.GetRequiredService<CreateRecord>();
            rec.Show();
            this.Close();
        }

        private void pageNumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PageSizeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PatientNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        private async Task GetData()
        {
            try
            {
                string patientName = PatientNameTextBox.Text;
                int pageNumber = 1, pageSize = 20;
                DateTime recordCreatedOn = recordDate.Value;
                string? recordType = null;
                if (!string.IsNullOrEmpty(pageNumberTextBox.Text))
                    pageNumber = int.Parse(pageNumberTextBox.Text);
                if (!string.IsNullOrEmpty(PageSizeTextBox.Text))
                    pageSize = int.Parse(PageSizeTextBox.Text);

                if (recordComboBox.SelectedItem != null)
                {
                    recordType = recordComboBox.SelectedItem.ToString();
                }


                var _allRecords = await _recordServices.GetRecordsAsync(patientName, pageNumber, pageSize, recordType,
                recordCreatedOn);

                recordData.DataSource = _allRecords;
                DataFormatters.FormatRecordView(ref recordData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void recordData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (recordData.Columns[e.ColumnIndex].Name == "Delete"
                || recordData.Columns[e.ColumnIndex].Name == "DetailsButton"))
            {
                recordData.Cursor = Cursors.Hand;
            }
        }

        private void recordData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (recordData.Columns[e.ColumnIndex].Name == "Delete"
                    || recordData.Columns[e.ColumnIndex].Name == "DetailsButton"))
            {
                recordData.Cursor = Cursors.Default;
            }
        }

        private async void recordData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == recordData.Columns["Delete"]!.Index && e.RowIndex >= 0)
            {
                var selectedRecord = (MedicalRecordsDto)recordData.Rows[e.RowIndex].DataBoundItem!;
                await DeleteRecord(selectedRecord);
            }

            else if (e.ColumnIndex == recordData.Columns["DetailsButton"].Index && e.RowIndex >= 0)
            {
                string recordDataJson = recordData.Rows[e.RowIndex].Cells["RecordData"].Value.ToString();
                string recordType = recordData.Rows[e.RowIndex].Cells["RecordType"].Value.ToString();

                GetDetailedReport(recordDataJson, recordType);
            }

        }

        private void GetDetailedReport(string recordDataJson, string recordType)
        {
            string details = "";

            if (recordType == "LabTest")
            {
                var data = JsonConvert.DeserializeObject<dynamic>(recordDataJson);
                details = $"Test Name: {data.TestName}\n" +
                                $"Test Time: {data.TestTime}\n" +
                                $"WBC: {data.WBC}\n" +
                                $"RBC: {data.RBC}\n" +
                                $"Hemoglobin: {data.Hemoglobe}\n" +
                                $"Platelets: {data.Platelete}\n" +
                                $"Doctor: {data.Doctor}\n" +
                                $"Remarks: {data.Remarks}";
            }

            else
            {
                var data = JsonConvert.DeserializeObject<dynamic>(recordDataJson);
                details = $"Height = {data.Height}\n" +
                            $"Weight = {data.Weight}\n" +
                            $"BP = {data.BloodPressure}\n" +
                            $"Temp = {data.Temperature}\n" +
                            $"Symptoms = {data.Symptoms}\n" +
                            $"BMI = {data.BMI}\n" +
                            $"Diagnosis = {data.Diagnosis}\n" +
                            $"Remarks = {data.Remarks}\n";
            }

            MessageBox.Show(details, "Patient Record Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private async Task DeleteRecord(MedicalRecordsDto selectedRecord)
        {
            if (selectedRecord != null)
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete this {selectedRecord.RecordType} Record of {selectedRecord.PatientName}?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    bool isSuccess = await _recordServices.DeleteRecordAsync(selectedRecord.RecordId);

                    if (isSuccess)
                    {
                        MessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await GetData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void recordData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
