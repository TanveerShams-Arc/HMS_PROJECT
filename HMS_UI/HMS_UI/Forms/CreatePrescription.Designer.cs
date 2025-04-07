namespace HMS_UI.Forms
{
    partial class CreatePrescription
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
            label6 = new Label();
            PatientTextBox = new TextBox();
            DoctorTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            patientData = new DataGridView();
            doctorData = new DataGridView();
            AddPatientBtn = new Button();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            cancelButton = new Button();
            createButton = new Button();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)patientData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)doctorData).BeginInit();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightCyan;
            label6.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 19);
            label6.Name = "label6";
            label6.Size = new Size(298, 37);
            label6.TabIndex = 10;
            label6.Text = "Create A Prescription";
            // 
            // PatientTextBox
            // 
            PatientTextBox.BackColor = Color.Thistle;
            PatientTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PatientTextBox.Location = new Point(97, 99);
            PatientTextBox.Margin = new Padding(3, 4, 3, 4);
            PatientTextBox.Name = "PatientTextBox";
            PatientTextBox.Size = new Size(145, 34);
            PatientTextBox.TabIndex = 11;
            // 
            // DoctorTextBox
            // 
            DoctorTextBox.BackColor = Color.Bisque;
            DoctorTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            DoctorTextBox.Location = new Point(97, 274);
            DoctorTextBox.Margin = new Padding(3, 4, 3, 4);
            DoctorTextBox.Name = "DoctorTextBox";
            DoctorTextBox.Size = new Size(145, 34);
            DoctorTextBox.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(3, 105);
            label1.Name = "label1";
            label1.Size = new Size(75, 28);
            label1.TabIndex = 13;
            label1.Text = "Patient";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(5, 274);
            label2.Name = "label2";
            label2.Size = new Size(73, 28);
            label2.TabIndex = 14;
            label2.Text = "Doctor";
            // 
            // patientData
            // 
            patientData.AllowUserToAddRows = false;
            patientData.AllowUserToDeleteRows = false;
            patientData.BackgroundColor = Color.PowderBlue;
            patientData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            patientData.Location = new Point(3, 137);
            patientData.Margin = new Padding(3, 4, 3, 4);
            patientData.MultiSelect = false;
            patientData.Name = "patientData";
            patientData.ReadOnly = true;
            patientData.RowHeadersWidth = 51;
            patientData.Size = new Size(774, 123);
            patientData.TabIndex = 15;
            // 
            // doctorData
            // 
            doctorData.AllowUserToAddRows = false;
            doctorData.AllowUserToDeleteRows = false;
            doctorData.BackgroundColor = Color.LightBlue;
            doctorData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            doctorData.Location = new Point(3, 316);
            doctorData.Margin = new Padding(3, 4, 3, 4);
            doctorData.MultiSelect = false;
            doctorData.Name = "doctorData";
            doctorData.ReadOnly = true;
            doctorData.RowHeadersWidth = 51;
            doctorData.Size = new Size(774, 132);
            doctorData.TabIndex = 16;
            // 
            // AddPatientBtn
            // 
            AddPatientBtn.BackColor = Color.Turquoise;
            AddPatientBtn.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            AddPatientBtn.Location = new Point(786, 158);
            AddPatientBtn.Margin = new Padding(3, 4, 3, 4);
            AddPatientBtn.Name = "AddPatientBtn";
            AddPatientBtn.Size = new Size(143, 75);
            AddPatientBtn.TabIndex = 17;
            AddPatientBtn.Text = "Add A New Patient";
            AddPatientBtn.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Turquoise;
            button1.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            button1.Location = new Point(786, 335);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(143, 75);
            button1.TabIndex = 17;
            button1.Text = "Add A New Patient";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(639, 19);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(504, 17);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 19;
            label3.Text = "PrescriveOn";
            label3.Click += label3_Click;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.Crimson;
            cancelButton.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            cancelButton.Location = new Point(154, 456);
            cancelButton.Margin = new Padding(3, 4, 3, 4);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(102, 39);
            cancelButton.TabIndex = 20;
            cancelButton.Text = "Cancel";
            cancelButton.UseVisualStyleBackColor = false;
            // 
            // createButton
            // 
            createButton.BackColor = Color.DeepSkyBlue;
            createButton.Font = new Font("Segoe UI Black", 12.75F, FontStyle.Bold);
            createButton.Location = new Point(504, 456);
            createButton.Margin = new Padding(3, 4, 3, 4);
            createButton.Name = "createButton";
            createButton.Size = new Size(102, 39);
            createButton.TabIndex = 21;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Teal;
            label4.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 555);
            label4.Name = "label4";
            label4.Size = new Size(229, 37);
            label4.TabIndex = 22;
            label4.Text = "medicineDetails";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.MediumSpringGreen;
            label5.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 619);
            label5.Name = "label5";
            label5.Size = new Size(89, 37);
            label5.TabIndex = 23;
            label5.Text = "notes";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Highlight;
            textBox1.Location = new Point(254, 565);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 24;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.HotTrack;
            textBox2.Location = new Point(134, 629);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(235, 27);
            textBox2.TabIndex = 24;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // CreatePrescription
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(941, 704);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(createButton);
            Controls.Add(cancelButton);
            Controls.Add(label3);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(AddPatientBtn);
            Controls.Add(doctorData);
            Controls.Add(patientData);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(DoctorTextBox);
            Controls.Add(PatientTextBox);
            Controls.Add(label6);
            Name = "CreatePrescription";
            Text = "CreatePrescription";
            ((System.ComponentModel.ISupportInitialize)patientData).EndInit();
            ((System.ComponentModel.ISupportInitialize)doctorData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private TextBox PatientTextBox;
        private TextBox DoctorTextBox;
        private Label label1;
        private Label label2;
        private DataGridView patientData;
        private DataGridView doctorData;
        private Button AddPatientBtn;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private Button cancelButton;
        private Button createButton;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}