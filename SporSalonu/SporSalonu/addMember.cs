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
                member.name = nameBox.Text.ToString();
                member.surname = surnameBox.Text.ToString();
                member.phoneNumber = numBox.Text.ToString();
                member.about = aboutBox.Text.ToString();

                connection.Open();
                SqlCommand addMember = new SqlCommand("insert into Member (İsim, Soyisim, Numara, Üyelik Tipi, Mail, Aidat, Hakkında) values (@m1,@m2,@m3,@m4,@m5,@m6,@m7)", connection);
                addMember.Parameters.AddWithValue("@m1", member.name);
                addMember.Parameters.AddWithValue("@m2", member.surname);
                addMember.Parameters.AddWithValue("@m3", member.phoneNumber);
                addMember.Parameters.AddWithValue("@m4", member.subType);
                addMember.Parameters.AddWithValue("@m5", member.eMail);
                addMember.Parameters.AddWithValue("@m6", member.subscription);
                addMember.Parameters.AddWithValue("@m7", member.about);

                addMember.ExecuteNonQuery();

                connection.Close();
            }
        }
    }
}
