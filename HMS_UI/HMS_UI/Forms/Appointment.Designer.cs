namespace HMS_UI
{
    partial class Appointment
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
            AppointmentStatusComboBox = new ComboBox();
            AppointmentDateTimePicker = new DateTimePicker();
            PatientTextBox = new TextBox();
            label3 = new Label();
            backButton = new Button();
            saveButton = new Button();
            createButton = new Button();
            cancelButton = new Button();
            editButton = new Button();
            label4 = new Label();
            ReceptionistTextBox = new TextBox();
            DoctorTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            appointmentData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            pageSize = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            pageNumber = new TextBox();
            leftArrowButton1 = new HMS_UI.CustomControls.LeftArrowButton();
            rightArrowButton1 = new HMS_UI.CustomControls.RightArrowButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // AppointmentStatusComboBox
            // 
            AppointmentStatusComboBox.BackColor = Color.SpringGreen;
            AppointmentStatusComboBox.Dock = DockStyle.Fill;
            AppointmentStatusComboBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            AppointmentStatusComboBox.FormattingEnabled = true;
            AppointmentStatusComboBox.Location = new Point(443, 16);
            AppointmentStatusComboBox.Name = "AppointmentStatusComboBox";
            AppointmentStatusComboBox.Size = new Size(113, 23);
            AppointmentStatusComboBox.TabIndex = 1;
            AppointmentStatusComboBox.SelectedIndexChanged += AppointmentStatusComboBox_SelectedIndexChanged;
            AppointmentStatusComboBox.TextChanged += AppointmentStatusComboBox_TextChanged;
            // 
            // AppointmentDateTimePicker
            // 
            AppointmentDateTimePicker.CalendarFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AppointmentDateTimePicker.Checked = false;
            AppointmentDateTimePicker.CustomFormat = "yyyy-MM-dd";
            AppointmentDateTimePicker.Dock = DockStyle.Fill;
            AppointmentDateTimePicker.Format = DateTimePickerFormat.Custom;
            AppointmentDateTimePicker.Location = new Point(443, 57);
            AppointmentDateTimePicker.Name = "AppointmentDateTimePicker";
            AppointmentDateTimePicker.ShowCheckBox = true;
            AppointmentDateTimePicker.Size = new Size(113, 23);
            AppointmentDateTimePicker.TabIndex = 2;
            AppointmentDateTimePicker.ValueChanged += AppointmentDateTimePicker_ValueChanged;
            // 
            // PatientTextBox
            // 
            PatientTextBox.BackColor = Color.RosyBrown;
            PatientTextBox.Dock = DockStyle.Fill;
            PatientTextBox.ForeColor = Color.Transparent;
            PatientTextBox.Location = new Point(582, 16);
            PatientTextBox.Name = "PatientTextBox";
            PatientTextBox.PlaceholderText = "Patient Name";
            PatientTextBox.Size = new Size(113, 23);
            PatientTextBox.TabIndex = 4;
            PatientTextBox.TextChanged += PatientTextBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(304, 13);
            label3.Name = "label3";
            label3.Size = new Size(113, 37);
            label3.TabIndex = 8;
            label3.Text = "Status";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // backButton
            // 
            backButton.AutoSize = true;
            backButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            backButton.BackColor = Color.LightCoral;
            backButton.Dock = DockStyle.Fill;
            backButton.ForeColor = Color.Transparent;
            backButton.Location = new Point(999, 16);
            backButton.Name = "backButton";
            backButton.Size = new Size(113, 31);
            backButton.TabIndex = 11;
            backButton.Text = "Back";
            backButton.UseVisualStyleBackColor = false;
            backButton.Click += BackButton_Click;
            // 
            // saveButton
            // 
            saveButton.AutoSize = true;
            saveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            saveButton.BackColor = Color.YellowGreen;
            saveButton.Dock = DockStyle.Fill;
            saveButton.Enabled = false;
            saveButton.Location = new Point(860, 57);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(113, 31);
            saveButton.TabIndex = 10;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = false;
            saveButton.Visible = false;
            saveButton.Click += SaveButton_Click;
            // 
            // createButton
            // 
            createButton.AutoSize = true;
            createButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            createButton.BackColor = Color.PeachPuff;
            createButton.Dock = DockStyle.Fill;
            createButton.Location = new Point(999, 57);
            createButton.Name = "createButton";
            createButton.Size = new Size(113, 31);
            createButton.TabIndex = 9;
            createButton.Text = "Create Appointment";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += CreatelButton_Click;
            // 
            // cancelButton
            // 
            cancelButton.AutoSize = true;
            cancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            cancelButton.BackColor = Color.Pink;
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.Enabled = false;
            cancelButton.Location = new Point(860, 16);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(113, 31);
            cancelButton.TabIndex = 9;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Visible = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // editButton
            // 
            editButton.AutoSize = true;
            editButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            editButton.BackColor = Color.PapayaWhip;
            editButton.Dock = DockStyle.Fill;
            editButton.Location = new Point(721, 57);
            editButton.Name = "editButton";
            editButton.Size = new Size(113, 31);
            editButton.TabIndex = 9;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = false;
            editButton.Click += EditButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(304, 54);
            label4.Name = "label4";
            label4.Size = new Size(113, 37);
            label4.TabIndex = 8;
            label4.Text = "Appointment Date";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // ReceptionistTextBox
            // 
            ReceptionistTextBox.BackColor = Color.LightSkyBlue;
            ReceptionistTextBox.Dock = DockStyle.Fill;
            ReceptionistTextBox.ForeColor = SystemColors.ActiveCaptionText;
            ReceptionistTextBox.Location = new Point(721, 16);
            ReceptionistTextBox.Name = "ReceptionistTextBox";
            ReceptionistTextBox.PlaceholderText = "Receptionist Name";
            ReceptionistTextBox.Size = new Size(113, 23);
            ReceptionistTextBox.TabIndex = 4;
            ReceptionistTextBox.TextChanged += ReceptionistTextBox_TextChanged;
            // 
            // DoctorTextBox
            // 
            DoctorTextBox.BackColor = Color.LightPink;
            DoctorTextBox.Dock = DockStyle.Fill;
            DoctorTextBox.ForeColor = Color.Black;
            DoctorTextBox.Location = new Point(582, 57);
            DoctorTextBox.Name = "DoctorTextBox";
            DoctorTextBox.PlaceholderText = "Doctor Name";
            DoctorTextBox.Size = new Size(113, 23);
            DoctorTextBox.TabIndex = 4;
            DoctorTextBox.TextChanged += DoctorTextBox_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 17;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.084164F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4208326F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.75069976F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4208355F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.78571415F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4208326F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.78571415F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4208355F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.78571415F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4208355F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.78571415F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4208355F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.78571415F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4208355F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.78571415F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10.4208393F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.08416653F));
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(appointmentData, 0, 7);
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 1, 5);
            tableLayoutPanel1.Controls.Add(createButton, 15, 5);
            tableLayoutPanel1.Controls.Add(cancelButton, 13, 3);
            tableLayoutPanel1.Controls.Add(backButton, 15, 3);
            tableLayoutPanel1.Controls.Add(saveButton, 13, 5);
            tableLayoutPanel1.Controls.Add(ReceptionistTextBox, 11, 3);
            tableLayoutPanel1.Controls.Add(editButton, 11, 5);
            tableLayoutPanel1.Controls.Add(PatientTextBox, 9, 3);
            tableLayoutPanel1.Controls.Add(DoctorTextBox, 9, 5);
            tableLayoutPanel1.Controls.Add(AppointmentStatusComboBox, 7, 3);
            tableLayoutPanel1.Controls.Add(AppointmentDateTimePicker, 7, 5);
            tableLayoutPanel1.Controls.Add(label3, 5, 3);
            tableLayoutPanel1.Controls.Add(label4, 5, 5);
            tableLayoutPanel1.Controls.Add(pageSize, 3, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 3);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.8758125F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.0594703F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.875812352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.006499F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.875812352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.006499F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.875812352F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.54847F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.875812352F));
            tableLayoutPanel1.Size = new Size(1151, 536);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            button1.BackColor = Color.Pink;
            button1.Dock = DockStyle.Fill;
            button1.Enabled = false;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(17, 1);
            button1.TabIndex = 13;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = false;
            button1.Visible = false;
            // 
            // appointmentData
            // 
            appointmentData.AllowUserToAddRows = false;
            appointmentData.AllowUserToDeleteRows = false;
            appointmentData.BackgroundColor = Color.DarkGray;
            appointmentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(appointmentData, 17);
            appointmentData.Dock = DockStyle.Fill;
            appointmentData.GridColor = SystemColors.WindowText;
            appointmentData.Location = new Point(3, 98);
            appointmentData.MultiSelect = false;
            appointmentData.Name = "appointmentData";
            appointmentData.ReadOnly = true;
            appointmentData.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(appointmentData, 2);
            appointmentData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            appointmentData.Size = new Size(1145, 435);
            appointmentData.TabIndex = 0;
            appointmentData.CellClick += appointmentData_CellClick;
            appointmentData.CellContentClick += appointmentData_CellContentClick_1;
            appointmentData.CellMouseEnter += appointmentData_CellMouseEnter;
            appointmentData.CellMouseLeave += appointmentData_CellMouseLeave;
            appointmentData.CurrentCellChanged += AppointmentData_CurrentCellChanged;
            appointmentData.SelectionChanged += AppointmentData_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(26, 13);
            label1.Name = "label1";
            label1.Size = new Size(113, 37);
            label1.TabIndex = 8;
            label1.Text = "Page Number";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(26, 54);
            label2.Name = "label2";
            label2.Size = new Size(113, 37);
            label2.TabIndex = 8;
            label2.Text = "Page Size";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pageSize
            // 
            pageSize.BackColor = Color.MistyRose;
            pageSize.Dock = DockStyle.Fill;
            pageSize.Location = new Point(165, 57);
            pageSize.Name = "pageSize";
            pageSize.PlaceholderText = "20";
            pageSize.Size = new Size(113, 23);
            pageSize.TabIndex = 4;
            pageSize.TextChanged += PageSize_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Controls.Add(pageNumber, 1, 0);
            tableLayoutPanel2.Controls.Add(leftArrowButton1, 0, 0);
            tableLayoutPanel2.Controls.Add(rightArrowButton1, 2, 0);
            tableLayoutPanel2.Location = new Point(165, 16);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(113, 31);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // pageNumber
            // 
            pageNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pageNumber.BackColor = Color.MistyRose;
            pageNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pageNumber.Location = new Point(25, 3);
            pageNumber.Name = "pageNumber";
            pageNumber.PlaceholderText = "1";
            pageNumber.ReadOnly = true;
            pageNumber.Size = new Size(61, 27);
            pageNumber.TabIndex = 4;
            pageNumber.TextAlign = HorizontalAlignment.Center;
            pageNumber.TextChanged += PageNumber_TextChanged;
            // 
            // leftArrowButton1
            // 
            leftArrowButton1.ArrowColor = Color.Black;
            leftArrowButton1.BackColor = Color.Beige;
            leftArrowButton1.Location = new Point(3, 3);
            leftArrowButton1.Name = "leftArrowButton1";
            leftArrowButton1.Size = new Size(16, 25);
            leftArrowButton1.TabIndex = 5;
            leftArrowButton1.Text = "leftArrowButton1";
            leftArrowButton1.Click += leftArrowButton1_Click;
            // 
            // rightArrowButton1
            // 
            rightArrowButton1.ArrowColor = Color.Black;
            rightArrowButton1.BackColor = Color.Beige;
            rightArrowButton1.Location = new Point(92, 3);
            rightArrowButton1.Name = "rightArrowButton1";
            rightArrowButton1.Size = new Size(18, 25);
            rightArrowButton1.TabIndex = 6;
            rightArrowButton1.Text = "rightArrowButton1";
            rightArrowButton1.Click += rightArrowButton1_Click;
            // 
            // Appointment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gray;
            ClientSize = new Size(1151, 536);
            Controls.Add(tableLayoutPanel1);
            Name = "Appointment";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Appointment";
            Load += Appointment_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)appointmentData).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox AppointmentStatusComboBox;
        private DateTimePicker AppointmentDateTimePicker;
        private TextBox PatientTextBox;
        private Label label3;
        private Label label4;
        private TextBox ReceptionistTextBox;
        private TextBox DoctorTextBox;
        private Button editButton;
        private Button saveButton;
        private Button cancelButton;
        private Button createButton;
        private Button backButton;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox pageNumber;
        private TextBox pageSize;
        private DataGridView appointmentData;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControls.LeftArrowButton leftArrowButton1;
        private CustomControls.RightArrowButton rightArrowButton1;
        private Button button1;
    }
}