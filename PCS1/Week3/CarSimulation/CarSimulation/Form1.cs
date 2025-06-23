using System.Drawing.Text;

namespace CarSimulation
{
    public partial class Form1 : Form
    {
        private Car myCar1;
        private Car myCar2;

        public Form1()
        {
            InitializeComponent();
            myCar1 = new Car();
            myCar2 = new Car();

        }

        private void btnAccelerate_Click(object sender, EventArgs e)
        {
            if (this.rbCar1.Checked)
            {
                myCar1.SpeedUp();
                this.lblCar1.Text = myCar1.AsAString();
            }
            else
            {
                myCar2.SpeedUp();
                this.lblCar2.Text = myCar2.AsAString();
            }
        }

        private void btnSetCarInfo_Click(object sender, EventArgs e)
        {
            myCar1.SetBrand(this.tbCar1Brand.Text);
            myCar1.SetMaxSpeed(Convert.ToInt32(this.numCar1MaxSpeed.Value));

            myCar2.SetBrand(this.tbCar2Brand.Text);
            myCar2.SetMaxSpeed(Convert.ToInt32(this.numCar2MaxSpeed.Value));

            this.lblCar1.Text = myCar1.AsAString();
            this.lblCar2.Text = myCar2.AsAString();
        }

        private void btnBreaks_Click(object sender, EventArgs e)
        {
            if (this.rbCar1.Checked)
            {
                myCar1.SlowDown();
                this.lblCar1.Text = myCar1.AsAString();
            }
            else
            {
                myCar2.SlowDown();
                this.lblCar2.Text = myCar2.AsAString();
            }
        }
    }
}
