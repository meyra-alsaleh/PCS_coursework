using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TruckManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double totalTrucks, palletsRemaining, boxesRemaining, palletsOrder, truckCapacity, orderedBoxes, boxesPerPallet;

            // Get values
            truckCapacity = Convert.ToInt32(this.tbTruckCapacity.Text);
            orderedBoxes = Convert.ToInt32(this.tbOrderedBoxes.Text);
            boxesPerPallet = Convert.ToInt32(this.tbBoxesPerPallet.Text);

            // Calculate values
            palletsOrder = orderedBoxes / boxesPerPallet;
            totalTrucks = (int)Math.Ceiling(orderedBoxes / (truckCapacity * boxesPerPallet));
            palletsRemaining = (int)Math.Ceiling((totalTrucks * truckCapacity) - palletsOrder);
            boxesRemaining = palletsRemaining * boxesPerPallet;

            // Labels output
            this.lblTotalTrucks.Text = "Total Trucks: " + totalTrucks;
            this.lblRemainingPallets.Text = "Remaining Pallets: " + palletsRemaining;
            this.lblRemainingBoxes.Text = "Remaining Boxes: " + boxesRemaining;
        }
    }
}
