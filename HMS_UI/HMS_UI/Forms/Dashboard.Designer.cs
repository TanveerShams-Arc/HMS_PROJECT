namespace HMS_UI
{
    partial class Dashboard
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            RecordButton = new Button();
            AppointmentButton = new Button();
            DoctorButton = new Button();
            TransactionButton = new Button();
            PrescriptionButton = new Button();
            label1 = new Label();
            nameLabel = new Label();
            InventoryButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            LogOutButton = new Button();
            NameBindingSource = new BindingSource(components);
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NameBindingSource).BeginInit();
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
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.BackColor = Color.MediumAquamarine;
            tableLayoutPanel1.ColumnCount = 7;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.107553F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.003828F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.7964263F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.6308956F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.7964263F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.6308956F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.033977F));
            tableLayoutPanel1.Controls.Add(RecordButton, 1, 10);
            tableLayoutPanel1.Controls.Add(AppointmentButton, 1, 9);
            tableLayoutPanel1.Controls.Add(DoctorButton, 3, 10);
            tableLayoutPanel1.Controls.Add(TransactionButton, 3, 9);
            tableLayoutPanel1.Controls.Add(PrescriptionButton, 5, 9);
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(nameLabel, 1, 5);
            tableLayoutPanel1.Controls.Add(InventoryButton, 5, 10);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 5, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 12;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.505561948F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.2356138F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.13983F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.0702467F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.900702655F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.4979134F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.9400864F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.5702171F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 4.13983F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // RecordButton
            // 
            RecordButton.AutoSize = true;
            RecordButton.BackColor = Color.CadetBlue;
            RecordButton.Dock = DockStyle.Top;
            RecordButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            RecordButton.ForeColor = Color.MintCream;
            RecordButton.Location = new Point(27, 317);
            RecordButton.Name = "RecordButton";
            RecordButton.Size = new Size(226, 47);
            RecordButton.TabIndex = 0;
            RecordButton.Text = "Records";
            RecordButton.UseVisualStyleBackColor = false;
            RecordButton.Click += RecordButton_Click;
            // 
            // AppointmentButton
            // 
            AppointmentButton.AutoSize = true;
            AppointmentButton.BackColor = Color.CadetBlue;
            AppointmentButton.Dock = DockStyle.Top;
            AppointmentButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AppointmentButton.ForeColor = Color.MintCream;
            AppointmentButton.Location = new Point(27, 240);
            AppointmentButton.Name = "AppointmentButton";
            AppointmentButton.Size = new Size(226, 47);
            AppointmentButton.TabIndex = 0;
            AppointmentButton.Text = "Appointments";
            AppointmentButton.UseVisualStyleBackColor = false;
            AppointmentButton.Click += AppointmentButton_Click;
            // 
            // DoctorButton
            // 
            DoctorButton.AutoSize = true;
            DoctorButton.BackColor = Color.CadetBlue;
            DoctorButton.Dock = DockStyle.Top;
            DoctorButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            DoctorButton.ForeColor = Color.MintCream;
            DoctorButton.Location = new Point(281, 317);
            DoctorButton.Name = "DoctorButton";
            DoctorButton.Size = new Size(231, 47);
            DoctorButton.TabIndex = 0;
            DoctorButton.Text = "Doctors";
            DoctorButton.UseVisualStyleBackColor = false;
            DoctorButton.Click += DoctorButton_Click;
            // 
            // TransactionButton
            // 
            TransactionButton.AutoSize = true;
            TransactionButton.BackColor = Color.CadetBlue;
            TransactionButton.Dock = DockStyle.Top;
            TransactionButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TransactionButton.ForeColor = Color.MintCream;
            TransactionButton.Location = new Point(281, 240);
            TransactionButton.Name = "TransactionButton";
            TransactionButton.Size = new Size(231, 47);
            TransactionButton.TabIndex = 0;
            TransactionButton.Text = "Transactions";
            TransactionButton.UseVisualStyleBackColor = false;
            TransactionButton.Click += TransactionButton_Click;
            // 
            // PrescriptionButton
            // 
            PrescriptionButton.AutoSize = true;
            PrescriptionButton.BackColor = Color.CadetBlue;
            PrescriptionButton.Dock = DockStyle.Top;
            PrescriptionButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            PrescriptionButton.ForeColor = Color.MintCream;
            PrescriptionButton.Location = new Point(540, 240);
            PrescriptionButton.Name = "PrescriptionButton";
            PrescriptionButton.Size = new Size(231, 47);
            PrescriptionButton.TabIndex = 0;
            PrescriptionButton.Text = "Prescriptions";
            PrescriptionButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.SetColumnSpan(label1, 5);
            label1.Dock = DockStyle.Bottom;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Palatino Linotype", 27.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkSlateBlue;
            label1.Location = new Point(27, 56);
            label1.Name = "label1";
            label1.Size = new Size(744, 54);
            label1.TabIndex = 1;
            label1.Text = "Welcome To The Hospital Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(nameLabel, 5);
            nameLabel.Dock = DockStyle.Top;
            nameLabel.FlatStyle = FlatStyle.Popup;
            nameLabel.Font = new Font("Segoe UI Semibold", 21.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            nameLabel.ForeColor = Color.Indigo;
            nameLabel.Location = new Point(27, 113);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(744, 40);
            nameLabel.TabIndex = 2;
            nameLabel.Text = "This Is Name";
            nameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // InventoryButton
            // 
            InventoryButton.AutoSize = true;
            InventoryButton.BackColor = Color.CadetBlue;
            InventoryButton.Dock = DockStyle.Top;
            InventoryButton.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            InventoryButton.ForeColor = Color.MintCream;
            InventoryButton.Location = new Point(540, 317);
            InventoryButton.Name = "InventoryButton";
            InventoryButton.Size = new Size(231, 47);
            InventoryButton.TabIndex = 0;
            InventoryButton.Text = "Inventory";
            InventoryButton.UseVisualStyleBackColor = false;
            InventoryButton.Click += InventoryButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(LogOutButton, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(540, 4);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(231, 33);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // LogOutButton
            // 
            LogOutButton.BackColor = Color.RosyBrown;
            LogOutButton.Dock = DockStyle.Fill;
            LogOutButton.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            LogOutButton.ForeColor = Color.Transparent;
            LogOutButton.Location = new Point(118, 3);
            LogOutButton.Name = "LogOutButton";
            LogOutButton.Size = new Size(110, 27);
            LogOutButton.TabIndex = 3;
            LogOutButton.Text = "Log Out";
            LogOutButton.UseVisualStyleBackColor = false;
            LogOutButton.Click += LogOutButton_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Dashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dashboard";
            Load += Dashboard_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)NameBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button AppointmentButton;
        private Button TransactionButton;
        private Button PrescriptionButton;
        private Button RecordButton;
        private Button InventoryButton;
        private Button DoctorButton;
        private Label label1;
        private Label nameLabel;
        private BindingSource NameBindingSource;
        private TableLayoutPanel tableLayoutPanel2;
        private Button LogOutButton;
    }
}