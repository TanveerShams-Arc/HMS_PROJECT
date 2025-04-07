using System.Threading.Tasks;
using HMS_API.Dtos;
using HMS_UI.Enums;
using HMS_UI.HelperFunctions;
using HMS_UI.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace HMS_UI.Forms
{
    public partial class Inventory : Form
    {
        private readonly IInventoryServices _inventoryServices;
        public Inventory(IInventoryServices inventoryServices)
        {
            InitializeComponent();

            _inventoryServices = inventoryServices;

            this.FormClosed += Utilities.CheckAndExitApplication;
            this.Show();
        }

        private async void Inventory_Load(object sender, EventArgs e)
        {
            InventoryComboBox.DataSource = Enum.GetValues(typeof(Manufacturer))
                .Cast<Manufacturer>()
                .Select(b => new { Value = b, Display = Utilities.GetEnumDescription(b) })
                .ToList();

            InventoryComboBox.DisplayMember = "Display";
            InventoryComboBox.ValueMember = "Value";
            InventoryComboBox.SelectedIndex = -1;

            await GetData();
        }

        private async void pageNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void PageSizeTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void MedicineNameTextBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private async void InventoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            await GetData();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            CreateInventory cin = DIContainer.ServiceProvider.GetRequiredService<CreateInventory>();
            cin.Show();
            this.Close();
        }

        private async void ExpiryDate_ValueChanged(object sender, EventArgs e)
        {
            await GetData();
        }


        private async Task GetData()
        {
            try
            {
                string? selectedManufacturer = null;

                if (InventoryComboBox.SelectedItem != null)
                {
                    var selectedItem = (dynamic)InventoryComboBox.SelectedItem; // Use dynamic to access anonymous type
                    Manufacturer selectedManufacturerObj = selectedItem.Value; // Get the enum value
                    selectedManufacturer = Utilities.GetEnumDescription(selectedManufacturerObj); // Get the description
                }

                string medicineName = MedicineNameTextBox.Text;
                int pageNumber = 1, pageSize = 20;

                DateTime? expiryDate = null;

                if (ExpiryDate.Checked)
                    expiryDate = ExpiryDate.Value;

                if (!string.IsNullOrEmpty(pageNumberTextBox.Text))
                    pageNumber = int.Parse(pageNumberTextBox.Text);
                if (!string.IsNullOrEmpty(PageSizeTextBox.Text))
                    pageSize = int.Parse(PageSizeTextBox.Text);


                var _allInventory = await _inventoryServices.GetInventoryAsync(medicineName, pageNumber, pageSize, selectedManufacturer,
                                                                                expiryDate);

                inventoryData.DataSource = _allInventory;
                DataFormatters.FormatInventoryView(ref inventoryData);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }





        private async void inventoryData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == inventoryData.Columns["Delete"]!.Index && e.RowIndex >= 0)
            {
                var selectedInventory = (InventoryDto)inventoryData.Rows[e.RowIndex].DataBoundItem!;
                await DeleteRecord(selectedInventory);
            }
        }

        private void inventoryData_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (inventoryData.Columns[e.ColumnIndex].Name == "Delete"))
            {
                inventoryData.Cursor = Cursors.Hand;
            }
        }

        private void inventoryData_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && (inventoryData.Columns[e.ColumnIndex].Name == "Delete"))
            {
                inventoryData.Cursor = Cursors.Default;
            }
        }




        private async Task DeleteRecord(InventoryDto selectedInventory)
        {
            if (selectedInventory != null)
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete this data of {selectedInventory.MedicineQuantity} {selectedInventory.Medicine} ?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    bool isSuccess = await _inventoryServices.DeleteRecordAsync(selectedInventory.ItemId);

                    if (isSuccess)
                    {
                        MessageBox.Show("Inventory Data deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        await GetData();
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete Inventory Data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Dashboard dash = DIContainer.ServiceProvider.GetService<Dashboard>();
            dash.Show();
            Close();
        }

        private async void InventoryComboBox_TextChanged(object sender, EventArgs e)
        {
            await GetData();
        }
    }
}
