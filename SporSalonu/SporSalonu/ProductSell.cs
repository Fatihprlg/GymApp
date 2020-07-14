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
    public partial class ProductSell : Form
    {
        public ProductSell()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");
        string stokSayisi;
        private void ProductSell_Load(object sender, EventArgs e)
        {
            satış_TarihiDateTimePicker.Value = DateTime.Now;
            // TODO: This line of code loads data into the 'databaseDataSet.Sell' table. You can move, or remove it, as needed.
            this.sellTableAdapter.Fill(this.databaseDataSet.Sell);
            this.sellBindingSource.AddNew();
            connection.Open();
            SqlCommand loadProducts = new SqlCommand("select [Urun Adi] from Products", connection);
            SqlDataReader productsReader = loadProducts.ExecuteReader();

            while (productsReader.Read())
                ürün_AdıComboBox.Items.Add(productsReader["Urun Adi"].ToString());
            connection.Close();
        }

        private void sellBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(adetTextBox.Text) <= int.Parse(stokSayisi))
                {
                    connection.Open();
                    SqlCommand addSell = new SqlCommand("insert into Sell ([Satış Tarihi], [Ürün ID], [Ürün Adı], Adet, [Toplam Fiyat], Müşteri) values (@tarih, @id, @urunAdi, @adet, @toplamFiyat, @musteri)", connection);
                    addSell.Parameters.AddWithValue("@tarih", satış_TarihiDateTimePicker.Value);
                    addSell.Parameters.AddWithValue("@id", int.Parse(ürün_IDTextBox.Text));
                    addSell.Parameters.AddWithValue("@urunAdi", ürün_AdıComboBox.SelectedItem.ToString());
                    addSell.Parameters.AddWithValue("@adet", adetTextBox.Text);
                    addSell.Parameters.AddWithValue("@toplamFiyat", float.Parse(toplam_FiyatLabel1.Text));
                    addSell.Parameters.AddWithValue("@musteri", müşteriTextBox.Text);
                    addSell.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    SqlCommand addAcc = new SqlCommand("insert into Accounting ([Gelen Para], Müşteri, Açıklama, Tarih, Tahsil) values (@gelenPara, @musteri, @aciklama, @tarih, @tahsil)", connection);
                    addAcc.Parameters.AddWithValue("@gelenPara", float.Parse(toplam_FiyatLabel1.Text));
                    addAcc.Parameters.AddWithValue("@musteri", müşteriTextBox.Text);
                    addAcc.Parameters.AddWithValue("@aciklama", ürün_AdıComboBox.SelectedItem.ToString() + "satışı");
                    addAcc.Parameters.AddWithValue("@tarih", satış_TarihiDateTimePicker.Value);
                    if (mnyCheck.Checked) addAcc.Parameters.AddWithValue("@tahsil", 1);
                    else addAcc.Parameters.AddWithValue("@tahsil", 0);
                    addAcc.ExecuteNonQuery();
                    connection.Close();
                    connection.Open();
                    SqlCommand stok = new SqlCommand("update Products set Stok = @stok where Id = @id", connection);
                    stok.Parameters.AddWithValue("@stok", int.Parse(stokSayisi) - 1);
                    stok.Parameters.AddWithValue("@id", ürün_IDTextBox.Text);
                    stok.ExecuteNonQuery();
                    connection.Close();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Yetersiz stok. Stok sayısı = " + stokSayisi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ürün_AdıComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand readID = new SqlCommand("select Id, Stok from Products where [Urun Adi] = @urunAdi", connection);
            readID.Parameters.AddWithValue("@urunAdi", ürün_AdıComboBox.SelectedItem.ToString());
            SqlDataReader dataReader = readID.ExecuteReader();
            dataReader.Read();
            stokSayisi = dataReader["Stok"].ToString();
            ürün_IDTextBox.Text = dataReader["Id"].ToString();
            connection.Close();
        }

        private void adetTextBox_Leave(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("select Id from Products where [Urun Adi] = @urunAdi", connection);
                sqlCommand1.Parameters.AddWithValue("@urunAdi", ürün_AdıComboBox.SelectedItem.ToString());
                SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
                sqlDataReader.Read();
                string urunID = sqlDataReader["Id"].ToString();
                connection.Close();
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("select Fiyati from Products where Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", urunID);
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
