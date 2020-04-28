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
        
        public static string remindEMail;
        public static string remindPassword;
        string eMail;
        string password;

        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GROR92P;Initial Catalog=SporSalonu;Integrated Security=True");
        List<BusinessOwner> owners = new List<BusinessOwner>();
        public Form1()
        {
            InitializeComponent();
            eMailTextBox.Text = remindEMail;
            passwordTextBox.Text = remindPassword;


        }


        private void enterBtn_Click(object sender, EventArgs e)
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
                    businessOwner.name = sqlData["İsim"].ToString();
                    businessOwner.surname = sqlData["Soyisim"].ToString();
                    businessOwner.password = sqlData["Şifre"].ToString();
                    businessOwner.businessName = sqlData["İşletme Adı"].ToString();
                    businessOwner.eMail = sqlData["Mail"].ToString();
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
                    if (remindMeChck.Checked == true)
                    {
                        remindEMail = eMailTextBox.Text.ToString();
                        remindPassword = passwordTextBox.Text.ToString();
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

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            Form signUp = new signUpPage();
            signUp.Show();
            this.Hide();
        }

     
    }
}
