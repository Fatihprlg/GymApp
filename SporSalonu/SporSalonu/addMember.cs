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
            Member member = new Member();
            if (!(string.IsNullOrEmpty(nameBox.Text)))
            {
               
                while (true)
                {
                    switch (memberTypeBox.SelectedIndex)
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
                member.eMail = eMailBox.Text;
                member.subscription = int.Parse(subscriptionBox.Text);

                
                try
                {
                    connection.Open();
                    SqlCommand addMember = new SqlCommand("insert into Members (Ad, Soyad, Numara, UyelikTipi, eMail, Borc, Hakkinda, Antrenor, BranşID, photoUrl) values (@m1,@m2,@m3,@m4,@m5,@m6,@m7,@m8,@m9,@m10)", connection);
                    addMember.Parameters.AddWithValue("@m1", member.name);
                    addMember.Parameters.AddWithValue("@m2", member.surname);
                    addMember.Parameters.AddWithValue("@m3", member.phoneNumber);
                    addMember.Parameters.AddWithValue("@m4", member.subType);
                    addMember.Parameters.AddWithValue("@m5", member.eMail);
                    addMember.Parameters.AddWithValue("@m6", member.subscription);
                    addMember.Parameters.AddWithValue("@m7", member.about);
                    addMember.Parameters.AddWithValue("@m8", comboBox1.SelectedIndex + 1);
                    addMember.Parameters.AddWithValue("@m9", comboBox2.SelectedIndex + 1);
                    addMember.Parameters.AddWithValue("@m10", browseBox.Text);

                    SqlCommand addMemberDetail = new SqlCommand("insert into MemberInfo (TC_ID, AnneAdi, BabaAdi, DogumYeri, DogumTarihi, Cinsiyet, Boy, Kilo) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)");
                    addMemberDetail.Parameters.AddWithValue("@p1", tckBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@p2", motherNameBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@p3", fatherNameBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@p4", birthPlaceBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@p5", birthDateT.Value);
                    addMemberDetail.Parameters.AddWithValue("@p6", genderBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@p7", lengthBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@p8", kiloBox.Text);

                    addMemberDetail.ExecuteNonQuery();
                    addMember.ExecuteNonQuery();

                    connection.Close();

                    Form mainMenu = new MainMenu();
                    mainMenu.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            browseBox.Text = openFileDialog1.FileName;
        }

        private void addMember_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from coachs", connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
                comboBox1.Items.Add(reader["Ad"].ToString() + reader["Soyad"].ToString());

            connection.Close();
            connection.Open();

            SqlCommand command2 = new SqlCommand("select * from branches", connection);
            SqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
                comboBox2.Items.Add(reader2["Branch"].ToString());

            connection.Close();

        }
    }
}
