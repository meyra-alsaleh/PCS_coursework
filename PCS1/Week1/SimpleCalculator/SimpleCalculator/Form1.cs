using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int answer = Convert.ToInt32(this.tbFirstNumber.Text) + Convert.ToInt32(this.tbSecondNumber.Text);
            this.lblAnswer.Text = "Answer: " + answer;
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            int answer = Convert.ToInt32(this.tbFirstNumber.Text) - Convert.ToInt32(this.tbSecondNumber.Text);
            this.lblAnswer.Text = "Answer: " + answer;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            int answer = Convert.ToInt32(this.tbFirstNumber.Text) * Convert.ToInt32(this.tbSecondNumber.Text);
            this.lblAnswer.Text = "Answer: " + answer;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(this.tbSecondNumber.Text);
            int num2 = Convert.ToInt32(this.tbSecondNumber.Text);
            if (num2 != 0)
            {
                int answer = num1 / num2;
                this.lblAnswer.Text = "Answer: " + answer;
            }
            else
            {
                this.lblAnswer.Text = "Division by 0 is not allowed!";
            }
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            this.btnHideInfo.Visible = true;
            this.tbInfo.Visible = true;
        }

        private void btnHideInfo_Click(object sender, EventArgs e)
        {
            this.btnHideInfo.Visible = false;
            this.tbInfo.Visible = false;
        }
    }
}
