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
    public partial class signUpPage : Form
    {
        public signUpPage()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            BusinessOwner businessOwner = new BusinessOwner();
            if (passwordBox.Text == passAgainBox.Text)
            {
                businessOwner.businessName = businessNameBox.Text;
                businessOwner.eMail = eMailBox.Text;
                businessOwner.name = nameBox.Text;
                businessOwner.surname = surnameBox.Text;
                businessOwner.password = passwordBox.Text;

                connection.Open();
                SqlCommand signUp = new SqlCommand("insert into businessOwner(Ad, Soyad, [Kulup Adi], eMail, Sifre) values (@Ad, @Soyad, @KulupAdi, @eMail, @Sifre)", connection);
                signUp.Parameters.AddWithValue("@Ad", businessOwner.name);
                signUp.Parameters.AddWithValue("@Soyad", businessOwner.surname);
                signUp.Parameters.AddWithValue("@eMail", businessOwner.eMail);
                signUp.Parameters.AddWithValue("@KulupAdi", businessOwner.businessName);
                signUp.Parameters.AddWithValue("@Sifre", businessOwner.password);

                this.Validate();
                this.membersBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.databaseDataSet);

                signUp.ExecuteNonQuery();
                connection.Close();

                Form entry = new Form1();
                entry.Show();
                this.Hide();
            }
            else
                passNotSameLbl.Visible = true;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Form entry = new Form1();
            entry.Show();
            this.Hide();
        }

        private void signUpPage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.businessOwner' table. You can move, or remove it, as needed.
            this.businessOwnerTableAdapter.Fill(this.databaseDataSet.businessOwner);
            this.businessOwnerBindingSource.AddNew();
        }

    }
}
