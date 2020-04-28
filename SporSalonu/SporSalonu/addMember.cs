using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace SporSalonu
{
    public partial class addMember : Form
    {
        public addMember()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GROR92P;Initial Catalog=SporSalonu;Integrated Security=True");

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(nameBox.Text.ToString())))
            {
                Member member = new Member();
                
                while (true)
                {
                    switch (memberTypeCBox.SelectedIndex)
                    {
                        case 0:
                            member.subType = "Aylık";
                            break;
                        case 1:
                            member.subType = "Yıllık";
                            break;
                        case 2:
                            member.subType = "Premium";
                            break;
                        default:
                            MessageBox.Show("Üye tipi belirleyiniz");
                            break;
                    }
                    if (!string.IsNullOrEmpty(member.subType))
                        break;
                }
                member.isActive = true;
                member.name = nameBox.Text;
                member.surname = surnameBox.Text;
                member.phoneNumber = numBox.Text;
                member.about = aboutBox.Text;
                member.subscription = int.Parse(subscriptionBox.Text);
                member.eMail = eMailBox.Text;
                try
                {
                    
                    connection.Open();
                    SqlCommand addMemberCmd = new SqlCommand("insert into Members (İsim, Soyisim, Numara,  Mail, [Üyelik Tipi], Borç, Hakkında) values (@m1,@m2,@m3,@m4,@m5,@m6,@m7)", connection);
                    addMemberCmd.Parameters.AddWithValue("@m1", member.name);
                    addMemberCmd.Parameters.AddWithValue("@m2", member.surname);
                    addMemberCmd.Parameters.AddWithValue("@m3", member.phoneNumber);
                    addMemberCmd.Parameters.AddWithValue("@m4", member.eMail);
                    addMemberCmd.Parameters.AddWithValue("@m5", member.subType);
                    addMemberCmd.Parameters.AddWithValue("@m6", member.subscription);
                    addMemberCmd.Parameters.AddWithValue("@m7", member.about);

                    addMemberCmd.ExecuteNonQuery();

                    connection.Close();

                    Form mainMenu = new MainMenu();
                    mainMenu.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(member.subscription.ToString());
                    MessageBox.Show(member.surname);
                    

                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
