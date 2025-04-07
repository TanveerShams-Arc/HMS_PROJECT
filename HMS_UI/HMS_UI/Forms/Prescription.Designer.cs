namespace HMS_UI.Forms
{
    partial class Prescription
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
            PrescriptionData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            PageNumberTextBox = new TextBox();
            PageSizeTextBox = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label8 = new Label();
            label10 = new Label();
            label13 = new Label();
            textBox7 = new TextBox();
            textBox9 = new TextBox();
            CreateButton = new Button();
            BackButton = new Button();
            CancelButton = new Button();
            EditButton = new Button();
            SaveButton = new Button();
            ((System.ComponentModel.ISupportInitialize)PrescriptionData).BeginInit();
            SuspendLayout();
            // 
            // PrescriptionData
            // 
            PrescriptionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PrescriptionData.Location = new Point(10, 131);
            PrescriptionData.Margin = new Padding(3, 2, 3, 2);
            PrescriptionData.Name = "PrescriptionData";
            PrescriptionData.RowHeadersWidth = 51;
            PrescriptionData.Size = new Size(872, 368);
            PrescriptionData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(89, 17);
            label1.TabIndex = 9;
            label1.Text = "Page Number";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.ForeColor = SystemColors.Window;
            label2.Location = new Point(22, 51);
            label2.Name = "label2";
            label2.Size = new Size(65, 17);
            label2.TabIndex = 10;
            label2.Text = "Page Size";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PageNumberTextBox
            // 
            PageNumberTextBox.Location = new Point(168, 19);
            PageNumberTextBox.Margin = new Padding(3, 2, 3, 2);
            PageNumberTextBox.Name = "PageNumberTextBox";
            PageNumberTextBox.Size = new Size(121, 23);
            PageNumberTextBox.TabIndex = 11;
            // 
            // PageSizeTextBox
            // 
            PageSizeTextBox.Location = new Point(168, 50);
            PageSizeTextBox.Margin = new Padding(3, 2, 3, 2);
            PageSizeTextBox.Name = "PageSizeTextBox";
            PageSizeTextBox.Size = new Size(121, 23);
            PageSizeTextBox.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(168, 89);
            dateTimePicker1.Margin = new Padding(3, 2, 3, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(121, 23);
            dateTimePicker1.TabIndex = 14;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label8.ForeColor = SystemColors.Window;
            label8.Location = new Point(363, 23);
            label8.Name = "label8";
            label8.Size = new Size(86, 17);
            label8.TabIndex = 16;
            label8.Text = "patientName";
            label8.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label10.ForeColor = SystemColors.Window;
            label10.Location = new Point(369, 56);
            label10.Name = "label10";
            label10.Size = new Size(80, 17);
            label10.TabIndex = 16;
            label10.Text = "doctorName";
            label10.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label13.ForeColor = SystemColors.Window;
            label13.Location = new Point(25, 89);
            label13.Name = "label13";
            label13.Size = new Size(86, 17);
            label13.TabIndex = 16;
            label13.Text = "prescribedOn";
            label13.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(467, 22);
            textBox7.Margin = new Padding(3, 2, 3, 2);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(123, 23);
            textBox7.TabIndex = 17;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(467, 56);
            textBox9.Margin = new Padding(3, 2, 3, 2);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(123, 23);
            textBox9.TabIndex = 17;
            // 
            // CreateButton
            // 
            CreateButton.Location = new Point(759, 19);
            CreateButton.Margin = new Padding(3, 2, 3, 2);
            CreateButton.Name = "CreateButton";
            CreateButton.Size = new Size(123, 26);
            CreateButton.TabIndex = 18;
            CreateButton.Text = "Create";
            CreateButton.UseVisualStyleBackColor = true;
            // 
            // BackButton
            // 
            BackButton.Location = new Point(759, 56);
            BackButton.Margin = new Padding(3, 2, 3, 2);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(123, 23);
            BackButton.TabIndex = 18;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            CancelButton.Location = new Point(620, 19);
            CancelButton.Margin = new Padding(3, 2, 3, 2);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(123, 26);
            CancelButton.TabIndex = 18;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = true;
            CancelButton.Click += button3_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(467, 89);
            EditButton.Margin = new Padding(3, 2, 3, 2);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(123, 23);
            EditButton.TabIndex = 18;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(620, 53);
            SaveButton.Margin = new Padding(3, 2, 3, 2);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(123, 26);
            SaveButton.TabIndex = 18;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            // 
            // Prescription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(889, 508);
            Controls.Add(EditButton);
            Controls.Add(SaveButton);
            Controls.Add(CancelButton);
            Controls.Add(BackButton);
            Controls.Add(CreateButton);
            Controls.Add(textBox7);
            Controls.Add(textBox9);
            Controls.Add(label13);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(dateTimePicker1);
            Controls.Add(PageSizeTextBox);
            Controls.Add(PageNumberTextBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PrescriptionData);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Prescription";
            Text = "Prescription";
            Load += Prescription_Load;
            ((System.ComponentModel.ISupportInitialize)PrescriptionData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView PrescriptionData;
        private Label label1;
        private Label label2;
        private TextBox PageNumberTextBox;
        private TextBox PageSizeTextBox;
        private DateTimePicker dateTimePicker1;
        private Label label8;
        private Label label10;
        private Label label13;
        private TextBox textBox7;
        private TextBox textBox9;
        private Button CreateButton;
        private Button BackButton;
        private Button CancelButton;
        private Button EditButton;
        private Button SaveButton;
    }
}