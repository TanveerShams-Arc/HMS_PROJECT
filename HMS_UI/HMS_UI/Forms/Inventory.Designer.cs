namespace HMS_UI.Forms
{
    partial class Inventory
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
            inventoryData = new DataGridView();
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label2 = new Label();
            label1 = new Label();
            PageSizeTextBox = new TextBox();
            pageNumberTextBox = new TextBox();
            label4 = new Label();
            tableLayoutPanel3 = new TableLayoutPanel();
            InventoryComboBox = new ComboBox();
            label3 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            label6 = new Label();
            ExpiryDate = new DateTimePicker();
            MedicineNameTextBox = new TextBox();
            AddButton = new Button();
            BackButton = new Button();
            ((System.ComponentModel.ISupportInitialize)inventoryData).BeginInit();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // inventoryData
            // 
            inventoryData.AllowUserToAddRows = false;
            inventoryData.AllowUserToDeleteRows = false;
            inventoryData.BackgroundColor = SystemColors.InactiveCaption;
            inventoryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            inventoryData.Dock = DockStyle.Fill;
            inventoryData.Location = new Point(3, 133);
            inventoryData.MultiSelect = false;
            inventoryData.Name = "inventoryData";
            inventoryData.ReadOnly = true;
            inventoryData.RowHeadersWidth = 51;
            inventoryData.Size = new Size(794, 314);
            inventoryData.TabIndex = 10;
            inventoryData.CellClick += inventoryData_CellClick;
            inventoryData.CellMouseEnter += inventoryData_CellMouseEnter;
            inventoryData.CellMouseLeave += inventoryData_CellMouseLeave;
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(inventoryData, 0, 1);
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
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6391F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6391068F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.67752016F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6391068F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.00212312F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 18.6391068F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0.496151149F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.59026F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 1.67751956F));
            tableLayoutPanel2.Controls.Add(label2, 0, 4);
            tableLayoutPanel2.Controls.Add(label1, 0, 3);
            tableLayoutPanel2.Controls.Add(PageSizeTextBox, 1, 4);
            tableLayoutPanel2.Controls.Add(pageNumberTextBox, 1, 3);
            tableLayoutPanel2.Controls.Add(label4, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 3, 3);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel4, 3, 4);
            tableLayoutPanel2.Controls.Add(MedicineNameTextBox, 7, 4);
            tableLayoutPanel2.Controls.Add(AddButton, 7, 3);
            tableLayoutPanel2.Controls.Add(BackButton, 7, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 22.6717052F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 1.39657748F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 13.9657726F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 24.0707283F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 32.8925629F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 5.002649F));
            tableLayoutPanel2.Size = new Size(794, 124);
            tableLayoutPanel2.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label2.Location = new Point(3, 75);
            label2.Name = "label2";
            label2.Size = new Size(141, 40);
            label2.TabIndex = 16;
            label2.Text = "Page Size";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label1.Location = new Point(3, 46);
            label1.Name = "label1";
            label1.Size = new Size(141, 29);
            label1.TabIndex = 13;
            label1.Text = "Page Number";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // PageSizeTextBox
            // 
            PageSizeTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            PageSizeTextBox.BackColor = Color.GhostWhite;
            PageSizeTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            PageSizeTextBox.Location = new Point(150, 80);
            PageSizeTextBox.Name = "PageSizeTextBox";
            PageSizeTextBox.PlaceholderText = "20";
            PageSizeTextBox.Size = new Size(141, 29);
            PageSizeTextBox.TabIndex = 21;
            PageSizeTextBox.TextChanged += PageSizeTextBox_TextChanged;
            // 
            // pageNumberTextBox
            // 
            pageNumberTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            pageNumberTextBox.BackColor = Color.LemonChiffon;
            pageNumberTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            pageNumberTextBox.Location = new Point(150, 49);
            pageNumberTextBox.Name = "pageNumberTextBox";
            pageNumberTextBox.PlaceholderText = "1";
            pageNumberTextBox.Size = new Size(141, 29);
            pageNumberTextBox.TabIndex = 21;
            pageNumberTextBox.TextChanged += pageNumberTextBox_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Cornsilk;
            tableLayoutPanel2.SetColumnSpan(label4, 3);
            label4.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(218, 28);
            label4.TabIndex = 22;
            label4.Text = "Manage Inventory";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel3, 3);
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.33368F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.66633F));
            tableLayoutPanel3.Controls.Add(InventoryComboBox, 1, 0);
            tableLayoutPanel3.Controls.Add(label3, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(310, 49);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Size = new Size(295, 23);
            tableLayoutPanel3.TabIndex = 24;
            // 
            // InventoryComboBox
            // 
            InventoryComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            InventoryComboBox.BackColor = Color.MistyRose;
            InventoryComboBox.FormattingEnabled = true;
            InventoryComboBox.Location = new Point(98, 3);
            InventoryComboBox.Name = "InventoryComboBox";
            InventoryComboBox.Size = new Size(194, 23);
            InventoryComboBox.TabIndex = 20;
            InventoryComboBox.SelectedIndexChanged += InventoryComboBox_SelectedIndexChanged;
            InventoryComboBox.TextChanged += InventoryComboBox_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(89, 23);
            label3.TabIndex = 18;
            label3.Text = "Manufacturer";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel2.SetColumnSpan(tableLayoutPanel4, 3);
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.66367F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.33633F));
            tableLayoutPanel4.Controls.Add(label6, 0, 0);
            tableLayoutPanel4.Controls.Add(ExpiryDate, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(310, 78);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(295, 34);
            tableLayoutPanel4.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic);
            label6.Location = new Point(3, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 34);
            label6.TabIndex = 18;
            label6.Text = "Expiry Date";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ExpiryDate
            // 
            ExpiryDate.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ExpiryDate.CalendarMonthBackground = Color.Beige;
            ExpiryDate.Checked = false;
            ExpiryDate.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ExpiryDate.Format = DateTimePickerFormat.Short;
            ExpiryDate.Location = new Point(99, 3);
            ExpiryDate.Name = "ExpiryDate";
            ExpiryDate.ShowCheckBox = true;
            ExpiryDate.Size = new Size(193, 29);
            ExpiryDate.TabIndex = 25;
            ExpiryDate.ValueChanged += ExpiryDate_ValueChanged;
            // 
            // MedicineNameTextBox
            // 
            MedicineNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MedicineNameTextBox.BackColor = Color.OldLace;
            MedicineNameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            MedicineNameTextBox.Location = new Point(614, 80);
            MedicineNameTextBox.Name = "MedicineNameTextBox";
            MedicineNameTextBox.PlaceholderText = "Medicine Name";
            MedicineNameTextBox.Size = new Size(157, 29);
            MedicineNameTextBox.TabIndex = 10;
            MedicineNameTextBox.TextChanged += MedicineNameTextBox_TextChanged;
            // 
            // AddButton
            // 
            AddButton.AutoSize = true;
            AddButton.BackColor = Color.AliceBlue;
            AddButton.Location = new Point(614, 49);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(157, 23);
            AddButton.TabIndex = 19;
            AddButton.Text = "Add Medicine";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // BackButton
            // 
            BackButton.AutoSize = true;
            BackButton.BackColor = Color.AliceBlue;
            BackButton.Location = new Point(614, 3);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(157, 22);
            BackButton.TabIndex = 19;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Inventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inventory";
            Load += Inventory_Load;
            ((System.ComponentModel.ISupportInitialize)inventoryData).EndInit();
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView inventoryData;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label6;
        private Label label2;
        private Label label1;
        private TextBox MedicineNameTextBox;
        private Button AddButton;
        private TextBox PageSizeTextBox;
        private TextBox pageNumberTextBox;
        private Label label4;
        private TableLayoutPanel tableLayoutPanel3;
        private ComboBox InventoryComboBox;
        private Label label3;
        private DateTimePicker ExpiryDate;
        private TableLayoutPanel tableLayoutPanel4;
        private Button BackButton;
    }
}