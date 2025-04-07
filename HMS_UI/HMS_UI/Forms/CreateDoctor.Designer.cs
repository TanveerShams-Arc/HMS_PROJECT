namespace HMS_UI
{
    partial class CreateDoctor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateDoctor));
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider4 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            errorProvider6 = new ErrorProvider(components);
            errorProvider8 = new ErrorProvider(components);
            errorProvider7 = new ErrorProvider(components);
            groupBox1 = new GroupBox();
            passwordTextBox = new TextBox();
            showPassCheckBox = new CheckBox();
            label4 = new Label();
            CreateBtn = new Button();
            CancelButton = new Button();
            passwordLabel = new Label();
            emailTextBox = new TextBox();
            label2 = new Label();
            phoneTextBox = new TextBox();
            label3 = new Label();
            fullNameTextBox = new TextBox();
            label1 = new Label();
            userNameTextBox = new TextBox();
            userNameLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            docExpTextBox = new TextBox();
            DoctorSpecializationComboBox = new ComboBox();
            doctorExpLabel = new Label();
            doctorSpecLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).BeginInit();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
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
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider6
            // 
            errorProvider6.ContainerControl = this;
            // 
            // errorProvider8
            // 
            errorProvider8.ContainerControl = this;
            // 
            // errorProvider7
            // 
            errorProvider7.ContainerControl = this;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(passwordTextBox);
            groupBox1.Controls.Add(showPassCheckBox);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(162, 327);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(197, 59);
            groupBox1.TabIndex = 22;
            groupBox1.TabStop = false;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            passwordTextBox.BackColor = Color.LemonChiffon;
            passwordTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            passwordTextBox.Location = new Point(0, 0);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(194, 29);
            passwordTextBox.TabIndex = 12;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // showPassCheckBox
            // 
            showPassCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            showPassCheckBox.AutoSize = true;
            showPassCheckBox.BackColor = Color.Fuchsia;
            showPassCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            showPassCheckBox.ForeColor = Color.Transparent;
            showPassCheckBox.Location = new Point(86, 35);
            showPassCheckBox.Name = "showPassCheckBox";
            showPassCheckBox.Size = new Size(108, 17);
            showPassCheckBox.TabIndex = 13;
            showPassCheckBox.Text = "Show Password";
            showPassCheckBox.TextAlign = ContentAlignment.MiddleRight;
            showPassCheckBox.UseVisualStyleBackColor = false;
            showPassCheckBox.CheckedChanged += showPassCheckBox_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.LightGray;
            tableLayoutPanel1.SetColumnSpan(label4, 4);
            label4.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(162, 0);
            label4.Name = "label4";
            label4.Size = new Size(356, 36);
            label4.TabIndex = 8;
            label4.Text = "Add A New Doctor Profile";
            label4.TextAlign = ContentAlignment.TopRight;
            label4.Click += label4_Click;
            // 
            // CreateBtn
            // 
            CreateBtn.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CreateBtn.AutoSize = true;
            CreateBtn.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CreateBtn.BackColor = Color.Yellow;
            CreateBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            CreateBtn.Image = (Image)resources.GetObject("CreateBtn.Image");
            CreateBtn.Location = new Point(578, 273);
            CreateBtn.Name = "CreateBtn";
            CreateBtn.Size = new Size(197, 48);
            CreateBtn.TabIndex = 20;
            CreateBtn.Text = "Create";
            CreateBtn.TextAlign = ContentAlignment.MiddleRight;
            CreateBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            CreateBtn.UseVisualStyleBackColor = false;
            CreateBtn.Click += CreateBtn_Click;
            // 
            // CancelButton
            // 
            CancelButton.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            CancelButton.AutoSize = true;
            CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton.BackColor = Color.Plum;
            CancelButton.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            CancelButton.Image = (Image)resources.GetObject("CancelButton.Image");
            CancelButton.Location = new Point(476, 273);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(96, 48);
            CancelButton.TabIndex = 21;
            CancelButton.Text = "Cancel";
            CancelButton.TextImageRelation = TextImageRelation.ImageBeforeText;
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordLabel.Location = new Point(16, 324);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(140, 65);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Temp Password:";
            passwordLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // emailTextBox
            // 
            emailTextBox.BackColor = Color.AntiqueWhite;
            emailTextBox.Dock = DockStyle.Fill;
            emailTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            emailTextBox.Location = new Point(162, 273);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(197, 29);
            emailTextBox.TabIndex = 11;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 270);
            label2.Name = "label2";
            label2.Size = new Size(58, 54);
            label2.TabIndex = 5;
            label2.Text = "Email:";
            label2.TextAlign = ContentAlignment.TopRight;
            // 
            // phoneTextBox
            // 
            phoneTextBox.BackColor = Color.OldLace;
            phoneTextBox.Dock = DockStyle.Fill;
            phoneTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            phoneTextBox.Location = new Point(162, 219);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(197, 29);
            phoneTextBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(91, 216);
            label3.Name = "label3";
            label3.Size = new Size(65, 54);
            label3.TabIndex = 4;
            label3.Text = "Phone:";
            label3.TextAlign = ContentAlignment.TopRight;
            // 
            // fullNameTextBox
            // 
            fullNameTextBox.BackColor = Color.LemonChiffon;
            fullNameTextBox.Dock = DockStyle.Fill;
            fullNameTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            fullNameTextBox.ForeColor = Color.White;
            fullNameTextBox.Location = new Point(162, 165);
            fullNameTextBox.Name = "fullNameTextBox";
            fullNameTextBox.Size = new Size(197, 29);
            fullNameTextBox.TabIndex = 10;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 162);
            label1.Name = "label1";
            label1.Size = new Size(94, 54);
            label1.TabIndex = 6;
            label1.Text = "Full Name:";
            label1.TextAlign = ContentAlignment.TopRight;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = Color.LightYellow;
            userNameTextBox.Dock = DockStyle.Fill;
            userNameTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            userNameTextBox.Location = new Point(162, 111);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(197, 29);
            userNameTextBox.TabIndex = 9;
            // 
            // userNameLabel
            // 
            userNameLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            userNameLabel.AutoSize = true;
            userNameLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userNameLabel.Location = new Point(60, 108);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(96, 54);
            userNameLabel.TabIndex = 8;
            userNameLabel.Text = "Username:";
            userNameLabel.TextAlign = ContentAlignment.TopRight;
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
            tableLayoutPanel1.Controls.Add(groupBox1, 2, 6);
            tableLayoutPanel1.Controls.Add(docExpTextBox, 5, 3);
            tableLayoutPanel1.Controls.Add(DoctorSpecializationComboBox, 5, 2);
            tableLayoutPanel1.Controls.Add(doctorExpLabel, 4, 3);
            tableLayoutPanel1.Controls.Add(doctorSpecLabel, 4, 2);
            tableLayoutPanel1.Controls.Add(CancelButton, 4, 5);
            tableLayoutPanel1.Controls.Add(CreateBtn, 5, 5);
            tableLayoutPanel1.Controls.Add(label4, 2, 0);
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
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // docExpTextBox
            // 
            docExpTextBox.BackColor = Color.PapayaWhip;
            docExpTextBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic);
            docExpTextBox.Location = new Point(578, 165);
            docExpTextBox.Name = "docExpTextBox";
            docExpTextBox.Size = new Size(197, 29);
            docExpTextBox.TabIndex = 25;
            // 
            // DoctorSpecializationComboBox
            // 
            DoctorSpecializationComboBox.BackColor = Color.Cornsilk;
            DoctorSpecializationComboBox.Cursor = Cursors.Hand;
            DoctorSpecializationComboBox.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DoctorSpecializationComboBox.FormattingEnabled = true;
            DoctorSpecializationComboBox.Location = new Point(578, 111);
            DoctorSpecializationComboBox.Name = "DoctorSpecializationComboBox";
            DoctorSpecializationComboBox.Size = new Size(197, 29);
            DoctorSpecializationComboBox.TabIndex = 26;
            // 
            // doctorExpLabel
            // 
            doctorExpLabel.AutoSize = true;
            doctorExpLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorExpLabel.Location = new Point(384, 162);
            doctorExpLabel.Name = "doctorExpLabel";
            doctorExpLabel.Size = new Size(153, 20);
            doctorExpLabel.TabIndex = 24;
            doctorExpLabel.Text = "Doctor Experiene:";
            doctorExpLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // doctorSpecLabel
            // 
            doctorSpecLabel.AutoSize = true;
            doctorSpecLabel.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            doctorSpecLabel.Location = new Point(384, 108);
            doctorSpecLabel.Name = "doctorSpecLabel";
            doctorSpecLabel.Size = new Size(185, 20);
            doctorSpecLabel.TabIndex = 23;
            doctorSpecLabel.Text = "Doctor Specialization:";
            doctorSpecLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CreateDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSkyBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateDoctor";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateDoctor";
            Load += CreateDoctor_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider4).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider6).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider8).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider7).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ErrorProvider errorProvider2;
        private TableLayoutPanel tableLayoutPanel1;
        private Label userNameLabel;
        private TextBox userNameTextBox;
        private Label label1;
        private TextBox fullNameTextBox;
        private Label label3;
        private TextBox phoneTextBox;
        private Label label2;
        private TextBox emailTextBox;
        private Label passwordLabel;
        private Button CancelButton;
        private Button CreateBtn;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox passwordTextBox;
        private CheckBox showPassCheckBox;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider4;
        private ErrorProvider errorProvider5;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider6;
        private ErrorProvider errorProvider8;
        private ErrorProvider errorProvider7;
        private TextBox docExpTextBox;
        private ComboBox DoctorSpecializationComboBox;
        private Label doctorExpLabel;
        private Label doctorSpecLabel;
    }
}