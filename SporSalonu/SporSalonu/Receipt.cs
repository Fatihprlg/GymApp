using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonu
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");
        string musteri;
        string aciklama;
        string teslimAlan;
        float miktar;
        float toplam;
        
        private void Receipt_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand load = new SqlCommand("select * from Accounting where Id = @id", connection);
            load.Parameters.AddWithValue("@id", Accounting.accID);
            SqlDataReader loadReader = load.ExecuteReader();
            loadReader.Read();
            musteri = loadReader["Müşteri"].ToString();
            aciklama = loadReader["Açıklama"].ToString();
            toplam = float.Parse(loadReader["Gelen Para"].ToString());
            infoLbl.Text = musteri + aciklama;
            cashTextBox.Text = toplam.ToString();
            totalLbl.Text = "Toplam: " + toplam.ToString();
            connection.Close();

            connection.Open();
            SqlCommand sqlC = new SqlCommand("select Ad, Soyad from businessOwner", connection);
            SqlDataReader dataReader = sqlC.ExecuteReader();
            dataReader.Read();
            teslimAlan = dataReader["Ad"].ToString() + dataReader["Soyad"].ToString();
            connection.Close();

        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            miktar = float.Parse(cardTextBox.Text) + float.Parse(transferTextBox.Text) + float.Parse(cashTextBox.Text);
            if (miktar <= toplam)
            {
                saveFileDialog1.FileName = musteri + " " + aciklama + " Makbuz";
                saveFileDialog1.DefaultExt = "xlsx";
                saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != null)
                {
                    try
                    {
                        var filePath = Assembly.GetExecutingAssembly().CodeBase + "/../../../Resources/TAHSİLAT-MAKBUZU.xlsx";
                        Excel report = new Excel(filePath, 1);
                        report.WriteCell(4, 6, "Tarih: " + DateTime.Now.ToString("dd/MM/yyyy"));
                        report.WriteCell(6, 7, Accounting.accID.ToString());
                        report.WriteCell(8, 2, musteri);
                        report.WriteCell(8, 5, aciklama);
                        report.WriteCell(9, 5, miktar.ToString() + "TL");
                        report.WriteCell(11, 3, cardTextBox.Text);
                        report.WriteCell(12, 3, transferTextBox.Text);
                        report.WriteCell(13, 3, cashTextBox.Text);
                        report.WriteCell(15, 3, miktar.ToString() + "TL");
                        report.WriteCell(16, 3, musteri);
                        report.WriteCell(16, 7, teslimAlan);
                        report.SaveAs(saveFileDialog1.FileName);
                        report.Close();
                        if (MessageBox.Show("Makbuz kaydedildi. Açmak istiyor musunuz?", "İşlem Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                    connection.Open();
                    SqlCommand updateAcc = new SqlCommand("update Accounting set Tahsil = @tahsil where Id = @id", connection);
                    updateAcc.Parameters.AddWithValue("@tahsil", 1);
                    updateAcc.Parameters.AddWithValue("@id", Accounting.accID);
                    updateAcc.ExecuteNonQuery();
                    connection.Close();
                }
    
            }
            else
            {
                wrongLbl.Visible = true;
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
