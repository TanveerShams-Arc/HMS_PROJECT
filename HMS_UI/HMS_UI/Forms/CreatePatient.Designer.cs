namespace HMS_UI
{
    partial class CreatePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePatient));
            tableLayoutPanel1 = new TableLayoutPanel();
            userNameLabel = new Label();
            userNameTextBox = new TextBox();
            label1 = new Label();
            fullNameTextBox = new TextBox();
            label3 = new Label();
            phoneTextBox = new TextBox();
            label2 = new Label();
            emailTextBox = new TextBox();
            passwordLabel = new Label();
            patientDOBLabel = new Label();
            PatientDateTimePicker = new DateTimePicker();
            patientBloodLabel = new Label();
            PatientBloodComboBox = new ComboBox();
            patientAdrsLabel = new Label();
            patientAddressTextBox = new TextBox();
            CancelButton = new Button();
            CreateBtn = new Button();
            label4 = new Label();
            groupBox1 = new GroupBox();
            passwordTextBox = new TextBox();
            showPassCheckBox = new CheckBox();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            errorProvider8 = new ErrorProvider(components);
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.12166739F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.87721F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.3771038F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.459241F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.3284359F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25.3771038F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.459241F));
            tableLayoutPanel1.Controls.Add(userNameLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(userNameTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(fullNameTextBox, 2, 3);
            tableLayoutPanel1.Controls.Add(label3, 1, 4);
            tableLayoutPanel1.Controls.Add(phoneTextBox, 2, 4);
            tableLayoutPanel1.Controls.Add(label2, 1, 5);
            tableLayoutPanel1.Controls.Add(emailTextBox, 2, 5);
            tableLayoutPanel1.Controls.Add(passwordLabel, 1, 6);
            tableLayoutPanel1.Controls.Add(patientDOBLabel, 4, 2);
            tableLayoutPanel1.Controls.Add(PatientDateTimePicker, 5, 2);
            tableLayoutPanel1.Controls.Add(patientBloodLabel, 4, 3);
            tableLayoutPanel1.Controls.Add(PatientBloodComboBox, 5, 3);
            tableLayoutPanel1.Controls.Add(patientAdrsLabel, 4, 4);
            tableLayoutPanel1.Controls.Add(patientAddressTextBox, 5, 4);
            tableLayoutPanel1.Controls.Add(CancelButton, 4, 6);
            tableLayoutPanel1.Controls.Add(CreateBtn, 5, 6);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 9;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2174711F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2174711F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2174711F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2174711F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2174711F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.2174711F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.6609631F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.10873556F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.925473F));
            tableLayoutPanel1.Size = new Size(800, 431);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            userNameLabel.Location = new Point(60, 104);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(96, 52);
            userNameLabel.TabIndex = 8;
            userNameLabel.Text = "Username:";
            userNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = Color.AntiqueWhite;
            userNameTextBox.Dock = DockStyle.Fill;
            userNameTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            userNameTextBox.Location = new Point(162, 107);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(197, 29);
            userNameTextBox.TabIndex = 9;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(58, 156);
            label1.Name = "label1";
            label1.Size = new Size(98, 52);
            label1.TabIndex = 6;
            label1.Text = "Full Name:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.BackColor = Color.LightGoldenrodYellow;
            fullNameTextBox.Dock = DockStyle.Fill;
            fullNameTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            fullNameTextBox.Location = new Point(162, 159);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(197, 29);
            fullNameTextBox.TabIndex = 10;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(90, 208);
            label3.Name = "label3";
            label3.Size = new Size(66, 52);
            label3.TabIndex = 4;
            label3.Text = "Phone:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // phoneTextBox
            // 
            phoneTextBox.BackColor = Color.Beige;
            phoneTextBox.Dock = DockStyle.Fill;
            phoneTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            phoneTextBox.Location = new Point(162, 211);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(197, 29);
            phoneTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(93, 260);
            label2.Name = "label2";
            label2.Size = new Size(63, 52);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.FloralWhite;
            emailTextBox.Dock = DockStyle.Fill;
            emailTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            emailTextBox.Location = new Point(162, 263);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(197, 29);
            emailTextBox.TabIndex = 11;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            passwordLabel.Location = new Point(12, 312);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(144, 63);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Temp Password:";
            passwordLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // patientDOBLabel
            // 
            patientDOBLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            patientDOBLabel.AutoSize = true;
            patientDOBLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            patientDOBLabel.Location = new Point(453, 104);
            patientDOBLabel.Name = "patientDOBLabel";
            patientDOBLabel.Size = new Size(119, 52);
            patientDOBLabel.TabIndex = 15;
            patientDOBLabel.Text = "Patient DOB:";
            patientDOBLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // PatientDateTimePicker
            // 
            PatientDateTimePicker.CustomFormat = "yyyy-MM-dd";
            PatientDateTimePicker.Dock = DockStyle.Fill;
            PatientDateTimePicker.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PatientDateTimePicker.Format = DateTimePickerFormat.Custom;
            PatientDateTimePicker.Location = new Point(578, 107);
            PatientDateTimePicker.Name = "PatientDateTimePicker";
            PatientDateTimePicker.Size = new Size(197, 29);
            PatientDateTimePicker.TabIndex = 19;
            // 
            // patientBloodLabel
            // 
            patientBloodLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            patientBloodLabel.AutoSize = true;
            patientBloodLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            patientBloodLabel.Location = new Point(396, 156);
            patientBloodLabel.Name = "patientBloodLabel";
            patientBloodLabel.Size = new Size(176, 52);
            patientBloodLabel.TabIndex = 14;
            patientBloodLabel.Text = "Patient BloodGroup:";
            patientBloodLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // PatientBloodComboBox
            // 
            PatientBloodComboBox.BackColor = Color.Beige;
            PatientBloodComboBox.Cursor = Cursors.Hand;
            PatientBloodComboBox.Dock = DockStyle.Fill;
            PatientBloodComboBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PatientBloodComboBox.FormattingEnabled = true;
            PatientBloodComboBox.Location = new Point(578, 159);
            PatientBloodComboBox.Name = "PatientBloodComboBox";
            PatientBloodComboBox.Size = new Size(197, 29);
            PatientBloodComboBox.TabIndex = 18;
            // 
            // patientAdrsLabel
            // 
            patientAdrsLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            patientAdrsLabel.AutoSize = true;
            patientAdrsLabel.Font = new Font("Segoe Print", 12F, FontStyle.Bold | FontStyle.Italic);
            patientAdrsLabel.Location = new Point(427, 208);
            patientAdrsLabel.Name = "patientAdrsLabel";
            patientAdrsLabel.Size = new Size(145, 52);
            patientAdrsLabel.TabIndex = 16;
            patientAdrsLabel.Text = "Patient Address:";
            patientAdrsLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // patientAddressTextBox
            // 
            patientAddressTextBox.BackColor = Color.MistyRose;
            patientAddressTextBox.Dock = DockStyle.Fill;
            patientAddressTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            patientAddressTextBox.Location = new Point(578, 211);
            patientAddressTextBox.Name = "patientAddressTextBox";
            patientAddressTextBox.Size = new Size(197, 29);
            patientAddressTextBox.TabIndex = 17;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.AutoSize = true;
            CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton.BackColor = Color.Thistle;
            CancelButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CancelButton.Image = (Image)resources.GetObject("CancelButton.Image");
            CancelButton.Location = new Point(476, 315);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(96, 57);
            CancelButton.TabIndex = 21;
            CancelButton.Text = "Cancel";
            CancelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreateBtn.AutoSize = true;
            CreateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CreateBtn.BackColor = Color.PaleTurquoise;
            CreateBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CreateBtn.Image = (Image)resources.GetObject("CreateBtn.Image");
            CreateBtn.Location = new Point(578, 315);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(197, 57);
            CreateBtn.TabIndex = 20;
            CreateBtn.Text = "Create";
            CreateBtn.TextAlign = ContentAlignment.MiddleRight;
            CreateBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.PaleTurquoise;
            tableLayoutPanel1.SetColumnSpan(label4, 4);
            label4.Font = new Font("Segoe Print", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(162, 0);
            label4.Name = "label4";
            label4.Size = new Size(425, 51);
            label4.TabIndex = 8;
            label4.Text = "Add A New Patient Profile:";
            label4.TextAlign = ContentAlignment.TopRight;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(showPassCheckBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(162, 315);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 57);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.Linen;
            passwordTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            passwordTextBox.Location = new Point(0, 0);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(197, 29);
            passwordTextBox.TabIndex = 12;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // showPassCheckBox
            // 
            showPassCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            showPassCheckBox.AutoSize = true;
            showPassCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            showPassCheckBox.Location = new Point(100, 35);
            showPassCheckBox.Name = "showPassCheckBox";
            showPassCheckBox.Size = new Size(108, 17);
            showPassCheckBox.TabIndex = 13;
            showPassCheckBox.Text = "Show Password";
            showPassCheckBox.TextAlign = ContentAlignment.MiddleRight;
            showPassCheckBox.UseVisualStyleBackColor = true;
            showPassCheckBox.CheckedChanged += showPassCheckBox_CheckedChanged;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            // 
            // errorProvider7
            // 
            errorProvider7.ContainerControl = this;
            // 
            // errorProvider8
            // 
            errorProvider8.ContainerControl = this;
            // 
            // CreatePatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(800, 431);
            Controls.Add(tableLayoutPanel1);
            Name = "CreatePatient";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePatient";
            Load += CreatePatient_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label passwordLabel;
        private TextBox emailTextBox;
        private CheckBox showPassCheckBox;
        private Label userNameLabel;
        private TextBox passwordTextBox;
        private TextBox userNameTextBox;
        private Label label1;
        private TextBox fullNameTextBox;
        private Label label3;
        private TextBox phoneTextBox;
        private Label label2;
        private Label patientDOBLabel;
        private DateTimePicker PatientDateTimePicker;
        private Label patientBloodLabel;
        private ComboBox PatientBloodComboBox;
        private Label patientAdrsLabel;
        private TextBox patientAddressTextBox;
        private Button CreateBtn;
        private Button CancelButton;
        private Label label4;
        private GroupBox groupBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider7;
        private ErrorProvider errorProvider8;
    }
}