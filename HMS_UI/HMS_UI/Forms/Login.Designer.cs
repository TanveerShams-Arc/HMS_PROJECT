namespace HMS_UI
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            signInLabel = new Label();
            pictureBox1 = new PictureBox();
            loginBtn = new Button();
            signUpButton = new Button();
            showPassCheckBox = new CheckBox();
            passwordTextBox = new TextBox();
            userNameTextBox = new TextBox();
            passwordLabel = new Label();
            userNameLabel = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // signInLabel
            // 
            signInLabel.AutoSize = true;
            signInLabel.BackColor = Color.Lavender;
            signInLabel.Dock = DockStyle.Fill;
            signInLabel.Font = new Font("PMingLiU-ExtB", 28.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            signInLabel.Location = new Point(237, 0);
            signInLabel.Name = "signInLabel";
            signInLabel.Size = new Size(174, 38);
            signInLabel.TabIndex = 0;
            signInLabel.Text = "SIGN IN";
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 41);
            pictureBox1.Name = "pictureBox1";
            tableLayoutPanel1.SetRowSpan(pictureBox1, 6);
            pictureBox1.Size = new Size(228, 338);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // loginBtn
            // 
            loginBtn.BackColor = Color.NavajoWhite;
            loginBtn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            loginBtn.Image = (Image)resources.GetObject("loginBtn.Image");
            loginBtn.Location = new Point(541, 272);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(106, 44);
            loginBtn.TabIndex = 3;
            loginBtn.Text = "Log In";
            loginBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            loginBtn.UseVisualStyleBackColor = false;
            loginBtn.Click += loginBtn_Click;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = Color.LightPink;
            signUpButton.Location = new Point(417, 272);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(106, 44);
            signUpButton.TabIndex = 3;
            signUpButton.Text = "Register";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // showPassCheckBox
            // 
            showPassCheckBox.AutoSize = true;
            showPassCheckBox.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            showPassCheckBox.Location = new Point(541, 230);
            showPassCheckBox.Name = "showPassCheckBox";
            showPassCheckBox.Size = new Size(108, 17);
            showPassCheckBox.TabIndex = 2;
            showPassCheckBox.Text = "Show Password";
            showPassCheckBox.UseVisualStyleBackColor = true;
            showPassCheckBox.CheckedChanged += showPassCheckBox_CheckedChanged;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.Beige;
            tableLayoutPanel1.SetColumnSpan(passwordTextBox, 2);
            passwordTextBox.Dock = DockStyle.Fill;
            passwordTextBox.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            passwordTextBox.Location = new Point(417, 184);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(242, 33);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.UseSystemPasswordChar = true;
            // 
            // userNameTextBox
            // 
            userNameTextBox.BackColor = Color.Beige;
            tableLayoutPanel1.SetColumnSpan(userNameTextBox, 2);
            userNameTextBox.Dock = DockStyle.Fill;
            userNameTextBox.Font = new Font("Segoe UI Black", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            userNameTextBox.Location = new Point(417, 118);
            userNameTextBox.Name = "userNameTextBox";
            userNameTextBox.Size = new Size(242, 33);
            userNameTextBox.TabIndex = 0;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Dock = DockStyle.Fill;
            passwordLabel.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic);
            passwordLabel.Location = new Point(237, 181);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(174, 46);
            passwordLabel.TabIndex = 0;
            passwordLabel.Text = "Password:";
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Dock = DockStyle.Fill;
            userNameLabel.Font = new Font("Segoe Print", 14.25F, FontStyle.Bold | FontStyle.Italic);
            userNameLabel.Location = new Point(237, 115);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(174, 66);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Username:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 35.32071F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.2474079F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7159386F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.7159386F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 23F));
            tableLayoutPanel1.Controls.Add(userNameLabel, 1, 2);
            tableLayoutPanel1.Controls.Add(passwordLabel, 1, 3);
            tableLayoutPanel1.Controls.Add(userNameTextBox, 2, 2);
            tableLayoutPanel1.Controls.Add(passwordTextBox, 2, 3);
            tableLayoutPanel1.Controls.Add(showPassCheckBox, 3, 4);
            tableLayoutPanel1.Controls.Add(loginBtn, 3, 5);
            tableLayoutPanel1.Controls.Add(signUpButton, 2, 5);
            tableLayoutPanel1.Controls.Add(signInLabel, 1, 0);
            tableLayoutPanel1.Controls.Add(pictureBox1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0069723F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20.0139446F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.977438F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.0783825F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.83263F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 30.0906372F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(706, 409);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(706, 409);
            Controls.Add(tableLayoutPanel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label signInLabel;
        private Button loginBtn;
        private CheckBox showPassCheckBox;
        private TextBox userNameTextBox;
        private Label passwordLabel;
        private Label userNameLabel;
        private PictureBox pictureBox1;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private Button signUpButton;
        private TextBox passwordTextBox;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
