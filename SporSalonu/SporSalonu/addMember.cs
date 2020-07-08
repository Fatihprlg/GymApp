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
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void saveBtn_Click(object sender, EventArgs e)
        {
            Member member = new Member();
            if (!(string.IsNullOrEmpty(adTextBox.Text)))
            {
               
                while (true)
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
                    if (!string.IsNullOrEmpty(member.subType))
                        break;
                }
                member.isActive = true;
                member.name = adTextBox.Text;
                member.surname = soyadTextBox.Text;
                member.phoneNumber = numaraTextBox.Text;
                member.about = hakkindaTextBox.Text;
                member.eMail = eMailTextBox.Text;
                member.subscription = int.Parse(borcTextBox.Text);

                
                try
                {
                    //this.memberInfoBindingSource.AddNew();
                    
                    connection.Open();
                    SqlCommand addMember = new SqlCommand("insert into Members(Ad, Soyad, Numara, [Uyelik Tipi], eMail, Borc, Hakkinda, Antrenor, Brans, Fotograf, Aktiflik, [Kayıt Tarihi]) values (@Ad, @Soyad, @Numara, @UyelikTipi, @eMail, @Borc, @Hakkinda, @Antrenor, @Brans, @Fotograf, @Aktiflik, @KayıtTarihi)", connection);
                    addMember.Parameters.AddWithValue("@Ad", member.name);
                    addMember.Parameters.AddWithValue("@Soyad", member.surname);
                    addMember.Parameters.AddWithValue("@Numara", member.phoneNumber);
                    addMember.Parameters.AddWithValue("@UyelikTipi", member.subType);
                    addMember.Parameters.AddWithValue("@eMail", member.eMail);
                    addMember.Parameters.AddWithValue("@Borc", member.subscription);
                    addMember.Parameters.AddWithValue("@Hakkinda", member.about);
                    addMember.Parameters.AddWithValue("@Antrenor", antrenorComboBox.SelectedIndex + 1);
                    addMember.Parameters.AddWithValue("@Brans", bransComboBox.SelectedIndex + 1);
                    addMember.Parameters.AddWithValue("@Fotograf", browseBox.Text);
                    addMember.Parameters.AddWithValue("@Aktiflik", 1);
                    addMember.Parameters.AddWithValue("@KayıtTarihi", DateTime.Now);


                    addMember.ExecuteNonQuery();
                    connection.Close();

                    connection.Open();
                    SqlCommand addMemberDetail = new SqlCommand("insert into memberInfo(TC, [Anne Adi], [Baba Adi], [Dogum Yeri], [Dogum Tarihi], Cinsiyet, Boy, Kilo) values (@TC, @AnneAdi, @BabaAdi, @DogumYeri, @DogumTarihi, @Cinsiyet, @Boy, @Kilo)", connection);
                    
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
                    this.Validate();
                    this.membersBindingSource.EndEdit();
                    this.memberInfoBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(this.databaseDataSet);

                    MainMenu mainMenu = new MainMenu();
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
            // TODO: This line of code loads data into the 'databaseDataSet.memberInfo' table. You can move, or remove it, as needed.
            this.memberInfoTableAdapter.Fill(this.databaseDataSet.memberInfo);
            // TODO: This line of code loads data into the 'databaseDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.databaseDataSet.Members);

            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand("select * from Coaches", connection);
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                    antrenorComboBox.Items.Add(reader["Ad"].ToString() + reader["Soyad"].ToString());

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
            

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
