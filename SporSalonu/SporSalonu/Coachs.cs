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
    public partial class Coachs : Form
    {
        public Coachs()
        {
            InitializeComponent();
        }


        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");

        private void Coachs_Load(object sender, EventArgs e)
        {
            coachList.FullRowSelect = true;
            connection.Open();
            // TODO: This line of code loads data into the 'databaseDataSet.Coaches' table. You can move, or remove it, as needed.
            this.coachesTableAdapter.Fill(this.databaseDataSet.Coaches);
            SqlCommand load = new SqlCommand("select * from Coaches", connection);
            SqlDataReader dataReader = load.ExecuteReader();

            while (dataReader.Read())
            {
                CoachClass coach = new CoachClass();
                coach.name = dataReader["Ad"].ToString();
                coach.surname = dataReader["Soyad"].ToString();
                ListViewItem coachs = new ListViewItem();
                coachs.Text = dataReader["ID"].ToString();
                coachs.SubItems.Add(coach.name + " " + coach.surname);
                coachs.SubItems.Add(dataReader["Numara"].ToString());
                coachs.SubItems.Add(dataReader["eMail"].ToString());
                coachs.SubItems.Add(dataReader["Brans"].ToString());
                coachList.Items.Add(coachs);
            }
            connection.Close();
            
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void coachesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.coachesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.databaseDataSet);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddCoach addCoach = new AddCoach();
            addCoach.Show();
            this.Hide();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(coachList.FocusedItem.SubItems[1].ToString() + " Kisisini silmek istediginize emin misiniz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                connection.Open();
                SqlCommand delete = new SqlCommand("delete from Coaches where ID = '" + coachList.FocusedItem.Text + "'", connection);
                delete.ExecuteNonQuery();
                connection.Close();
                coachList.Items.Clear();
                Coachs_Load(sender, e);
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            UpdateCoach updateCoach = new UpdateCoach();
            updateCoach.Show();
            this.Hide();
        }
    }
}
