using System.Text;
using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using HMS_UI.Services;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;

namespace HMS_UI
{
    public partial class CreateRecord : Form
    {

        private readonly IDoctorServices _doctorServices;
        private readonly IPatientServices _patientServices;
        private readonly IRecordServices _recordServices;


        public static int doctorPageNumber = 1;
        public static int patientPageNumber = 1;


        private static bool anyChecked = false;

        public static int doctorPageSize = 15;
        public static int patientPageSize = 15;

        public CreateRecord(IDoctorServices doctorServices, IPatientServices patientServices, IRecordServices recordServices)
        {
            InitializeComponent();

            _doctorServices = doctorServices;
            _patientServices = patientServices;
            _recordServices = recordServices;


            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();

        }


        private async void AddRecord_Load(object sender, EventArgs e)
        {
            LabTestPanel.Visible = false;
            LabTestPanel.Enabled = false;

            GeneralCheckupPanel.Visible = false;
            GeneralCheckupPanel.Enabled = false;

            recComboBox.DataSource = Enum.GetValues(typeof(MedicalRecordType));

            recComboBox.SelectedIndex = -1;


            TestComboBox.DataSource = Enum.GetValues(typeof(TestName));

            TestComboBox.SelectedIndex = -1;


            await GetPatientData();
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (recComboBox.SelectedIndex == -1)
            {
                MessageBox.Show($"Error: Select Record Type", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var selectedRecordType = (MedicalRecordType)recComboBox.SelectedItem!;

            if (selectedRecordType.Equals(MedicalRecordType.GeneralCheckup))
            {

                LabTestPanel.Visible = true;
                LabTestPanel.Enabled = true;

                GeneralCheckupPanel.Visible = true;
                GeneralCheckupPanel.Enabled = true;
            }

            if (selectedRecordType.Equals(MedicalRecordType.LabTest))
            {
                LabTestPanel.Visible = true;
                LabTestPanel.Enabled = true;

                GeneralCheckupPanel.Visible = false;
                GeneralCheckupPanel.Enabled = false;
            }
        }

        private async void PatientTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetPatientData();
        }

        private void recComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void patientPageDown_Click(object sender, EventArgs e)
        {
            if (patientPageNumber > 1)
            {
                patientPageNumber--;
                GetPatientData();
            }
            if (patientPageNumber == 1)
                patientPageDown.Enabled = false;
        }

        private void PatientPageUp_Click(object sender, EventArgs e)
        {
            patientPageNumber++;
            patientPageDown.Enabled = true;
            GetPatientData();
        }

        private void AddPatientBtn_Click(object sender, EventArgs e)
        {
            CreatePatient cpt = DIContainer.ServiceProvider!.GetRequiredService<CreatePatient>();
            cpt.Show();
            SessionManager.PreviousForm = this;
            Hide();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            LabTestPanel.Visible = false;
            LabTestPanel.Enabled = false;
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

        private async void AddButton_Click(object sender, EventArgs e)
        {
            if (patientData.SelectedRows.Count == 0)
            {
                throw new InvalidOperationException("Please select the patient");
            }

            if (recComboBox.SelectedItem == null)
            {
                throw new InvalidOperationException("Select Record Type to Continue");
            }
            if (TestComboBox.SelectedItem == null)
            {
                throw new InvalidOperationException("Select Test Type to Continue");
            }

            try
            {
                string? patientId = patientData.SelectedRows[0].Cells[0].Value?.ToString();
                DateTime recordCreatedOn = DateTime.Now;
                string? recordType = recComboBox.SelectedItem.ToString();
                string? recordData = null;

                if (recordType == "LabTest")
                {
                    var recordDataObj = new
                    {
                        TestName = TestComboBox.SelectedItem.ToString()!,
                        TestTime = TestDate.Value.ToString(),
                        WBC = WBCTextBox.Text,
                        RBC = RBCTextBox.Text,
                        Hemoglobe = HemoTextBox.Text,
                        Platelete = PlatTextBox.Text,
                        Doctor = DoctorTextBox.Text,
                        Remarks = RemarksTextBox.Text
                    };

                    recordData = JsonConvert.SerializeObject(recordDataObj);
                }

                bool isSuccess = await _recordServices.CreateRecordAsync(patientId, recordType, recordData, recordCreatedOn);

                if (isSuccess)
                {
                    MessageBox.Show("Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    MedicalRecords ap = DIContainer.ServiceProvider!.GetRequiredService<MedicalRecords>();
                    ap.Show();

                    Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            MedicalRecords rec = DIContainer.ServiceProvider.GetRequiredService<MedicalRecords>();
            rec.Show();
            Close();
        }

        private void GeneralCheckupPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void HyperRadioBtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackButton2_Click(object sender, EventArgs e)
        {
            LabTestPanel.Visible = false;
            LabTestPanel.Enabled = false;

            GeneralCheckupPanel.Visible = false;
            GeneralCheckupPanel.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {


        }



        private void AppendChildNodes(TreeNode parentNode, StringBuilder result, int level)
        {
            foreach (TreeNode childNode in parentNode.Nodes)
            {
                if (childNode.Checked)
                {
                    anyChecked = true;
                    string indent = new string('-', level);
                    result.AppendLine(indent + childNode.Text);
                }
                AppendChildNodes(childNode, result, level + 1);
            }
        }





        private async void AddButton2_Click(object sender, EventArgs e)
        {
            if (patientData.SelectedRows.Count == 0)
            {
                throw new InvalidOperationException("Please select the patient");
            }

            if (recComboBox.SelectedItem == null)
            {
                throw new InvalidOperationException("Select Record Type to Continue");
            }


            bool isAnyChecked = false;
            RadioButton checkedRadioButton = null;

            foreach (Control control in BPressurePanel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    isAnyChecked = true;
                    checkedRadioButton = radioButton;
                    break;
                }
            }

            if (!isAnyChecked)
            {
                throw new InvalidOperationException("Please select Blood Pressure Option");
            }

            string BloodPressure = checkedRadioButton.Text;
            string BloodPressureButton = checkedRadioButton.Name;



            bool isAnyChecked2 = false;
            RadioButton checkedRadioButton2 = null;

            foreach (Control control in TempPanel.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    isAnyChecked2 = true;
                    checkedRadioButton2 = radioButton;
                    break;
                }
            }

            if (string.IsNullOrEmpty(tempText.Text))
            {
                throw new InvalidOperationException("Please fill in body Temperature");
            }

            if (!decimal.TryParse(tempText.Text, out decimal tempValue))
            {
                throw new InvalidOperationException("Body Temp must be decimal value");
            }

            if (!isAnyChecked2)
            {
                throw new InvalidOperationException("Please select Temperature Unit");
            }

            string TempUnit = checkedRadioButton2.Text;
            string TempUnitButton = checkedRadioButton2.Name;


            if (symptomCheckBox.CheckedItems.Count < 0)
            {
                MessageBox.Show("At least one symptom must be selected.");
            }

            string symptoms = "";

            foreach (var item in symptomCheckBox.CheckedItems)
            {
                if (symptoms == "")
                    symptoms += "-" + item.ToString();
                else
                    symptoms += "\n-" + item.ToString();
            }


            StringBuilder result = new StringBuilder();
            foreach (TreeNode parentNode in DiagnosisTreeView.Nodes)
            {
                if (parentNode.Checked)
                {
                    anyChecked = true;
                    result.AppendLine(parentNode.Text);
                }
                AppendChildNodes(parentNode, result, 1);
            }

            if (!anyChecked)
            {
                MessageBox.Show("At least one Diagnosis must be selected.");
            }


            string diagnosis = result.ToString();

            decimal Height = decimal.Parse(heightTextBox.Text);
            decimal weight = decimal.Parse(weightTextBox.Text);
            decimal bmi = decimal.Parse(BMITextBox.Text);

            string remarks = GrRemarksTextBox.Text;

            try
            {
                string? patientId = patientData.SelectedRows[0].Cells[0].Value?.ToString();
                DateTime recordCreatedOn = DateTime.Now;
                string? recordType = recComboBox.SelectedItem.ToString();
                string? recordData = null;

                if (recordType == "GeneralCheckup")
                {
                    var recordDataObj = new
                    {
                        Height,
                        Weight = weight,
                        BloodPressure,
                        Temperature = tempValue.ToString() + " " + TempUnit,
                        Symptoms = symptoms,
                        BMI = bmi,
                        Diagnosis = diagnosis,
                        Remarks = remarks
                    };

                    recordData = JsonConvert.SerializeObject(recordDataObj);
                }

                bool isSuccess = await _recordServices.CreateRecordAsync(patientId, recordType, recordData, recordCreatedOn);

                if (isSuccess)
                {
                    MessageBox.Show("Record Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    MedicalRecords ap = DIContainer.ServiceProvider!.GetRequiredService<MedicalRecords>();
                    ap.Show();

                    Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
