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
            double totalPrice, truckPrice, palletPrice, boxPrice;

            // Get values
            truckCapacity = Convert.ToInt32(this.tbTruckCapacity.Text);
            orderedBoxes = Convert.ToInt32(this.tbOrderedBoxes.Text);
            boxesPerPallet = Convert.ToInt32(this.tbBoxesPerPallet.Text);

            // Calculate values
            palletsOrder = orderedBoxes / boxesPerPallet;
            totalTrucks = (int)Math.Ceiling(orderedBoxes / (truckCapacity * boxesPerPallet));
            palletsRemaining = (int)Math.Ceiling((totalTrucks * truckCapacity) - palletsOrder);
            boxesRemaining = palletsRemaining * boxesPerPallet;

            // Calculate total price
            if (this.rbCompanyA.Checked)
            {
                truckPrice = 400;
                palletPrice = 25;
                boxPrice = 1.50;
            }
            else if (this.rbCompanyB.Checked)
            {
                truckPrice = 430;
                palletPrice = 19;
                boxPrice = 1.25;
            }
            else
            {
                truckPrice = 500;
                palletPrice = 34;
                boxPrice = 2.50;
            }

            totalPrice = totalTrucks * truckPrice + palletsOrder * palletPrice + orderedBoxes * boxPrice;


            // Labels output
            this.lblTotalTrucks.Text = "Total Trucks: " + totalTrucks;
            this.lblRemainingPallets.Text = "Remaining Pallets: " + palletsRemaining;
            this.lblRemainingBoxes.Text = "Remaining Boxes: " + boxesRemaining;
            this.lblTotalPrice.Text = "Total Price: " + totalPrice + " euro";
        }

        private void rbCompanyA_CheckedChanged(object sender, EventArgs e)
        {
            this.tbDescription.Text = "Prices: \r\nTurck price: 400.00 euro \r\nPallet price: 25.00 euro \r\nBox price: 1.50 euro";

            this.tbTruckCapacity.Text = "20";
            this.tbBoxesPerPallet.Text = "30";
        }

        private void rbCompanyB_CheckedChanged(object sender, EventArgs e)
        {
            this.tbDescription.Text = "Prices: \r\nTurck price: 430.00 euro \r\nPallet price: 19.00 euro \r\nBox price: 1.25 euro";

            this.tbTruckCapacity.Text = "24";
            this.tbBoxesPerPallet.Text = "30";
        }

        private void rbCompanyC_CheckedChanged(object sender, EventArgs e)
        {
            this.tbDescription.Text = "Prices: \r\nTurck price: 500.00 euro \r\nPallet price: 34.00 euro \r\nBox price: 2.50 euro";

            this.tbTruckCapacity.Text = "28";
            this.tbBoxesPerPallet.Text = "35";
        }
    }
}
