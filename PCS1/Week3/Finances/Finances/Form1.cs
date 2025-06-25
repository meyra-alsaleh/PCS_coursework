namespace Finances
{
    public partial class Form1 : Form
    {
        private Wallet myWallet;
        public Form1()
        {
            InitializeComponent();

            myWallet = new Wallet();
        }

        private void btnSetOwner_Click(object sender, EventArgs e)
        {
            myWallet.SetOwnerName(this.tbOwnerName.Text);
        }

        private void btnShowInfo_Click(object sender, EventArgs e)
        {
            this.lblShowOwnerName.Text = "Wallet belongs to " + myWallet.GetOwnerName();
            this.lblShowAmountMoney.Text = "Amount of money is " + myWallet.GetAmountMoney() + " EURO";
        }

        private void btnAddMoney_Click(object sender, EventArgs e)
        {
            myWallet.AddMoney(Convert.ToInt32(this.numAddMoney.Value));
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            myWallet.WithdrawMoney(Convert.ToInt32(this.numAddMoney.Value));
        }
    }
}
