namespace HMS_UI
{
    partial class Doctors
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            doctorData = new DataGridView();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            DoctorExpTextBox = new TextBox();
            DoctorNameTextBox = new TextBox();
            BackButton = new Button();
            pageNumberTextBox = new TextBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            SpecializationComboBox = new ComboBox();
            label3 = new Label();
            PageSizeTextBox = new TextBox();
            label4 = new Label();
            button1 = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)doctorData).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(doctorData, 0, 1);
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
            // doctorData
            // 
            doctorData.AllowUserToAddRows = false;
            doctorData.AllowUserToDeleteRows = false;
            doctorData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorData.Dock = DockStyle.Fill;
            doctorData.Location = new Point(3, 133);
            doctorData.MultiSelect = false;
            doctorData.Name = "doctorData";
            doctorData.ReadOnly = true;
            doctorData.RowHeadersWidth = 51;
            doctorData.Size = new Size(794, 314);
            doctorData.TabIndex = 10;
            doctorData.CellClick += doctorData_CellClick;
            doctorData.CellMouseEnter += doctorData_CellMouseEnter;
            doctorData.CellMouseLeave += doctorData_CellMouseLeave;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 9;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7837F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7837F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.69053352F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7837F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.00989711F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7837F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.69053316F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7837F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.69053316F));
            tableLayoutPanel2.Controls.Add(label2, 0, 4);
            tableLayoutPanel2.Controls.Add(label1, 0, 3);
            tableLayoutPanel2.Controls.Add(DoctorExpTextBox, 5, 4);
            tableLayoutPanel2.Controls.Add(DoctorNameTextBox, 3, 4);
            tableLayoutPanel2.Controls.Add(BackButton, 7, 3);
            tableLayoutPanel2.Controls.Add(pageNumberTextBox, 1, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 3, 3);
            tableLayoutPanel2.Controls.Add(PageSizeTextBox, 1, 4);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(button1, 7, 4);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.1916466F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 1.67500556F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 16.7500553F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.19165F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 27.19165F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(794, 124);
            tableLayoutPanel2.TabIndex = 11;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(3, 88);
            label2.Name = "label2";
            label2.Size = new Size(143, 36);
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
            label1.Size = new Size(143, 33);
            label1.TabIndex = 13;
            label1.Text = "Page Number";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // DoctorExpTextBox
            // 
            DoctorExpTextBox.BackColor = Color.Lavender;
            DoctorExpTextBox.Dock = DockStyle.Fill;
            DoctorExpTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            DoctorExpTextBox.Location = new Point(471, 91);
            DoctorExpTextBox.Name = "DoctorExpTextBox";
            DoctorExpTextBox.PlaceholderText = "Experience";
            DoctorExpTextBox.Size = new Size(143, 29);
            DoctorExpTextBox.TabIndex = 10;
            DoctorExpTextBox.TextChanged += DoctorExpTextBox_TextChanged;
            // 
            // DoctorNameTextBox
            // 
            DoctorNameTextBox.BackColor = Color.NavajoWhite;
            DoctorNameTextBox.Dock = DockStyle.Fill;
            DoctorNameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            DoctorNameTextBox.Location = new Point(314, 91);
            DoctorNameTextBox.Name = "DoctorNameTextBox";
            DoctorNameTextBox.PlaceholderText = "Name";
            DoctorNameTextBox.Size = new Size(143, 29);
            DoctorNameTextBox.TabIndex = 10;
            DoctorNameTextBox.TextChanged += DoctorNameTextBox_TextChanged;
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.BackColor = Color.BlanchedAlmond;
            BackButton.Dock = DockStyle.Fill;
            BackButton.Location = new Point(633, 58);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(143, 27);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // pageNumberTextBox
            // 
            pageNumberTextBox.BackColor = Color.Bisque;
            pageNumberTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            pageNumberTextBox.Location = new Point(152, 58);
            pageNumberTextBox.Name = "pageNumberTextBox";
            pageNumberTextBox.PlaceholderText = "1";
            pageNumberTextBox.Size = new Size(143, 29);
            pageNumberTextBox.TabIndex = 21;
            pageNumberTextBox.TextChanged += pageNumberTextBox_TextChanged;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(SpecializationComboBox, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Location = new Point(314, 58);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(300, 27);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // SpecializationComboBox
            // 
            SpecializationComboBox.BackColor = Color.PaleGoldenrod;
            SpecializationComboBox.FormattingEnabled = true;
            SpecializationComboBox.Location = new Point(153, 3);
            SpecializationComboBox.Name = "SpecializationComboBox";
            SpecializationComboBox.Size = new Size(143, 23);
            SpecializationComboBox.TabIndex = 20;
            SpecializationComboBox.SelectedIndexChanged += SpecializationComboBox_SelectedIndexChanged;
            SpecializationComboBox.TextChanged += SpecializationComboBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Right;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(56, 0);
            label3.Name = "label3";
            label3.Size = new Size(91, 27);
            label3.TabIndex = 18;
            label3.Text = "Specialization";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // PageSizeTextBox
            // 
            PageSizeTextBox.BackColor = Color.MistyRose;
            PageSizeTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PageSizeTextBox.Location = new Point(152, 91);
            PageSizeTextBox.Name = "PageSizeTextBox";
            PageSizeTextBox.PlaceholderText = "20";
            PageSizeTextBox.Size = new Size(143, 29);
            PageSizeTextBox.TabIndex = 21;
            PageSizeTextBox.TextChanged += PageSizeTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.OldLace;
            tableLayoutPanel2.SetColumnSpan(label4, 8);
            label4.Font = new Font("Palatino Linotype", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(222, 33);
            label4.TabIndex = 22;
            label4.Text = "Manage Doctors";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.BlanchedAlmond;
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(633, 91);
            button1.Name = "button1";
            button1.Size = new Size(143, 30);
            button1.TabIndex = 19;
            button1.Text = "Add Doctor";
            button1.UseVisualStyleBackColor = false;
            button1.Click += AddButton_Click;
            // 
            // Doctors
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PowderBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Doctors";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Doctors";
            Load += Doctors_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)doctorData).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView doctorData;
        private TableLayoutPanel tableLayoutPanel2;
        private TextBox DoctorNameTextBox;
        private Label label1;
        private Label label2;
        private TextBox DoctorExpTextBox;
        private Label label3;
        private Button BackButton;
        private ComboBox SpecializationComboBox;
        private TextBox PageSizeTextBox;
        private Label label4;
        private TextBox pageNumberTextBox;
        private TableLayoutPanel tableLayoutPanel3;
        private Button button1;
    }
}