namespace BMICalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Hook an event
            this.tbWeightKg.TextChanged += TextBoxes_TextChanged;
            this.tbHeightM.TextChanged += TextBoxes_TextChanged;

            this.btnCalculateBMI.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        // Event to enable the calculate button once the two values are input
        private void TextBoxes_TextChanged(object sender, EventArgs e)
        {
            this.btnCalculateBMI.Enabled = !string.IsNullOrWhiteSpace(this.tbWeightKg.Text) &&
                              !string.IsNullOrWhiteSpace(this.tbHeightM.Text);
        }

        private void btnCalculateBMI_Click(object sender, EventArgs e)
        {
            double bmi;

            // Calculate BMI
            bmi = Convert.ToDouble(this.tbWeightKg.Text) / Math.Pow(Convert.ToDouble(this.tbHeightM.Text), 2);

            // Result for BMI
            if (bmi < 18.5)
            {
                this.lblResult.Text = "You are: underweight";
                this.lblMessage.Text = "Your BMI is extremely low. Please contact your doctor, \r\nbecause your health is in danger!";
            }
            else if (bmi >= 18.5 && bmi < 25.0 )
            {
                this.lblResult.Text = "You are: normal weight";
                this.lblMessage.Text = "Your BMI is in the norm!";

            }
            else if (bmi >= 25.0 && bmi < 30.0)
            {
                this.lblResult.Text = "You are: overweight";
                this.lblMessage.Text = "Your BMI is higher than the norm. Please contact your doctor, \r\nfor any advice!";
            }
            else
            {
                this.lblResult.Text = "You are: obese";
                this.lblMessage.Text = "Your BMI is extremely high. Please contact your doctor, \r\nbecause your health is in danger!";
            }


                this.lblBMI.Text = "Your BMI is: " + bmi.ToString("0.00");
        }
    }
}
