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
    public partial class MainMenu : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-GROR92P;Initial Catalog=SporSalonu;Integrated Security=True");
        public MainMenu()
        {
            InitializeComponent();

            dataViewer();
        }

        private void dataViewer()
        {
            SqlDataAdapter dataAdapter = new SqlDataAdapter("Select * from Members", connection);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            membersView.DataSource = dataSet.Tables[0];
        }
       
        private void newMemberBtn_Click(object sender, EventArgs e)
        {
            Form addMember = new addMember();
            addMember.Show();
            this.Hide();
        }
        string memberName;
        private void deleteMember_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand delete = new SqlCommand("Delete from Members where İsim = @memberName", connection);
            delete.Parameters.AddWithValue("@memberName", memberName);
            delete.ExecuteNonQuery();
            connection.Close();
            dataViewer();
        }

        private void membersView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedItem = membersView.SelectedCells[0].RowIndex;

             memberName = membersView.Rows[selectedItem].Cells[0].Value.ToString();
             
        }
    }
}
