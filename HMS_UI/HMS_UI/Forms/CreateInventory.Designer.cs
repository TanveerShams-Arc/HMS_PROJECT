namespace HMS_UI.Forms
{
    partial class CreateInventory
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            MedNameTextBox = new TextBox();
            ExpiryDatePicker = new DateTimePicker();
            MedQuantityNumeric = new NumericUpDown();
            ManufactComboBox = new ComboBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            CancelButton = new Button();
            AddButton = new Button();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MedQuantityNumeric).BeginInit();
            tableLayoutPanel2.SuspendLayout();
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
            tableLayoutPanel1.BackColor = Color.LightSteelBlue;
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.00026F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.8041382F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 2.00026035F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50.0064964F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.1888447F));
            tableLayoutPanel1.Controls.Add(label1, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 1, 5);
            tableLayoutPanel1.Controls.Add(label3, 1, 7);
            tableLayoutPanel1.Controls.Add(label4, 1, 9);
            tableLayoutPanel1.Controls.Add(label5, 1, 1);
            tableLayoutPanel1.Controls.Add(MedNameTextBox, 3, 3);
            tableLayoutPanel1.Controls.Add(ExpiryDatePicker, 3, 9);
            tableLayoutPanel1.Controls.Add(MedQuantityNumeric, 3, 5);
            tableLayoutPanel1.Controls.Add(ManufactComboBox, 3, 7);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 3, 11);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.89431566F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9052629F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.8943158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9052629F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.8943158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9052629F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.8943158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9052629F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.8943158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.9052629F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 0.8943158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0538969F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.0538969F));
            tableLayoutPanel1.Size = new Size(800, 450);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 75);
            label1.Name = "label1";
            label1.Size = new Size(248, 67);
            label1.TabIndex = 0;
            label1.Text = "Medicine Name";
            label1.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 146);
            label2.Name = "label2";
            label2.Size = new Size(248, 67);
            label2.TabIndex = 0;
            label2.Text = "Medicine Quantity";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(19, 217);
            label3.Name = "label3";
            label3.Size = new Size(248, 67);
            label3.TabIndex = 0;
            label3.Text = "Medicine Manufacturer";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.Location = new Point(19, 288);
            label4.Name = "label4";
            label4.Size = new Size(248, 67);
            label4.TabIndex = 0;
            label4.Text = "Batch Expiry Date";
            label4.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Thistle;
            tableLayoutPanel1.SetColumnSpan(label5, 3);
            label5.Dock = DockStyle.Fill;
            label5.Font = new Font("Palatino Linotype", 22.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.Location = new Point(19, 4);
            label5.Name = "label5";
            label5.Size = new Size(664, 67);
            label5.TabIndex = 1;
            label5.Text = "Add New Medicine Batch";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MedNameTextBox
            // 
            MedNameTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MedNameTextBox.BackColor = Color.PaleGoldenrod;
            MedNameTextBox.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            MedNameTextBox.Location = new Point(289, 94);
            MedNameTextBox.Name = "MedNameTextBox";
            MedNameTextBox.Size = new Size(394, 29);
            MedNameTextBox.TabIndex = 2;
            // 
            // ExpiryDatePicker
            // 
            ExpiryDatePicker.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ExpiryDatePicker.CalendarMonthBackground = Color.Linen;
            ExpiryDatePicker.Format = DateTimePickerFormat.Short;
            ExpiryDatePicker.Location = new Point(289, 307);
            ExpiryDatePicker.Name = "ExpiryDatePicker";
            ExpiryDatePicker.Size = new Size(394, 29);
            ExpiryDatePicker.TabIndex = 4;
            // 
            // MedQuantityNumeric
            // 
            MedQuantityNumeric.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            MedQuantityNumeric.BackColor = Color.NavajoWhite;
            MedQuantityNumeric.Location = new Point(289, 165);
            MedQuantityNumeric.Name = "MedQuantityNumeric";
            MedQuantityNumeric.Size = new Size(394, 29);
            MedQuantityNumeric.TabIndex = 5;
            // 
            // ManufactComboBox
            // 
            ManufactComboBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            ManufactComboBox.BackColor = Color.PaleGoldenrod;
            ManufactComboBox.FormattingEnabled = true;
            ManufactComboBox.Location = new Point(289, 239);
            ManufactComboBox.Name = "ManufactComboBox";
            ManufactComboBox.Size = new Size(394, 29);
            ManufactComboBox.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.7289734F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 6.542056F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.7289734F));
            tableLayoutPanel2.Controls.Add(CancelButton, 0, 0);
            tableLayoutPanel2.Controls.Add(AddButton, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(289, 362);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(394, 39);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // CancelButton
            // 
            CancelButton.BackColor = Color.Plum;
            CancelButton.Dock = DockStyle.Fill;
            CancelButton.Location = new Point(3, 3);
            CancelButton.Name = "CancelButton";
            CancelButton.Size = new Size(178, 33);
            CancelButton.TabIndex = 0;
            CancelButton.Text = "Cancel";
            CancelButton.UseVisualStyleBackColor = false;
            CancelButton.Click += CancelButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.DarkSeaGreen;
            AddButton.Dock = DockStyle.Fill;
            AddButton.Location = new Point(212, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(179, 33);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add To Inventory";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // CreateInventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleTurquoise;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "CreateInventory";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateInventory";
            Load += CreateInventory_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)MedQuantityNumeric).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox MedNameTextBox;
        private TextBox MedQuantityTextBox;
        private ComboBox comboBox1;
        private DateTimePicker ExpiryDatePicker;
        private NumericUpDown MedQuantityNumeric;
        private ComboBox ManufactComboBox;
        private TableLayoutPanel tableLayoutPanel2;
        private Button CancelButton;
        private Button AddButton;
    }
}