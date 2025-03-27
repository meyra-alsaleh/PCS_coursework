using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToggleColours
{
    public partial class Form1 : Form
    {
        int cnt = 1;            //indicates the button presses
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(204, 255, 204);         // green
        }

        private void btnSwitchColour_Click(object sender, EventArgs e)
        {
            cnt++;                      // with each press, counter increases by 1
            if (cnt % 2 == 0)
            {
                this.BackColor = Color.FromArgb(204, 204, 255);         // purple
            }
            else
            {
                if (cnt % 3 == 0)
                {
                    this.BackColor = Color.FromArgb(255, 204, 204);         // red
                    cnt = 0;                                                // set back to original state
                }
                else
                {
                    this.BackColor = Color.FromArgb(204, 255, 204);         // green
                }
            }
        }
    }
}
