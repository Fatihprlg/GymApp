using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
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
        string kulupAdi = "";
        public static string ad;
        public static string soyad;
        public static string brans;
        public static string dogumTarihi;
        public static string foto;
        private void MemberDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.databaseDataSet.Members);


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
                MessageBox.Show(ex2.Message + "comboboxes");
            }
            try
            {
                connection.Open();
                SqlCommand memberDetail = new SqlCommand("select * from Members where Id = @id", connection);
                memberDetail.Parameters.AddWithValue("@id", MainMenu.memberID);
                SqlDataReader detailReader = memberDetail.ExecuteReader();
                if (detailReader.Read())
                {
                    adTextBox.Text = detailReader["Ad"].ToString();
                    ad = adTextBox.Text;
                    soyadTextBox.Text = detailReader["Soyad"].ToString();
                    soyad = soyadTextBox.Text;
                    numaraTextBox.Text = detailReader["Numara"].ToString();
                    uyelikTipiComboBox.Text = detailReader["Uyelik Tipi"].ToString();
                    eMailTextBox.Text = detailReader["eMail"].ToString();
                    aidatTextBox.Text = detailReader["Aidat"].ToString();
                    hakkindaTextBox.Text = detailReader["Hakkinda"].ToString();
                    antrenorComboBox.SelectedIndex = int.Parse(detailReader["Antrenor"].ToString()) - 1;
                    bransComboBox.SelectedIndex = int.Parse(detailReader["Brans"].ToString()) - 1;
                    brans = bransComboBox.SelectedItem.ToString();
                    browseBox.Text = detailReader["Fotograf"].ToString();
                    foto = browseBox.Text;
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
                    DateTime date = Convert.ToDateTime(detailReader["Kayıt Tarihi"]);
                    dogumTarihi = date.ToString("dd/MM/yyyy");
                    kayitTarihiLbl.Text = "Kayıt Tarihi : " + date.ToString("dd/MM/yyyy");
                    adresTextBox.Text = detailReader["Adres"].ToString();
                }
                memberDetail.Dispose();
                
                connection.Close();
                connection.Open();
                SqlCommand memberInfo = new SqlCommand("select * from memberInfo where Id = @id", connection);
                memberInfo.Parameters.AddWithValue("@id", MainMenu.memberID);
                SqlDataReader infoReader = memberInfo.ExecuteReader();
                if (infoReader.Read())
                {
                    tCTextBox.Text = infoReader["TC"].ToString();
                    anne_AdiTextBox.Text = infoReader["Anne Adi"].ToString();
                    baba_AdiTextBox.Text = infoReader["Baba Adi"].ToString();
                    dogum_YeriTextBox.Text = infoReader["Dogum Yeri"].ToString();
                    dogumTarihiDateTimePicker.Value = Convert.ToDateTime(infoReader["Dogum Tarihi"]);
                    cinsiyet_TextBox.Text = infoReader["Cinsiyet"].ToString();
                    boyTextBox.Text = infoReader["Boy"].ToString();
                    kiloTextBox.Text = infoReader["Kilo"].ToString();

                    pictureBox1.ImageLocation = browseBox.Text;
                }
                memberInfo.Dispose();
                connection.Close();
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message + ex3.InnerException + ex3.Source);
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
                member.subscription = int.Parse(aidatTextBox.Text);


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
            saveFileDialog1.FileName = adTextBox.Text + " Lisans";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            if (saveFileDialog1.FileName != null)
            {
                try
                {
                    var filePath = Assembly.GetExecutingAssembly().CodeBase + "/../../../Resources/bosLisans.xlsx";
                    Excel license = new Excel(filePath, 1);
                    license.WriteCell(0, 1, bransComboBox.SelectedItem.ToString());
                    license.WriteCell(1, 1, kulupAdi);
                    license.WriteCell(2, 1, tCTextBox.Text);
                    license.WriteCell(3, 1, adTextBox.Text);
                    license.WriteCell(4, 1, soyadTextBox.Text);
                    license.WriteCell(5, 1, dogum_YeriTextBox.Text);
                    license.WriteCell(7, 1, cinsiyet_TextBox.Text);
                    license.WriteCell(8, 1, baba_AdiTextBox.Text);
                    license.WriteCell(9, 1, anne_AdiTextBox.Text);
                    license.WriteCell(10, 1, dogum_YeriTextBox.Text);
                    license.WriteCell(16, 1, adresTextBox.Text);
                    license.WriteCell(11, 1, dogumTarihiDateTimePicker.Value.ToString("dd/MM/yyyy"));
                    license.WriteCell(21, 1, numaraTextBox.Text);
                    license.WriteCell(22, 1, eMailTextBox.Text);
                    license.SaveAs(saveFileDialog1.FileName);
                    license.Close();
                    if (MessageBox.Show("Lisans kaydedildi. Açmak istiyor musunuz?", "İşlem Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            string fileName = saveFileDialog1.FileName;
                            if (!fileName.Contains(".xlsx"))
                            {
                                fileName += ".xlsx";
                            }
                            var process = new System.Diagnostics.Process();
                            process.StartInfo = new System.Diagnostics.ProcessStartInfo() { UseShellExecute = true, FileName = fileName };
                            process.Start();
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
           



        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void cardBtn_Click(object sender, EventArgs e)
        {
            CardForm cardForm = new CardForm();
            cardForm.Show();
            this.Hide();
        }
    }
}
