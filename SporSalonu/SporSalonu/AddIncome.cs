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
    public partial class AddIncome : Form
    {
        public AddIncome()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");
        private void accountingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void AddIncome_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.databaseDataSet.Accounting);
            this.accountingBindingSource.AddNew();
            connection.Open();
            SqlCommand sqlCommand = new SqlCommand("select Id, Ad, Soyad from Members",connection);
            SqlDataReader sqlData = sqlCommand.ExecuteReader();
            while (sqlData.Read())
            {
                membersCBox.Items.Add(sqlData["Id"].ToString() + " " + sqlData["Ad"].ToString() + " " + sqlData["Soyad"].ToString());
            }
            connection.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand addIncome = new SqlCommand("insert into Accounting ([Gelen Para], Müşteri, Açıklama, Tarih, Tahsil) values (@gelenPara, @musteri, @aciklama, @tarih, @tahsil)", connection);
            addIncome.Parameters.AddWithValue("@gelenPara", float.Parse(gelen_ParaTextBox.Text));
            addIncome.Parameters.AddWithValue("@musteri", müşteriTextBox.Text);
            addIncome.Parameters.AddWithValue("@aciklama", açıklamaTextBox.Text);
            addIncome.Parameters.AddWithValue("@tarih", tarihDateTimePicker1.Value);
            if (tahsilCheckBox.Checked) addIncome.Parameters.AddWithValue("@tahsil", 1);
            else addIncome.Parameters.AddWithValue("@tahsil", 0);
            addIncome.ExecuteNonQuery();
            connection.Close();
            if (aidatChck.Checked)
            {
                connection.Open();
                SqlCommand sqlCommand = new SqlCommand("select Borc from Members where Id = @id", connection);
                sqlCommand.Parameters.AddWithValue("@id", membersCBox.SelectedItem.ToString().Substring(0,1));
                SqlDataReader sqlData = sqlCommand.ExecuteReader();
                sqlData.Read();
                float borc = float.Parse(sqlData["Borc"].ToString());
                connection.Close();

                connection.Open();
                SqlCommand aidat = new SqlCommand("update Members set Borc = @borc where Id = @id", connection);
                aidat.Parameters.AddWithValue("@borc", borc - float.Parse(gelen_ParaTextBox.Text));
                aidat.Parameters.AddWithValue("@id", membersCBox.SelectedItem.ToString().Substring(0, 1));
                aidat.ExecuteNonQuery();
                connection.Close();
            }

            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void aidatChck_CheckStateChanged(object sender, EventArgs e)
        {
            if (aidatChck.Checked)
            {
                müşteriTextBox.Visible = false;
                membersCBox.Visible = true;
            }
            else
            {
                müşteriTextBox.Visible = true;
                membersCBox.Visible = false;
            }
        }
    }
}
