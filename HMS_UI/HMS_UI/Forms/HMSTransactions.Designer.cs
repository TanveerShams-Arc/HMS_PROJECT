namespace HMS_UI.Forms
{
    partial class HMSTransactions
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
            pageNumber = new TextBox();
            rightArrowButton1 = new HMS_UI.CustomControls.RightArrowButton();
            tableLayoutPanel1 = new TableLayoutPanel();
            TransactionData = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            createButton = new Button();
            CancelButton = new Button();
            BackButton = new Button();
            SaveButton = new Button();
            PaidTextBox = new TextBox();
            EditButton = new Button();
            AmountTextBox = new TextBox();
            PatientTextBox = new TextBox();
            TransactionStatusComboBox = new ComboBox();
            TransactionDateTimePicker = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            pageSize = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            leftArrowButton1 = new HMS_UI.CustomControls.LeftArrowButton();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionData).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // pageNumber
            // 
            pageNumber.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pageNumber.BackColor = Color.MistyRose;
            pageNumber.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pageNumber.Location = new Point(23, 3);
            pageNumber.Name = "pageNumber";
            pageNumber.PlaceholderText = "1";
            pageNumber.ReadOnly = true;
            pageNumber.Size = new Size(54, 27);
            pageNumber.TabIndex = 4;
            pageNumber.TextAlign = HorizontalAlignment.Center;
            pageNumber.TextChanged += pageNumber_TextChanged;
            // 
            // rightArrowButton1
            // 
            rightArrowButton1.ArrowColor = Color.Black;
            rightArrowButton1.BackColor = Color.Beige;
            rightArrowButton1.Location = new Point(83, 3);
            rightArrowButton1.Name = "rightArrowButton1";
            rightArrowButton1.Size = new Size(15, 23);
            rightArrowButton1.TabIndex = 6;
            rightArrowButton1.Text = "rightArrowButton1";
            rightArrowButton1.Click += rightArrowButton1_Click;
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
            tableLayoutPanel1.Controls.Add(TransactionData, 0, 7);
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 1, 5);
            tableLayoutPanel1.Controls.Add(createButton, 15, 5);
            tableLayoutPanel1.Controls.Add(CancelButton, 13, 3);
            tableLayoutPanel1.Controls.Add(BackButton, 15, 3);
            tableLayoutPanel1.Controls.Add(SaveButton, 13, 5);
            tableLayoutPanel1.Controls.Add(PaidTextBox, 11, 3);
            tableLayoutPanel1.Controls.Add(EditButton, 11, 5);
            tableLayoutPanel1.Controls.Add(AmountTextBox, 9, 3);
            tableLayoutPanel1.Controls.Add(PatientTextBox, 9, 5);
            tableLayoutPanel1.Controls.Add(TransactionStatusComboBox, 7, 3);
            tableLayoutPanel1.Controls.Add(TransactionDateTimePicker, 7, 5);
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
            tableLayoutPanel1.Size = new Size(1029, 503);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // TransactionData
            // 
            TransactionData.AllowUserToAddRows = false;
            TransactionData.AllowUserToDeleteRows = false;
            TransactionData.BackgroundColor = Color.White;
            TransactionData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(TransactionData, 17);
            TransactionData.Dock = DockStyle.Fill;
            TransactionData.GridColor = SystemColors.WindowText;
            TransactionData.Location = new Point(3, 94);
            TransactionData.MultiSelect = false;
            TransactionData.Name = "TransactionData";
            TransactionData.ReadOnly = true;
            TransactionData.RowHeadersWidth = 51;
            tableLayoutPanel1.SetRowSpan(TransactionData, 2);
            TransactionData.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            TransactionData.Size = new Size(1023, 406);
            TransactionData.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.ForeColor = SystemColors.Window;
            label1.Location = new Point(24, 13);
            label1.Name = "label1";
            label1.Size = new Size(101, 35);
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
            label2.Location = new Point(24, 52);
            label2.Name = "label2";
            label2.Size = new Size(101, 35);
            label2.TabIndex = 8;
            label2.Text = "Page Size";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // createButton
            // 
            createButton.AutoSize = true;
            createButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            createButton.BackColor = Color.PeachPuff;
            createButton.Dock = DockStyle.Fill;
            createButton.Location = new Point(899, 55);
            createButton.Name = "createButton";
            createButton.Size = new Size(101, 29);
            createButton.TabIndex = 9;
            createButton.Text = "Create";
            createButton.UseVisualStyleBackColor = false;
            createButton.Click += createButton_Click;
            // 
            // CancelButton
            // 
            CancelButton.AutoSize = true;
            CancelButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            CancelButton.BackColor = Color.Pink;
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.Enabled = false;
            CancelButton.Location = new Point(774, 16);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(101, 29);
            CancelButton.TabIndex = 9;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Visible = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackButton.BackColor = Color.LightCoral;
            BackButton.Dock = DockStyle.Fill;
            BackButton.ForeColor = Color.Transparent;
            BackButton.Location = new Point(899, 16);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(101, 29);
            BackButton.TabIndex = 11;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.AutoSize = true;
            SaveButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            SaveButton.BackColor = Color.YellowGreen;
            SaveButton.Dock = DockStyle.Fill;
            SaveButton.Enabled = false;
            SaveButton.Location = new Point(774, 55);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(101, 29);
            SaveButton.TabIndex = 10;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = false;
            SaveButton.Visible = false;
            SaveButton.Click += SaveButton_Click;
            // 
            // PaidTextBox
            // 
            PaidTextBox.BackColor = Color.LightSkyBlue;
            PaidTextBox.Dock = DockStyle.Fill;
            PaidTextBox.ForeColor = SystemColors.ActiveCaptionText;
            PaidTextBox.Location = new Point(649, 16);
            PaidTextBox.Name = "PaidTextBox";
            PaidTextBox.PlaceholderText = "Amount Paid";
            PaidTextBox.Size = new Size(101, 23);
            PaidTextBox.TabIndex = 4;
            PaidTextBox.TextChanged += PaidTextBox_TextChanged;
            // 
            // EditButton
            // 
            EditButton.AutoSize = true;
            EditButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            EditButton.BackColor = Color.PapayaWhip;
            EditButton.Dock = DockStyle.Fill;
            EditButton.Location = new Point(649, 55);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(101, 29);
            EditButton.TabIndex = 9;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = false;
            EditButton.Click += EditButton_Click;
            // 
            // AmountTextBox
            // 
            AmountTextBox.BackColor = Color.Gainsboro;
            AmountTextBox.Dock = DockStyle.Fill;
            AmountTextBox.ForeColor = Color.Transparent;
            AmountTextBox.Location = new Point(524, 16);
            AmountTextBox.Name = "AmountTextBox";
            AmountTextBox.PlaceholderText = "Amount";
            AmountTextBox.Size = new Size(101, 23);
            AmountTextBox.TabIndex = 4;
            AmountTextBox.TextChanged += AmountTextBox_TextChanged;
            // 
            // PatientTextBox
            // 
            PatientTextBox.BackColor = Color.LavenderBlush;
            PatientTextBox.Dock = DockStyle.Fill;
            PatientTextBox.ForeColor = Color.Black;
            PatientTextBox.Location = new Point(524, 55);
            PatientTextBox.Name = "PatientTextBox";
            PatientTextBox.PlaceholderText = "Patient Name";
            PatientTextBox.Size = new Size(101, 23);
            PatientTextBox.TabIndex = 4;
            PatientTextBox.TextChanged += PatientTextBox_TextChanged;
            // 
            // TransactionStatusComboBox
            // 
            TransactionStatusComboBox.BackColor = Color.SpringGreen;
            TransactionStatusComboBox.Dock = DockStyle.Fill;
            TransactionStatusComboBox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic);
            TransactionStatusComboBox.FormattingEnabled = true;
            TransactionStatusComboBox.Location = new Point(399, 16);
            TransactionStatusComboBox.Name = "TransactionStatusComboBox";
            TransactionStatusComboBox.Size = new Size(101, 23);
            TransactionStatusComboBox.TabIndex = 1;
            TransactionStatusComboBox.SelectedIndexChanged += TransactionStatusComboBox_SelectedIndexChanged;
            // 
            // TransactionDateTimePicker
            // 
            TransactionDateTimePicker.CalendarFont = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            TransactionDateTimePicker.Checked = false;
            TransactionDateTimePicker.CustomFormat = "yyyy-MM-dd";
            TransactionDateTimePicker.Dock = DockStyle.Fill;
            TransactionDateTimePicker.Format = DateTimePickerFormat.Custom;
            TransactionDateTimePicker.Location = new Point(399, 55);
            TransactionDateTimePicker.Name = "TransactionDateTimePicker";
            TransactionDateTimePicker.ShowCheckBox = true;
            TransactionDateTimePicker.Size = new Size(101, 23);
            TransactionDateTimePicker.TabIndex = 2;
            TransactionDateTimePicker.ValueChanged += TransactionDateTimePicker_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.ForeColor = SystemColors.Window;
            label3.Location = new Point(274, 13);
            label3.Name = "label3";
            label3.Size = new Size(101, 35);
            label3.TabIndex = 8;
            label3.Text = "Status";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label4.ForeColor = SystemColors.Window;
            label4.Location = new Point(274, 52);
            label4.Name = "label4";
            label4.Size = new Size(101, 35);
            label4.TabIndex = 8;
            label4.Text = "Transaction Date";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // pageSize
            // 
            pageSize.BackColor = Color.MistyRose;
            pageSize.Dock = DockStyle.Fill;
            pageSize.Location = new Point(149, 55);
            pageSize.Name = "pageSize";
            pageSize.PlaceholderText = "20";
            pageSize.Size = new Size(101, 23);
            pageSize.TabIndex = 4;
            pageSize.TextChanged += pageSize_TextChanged;
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
            tableLayoutPanel2.Location = new Point(149, 16);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(101, 29);
            tableLayoutPanel2.TabIndex = 12;
            // 
            // leftArrowButton1
            // 
            leftArrowButton1.ArrowColor = Color.Black;
            leftArrowButton1.BackColor = Color.Beige;
            leftArrowButton1.Location = new Point(3, 3);
            leftArrowButton1.Name = "leftArrowButton1";
            leftArrowButton1.Size = new Size(14, 23);
            leftArrowButton1.TabIndex = 5;
            leftArrowButton1.Text = "leftArrowButton1";
            leftArrowButton1.Click += leftArrowButton1_Click;
            // 
            // HMSTransactions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Crimson;
            ClientSize = new Size(1029, 503);
            Controls.Add(tableLayoutPanel1);
            Name = "HMSTransactions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HMSTransactions";
            Load += HMSTransactions_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TransactionData).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox pageNumber;
        private CustomControls.RightArrowButton rightArrowButton1;
        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView TransactionData;
        private Label label1;
        private Label label2;
        private Button createButton;
        private Button CancelButton;
        private Button BackButton;
        private Button SaveButton;
        private TextBox PaidTextBox;
        private Button EditButton;
        private TextBox AmountTextBox;
        private TextBox PatientTextBox;
        private ComboBox TransactionStatusComboBox;
        private DateTimePicker TransactionDateTimePicker;
        private Label label3;
        private Label label4;
        private TextBox pageSize;
        private TableLayoutPanel tableLayoutPanel2;
        private CustomControls.LeftArrowButton leftArrowButton1;
    }
}