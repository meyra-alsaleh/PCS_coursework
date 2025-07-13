namespace ProductInventory
{
    public partial class Form1 : Form
    {
        private Product product;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSetInStock_Click(object sender, EventArgs e)
        {
            product = new Product(this.tbName.Text, Convert.ToDouble(this.tbPrice.Text));
            product.SetInStock();
        }

        private void btnGetInfo_Click(object sender, EventArgs e)
        {
            this.lblProductInfo.Text = product.GetInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.lblTotalPrice.Text = "Total Price: " + product.CalculatePrice(Convert.ToInt32(this.numQuantity.Value));
        }
    }
}
