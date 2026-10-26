namespace InventoryManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            txtProductName.Clear();
            txtQuantity.Clear();
            txtPrice.Clear();

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

            string name = txtProductName.Text;
            string quantity = txtQuantity.Text;
            string price = txtPrice.Text;

            MessageBox.Show("Product Added Successfully!\n" +
                            "Product Name: " + name + "\n" +
                            "Quantity: " + quantity + "\n" +
                            "Price: " + price);

        }
    }
}
