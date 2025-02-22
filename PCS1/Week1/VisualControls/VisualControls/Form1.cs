using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My name is Meyra - Mijn naam is Meyra");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            this.progressBar1.Value = this.trackBar1.Value;
            this.label1.Text = this.trackBar1.Value.ToString();
        }

        private void rbMakeGreen_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkSeaGreen;
        }

        private void rbMakeRed_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.Salmon;
        }

        private void rbMakeYellow_CheckedChanged(object sender, EventArgs e)
        {
            this.BackColor = Color.PaleGoldenrod;
        }
    }
}
