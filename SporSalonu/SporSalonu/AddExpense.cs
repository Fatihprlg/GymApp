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
    public partial class AddExpense : Form
    {
        public AddExpense()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void accountingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.accountingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void accountingBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.accountingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);

        }

        private void AddExpense_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseDataSet.Accounting' table. You can move, or remove it, as needed.
            this.accountingTableAdapter.Fill(this.databaseDataSet.Accounting);
            this.accountingBindingSource.AddNew();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand addIncome = new SqlCommand("insert into Accounting ([Giden Para], Açıklama, Tarih, Tahsil) values (@gidenPara, @aciklama, @tarih, @tahsil)", connection);
            addIncome.Parameters.AddWithValue("@gidenPara", float.Parse(giden_ParaTextBox.Text));
            addIncome.Parameters.AddWithValue("@aciklama", açıklamaTextBox.Text);
            addIncome.Parameters.AddWithValue("@tarih", tarihDateTimePicker.Value);
            if (tahsilCheckBox.Checked) addIncome.Parameters.AddWithValue("@tahsil", 1);
            else addIncome.Parameters.AddWithValue("@tahsil", 0);
            addIncome.ExecuteNonQuery();
            connection.Close();
            this.Hide();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
