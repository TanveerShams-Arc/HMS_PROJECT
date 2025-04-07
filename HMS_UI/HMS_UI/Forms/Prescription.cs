using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HMS_UI.Interfaces;

namespace HMS_UI.Forms
{
    public partial class Prescription : Form
    {
        private readonly IPrescriptionServices _prescriptionServices;
        public Prescription(IPrescriptionServices prescriptionServices)
        {
            InitializeComponent();
            _prescriptionServices = prescriptionServices;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Prescription_Load(object sender, EventArgs e)
        {

        }
    }
}
