namespace Finances
{
    public partial class Form1 : Form
    {
        private Wallet myWallet;
        private Wallet otherWallet;
        public Form1()
        {
            InitializeComponent();

            myWallet = new Wallet();
            otherWallet = new Wallet();
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

        private void btnShowInfoOther_Click(object sender, EventArgs e)
        {
            this.lblShowOwnerNameOther.Text = "Wallet belongs to " + otherWallet.GetOwnerName();
            this.lblShowAmountMoneyOther.Text = "Amount of money is " + otherWallet.GetAmountMoney() + " EURO";
        }

        private void btnSetOwnerOther_Click(object sender, EventArgs e)
        {
            otherWallet.SetOwnerName(this.tbOwnerNameOther.Text);
        }

        private void btnAddMoneyOther_Click(object sender, EventArgs e)
        {
            otherWallet.AddMoney(Convert.ToInt32(this.numAddMoneyOther.Value));
        }

        private void btnWithdrawMoneyOther_Click(object sender, EventArgs e)
        {
            otherWallet.WithdrawMoney(Convert.ToInt32(this.numAddMoneyOther.Value));
        }

        private void btnTransferMyToOther_Click(object sender, EventArgs e)
        {
            int transferAmount = Convert.ToInt32(this.numTransferMoney.Value);

            if (transferAmount < 0)
            {
                MessageBox.Show("The transfer money amount cannot be negative");
            }
            else if (transferAmount > myWallet.GetAmountMoney())
            {
                MessageBox.Show("Your wallet does not have enough money to transfer");
            }
            else
            {
                myWallet.WithdrawMoney(transferAmount);
                otherWallet.AddMoney(transferAmount);
            }
        }

        private void btnTransferOtherToMy_Click(object sender, EventArgs e)
        {
            int transferAmount = Convert.ToInt32(this.numTransferMoney.Value);

            if (transferAmount < 0)
            {
                MessageBox.Show("The transfer money amount cannot be negative");
            }
            else if (transferAmount > otherWallet.GetAmountMoney())
            {
                MessageBox.Show("Your wallet does not have enough money to transfer");
            }
            else
            {
                otherWallet.WithdrawMoney(transferAmount);
                myWallet.AddMoney(transferAmount);
            }
        }
    }
}
