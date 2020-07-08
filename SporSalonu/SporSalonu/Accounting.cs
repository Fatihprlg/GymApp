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
    public partial class Accounting : Form
    {
        public Accounting()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void Accounting_Load(object sender, EventArgs e)
        {
            endDate.Value = startDate.Value.AddMonths(1);
            connection.Open();
            SqlCommand loadAcc = new SqlCommand("select * from Accounting where Tarih between @startDate and @endDate", connection);
            loadAcc.Parameters.AddWithValue("@startDate", startDate.Value);
            loadAcc.Parameters.AddWithValue("@endDate", endDate.Value);
            SqlDataReader readAcc = loadAcc.ExecuteReader();

            while (readAcc.Read())
            {
                ListViewItem accounting = new ListViewItem();
                accounting.Text = readAcc["Id"].ToString();
                if (float.Parse(readAcc["Gelen Para"].ToString()) == 0 || readAcc["Gelen Para"] == null) accounting.SubItems.Add("-" + readAcc["Giden Para"].ToString());
                else accounting.SubItems.Add(readAcc["Gelen Para"].ToString());
                if (readAcc["Müşteri"] == null) accounting.SubItems.Add("-");
                else accounting.SubItems.Add(readAcc["Müşteri"].ToString());
                accounting.SubItems.Add(readAcc["Açıklama"].ToString());
                accounting.SubItems.Add(readAcc["Tarih"].ToString());
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
            addExpense.Show();
            accountingList.Items.Clear();
            Accounting_Load(sender, e);
        }
    }
}
