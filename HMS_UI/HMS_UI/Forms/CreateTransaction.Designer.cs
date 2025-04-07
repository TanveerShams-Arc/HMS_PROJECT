namespace HMS_UI.Forms
{
    partial class CreateTransaction
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
            createButton = new Button();
            label6 = new Label();
            statusComboBox = new ComboBox();
            patientData = new DataGridView();
            TransactDateTimePicker = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            PatientTextBox = new TextBox();
            bindingSource = new BindingSource(components);
            patientPageDown = new HMS_UI.CustomControls.LeftArrowButton();
            PatientPageUp = new HMS_UI.CustomControls.RightArrowButton();
            cancelButton = new Button();
            AddPatientBtn = new Button();
            label8 = new Label();
            label7 = new Label();
            PaidTextBox = new TextBox();
            AmountTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)patientData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // createButton
            // 
            createButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            createButton.BackColor = Color.DeepSkyBlue;
            createButton.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            createButton.Location = new Point(649, 390);
            createButton.Name = "createButton";
            createButton.Size = new Size(205, 39);
            createButton.TabIndex = 60;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCyan;
            tableLayoutPanel1.SetColumnSpan(label6, 2);
            label6.Dock = DockStyle.Left;
            label6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 37);
            label6.Name = "label6";
            label6.Size = new Size(206, 36);
            label6.TabIndex = 56;
            label6.Text = "Create Transaction";
            // 
            // statusComboBox
            // 
            statusComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            statusComboBox.BackColor = Color.LightGoldenrodYellow;
            statusComboBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            statusComboBox.FormattingEnabled = true;
            statusComboBox.Location = new Point(649, 268);
            statusComboBox.Name = "statusComboBox";
            statusComboBox.Size = new Size(205, 29);
            statusComboBox.TabIndex = 55;
            // 
            // patientData
            // 
            patientData.AllowUserToAddRows = false;
            patientData.AllowUserToDeleteRows = false;
            patientData.BackgroundColor = Color.PowderBlue;
            patientData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(patientData, 2);
            patientData.Dock = DockStyle.Fill;
            patientData.Location = new Point(3, 150);
            patientData.MultiSelect = false;
            patientData.Name = "patientData";
            patientData.ReadOnly = true;
            patientData.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(patientData, 6);
            patientData.Size = new Size(464, 203);
            patientData.TabIndex = 53;
            // 
            // TransactDateTimePicker
            // 
            TransactDateTimePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            TransactDateTimePicker.CalendarFont = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TransactDateTimePicker.Checked = false;
            TransactDateTimePicker.CustomFormat = "yyyy-MM-dd HH:mm";
            TransactDateTimePicker.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TransactDateTimePicker.Format = DateTimePickerFormat.Custom;
            TransactDateTimePicker.Location = new Point(649, 321);
            TransactDateTimePicker.Name = "TransactDateTimePicker";
            TransactDateTimePicker.ShowCheckBox = true;
            TransactDateTimePicker.Size = new Size(205, 27);
            TransactDateTimePicker.TabIndex = 52;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label4.Location = new Point(480, 270);
            label4.Name = "label4";
            label4.Size = new Size(163, 25);
            label4.TabIndex = 47;
            label4.Text = "Status";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label3.Location = new Point(480, 322);
            label3.Name = "label3";
            label3.Size = new Size(163, 25);
            label3.TabIndex = 48;
            label3.Text = "Date";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Black", 14F, FontStyle.Bold);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(96, 32);
            label1.TabIndex = 40;
            label1.Text = "Patient";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PatientTextBox
            // 
            PatientTextBox.BackColor = Color.Thistle;
            PatientTextBox.Dock = DockStyle.Fill;
            PatientTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PatientTextBox.Location = new Point(105, 3);
            PatientTextBox.Name = "PatientTextBox";
            PatientTextBox.Size = new Size(356, 29);
            PatientTextBox.TabIndex = 39;
            PatientTextBox.TextChanged += PatientTextBox_TextChanged;
            // 
            // patientPageDown
            // 
            patientPageDown.ArrowColor = SystemColors.Control;
            patientPageDown.BackColor = SystemColors.ControlDark;
            patientPageDown.Dock = DockStyle.Fill;
            patientPageDown.Location = new Point(3, 3);
            patientPageDown.Name = "patientPageDown";
            patientPageDown.Size = new Size(44, 33);
            patientPageDown.TabIndex = 63;
            patientPageDown.Text = "LeftButton";
            patientPageDown.Click += patientPageDown_Click;
            // 
            // PatientPageUp
            // 
            PatientPageUp.ArrowColor = SystemColors.Control;
            PatientPageUp.BackColor = SystemColors.ControlDark;
            PatientPageUp.Dock = DockStyle.Fill;
            PatientPageUp.Font = new Font("Segoe UI", 9F);
            PatientPageUp.Location = new Point(423, 3);
            PatientPageUp.Name = "PatientPageUp";
            PatientPageUp.Size = new Size(38, 33);
            PatientPageUp.TabIndex = 62;
            PatientPageUp.Text = "RightButton";
            PatientPageUp.Click += PatientPageUp_Click;
            // 
            // cancelButton
            // 
            cancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cancelButton.BackColor = Color.PaleTurquoise;
            cancelButton.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            cancelButton.Location = new Point(480, 390);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(163, 39);
            cancelButton.TabIndex = 59;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += cancelButton_Click;
            // 
            // AddPatientBtn
            // 
            AddPatientBtn.BackColor = Color.Turquoise;
            AddPatientBtn.Dock = DockStyle.Fill;
            AddPatientBtn.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            AddPatientBtn.Location = new Point(53, 3);
            AddPatientBtn.Name = "AddPatientBtn";
            AddPatientBtn.Size = new Size(364, 33);
            AddPatientBtn.TabIndex = 57;
            AddPatientBtn.Text = "Add A New Patient";
            AddPatientBtn.UseVisualStyleBackColor = false;
            AddPatientBtn.Click += AddPatientBtn_Click_1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label8.Location = new Point(480, 221);
            label8.Name = "label8";
            label8.Size = new Size(163, 25);
            label8.TabIndex = 49;
            label8.Text = "Amount Paid:";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold);
            label7.Location = new Point(480, 169);
            label7.Name = "label7";
            label7.Size = new Size(163, 25);
            label7.TabIndex = 51;
            label7.Text = "Total Amount:";
            label7.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PaidTextBox
            // 
            PaidTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PaidTextBox.BackColor = Color.Beige;
            PaidTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PaidTextBox.Location = new Point(649, 219);
            PaidTextBox.Name = "PaidTextBox";
            PaidTextBox.Size = new Size(205, 29);
            PaidTextBox.TabIndex = 43;
            // 
            // AmountTextBox
            // 
            AmountTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            AmountTextBox.BackColor = Color.OldLace;
            AmountTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            AmountTextBox.Location = new Point(649, 167);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.Size = new Size(205, 29);
            AmountTextBox.TabIndex = 41;
            AmountTextBox.TextChanged += AmountTextBox_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.9267311F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.12252F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.8756867F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.83664F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.5040836F));
            tableLayoutPanel1.Controls.Add(label6, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 3);
            tableLayoutPanel1.Controls.Add(patientData, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 12);
            tableLayoutPanel1.Controls.Add(cancelButton, 3, 12);
            tableLayoutPanel1.Controls.Add(TransactDateTimePicker, 4, 10);
            tableLayoutPanel1.Controls.Add(label3, 3, 10);
            tableLayoutPanel1.Controls.Add(statusComboBox, 4, 8);
            tableLayoutPanel1.Controls.Add(label8, 3, 6);
            tableLayoutPanel1.Controls.Add(PaidTextBox, 4, 6);
            tableLayoutPanel1.Controls.Add(label7, 3, 5);
            tableLayoutPanel1.Controls.Add(AmountTextBox, 4, 5);
            tableLayoutPanel1.Controls.Add(createButton, 4, 12);
            tableLayoutPanel1.Controls.Add(label4, 3, 8);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 14;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.63507462F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.42872F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 3.50800681F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.90496F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.85718F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.2383814F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.42872F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.66320169F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.35551F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 1.66320169F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.939709F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.444906F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.7609148F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.39945364F));
            tableLayoutPanel1.Size = new Size(857, 481);
            tableLayoutPanel1.TabIndex = 64;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel2, 2);
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(PatientTextBox, 1, 0);
            tableLayoutPanel2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel2.Location = new Point(3, 93);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(464, 32);
            tableLayoutPanel2.TabIndex = 64;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel3.ColumnCount = 3;
            tableLayoutPanel1.SetColumnSpan(tableLayoutPanel3, 2);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12.0967741F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 87.90323F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 43F));
            tableLayoutPanel3.Controls.Add(PatientPageUp, 2, 0);
            tableLayoutPanel3.Controls.Add(patientPageDown, 0, 0);
            tableLayoutPanel3.Controls.Add(AddPatientBtn, 1, 0);
            tableLayoutPanel3.Location = new Point(3, 390);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel3.Size = new Size(464, 39);
            tableLayoutPanel3.TabIndex = 65;
            // 
            // CreateTransaction
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(857, 481);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "CreateTransaction";
            Text = "CreateTransaction";
            Load += CreateTransaction_Load;
            ((System.ComponentModel.ISupportInitialize)patientData).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button createButton;
        private Label label6;
        private ComboBox statusComboBox;
        private DataGridView patientData;
        private DateTimePicker TransactDateTimePicker;
        private Label label4;
        private Label label3;
        private Label label1;
        private TextBox PatientTextBox;
        private BindingSource bindingSource;
        private CustomControls.LeftArrowButton patientPageDown;
        private CustomControls.RightArrowButton PatientPageUp;
        private Button cancelButton;
        private Button AddPatientBtn;
        private Label label8;
        private Label label7;
        private TextBox PaidTextBox;
        private TextBox AmountTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}