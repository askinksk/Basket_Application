namespace Project1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string ProductsText = "Ürünler";
            var addToCartbuttonText = "Sepete Ekle";
            var cartText = "Sepetiniz";
            var btnRemoveFromCartButtonText = "Sepetten Çýkart";


            btnRemoveFromCart.Text = btnRemoveFromCartButtonText;


            lblProducts.Text = ProductsText;
            btnAddToCart.Text = addToCartbuttonText;
            lblCart.Text = cartText;

            string[] products = new string[] { "Laptop", "Masaüstü", "Mouse", "Klavye" };

            foreach (string Ürün in products)
            {
                lbxProducts.Items.Add(Ürün);
            }

            if (lbxCart.Items.Count == 0)
            {
                btnRemoveFromCart.Enabled = false;
            }

            //for (int i = 0; i < products.Length; i++)
            //{
            //    lbxProducts.Items.Add(products[i]);
            //}

            /*lbxProducts.Items.Add(products[0]);
            lbxProducts.Items.Add(products[1]);
            lbxProducts.Items.Add(products[2]);
            lbxProducts.Items.Add(products[3]);*/
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            if (lbxProducts.SelectedItem != null)
            {
                lbxCart.Items.Add(lbxProducts.SelectedItem);
                btnRemoveFromCart.Enabled = true;
            }
            else
            {
                MessageBox.Show("Bir Ürün Seçiniz");
            }

        }

   

        private void btnRemoveFromCart_Click(object sender, EventArgs e)
        {


            if (lbxCart.SelectedItem != null)
            {
                lbxCart.Items.Remove(lbxCart.SelectedItem);
            }
            else
            {
                MessageBox.Show("Sepetten Çýkartmak Ýçin Ürün Seçiniz");
            }

            

        }
    }
}