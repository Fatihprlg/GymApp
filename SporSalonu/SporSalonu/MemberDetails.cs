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
    public partial class MemberDetails : Form
    {
        public MemberDetails()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");
        Member member = new Member();

        private void MemberDetails_Load(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Coaches", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    antrenorComboBox.Items.Add(reader["Ad"].ToString() + " " + reader["Soyad"].ToString());

                connection.Close();
                connection.Open();

                SqlCommand command2 = new SqlCommand("select * from Branches", connection);
                SqlDataReader reader2 = command2.ExecuteReader();

                while (reader2.Read())
                    bransComboBox.Items.Add(reader2["Brans Adi"].ToString());

                connection.Close();
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
            try
            {
                connection.Open();
                SqlCommand memberDetail = new SqlCommand("select * from Members where Id = @id", connection);
                memberDetail.Parameters.AddWithValue("@id", MainMenu.memberID);
                SqlDataReader detailReader = memberDetail.ExecuteReader();
                while (detailReader.Read())
                {
                    adTextBox.Text = detailReader["Ad"].ToString();
                    soyadTextBox.Text = detailReader["Soyad"].ToString();
                    numaraTextBox.Text = detailReader["Numara"].ToString();
                    uyelikTipiComboBox.Text = detailReader["Uyelik Tipi"].ToString();
                    eMailTextBox.Text = detailReader["eMail"].ToString();
                    borcTextBox.Text = detailReader["Borc"].ToString();
                    hakkindaTextBox.Text = detailReader["Hakkinda"].ToString();
                    antrenorComboBox.Text = detailReader["Antrenor"].ToString();
                    bransComboBox.Text = detailReader["Brans"].ToString();
                    browseBox.Text = detailReader["Fotograf"].ToString();
                    if (detailReader["Aktiflik"].ToString() == "1")
                    {
                        aktiflikCheck.Text = "Aktif";
                        aktiflikCheck.Checked = true;
                    }
                    else
                    {
                        aktiflikCheck.Text = "Aktif Degil";
                        aktiflikCheck.Checked = false;
                    }
                    kayitTarihiLbl.Text = "Kayıt Tarihi : " + detailReader["Kayıt Tarihi"].ToString();
                }

                connection.Close();
                connection.Open();
                SqlCommand memberInfo = new SqlCommand("select * from memberInfo where Id = @id", connection);
                memberInfo.Parameters.AddWithValue("@id", MainMenu.memberID);
                SqlDataReader infoReader = memberInfo.ExecuteReader();
                while (infoReader.Read())
                {
                    tCTextBox.Text = infoReader["TC"].ToString();
                    anne_AdiTextBox.Text = infoReader["Anne Adi"].ToString();
                    baba_AdiTextBox.Text = infoReader["Baba Adi"].ToString();
                    dogum_YeriTextBox.Text = infoReader["Dogum Yeri"].ToString();
                    dogumTarihiDateTimePicker.Value = (DateTime)infoReader["Dogum Tarihi"];
                    cinsiyet_TextBox.Text = infoReader["Cinsiyet"].ToString();
                    boyTextBox.Text = infoReader["Boy"].ToString();
                    kiloTextBox.Text = infoReader["Kilo"].ToString();

                    pictureBox1.ImageLocation = browseBox.Text;
                }

                connection.Close();
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
         
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.ImageLocation = openFileDialog1.FileName;
            browseBox.Text = openFileDialog1.FileName;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(adTextBox.Text)))
            {


                member.isActive = aktiflikCheck.Checked;
                member.name = adTextBox.Text;
                member.surname = soyadTextBox.Text;
                member.phoneNumber = numaraTextBox.Text;
                member.about = hakkindaTextBox.Text;
                member.eMail = eMailTextBox.Text;
                member.subscription = int.Parse(borcTextBox.Text);


                try
                {
                    connection.Open();
                    SqlCommand addMember = new SqlCommand("update Members set Ad = @ad, Soyad = @soyad, Numara = @numara, [Uyelik Tipi] = @uyelikTipi, eMail = @eMail, Borc = @borc, Hakkinda = @hakkinda, Antrenor = @antrenor, Brans = @brans, Fotograf = @foto, Aktiflik = @aktiflik where ID = '" + MainMenu.memberID + "'", connection);
                    addMember.Parameters.AddWithValue("@ad", member.name);
                    addMember.Parameters.AddWithValue("@soyad", member.surname);
                    addMember.Parameters.AddWithValue("@numara", member.phoneNumber);
                    addMember.Parameters.AddWithValue("@uyelikTipi", member.subType);
                    addMember.Parameters.AddWithValue("@eMail", member.eMail);
                    addMember.Parameters.AddWithValue("@borc", member.subscription);
                    addMember.Parameters.AddWithValue("@hakkinda", member.about);
                    addMember.Parameters.AddWithValue("@antrenor", antrenorComboBox.SelectedIndex + 1);
                    addMember.Parameters.AddWithValue("@brans", bransComboBox.SelectedIndex + 1);
                    addMember.Parameters.AddWithValue("@foto", browseBox.Text);
                    if (member.isActive) addMember.Parameters.AddWithValue("@aktiflik", 1);
                    else addMember.Parameters.AddWithValue("@aktiflik", 0);

                    addMember.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    SqlCommand addMemberDetail = new SqlCommand("Update memberInfo set TC = @TC, [Anne Adi] = @AnneAdi, [Baba Adi] = @BabaAdi, [Dogum Yeri] = @BabaAdi, [Dogum Tarihi] = @DogumTarihi, Cinsiyet = @Cinsiyet, Boy = @Boy, Kilo = @Kilo where ID = '" + MainMenu.memberID + "'", connection);

                    addMemberDetail.Parameters.AddWithValue("@TC", tCTextBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@AnneAdi", anne_AdiTextBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@BabaAdi", baba_AdiTextBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@DogumYeri", dogum_YeriTextBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@DogumTarihi", dogumTarihiDateTimePicker.Value);
                    addMemberDetail.Parameters.AddWithValue("@Cinsiyet", cinsiyet_TextBox.Text);
                    addMemberDetail.Parameters.AddWithValue("@Boy", int.Parse(boyTextBox.Text));
                    addMemberDetail.Parameters.AddWithValue("@Kilo", int.Parse(kiloTextBox.Text));


                    addMemberDetail.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void aktiflikCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (aktiflikCheck.Checked == true)
            {
                aktiflikCheck.Text = "Aktif";
            }
            else
            {
                aktiflikCheck.Text = "Aktif Değil";
            }
        }

        private void uyelikTipiComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

                switch (uyelikTipiComboBox.SelectedIndex)
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
        }

        private void licenceBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
