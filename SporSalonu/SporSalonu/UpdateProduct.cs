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
    public partial class UpdateProduct : Form
    {
        public UpdateProduct()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void UpdateProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.databaseDataSet.Products);
            try
            {
                connection.Open();
                SqlCommand load = new SqlCommand("select * from Products where Id = @id", connection);
                load.Parameters.AddWithValue("@id", Products.productID.ToString());
                SqlDataReader sqlData = load.ExecuteReader();
                sqlData.Read();
                idTextBox.Text = sqlData["Id"].ToString();
                urun_AdiTextBox.Text = sqlData["Urun Adi"].ToString();
                fiyatiTextBox.Text = sqlData["Fiyati"].ToString();
                stokTextBox.Text = sqlData["Stok"].ToString();
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand update = new SqlCommand("update Products set [Urun Adi] = @urunAdi, Fiyati = @fiyat, Stok = @stok where Id = @id", connection);
                update.Parameters.AddWithValue("@id", idTextBox.Text);
                update.Parameters.AddWithValue("@urunAdi", urun_AdiTextBox.Text);
                update.Parameters.AddWithValue("@fiyat", fiyatiTextBox.Text);
                update.Parameters.AddWithValue("@stok", stokTextBox.Text);
                update.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            this.Hide();
        }
    }
}
