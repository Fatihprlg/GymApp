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
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");
        public static int accID;
        private void Accounting_Load(object sender, EventArgs e)
        {
            endDate.Value = DateTime.Now.AddDays(1);
            startDate.Value = endDate.Value.AddMonths(-1);
            connection.Open();
            SqlCommand loadAcc = new SqlCommand("select * from Accounting where Tarih between @startDate and @endDate", connection);
            loadAcc.Parameters.AddWithValue("@startDate", startDate.Value);
            loadAcc.Parameters.AddWithValue("@endDate", endDate.Value);
            SqlDataReader readAcc = loadAcc.ExecuteReader();
            
            while (readAcc.Read())
            {
                ListViewItem accounting = new ListViewItem();
                accounting.Text = readAcc["Id"].ToString();
                if (readAcc["Gelen Para"].ToString() == "0" || String.IsNullOrEmpty(readAcc["Gelen Para"].ToString())) accounting.SubItems.Add("-" + readAcc["Giden Para"].ToString());
                else accounting.SubItems.Add(readAcc["Gelen Para"].ToString());
                if (readAcc["Müşteri"] == null) accounting.SubItems.Add("-");
                else accounting.SubItems.Add(readAcc["Müşteri"].ToString());
                accounting.SubItems.Add(readAcc["Açıklama"].ToString());
                accounting.SubItems.Add(readAcc["Tarih"].ToString());
                
                if (readAcc["Tahsil"].ToString() == "1" && (readAcc["Giden Para"].ToString() == "0" || String.IsNullOrEmpty(readAcc["Giden Para"].ToString())))
                {
                    accounting.SubItems.Add("Alındı");
                    accounting.BackColor = Color.FromArgb(208, 235, 255);
                }
                else if (readAcc["Tahsil"].ToString() == "1" && !(readAcc["Giden Para"].ToString() == "0" || String.IsNullOrEmpty(readAcc["Giden Para"].ToString())))
                {
                    accounting.SubItems.Add("Verildi");
                    accounting.BackColor = Color.FromArgb(208, 235, 255);
                }
                else if(readAcc["Tahsil"].ToString() == "0" && (readAcc["Giden Para"].ToString() == "0" || String.IsNullOrEmpty(readAcc["Giden Para"].ToString())))
                {
                    accounting.SubItems.Add("Alınmadı");
                    accounting.BackColor = Color.LightCoral;
                }
                else if (readAcc["Tahsil"].ToString() == "0" && !(readAcc["Giden Para"].ToString() == "0" || String.IsNullOrEmpty(readAcc["Giden Para"].ToString())))
                {
                    accounting.SubItems.Add("Verilmedi");
                    accounting.BackColor = Color.LightCoral;
                }
                accountingList.Items.Add(accounting);
            }
            connection.Close();
            
        }

        private void incomeBtn_Click(object sender, EventArgs e)
        {
            AddIncome addIncome = new AddIncome();
            addIncome.Show();
            accountingList.Items.Clear();
            Accounting_Load(sender, e);
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            connection.Dispose();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void expenseBtn_Click(object sender, EventArgs e)
        {
            AddExpense addExpense = new AddExpense();
            addExpense.ShowDialog();
            accountingList.Items.Clear();
            Accounting_Load(sender, e);
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "Rapor";
            saveFileDialog1.DefaultExt = "xlsx";
            saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            saveFileDialog1.ShowDialog();
            try
            {
                var filePath = Assembly.GetExecutingAssembly().CodeBase + "/../../../Resources/GelirGiderRapor.xlsx";
                int j = 0;
                Excel reportIncome = new Excel(filePath, 2);
                for (int i = 0; i < accountingList.Items.Count; i++)
                {
                    if (float.Parse(accountingList.Items[i].SubItems[1].Text) > 0)
                    {
                        reportIncome.WriteCell(j + 3, 1, accountingList.Items[i].SubItems[3].Text);
                        reportIncome.WriteCell(j + 3, 2, accountingList.Items[i].SubItems[1].Text);
                        j++;
                    }
                }
                reportIncome.SaveAs(saveFileDialog1.FileName);
                reportIncome.Close();
                j = 0;
                Excel reportExpense = new Excel(saveFileDialog1.FileName, 3);
                for (int i = 0; i < accountingList.Items.Count; i++)
                {
                    if (float.Parse(accountingList.Items[i].SubItems[1].Text) < 0)
                    {
                        reportExpense.WriteCell(j + 3, 1, accountingList.Items[i].SubItems[3].Text);
                        reportExpense.WriteCell(j + 3, 2, accountingList.Items[i].SubItems[1].Text.Substring(1));
                        j++;
                    }
                }
                reportExpense.Save();
                reportExpense.Close();
                if (MessageBox.Show("Rapor kaydedildi. Açmak istiyor musunuz?", "İşlem Başarılı", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
                    catch (Exception ex1)
                    {
                        MessageBox.Show(ex1.Message);
                    }
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message);
            }
        }

        private void accountingList_MouseClick(object sender, MouseEventArgs e)
        {
            accID = int.Parse(accountingList.SelectedItems[0].SubItems[0].Text);
            if (float.Parse(accountingList.SelectedItems[0].SubItems[1].Text) > 0)
            {
                receiptBtn.Enabled = true;
            }
            else
            {
                receiptBtn.Enabled = false;
            }
        }

        private void receiptBtn_Click(object sender, EventArgs e)
        {
            Receipt receipt = new Receipt();
            receipt.ShowDialog();
            Accounting_Load(sender, e);
        }
    }
}
