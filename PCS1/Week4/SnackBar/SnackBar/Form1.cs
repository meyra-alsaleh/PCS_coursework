using System.Net.Http.Headers;

namespace SnackBar
{
    public partial class Form1 : Form
    {
        private Snack cajunFries;
        private Snack kibbeling;
        private Snack gimbap;
        public Form1()
        {
            InitializeComponent();
            cajunFries = new Snack("Cajun Fries", 4.99, 70, true);
            kibbeling = new Snack("Kibbeling", 8.89, 50, false);
            gimbap = new Snack("Gimbap", 12.99, 30, false);

        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            if (rbCajunFries.Checked)
            {
                this.lblSnackInfo.Text = cajunFries.GetInfo();
            }
            else if (rbKibbeling.Checked)
            {
                this.lblSnackInfo.Text = kibbeling.GetInfo();
            }
            else
            {
                this.lblSnackInfo.Text = gimbap.GetInfo();
            }
        }
    }
}
