using HMS_UI.CustomControls;

namespace HMS_UI
{
    partial class CreateAppointment
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
            components = new System.ComponentModel.Container();
            PatientTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            DoctorTextBox = new TextBox();
            label3 = new Label();
            apDdateTimePicker = new DateTimePicker();
            label4 = new Label();
            patientData = new DataGridView();
            doctorData = new DataGridView();
            statusComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            createButton = new Button();
            bindingSource = new BindingSource(components);
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            nameTextBox = new TextBox();
            emailTextBox = new TextBox();
            phoneTextBox = new TextBox();
            cancelButton = new Button();
            AddPatientBtn = new Button();
            CreateDoctorBtn = new Button();
            PatientPageUp = new RightArrowButton();
            patientPageDown = new LeftArrowButton();
            DoctorPageUp = new RightArrowButton();
            DoctorPageDown = new LeftArrowButton();
            ((System.ComponentModel.ISupportInitialize)patientData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            SuspendLayout();
            // 
            // PatientTextBox
            // 
            PatientTextBox.BackColor = Color.Thistle;
            PatientTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PatientTextBox.Location = new Point(83, 82);
            PatientTextBox.Name = "PatientTextBox";
            PatientTextBox.Size = new Size(219, 29);
            PatientTextBox.TabIndex = 0;
            PatientTextBox.TextChanged += PatientTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(12, 85);
            label1.Name = "label1";
            label1.Size = new Size(61, 21);
            label1.TabIndex = 1;
            label1.Text = "Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(476, 85);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 3;
            label2.Text = "Doctor";
            // 
            // DoctorTextBox
            // 
            DoctorTextBox.BackColor = Color.Bisque;
            DoctorTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            DoctorTextBox.Location = new Point(563, 82);
            DoctorTextBox.Name = "DoctorTextBox";
            DoctorTextBox.Size = new Size(219, 29);
            DoctorTextBox.TabIndex = 2;
            DoctorTextBox.TextChanged += DoctorTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(836, 133);
            label3.Name = "label3";
            label3.Size = new Size(44, 21);
            label3.TabIndex = 3;
            label3.Text = "Date";
            // 
            // apDdateTimePicker
            // 
            apDdateTimePicker.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            apDdateTimePicker.Checked = false;
            apDdateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            apDdateTimePicker.Format = DateTimePickerFormat.Custom;
            apDdateTimePicker.Location = new Point(886, 132);
            apDdateTimePicker.Name = "apDdateTimePicker";
            apDdateTimePicker.ShowCheckBox = true;
            apDdateTimePicker.Size = new Size(200, 23);
            apDdateTimePicker.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(825, 186);
            label4.Name = "label4";
            label4.Size = new Size(55, 21);
            label4.TabIndex = 3;
            label4.Text = "Status";
            // 
            // patientData
            // 
            patientData.AllowUserToAddRows = false;
            patientData.AllowUserToDeleteRows = false;
            patientData.BackgroundColor = Color.PowderBlue;
            patientData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientData.Location = new Point(12, 117);
            patientData.MultiSelect = false;
            patientData.Name = "patientData";
            patientData.ReadOnly = true;
            patientData.RowHeadersWidth = 51;
            patientData.Size = new Size(290, 346);
            patientData.TabIndex = 5;
            // 
            // doctorData
            // 
            doctorData.AllowUserToAddRows = false;
            doctorData.AllowUserToDeleteRows = false;
            doctorData.BackgroundColor = Color.LightBlue;
            doctorData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorData.Location = new Point(369, 117);
            doctorData.MultiSelect = false;
            doctorData.Name = "doctorData";
            doctorData.ReadOnly = true;
            doctorData.RowHeadersWidth = 51;
            doctorData.Size = new Size(413, 346);
            doctorData.TabIndex = 6;
            // 
            // statusComboBox
            // 
            statusComboBox.BackColor = Color.LightGoldenrodYellow;
            statusComboBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(886, 183);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(200, 29);
            statusComboBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(801, 260);
            label5.Name = "label5";
            label5.Size = new Size(178, 21);
            label5.TabIndex = 3;
            label5.Text = "Appointment Taken By,";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCyan;
            label6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(12, 25);
            label6.Name = "label6";
            label6.Size = new Size(295, 30);
            label6.TabIndex = 9;
            label6.Text = "Create A New Appointment";
            // 
            // createButton
            // 
            createButton.BackColor = Color.DeepSkyBlue;
            createButton.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            createButton.Location = new Point(997, 82);
            createButton.Name = "createButton";
            createButton.Size = new Size(89, 29);
            createButton.TabIndex = 10;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += CreateButton_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label7.Location = new Point(801, 297);
            label7.Name = "label7";
            label7.Size = new Size(57, 21);
            label7.TabIndex = 3;
            label7.Text = "Name:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label8.Location = new Point(801, 339);
            label8.Name = "label8";
            label8.Size = new Size(52, 21);
            label8.TabIndex = 3;
            label8.Text = "Email:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label9.Location = new Point(801, 382);
            label9.Name = "label9";
            label9.Size = new Size(60, 21);
            label9.TabIndex = 3;
            label9.Text = "Phone:";
            // 
            // nameTextBox
            // 
            nameTextBox.BackColor = Color.OldLace;
            nameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            nameTextBox.Location = new Point(864, 294);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.ReadOnly = true;
            nameTextBox.Size = new Size(219, 29);
            nameTextBox.TabIndex = 2;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.Beige;
            emailTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            emailTextBox.Location = new Point(864, 339);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.ReadOnly = true;
            emailTextBox.Size = new Size(219, 29);
            emailTextBox.TabIndex = 2;
            // 
            // phoneTextBox
            // 
            phoneTextBox.BackColor = Color.Wheat;
            phoneTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            phoneTextBox.Location = new Point(864, 379);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.ReadOnly = true;
            phoneTextBox.Size = new Size(219, 29);
            phoneTextBox.TabIndex = 2;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.PaleTurquoise;
            cancelButton.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            cancelButton.Location = new Point(886, 82);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(89, 29);
            cancelButton.TabIndex = 10;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // AddPatientBtn
            // 
            AddPatientBtn.BackColor = Color.Turquoise;
            AddPatientBtn.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            AddPatientBtn.Location = new Point(64, 469);
            AddPatientBtn.Name = "AddPatientBtn";
            AddPatientBtn.Size = new Size(185, 44);
            AddPatientBtn.TabIndex = 10;
            AddPatientBtn.Text = "Add A New Patient";
            AddPatientBtn.UseVisualStyleBackColor = false;
            AddPatientBtn.Click += AddPatientBtn_Click;
            // 
            // CreateDoctorBtn
            // 
            CreateDoctorBtn.BackColor = Color.Aquamarine;
            CreateDoctorBtn.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            CreateDoctorBtn.Location = new Point(433, 469);
            CreateDoctorBtn.Name = "CreateDoctorBtn";
            CreateDoctorBtn.Size = new Size(290, 44);
            CreateDoctorBtn.TabIndex = 10;
            CreateDoctorBtn.Text = "Add A New Doctor";
            CreateDoctorBtn.UseVisualStyleBackColor = false;
            CreateDoctorBtn.Click += CreateDoctorBtn_Click;
            // 
            // PatientPageUp
            // 
            PatientPageUp.ArrowColor = SystemColors.Control;
            PatientPageUp.BackColor = SystemColors.ControlDark;
            PatientPageUp.Font = new Font("Segoe UI", 9F);
            PatientPageUp.Location = new Point(284, 469);
            PatientPageUp.Name = "PatientPageUp";
            PatientPageUp.Size = new Size(18, 20);
            PatientPageUp.TabIndex = 11;
            PatientPageUp.Text = "RightButton";
            PatientPageUp.Click += PatientPageUp_Click;
            // 
            // patientPageDown
            // 
            patientPageDown.ArrowColor = SystemColors.Control;
            patientPageDown.BackColor = SystemColors.ControlDark;
            patientPageDown.Location = new Point(12, 469);
            patientPageDown.Name = "patientPageDown";
            patientPageDown.Size = new Size(18, 20);
            patientPageDown.TabIndex = 12;
            patientPageDown.Text = "LeftButton";
            patientPageDown.Click += patientPageDown_Click;
            // 
            // DoctorPageUp
            // 
            DoctorPageUp.ArrowColor = SystemColors.Control;
            DoctorPageUp.BackColor = SystemColors.ControlDark;
            DoctorPageUp.Font = new Font("Segoe UI", 9F);
            DoctorPageUp.Location = new Point(764, 469);
            DoctorPageUp.Name = "DoctorPageUp";
            DoctorPageUp.Size = new Size(18, 20);
            DoctorPageUp.TabIndex = 11;
            DoctorPageUp.Text = "RightButton";
            DoctorPageUp.Click += DoctorPageUp_Click;
            // 
            // DoctorPageDown
            // 
            DoctorPageDown.ArrowColor = SystemColors.Control;
            DoctorPageDown.BackColor = SystemColors.ControlDark;
            DoctorPageDown.Location = new Point(369, 469);
            DoctorPageDown.Name = "DoctorPageDown";
            DoctorPageDown.Size = new Size(18, 20);
            DoctorPageDown.TabIndex = 12;
            DoctorPageDown.Text = "LeftButton";
            DoctorPageDown.Click += DoctorPageDown_Click;
            // 
            // CreateAppointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CadetBlue;
            ClientSize = new Size(1111, 525);
            Controls.Add(DoctorPageDown);
            Controls.Add(patientPageDown);
            Controls.Add(DoctorPageUp);
            Controls.Add(PatientPageUp);
            Controls.Add(cancelButton);
            Controls.Add(CreateDoctorBtn);
            Controls.Add(AddPatientBtn);
            Controls.Add(createButton);
            Controls.Add(label6);
            Controls.Add(statusComboBox);
            Controls.Add(doctorData);
            Controls.Add(patientData);
            Controls.Add(apDdateTimePicker);
            Controls.Add(label5);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(phoneTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(DoctorTextBox);
            Controls.Add(label1);
            Controls.Add(PatientTextBox);
            Name = "CreateAppointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateAppointment";
            Load += CreateAppointment_Load;
            ((System.ComponentModel.ISupportInitialize)patientData).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorData).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox PatientTextBox;
        private Label label1;
        private Label label2;
        private TextBox DoctorTextBox;
        private Label label3;
        private DateTimePicker apDdateTimePicker;
        private Label label4;
        private DataGridView patientData;
        private DataGridView doctorData;
        private ComboBox statusComboBox;
        private Label label5;
        private Label label6;
        private Button createButton;
        private BindingSource bindingSource;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox nameTextBox;
        private TextBox emailTextBox;
        private TextBox phoneTextBox;
        private Button cancelButton;
        private Button AddPatientBtn;
        private Button CreateDoctorBtn;
        private RightArrowButton PatientPageUp;
        private LeftArrowButton patientPageDown;
        private RightArrowButton DoctorPageUp;
        private LeftArrowButton DoctorPageDown;
    }
}