using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonu
{
    public partial class Products : Form
    {
        public Products()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");
        public static int productID;


        private void Products_Load(object sender, EventArgs e)
        {
            productsList.FullRowSelect = true;
            connection.Open();
            SqlCommand loadProducts = new SqlCommand("select * from Products",connection);
            SqlDataReader readProducts = loadProducts.ExecuteReader();

            while (readProducts.Read())
            {
                ListViewItem product = new ListViewItem();
                product.Text = readProducts["Id"].ToString();
                product.SubItems.Add(readProducts["Urun Adi"].ToString());
                product.SubItems.Add(readProducts["Fiyati"].ToString());
                product.SubItems.Add(readProducts["Stok"].ToString());
                productsList.Items.Add(product);
            }
            connection.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(productsList.FocusedItem.SubItems[1].ToString() + "Urunu silinecektir. Onaylıyor musunuz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand deleteProduct = new SqlCommand("delete from Products where Id = @id", connection);
                    deleteProduct.Parameters.AddWithValue("@id", productID);
                    deleteProduct.ExecuteNonQuery();
                    connection.Close();
                    productsList.Items.Clear();
                    Products_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void productsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            productID = int.Parse(productsList.SelectedItems[0].SubItems[0].Text);
        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.ShowDialog();
            productsList.Items.Clear();
            Products_Load(sender, e);
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            SellProduct sellProduct = new SellProduct();
            sellProduct.Show();
        }
    }
}
