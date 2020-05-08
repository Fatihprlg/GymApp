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
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GROR92P;Initial Catalog=SporSalonu;Integrated Security=True");

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            BusinessOwner businessOwner = new BusinessOwner();
            if (passwordBox.Text == passAgainBox.Text)
            {
                businessOwner.businessName = businessNameBox.Text.ToString();
                businessOwner.eMail = eMailBox.Text.ToString();
                businessOwner.name = nameBox.Text.ToString();
                businessOwner.surname = surnameBox.Text.ToString();
                businessOwner.password = passwordBox.Text.ToString();

                connection.Open();
                SqlCommand addBusinessOwner = new SqlCommand("insert into businessOwner (Ad, Soyad, KulupAdi, eMail, Sifre) values (@b1,@b2,@b3,@b4,@b5)", connection);
                addBusinessOwner.Parameters.AddWithValue("@b1", businessOwner.name);
                addBusinessOwner.Parameters.AddWithValue("@b2", businessOwner.surname);
                addBusinessOwner.Parameters.AddWithValue("@b3", businessOwner.businessName);
                addBusinessOwner.Parameters.AddWithValue("@b4", businessOwner.eMail);
                addBusinessOwner.Parameters.AddWithValue("@b5", businessOwner.password);

                addBusinessOwner.ExecuteNonQuery();

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
    }
}
