namespace HMS_UI
{
    partial class CreateRecord
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TreeNode treeNode11 = new TreeNode("Asthma");
            TreeNode treeNode12 = new TreeNode("Pneumonia");
            TreeNode treeNode13 = new TreeNode("Respiratory System", new TreeNode[] { treeNode11, treeNode12 });
            TreeNode treeNode14 = new TreeNode("Hypertension");
            TreeNode treeNode15 = new TreeNode("Heart Disease");
            TreeNode treeNode16 = new TreeNode("Cardiovascular System", new TreeNode[] { treeNode14, treeNode15 });
            TreeNode treeNode17 = new TreeNode("Gastritis");
            TreeNode treeNode18 = new TreeNode("Acid Reflux");
            TreeNode treeNode19 = new TreeNode("Digestive System", new TreeNode[] { treeNode17, treeNode18 });
            TreeNode treeNode20 = new TreeNode("Body Diagnosis", new TreeNode[] { treeNode13, treeNode16, treeNode19 });
            panel1 = new Panel();
            LabTestPanel = new Panel();
            GeneralCheckupPanel = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            BPressurePanel = new FlowLayoutPanel();
            Normal = new RadioButton();
            PreHyperRadioBtn = new RadioButton();
            HyperRadioBtn = new RadioButton();
            label12 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            label16 = new Label();
            heightTextBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            label17 = new Label();
            weightTextBox = new TextBox();
            tableLayoutPanel4 = new TableLayoutPanel();
            label18 = new Label();
            BMITextBox = new TextBox();
            tableLayoutPanel5 = new TableLayoutPanel();
            label19 = new Label();
            tempText = new TextBox();
            TempPanel = new FlowLayoutPanel();
            degCelcRadioBtn = new RadioButton();
            DegFarRadioBtn = new RadioButton();
            label14 = new Label();
            DiagnosisTreeView = new TreeView();
            tableLayoutPanel6 = new TableLayoutPanel();
            label13 = new Label();
            symptomCheckBox = new CheckedListBox();
            tableLayoutPanel7 = new TableLayoutPanel();
            label20 = new Label();
            GrRemarksTextBox = new TextBox();
            label15 = new Label();
            tableLayoutPanel8 = new TableLayoutPanel();
            BackButton2 = new Button();
            AddButton2 = new Button();
            BackButton = new Button();
            AddButton = new Button();
            RemarksTextBox = new TextBox();
            DoctorTextBox = new TextBox();
            PlatTextBox = new TextBox();
            HemoTextBox = new TextBox();
            RBCTextBox = new TextBox();
            label11 = new Label();
            WBCTextBox = new TextBox();
            label9 = new Label();
            TestDate = new DateTimePicker();
            label8 = new Label();
            TestComboBox = new ComboBox();
            label7 = new Label();
            label5 = new Label();
            label3 = new Label();
            label10 = new Label();
            label2 = new Label();
            CancelButton = new Button();
            nextButton = new Button();
            label6 = new Label();
            recComboBox = new ComboBox();
            label4 = new Label();
            patientPageDown = new HMS_UI.CustomControls.LeftArrowButton();
            PatientPageUp = new HMS_UI.CustomControls.RightArrowButton();
            AddPatientBtn = new Button();
            patientData = new DataGridView();
            label1 = new Label();
            PatientTextBox = new TextBox();
            panel1.SuspendLayout();
            LabTestPanel.SuspendLayout();
            GeneralCheckupPanel.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            BPressurePanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            TempPanel.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            tableLayoutPanel7.SuspendLayout();
            tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)patientData).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.Controls.Add(LabTestPanel);
            panel1.Controls.Add(CancelButton);
            panel1.Controls.Add(nextButton);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(recComboBox);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(patientPageDown);
            panel1.Controls.Add(PatientPageUp);
            panel1.Controls.Add(AddPatientBtn);
            panel1.Controls.Add(patientData);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(PatientTextBox);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(883, 540);
            panel1.TabIndex = 0;
            // 
            // LabTestPanel
            // 
            LabTestPanel.Controls.Add(GeneralCheckupPanel);
            LabTestPanel.Controls.Add(BackButton);
            LabTestPanel.Controls.Add(AddButton);
            LabTestPanel.Controls.Add(RemarksTextBox);
            LabTestPanel.Controls.Add(DoctorTextBox);
            LabTestPanel.Controls.Add(PlatTextBox);
            LabTestPanel.Controls.Add(HemoTextBox);
            LabTestPanel.Controls.Add(RBCTextBox);
            LabTestPanel.Controls.Add(label11);
            LabTestPanel.Controls.Add(WBCTextBox);
            LabTestPanel.Controls.Add(label9);
            LabTestPanel.Controls.Add(TestDate);
            LabTestPanel.Controls.Add(label8);
            LabTestPanel.Controls.Add(TestComboBox);
            LabTestPanel.Controls.Add(label7);
            LabTestPanel.Controls.Add(label5);
            LabTestPanel.Controls.Add(label3);
            LabTestPanel.Controls.Add(label10);
            LabTestPanel.Controls.Add(label2);
            LabTestPanel.Dock = DockStyle.Fill;
            LabTestPanel.Location = new Point(0, 0);
            LabTestPanel.Name = "LabTestPanel";
            LabTestPanel.Size = new Size(883, 540);
            LabTestPanel.TabIndex = 23;
            // 
            // GeneralCheckupPanel
            // 
            GeneralCheckupPanel.BackColor = Color.LightCyan;
            GeneralCheckupPanel.Controls.Add(tableLayoutPanel1);
            GeneralCheckupPanel.Dock = DockStyle.Fill;
            GeneralCheckupPanel.Location = new Point(0, 0);
            GeneralCheckupPanel.Name = "GeneralCheckupPanel";
            GeneralCheckupPanel.Size = new Size(883, 540);
            GeneralCheckupPanel.TabIndex = 5;
            GeneralCheckupPanel.Paint += GeneralCheckupPanel_Paint;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(BPressurePanel, 0, 7);
            tableLayoutPanel1.Controls.Add(label12, 0, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel5, 0, 9);
            tableLayoutPanel1.Controls.Add(label14, 1, 4);
            tableLayoutPanel1.Controls.Add(DiagnosisTreeView, 1, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel6, 0, 11);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel7, 1, 9);
            tableLayoutPanel1.Controls.Add(label15, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel8, 1, 13);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 15;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.464209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.41963148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.464209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.41963148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.464209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.41963148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.06976461F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.464209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 2.46776319F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.464209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.02569079F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.464209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.464209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.464209F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.464209F));
            tableLayoutPanel1.Size = new Size(883, 540);
            tableLayoutPanel1.TabIndex = 0;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // BPressurePanel
            // 
            BPressurePanel.Controls.Add(Normal);
            BPressurePanel.Controls.Add(PreHyperRadioBtn);
            BPressurePanel.Controls.Add(HyperRadioBtn);
            BPressurePanel.Location = new Point(3, 215);
            BPressurePanel.Name = "BPressurePanel";
            BPressurePanel.Size = new Size(370, 25);
            BPressurePanel.TabIndex = 5;
            // 
            // Normal
            // 
            Normal.AutoSize = true;
            Normal.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Normal.Location = new Point(3, 3);
            Normal.Name = "Normal";
            Normal.Size = new Size(83, 25);
            Normal.TabIndex = 2;
            Normal.TabStop = true;
            Normal.Text = "Normal";
            Normal.UseVisualStyleBackColor = true;
            // 
            // PreHyperRadioBtn
            // 
            PreHyperRadioBtn.AutoSize = true;
            PreHyperRadioBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PreHyperRadioBtn.Location = new Point(92, 3);
            PreHyperRadioBtn.Name = "PreHyperRadioBtn";
            PreHyperRadioBtn.Size = new Size(145, 25);
            PreHyperRadioBtn.TabIndex = 2;
            PreHyperRadioBtn.TabStop = true;
            PreHyperRadioBtn.Text = "Prehypertension";
            PreHyperRadioBtn.UseVisualStyleBackColor = true;
            // 
            // HyperRadioBtn
            // 
            HyperRadioBtn.AutoSize = true;
            HyperRadioBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            HyperRadioBtn.Location = new Point(243, 3);
            HyperRadioBtn.Name = "HyperRadioBtn";
            HyperRadioBtn.Size = new Size(124, 25);
            HyperRadioBtn.TabIndex = 2;
            HyperRadioBtn.TabStop = true;
            HyperRadioBtn.Text = "Hypertension";
            HyperRadioBtn.UseVisualStyleBackColor = true;
            HyperRadioBtn.CheckedChanged += HyperRadioBtn_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Dock = DockStyle.Fill;
            label12.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(3, 174);
            label12.Name = "label12";
            label12.Size = new Size(435, 38);
            label12.TabIndex = 1;
            label12.Text = "Blood Pressure:";
            label12.TextAlign = ContentAlignment.BottomLeft;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.Controls.Add(label16, 0, 0);
            tableLayoutPanel2.Controls.Add(heightTextBox, 1, 0);
            tableLayoutPanel2.Location = new Point(3, 69);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(435, 29);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Dock = DockStyle.Fill;
            label16.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(3, 0);
            label16.Name = "label16";
            label16.Size = new Size(81, 29);
            label16.TabIndex = 1;
            label16.Text = "Height:";
            // 
            // heightTextBox
            // 
            heightTextBox.Dock = DockStyle.Fill;
            heightTextBox.Location = new Point(90, 3);
            heightTextBox.Name = "heightTextBox";
            heightTextBox.Size = new Size(342, 23);
            heightTextBox.TabIndex = 2;
            heightTextBox.TextChanged += textBox2_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.Controls.Add(label17, 0, 0);
            tableLayoutPanel3.Controls.Add(weightTextBox, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 127);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(435, 29);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Dock = DockStyle.Fill;
            label17.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(3, 0);
            label17.Name = "label17";
            label17.Size = new Size(81, 29);
            label17.TabIndex = 1;
            label17.Text = "Weight:";
            // 
            // weightTextBox
            // 
            weightTextBox.Dock = DockStyle.Fill;
            weightTextBox.Location = new Point(90, 3);
            weightTextBox.Name = "weightTextBox";
            weightTextBox.Size = new Size(342, 23);
            weightTextBox.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.Controls.Add(label18, 0, 0);
            tableLayoutPanel4.Controls.Add(BMITextBox, 1, 0);
            tableLayoutPanel4.Location = new Point(444, 69);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(436, 29);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(3, 0);
            label18.Name = "label18";
            label18.Size = new Size(53, 25);
            label18.TabIndex = 1;
            label18.Text = "BMI:";
            // 
            // BMITextBox
            // 
            BMITextBox.Dock = DockStyle.Fill;
            BMITextBox.Location = new Point(90, 3);
            BMITextBox.Name = "BMITextBox";
            BMITextBox.Size = new Size(343, 23);
            BMITextBox.TabIndex = 2;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 3;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.6122456F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 43.877552F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.5102043F));
            tableLayoutPanel5.Controls.Add(label19, 0, 0);
            tableLayoutPanel5.Controls.Add(tempText, 1, 0);
            tableLayoutPanel5.Controls.Add(TempPanel, 2, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 279);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(435, 45);
            tableLayoutPanel5.TabIndex = 6;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Dock = DockStyle.Fill;
            label19.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(3, 0);
            label19.Name = "label19";
            label19.Size = new Size(127, 45);
            label19.TabIndex = 1;
            label19.Text = "Body Temp:";
            label19.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tempText
            // 
            tempText.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            tempText.Location = new Point(136, 11);
            tempText.Name = "tempText";
            tempText.Size = new Size(184, 23);
            tempText.TabIndex = 2;
            // 
            // TempPanel
            // 
            TempPanel.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TempPanel.Controls.Add(degCelcRadioBtn);
            TempPanel.Controls.Add(DegFarRadioBtn);
            TempPanel.Location = new Point(326, 6);
            TempPanel.Name = "TempPanel";
            TempPanel.Size = new Size(106, 33);
            TempPanel.TabIndex = 2;
            // 
            // degCelcRadioBtn
            // 
            degCelcRadioBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            degCelcRadioBtn.AutoSize = true;
            degCelcRadioBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            degCelcRadioBtn.Location = new Point(3, 3);
            degCelcRadioBtn.Name = "degCelcRadioBtn";
            degCelcRadioBtn.Size = new Size(44, 25);
            degCelcRadioBtn.TabIndex = 2;
            degCelcRadioBtn.TabStop = true;
            degCelcRadioBtn.Text = "°C";
            degCelcRadioBtn.UseVisualStyleBackColor = true;
            // 
            // DegFarRadioBtn
            // 
            DegFarRadioBtn.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            DegFarRadioBtn.AutoSize = true;
            DegFarRadioBtn.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DegFarRadioBtn.Location = new Point(53, 3);
            DegFarRadioBtn.Name = "DegFarRadioBtn";
            DegFarRadioBtn.Size = new Size(42, 25);
            DegFarRadioBtn.TabIndex = 2;
            DegFarRadioBtn.TabStop = true;
            DegFarRadioBtn.Text = "°F";
            DegFarRadioBtn.UseVisualStyleBackColor = true;
            DegFarRadioBtn.CheckedChanged += HyperRadioBtn_CheckedChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Dock = DockStyle.Fill;
            label14.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(444, 116);
            label14.Name = "label14";
            label14.Size = new Size(436, 51);
            label14.TabIndex = 1;
            label14.Text = "Diagnosis:";
            label14.TextAlign = ContentAlignment.BottomLeft;
            // 
            // DiagnosisTreeView
            // 
            DiagnosisTreeView.CheckBoxes = true;
            DiagnosisTreeView.Dock = DockStyle.Fill;
            DiagnosisTreeView.Location = new Point(444, 170);
            DiagnosisTreeView.Name = "DiagnosisTreeView";
            treeNode11.Name = "Asthma";
            treeNode11.Text = "Asthma";
            treeNode12.Name = "Pneumonia";
            treeNode12.Text = "Pneumonia";
            treeNode13.Name = "RespSystem";
            treeNode13.Text = "Respiratory System";
            treeNode14.Name = "Hypertension";
            treeNode14.Text = "Hypertension";
            treeNode15.Name = "HeartDisease";
            treeNode15.Text = "Heart Disease";
            treeNode16.Name = "CardiovascularSystem";
            treeNode16.Text = "Cardiovascular System";
            treeNode17.Name = "Gastritis";
            treeNode17.Text = "Gastritis";
            treeNode18.Name = "AcidReflux";
            treeNode18.Text = "Acid Reflux";
            treeNode19.Name = "DigestiveSystem";
            treeNode19.Text = "Digestive System";
            treeNode20.Name = "BodyDiagnosis";
            treeNode20.Text = "Body Diagnosis";
            DiagnosisTreeView.Nodes.AddRange(new TreeNode[] { treeNode20 });
            tableLayoutPanel1.SetRowSpan(DiagnosisTreeView, 4);
            DiagnosisTreeView.Size = new Size(436, 103);
            DiagnosisTreeView.TabIndex = 4;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 1;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel6.Controls.Add(label13, 0, 0);
            tableLayoutPanel6.Controls.Add(symptomCheckBox, 0, 1);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 335);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 2;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel6, 3);
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 29.5774651F));
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 70.42254F));
            tableLayoutPanel6.Size = new Size(435, 147);
            tableLayoutPanel6.TabIndex = 7;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Dock = DockStyle.Fill;
            label13.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(3, 0);
            label13.Name = "label13";
            label13.Size = new Size(429, 43);
            label13.TabIndex = 4;
            label13.Text = "Reported Symptoms:";
            label13.TextAlign = ContentAlignment.BottomLeft;
            // 
            // symptomCheckBox
            // 
            symptomCheckBox.Dock = DockStyle.Fill;
            symptomCheckBox.FormattingEnabled = true;
            symptomCheckBox.Items.AddRange(new object[] { "Fever", "Headache", "Cough", "Chest Pain", "Shortness of Breath" });
            symptomCheckBox.Location = new Point(3, 46);
            symptomCheckBox.Name = "symptomCheckBox";
            symptomCheckBox.Size = new Size(429, 98);
            symptomCheckBox.TabIndex = 3;
            symptomCheckBox.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // tableLayoutPanel7
            // 
            tableLayoutPanel7.ColumnCount = 1;
            tableLayoutPanel7.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel7.Controls.Add(label20, 0, 0);
            tableLayoutPanel7.Controls.Add(GrRemarksTextBox, 0, 1);
            tableLayoutPanel7.Dock = DockStyle.Fill;
            tableLayoutPanel7.Location = new Point(444, 279);
            tableLayoutPanel7.Name = "tableLayoutPanel7";
            tableLayoutPanel7.RowCount = 2;
            tableLayoutPanel1.SetRowSpan(tableLayoutPanel7, 4);
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 21.875F));
            tableLayoutPanel7.RowStyles.Add(new RowStyle(SizeType.Percent, 78.125F));
            tableLayoutPanel7.Size = new Size(436, 152);
            tableLayoutPanel7.TabIndex = 8;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(3, 0);
            label20.Name = "label20";
            label20.Size = new Size(93, 25);
            label20.TabIndex = 1;
            label20.Text = "Remarks:";
            // 
            // GrRemarksTextBox
            // 
            GrRemarksTextBox.Dock = DockStyle.Fill;
            GrRemarksTextBox.Location = new Point(3, 36);
            GrRemarksTextBox.Multiline = true;
            GrRemarksTextBox.Name = "GrRemarksTextBox";
            GrRemarksTextBox.Size = new Size(430, 113);
            GrRemarksTextBox.TabIndex = 2;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Dock = DockStyle.Fill;
            label15.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(3, 0);
            label15.Name = "label15";
            label15.Size = new Size(435, 51);
            label15.TabIndex = 1;
            label15.Text = "General Checkup Report";
            label15.TextAlign = ContentAlignment.MiddleLeft;
            label15.Click += label15_Click;
            // 
            // tableLayoutPanel8
            // 
            tableLayoutPanel8.ColumnCount = 2;
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Controls.Add(BackButton2, 0, 0);
            tableLayoutPanel8.Controls.Add(AddButton2, 1, 0);
            tableLayoutPanel8.Dock = DockStyle.Fill;
            tableLayoutPanel8.Location = new Point(444, 437);
            tableLayoutPanel8.Name = "tableLayoutPanel8";
            tableLayoutPanel8.RowCount = 1;
            tableLayoutPanel8.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel8.Size = new Size(436, 45);
            tableLayoutPanel8.TabIndex = 9;
            // 
            // BackButton2
            // 
            BackButton2.Dock = DockStyle.Fill;
            BackButton2.Location = new Point(3, 3);
            BackButton2.Name = "BackButton2";
            BackButton2.Size = new Size(212, 39);
            BackButton2.TabIndex = 0;
            BackButton2.Text = "Back";
            BackButton2.UseVisualStyleBackColor = true;
            BackButton2.Click += BackButton2_Click;
            // 
            // AddButton2
            // 
            AddButton2.Dock = DockStyle.Fill;
            AddButton2.Location = new Point(221, 3);
            AddButton2.Name = "AddButton2";
            AddButton2.Size = new Size(212, 39);
            AddButton2.TabIndex = 0;
            AddButton2.Text = "Add";
            AddButton2.UseVisualStyleBackColor = true;
            AddButton2.Click += AddButton2_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.Moccasin;
            BackButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            BackButton.Location = new Point(510, 294);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(170, 43);
            BackButton.TabIndex = 4;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.MistyRose;
            AddButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AddButton.Location = new Point(686, 294);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(170, 43);
            AddButton.TabIndex = 4;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // RemarksTextBox
            // 
            RemarksTextBox.BackColor = Color.LemonChiffon;
            RemarksTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            RemarksTextBox.Location = new Point(458, 107);
            RemarksTextBox.Multiline = true;
            RemarksTextBox.Name = "RemarksTextBox";
            RemarksTextBox.Size = new Size(398, 181);
            RemarksTextBox.TabIndex = 3;
            // 
            // DoctorTextBox
            // 
            DoctorTextBox.BackColor = Color.Thistle;
            DoctorTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            DoctorTextBox.Location = new Point(240, 419);
            DoctorTextBox.Name = "DoctorTextBox";
            DoctorTextBox.Size = new Size(186, 35);
            DoctorTextBox.TabIndex = 3;
            // 
            // PlatTextBox
            // 
            PlatTextBox.BackColor = Color.PaleTurquoise;
            PlatTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            PlatTextBox.Location = new Point(241, 359);
            PlatTextBox.Name = "PlatTextBox";
            PlatTextBox.Size = new Size(185, 35);
            PlatTextBox.TabIndex = 3;
            // 
            // HemoTextBox
            // 
            HemoTextBox.BackColor = Color.LightCyan;
            HemoTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            HemoTextBox.Location = new Point(241, 297);
            HemoTextBox.Name = "HemoTextBox";
            HemoTextBox.Size = new Size(185, 35);
            HemoTextBox.TabIndex = 3;
            // 
            // RBCTextBox
            // 
            RBCTextBox.BackColor = Color.Wheat;
            RBCTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            RBCTextBox.Location = new Point(241, 235);
            RBCTextBox.Name = "RBCTextBox";
            RBCTextBox.Size = new Size(185, 35);
            RBCTextBox.TabIndex = 3;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label11.Location = new Point(89, 428);
            label11.Name = "label11";
            label11.Size = new Size(128, 23);
            label11.TabIndex = 0;
            label11.Text = "Doctor's Name";
            // 
            // WBCTextBox
            // 
            WBCTextBox.BackColor = Color.NavajoWhite;
            WBCTextBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            WBCTextBox.Location = new Point(241, 177);
            WBCTextBox.Name = "WBCTextBox";
            WBCTextBox.Size = new Size(185, 35);
            WBCTextBox.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label9.Location = new Point(89, 368);
            label9.Name = "label9";
            label9.Size = new Size(131, 23);
            label9.TabIndex = 0;
            label9.Text = "Platelets Count";
            // 
            // TestDate
            // 
            TestDate.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TestDate.Format = DateTimePickerFormat.Short;
            TestDate.Location = new Point(237, 137);
            TestDate.Name = "TestDate";
            TestDate.Size = new Size(189, 23);
            TestDate.TabIndex = 2;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label8.Location = new Point(64, 306);
            label8.Name = "label8";
            label8.Size = new Size(156, 23);
            label8.TabIndex = 0;
            label8.Text = "Hemoglobin Level";
            // 
            // TestComboBox
            // 
            TestComboBox.BackColor = Color.LightPink;
            TestComboBox.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold | FontStyle.Italic);
            TestComboBox.FormattingEnabled = true;
            TestComboBox.Location = new Point(239, 81);
            TestComboBox.Name = "TestComboBox";
            TestComboBox.Size = new Size(187, 38);
            TestComboBox.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label7.Location = new Point(35, 244);
            label7.Name = "label7";
            label7.Size = new Size(185, 23);
            label7.TabIndex = 0;
            label7.Text = "Red Blood Cells (RBC)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label5.Location = new Point(12, 186);
            label5.Name = "label5";
            label5.Size = new Size(208, 23);
            label5.TabIndex = 0;
            label5.Text = "White Blood Cells (WBC)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label3.Location = new Point(136, 137);
            label3.Name = "label3";
            label3.Size = new Size(84, 23);
            label3.TabIndex = 0;
            label3.Text = "Test Date";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label10.Location = new Point(457, 81);
            label10.Name = "label10";
            label10.Size = new Size(79, 23);
            label10.TabIndex = 0;
            label10.Text = "Remarks";
            label10.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label2.Location = new Point(127, 90);
            label2.Name = "label2";
            label2.Size = new Size(93, 23);
            label2.TabIndex = 0;
            label2.Text = "Test Name";
            label2.Click += label2_Click;
            // 
            // CancelButton
            // 
            CancelButton.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            CancelButton.Location = new Point(651, 268);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(107, 36);
            CancelButton.TabIndex = 22;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += CancelButton_Click;
            // 
            // nextButton
            // 
            nextButton.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            nextButton.Location = new Point(764, 268);
            nextButton.Name = "nextButton";
            nextButton.Size = new Size(107, 36);
            nextButton.TabIndex = 22;
            nextButton.Text = "Next";
            nextButton.UseVisualStyleBackColor = true;
            nextButton.Click += nextButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(23, 32);
            label6.Name = "label6";
            label6.Size = new Size(291, 30);
            label6.TabIndex = 21;
            label6.Text = "Add A New Medical Record";
            // 
            // recComboBox
            // 
            recComboBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recComboBox.FormattingEnabled = true;
            recComboBox.Location = new Point(671, 201);
            recComboBox.Name = "recComboBox";
            recComboBox.Size = new Size(200, 29);
            recComboBox.TabIndex = 20;
            recComboBox.SelectedIndexChanged += recComboBox_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(563, 204);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 19;
            label4.Text = "Record Type";
            // 
            // patientPageDown
            // 
            patientPageDown.ArrowColor = SystemColors.Control;
            patientPageDown.BackColor = SystemColors.ControlDark;
            patientPageDown.Location = new Point(23, 480);
            patientPageDown.Name = "patientPageDown";
            patientPageDown.Size = new Size(18, 32);
            patientPageDown.TabIndex = 18;
            patientPageDown.Text = "LeftButton";
            patientPageDown.Click += patientPageDown_Click;
            // 
            // PatientPageUp
            // 
            PatientPageUp.ArrowColor = SystemColors.Control;
            PatientPageUp.BackColor = SystemColors.ControlDark;
            PatientPageUp.Font = new Font("Segoe UI", 9F);
            PatientPageUp.Location = new Point(518, 480);
            PatientPageUp.Name = "PatientPageUp";
            PatientPageUp.Size = new Size(18, 32);
            PatientPageUp.TabIndex = 17;
            PatientPageUp.Text = "RightButton";
            PatientPageUp.Click += PatientPageUp_Click;
            // 
            // AddPatientBtn
            // 
            AddPatientBtn.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            AddPatientBtn.Location = new Point(47, 480);
            AddPatientBtn.Name = "AddPatientBtn";
            AddPatientBtn.Size = new Size(465, 32);
            AddPatientBtn.TabIndex = 16;
            AddPatientBtn.Text = "Add A New Patient";
            AddPatientBtn.UseVisualStyleBackColor = true;
            AddPatientBtn.Click += AddPatientBtn_Click;
            // 
            // patientData
            // 
            patientData.AllowUserToAddRows = false;
            patientData.AllowUserToDeleteRows = false;
            patientData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientData.Location = new Point(23, 128);
            patientData.MultiSelect = false;
            patientData.Name = "patientData";
            patientData.ReadOnly = true;
            patientData.RowHeadersWidth = 51;
            patientData.Size = new Size(513, 346);
            patientData.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(23, 93);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 14;
            label1.Text = "Patient";
            // 
            // PatientTextBox
            // 
            PatientTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PatientTextBox.Location = new Point(90, 93);
            PatientTextBox.Name = "PatientTextBox";
            PatientTextBox.Size = new Size(446, 29);
            PatientTextBox.TabIndex = 13;
            PatientTextBox.TextChanged += PatientTextBox_TextChanged;
            // 
            // CreateRecord
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(883, 540);
            Controls.Add(panel1);
            Name = "CreateRecord";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateRecord";
            Load += AddRecord_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            LabTestPanel.ResumeLayout(false);
            LabTestPanel.PerformLayout();
            GeneralCheckupPanel.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            BPressurePanel.ResumeLayout(false);
            BPressurePanel.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            TempPanel.ResumeLayout(false);
            TempPanel.PerformLayout();
            tableLayoutPanel6.ResumeLayout(false);
            tableLayoutPanel6.PerformLayout();
            tableLayoutPanel7.ResumeLayout(false);
            tableLayoutPanel7.PerformLayout();
            tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)patientData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private CustomControls.LeftArrowButton patientPageDown;
        private CustomControls.RightArrowButton PatientPageUp;
        private Button AddPatientBtn;
        private DataGridView patientData;
        private Label label1;
        private TextBox PatientTextBox;
        private ComboBox recComboBox;
        private Label label4;
        private Label label6;
        private Button nextButton;
        private Panel LabTestPanel;
        private Label label2;
        private TextBox RBCTextBox;
        private TextBox WBCTextBox;
        private DateTimePicker TestDate;
        private ComboBox TestComboBox;
        private Label label7;
        private Label label5;
        private Label label3;
        private TextBox HemoTextBox;
        private Label label8;
        private TextBox RemarksTextBox;
        private TextBox PlatTextBox;
        private Label label9;
        private Button AddButton;
        private TextBox DoctorTextBox;
        private Label label11;
        private Label label10;
        private Button BackButton;
        private Button CancelButton;
        private Panel GeneralCheckupPanel;
        private RadioButton HyperRadioBtn;
        private RadioButton PreHyperRadioBtn;
        private RadioButton Normal;
        private Label label12;
        private TableLayoutPanel tableLayoutPanel1;
        private TreeView treeView2;
        private TreeView DiagnosisTreeView;
        private CheckedListBox symptomCheckBox;
        private Label label14;
        private FlowLayoutPanel BPressurePanel;
        private Label label15;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label16;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label17;
        private TextBox heightTextBox;
        private TextBox weightTextBox;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label18;
        private TextBox BMITextBox;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label19;
        private TextBox tempText;
        private FlowLayoutPanel TempPanel;
        private RadioButton degCelcRadioBtn;
        private RadioButton DegFarRadioBtn;
        private TableLayoutPanel tableLayoutPanel6;
        private Label label13;
        private TableLayoutPanel tableLayoutPanel7;
        private Label label20;
        private TextBox GrRemarksTextBox;
        private TableLayoutPanel tableLayoutPanel8;
        private Button BackButton2;
        private Button AddButton2;
    }
}