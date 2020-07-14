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
    public partial class Form1 : Form
    {

        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");
        List<BusinessOwner> owners = new List<BusinessOwner>();
        public Form1()
        {
            InitializeComponent();
            remember();
        }

        private void remember()
        {
            if(Properties.Settings.Default.remme == true)
            {
                eMailTextBox.Text = Properties.Settings.Default.Username;
                passwordTextBox.Text = Properties.Settings.Default.Password;
                remindMeChck.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Coaches' table. You can move, or remove it, as needed.
            this.coachesTableAdapter.Fill(this.databaseDataSet.Coaches);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void enterBtn_Click_1(object sender, EventArgs e)
        {
            connection.Open();

            SqlCommand sqlCommand = new SqlCommand("Select * from businessOwner", connection);
            SqlDataReader sqlData = sqlCommand.ExecuteReader();


            int sayac = 0;

            while (sayac == owners.Count)
            {
                BusinessOwner businessOwner = new BusinessOwner();

                while (sqlData.Read())
                {
                    businessOwner.name = sqlData["Ad"].ToString();
                    businessOwner.surname = sqlData["Soyad"].ToString();
                    businessOwner.password = sqlData["Sifre"].ToString();
                    businessOwner.businessName = sqlData["Kulup Adi"].ToString();
                    businessOwner.eMail = sqlData["eMail"].ToString();
                    owners.Add(businessOwner);
                    break;
                }
                sayac++;
            }


            connection.Close();
            foreach (BusinessOwner o in owners)
            {
                if ((eMailTextBox.Text.ToString() == o.eMail.Trim()) && (passwordTextBox.Text == o.password.Trim()))
                {
                    if (remindMeChck.CheckState == CheckState.Checked)
                    {
                        Properties.Settings.Default.Username = eMailTextBox.Text;
                        Properties.Settings.Default.Password = passwordTextBox.Text;
                        Properties.Settings.Default.remme = true;
                        Properties.Settings.Default.Save();
                    }
                    else
                    {
                        Properties.Settings.Default.Username = "";
                        Properties.Settings.Default.Password = "";
                        Properties.Settings.Default.remme = false;
                        Properties.Settings.Default.Save();
                    }
                    Form mainMenu = new MainMenu();
                    mainMenu.Show();
                    this.Hide();
                    break;
                }
                else
                {
                    MessageBox.Show("E Mail veya şifre Yanlış");
                    break;
                }
            }
        }

        private void signUpBtn_Click_1(object sender, EventArgs e)
        {
            Form signUp = new signUpPage();
            signUp.Show();
            this.Hide();
        }

    }
}
