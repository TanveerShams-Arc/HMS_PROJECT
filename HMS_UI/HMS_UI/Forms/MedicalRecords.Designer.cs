namespace HMS_UI
{
    partial class MedicalRecords
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
            recordData = new DataGridView();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label6 = new Label();
            label2 = new Label();
            label1 = new Label();
            PatientNameTextBox = new TextBox();
            AddButton = new Button();
            PageSizeTextBox = new TextBox();
            pageNumberTextBox = new TextBox();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            recordComboBox = new ComboBox();
            label3 = new Label();
            recordDate = new DateTimePicker();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)recordData).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // recordData
            // 
            recordData.AllowUserToAddRows = false;
            recordData.AllowUserToDeleteRows = false;
            recordData.BackgroundColor = Color.LightSteelBlue;
            recordData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            recordData.Dock = DockStyle.Fill;
            recordData.Location = new Point(3, 133);
            recordData.MultiSelect = false;
            recordData.Name = "recordData";
            recordData.ReadOnly = true;
            recordData.RowHeadersWidth = 51;
            recordData.Size = new Size(794, 314);
            recordData.TabIndex = 10;
            recordData.CellClick += recordData_CellClick;
            recordData.CellContentClick += recordData_CellContentClick;
            recordData.CellMouseEnter += recordData_CellMouseEnter;
            recordData.CellMouseLeave += recordData_CellMouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(recordData, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 28.9863911F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 71.0136F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0100231F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0100231F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.71090233F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0100231F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.02206516F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0100231F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.5060244F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.0100231F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.71090186F));
            tableLayoutPanel2.Controls.Add(label6, 5, 4);
            tableLayoutPanel2.Controls.Add(label2, 0, 4);
            tableLayoutPanel2.Controls.Add(label1, 0, 3);
            tableLayoutPanel2.Controls.Add(PatientNameTextBox, 3, 4);
            tableLayoutPanel2.Controls.Add(AddButton, 7, 3);
            tableLayoutPanel2.Controls.Add(PageSizeTextBox, 1, 4);
            tableLayoutPanel2.Controls.Add(pageNumberTextBox, 1, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 3, 3);
            tableLayoutPanel2.Controls.Add(recordDate, 7, 4);
            tableLayoutPanel2.Controls.Add(BackButton, 7, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.1916428F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 1.67500532F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7500534F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.1916485F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.1916485F));
            tableLayoutPanel2.Size = new Size(794, 124);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Right;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(523, 88);
            label6.Name = "label6";
            label6.Size = new Size(95, 36);
            label6.TabIndex = 18;
            label6.Text = "Date of Report";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Size = new Size(144, 36);
            label2.TabIndex = 16;
            label2.Text = "Page Size";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(3, 55);
            label1.Name = "label1";
            label1.Size = new Size(144, 33);
            label1.TabIndex = 13;
            label1.Text = "Page Number";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PatientNameTextBox
            // 
            PatientNameTextBox.BackColor = Color.LavenderBlush;
            PatientNameTextBox.Dock = DockStyle.Fill;
            PatientNameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PatientNameTextBox.Location = new Point(316, 91);
            PatientNameTextBox.Name = "PatientNameTextBox";
            PatientNameTextBox.PlaceholderText = "Patient Name";
            PatientNameTextBox.Size = new Size(144, 29);
            PatientNameTextBox.TabIndex = 10;
            PatientNameTextBox.TextChanged += PatientNameTextBox_TextChanged;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.BackColor = Color.PaleTurquoise;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(628, 58);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(144, 27);
            AddButton.TabIndex = 19;
            AddButton.Text = "Add Report";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // PageSizeTextBox
            // 
            PageSizeTextBox.BackColor = Color.PowderBlue;
            PageSizeTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PageSizeTextBox.Location = new Point(153, 91);
            PageSizeTextBox.Name = "PageSizeTextBox";
            PageSizeTextBox.PlaceholderText = "20";
            PageSizeTextBox.Size = new Size(143, 29);
            PageSizeTextBox.TabIndex = 21;
            PageSizeTextBox.TextChanged += PageSizeTextBox_TextChanged;
            // 
            // pageNumberTextBox
            // 
            pageNumberTextBox.BackColor = Color.Bisque;
            pageNumberTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            pageNumberTextBox.Location = new Point(153, 58);
            pageNumberTextBox.Name = "pageNumberTextBox";
            pageNumberTextBox.PlaceholderText = "1";
            pageNumberTextBox.Size = new Size(143, 29);
            pageNumberTextBox.TabIndex = 21;
            pageNumberTextBox.TextChanged += pageNumberTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Thistle;
            tableLayoutPanel2.SetColumnSpan(label4, 5);
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(267, 30);
            label4.TabIndex = 22;
            label4.Text = "Manage Medical Records";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(recordComboBox, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(316, 58);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(302, 27);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // recordComboBox
            // 
            recordComboBox.BackColor = Color.PaleGreen;
            recordComboBox.Dock = DockStyle.Fill;
            recordComboBox.FormattingEnabled = true;
            recordComboBox.Location = new Point(154, 3);
            recordComboBox.Name = "recordComboBox";
            recordComboBox.Size = new Size(145, 23);
            recordComboBox.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(69, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 27);
            label3.TabIndex = 18;
            label3.Text = "Report Type";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // recordDate
            // 
            recordDate.Checked = false;
            recordDate.Dock = DockStyle.Fill;
            recordDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            recordDate.Format = DateTimePickerFormat.Short;
            recordDate.Location = new Point(628, 91);
            recordDate.Name = "recordDate";
            recordDate.ShowCheckBox = true;
            recordDate.Size = new Size(144, 29);
            recordDate.TabIndex = 25;
            recordDate.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.BackColor = Color.PaleTurquoise;
            BackButton.Dock = DockStyle.Fill;
            BackButton.Location = new Point(628, 3);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(144, 27);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // MedicalRecords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumAquamarine;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "MedicalRecords";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MedicalRecords";
            Load += MedicalRecords_Load;
            ((System.ComponentModel.ISupportInitialize)recordData).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView recordData;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label2;
        private Label label1;
        private TextBox PatientNameTextBox;
        private Button AddButton;
        private TextBox PageSizeTextBox;
        private TextBox pageNumberTextBox;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox recordComboBox;
        private Label label3;
        private Label label6;
        private DateTimePicker recordDate;
        private Button BackButton;
    }
}