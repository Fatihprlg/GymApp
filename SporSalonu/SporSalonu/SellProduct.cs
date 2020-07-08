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
    public partial class SellProduct : Form
    {
        public SellProduct()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void sellBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sellBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void SellProduct_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Sell' table. You can move, or remove it, as needed.
            this.sellTableAdapter.Fill(this.databaseDataSet.Sell);
            this.sellBindingSource.AddNew();
            connection.Open();
            SqlCommand loadProducts = new SqlCommand("select [Urun Adi] from Products", connection);
            SqlDataReader productsReader = loadProducts.ExecuteReader();

            while(productsReader.Read())
                ürün_AdıComboBox.Items.Add(productsReader["Urun Adi"].ToString());

        }

        private void adetTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("select Fiyati from Products where Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", ürün_AdıComboBox.SelectedIndex + 1);
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                dataReader.Read();
                float totalPrice = float.Parse(dataReader["Fiyati"].ToString()) * int.Parse(adetTextBox.Text);
                toplam_FiyatLabel1.Text = totalPrice.ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sellBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
            if (mnyCheck.Checked)
            {
                connection.Open();
                SqlCommand addAcc = new SqlCommand("insert into Accounting ([Gelen Para], Müşteri, Açıklama, Tarih) values (@gelenPara, @musteri, @aciklama, @tarih)", connection);
                addAcc.Parameters.AddWithValue("@gelenPara", float.Parse(toplam_FiyatLabel1.Text));
                addAcc.Parameters.AddWithValue("@musteri", müşteriTextBox.Text);
                addAcc.Parameters.AddWithValue("@aciklama", ürün_AdıComboBox.SelectedValue.ToString() + "satışı");
                addAcc.Parameters.AddWithValue("@tarih", satış_TarihiDateTimePicker.Value);
                addAcc.ExecuteNonQuery();
                connection.Close();
            }
        }

        private void ürün_AdıComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ürün_IDTextBox.Text = (ürün_AdıComboBox.SelectedIndex + 1).ToString();
        }
    }
}
