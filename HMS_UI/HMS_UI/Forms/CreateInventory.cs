using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI.Forms
{
    public partial class CreateInventory : Form
    {

        private readonly IInventoryServices _inventoryServices;
        public CreateInventory(IInventoryServices inventoryServices)
        {
            InitializeComponent();
            _inventoryServices = inventoryServices;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();
        }

        private void CreateInventory_Load(object sender, EventArgs e)
        {
            ManufactComboBox.DataSource = Enum.GetValues(typeof(Manufacturer))
                                    .Cast<Manufacturer>()
                                    .Select(b => new { Value = b, Display = Utilities.GetEnumDescription(b) })
                                    .ToList();

            ManufactComboBox.DisplayMember = "Display";
            ManufactComboBox.ValueMember = "Value";
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Inventory invent = DIContainer.ServiceProvider.GetRequiredService<Inventory>();
            invent.Show();
            this.Close();
        }

        private async void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                string? selectedManufacturer = null;

                if (ManufactComboBox.SelectedItem != null)
                {
                    Manufacturer selectedManufacturerObj = (Manufacturer)ManufactComboBox.SelectedValue!;
                    selectedManufacturer = Utilities.GetEnumDescription(selectedManufacturerObj);
                }

                string medicineName = MedNameTextBox.Text;

                DateTime expiryDate = ExpiryDatePicker.Value;

                int medQuantity = (int)MedQuantityNumeric.Value;

                bool isSuccess = await _inventoryServices.CreateInventoryAsync(medicineName, selectedManufacturer, medQuantity, expiryDate);

                if (isSuccess)
                {
                    MessageBox.Show("Inventory Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Inventory ap = DIContainer.ServiceProvider!.GetRequiredService<Inventory>();
                    ap.Show();

                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
