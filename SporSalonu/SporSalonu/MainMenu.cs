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
            
            
        }
       
        private void newMemberBtn_Click(object sender, EventArgs e)
        {
            addMember addMember = new addMember();
            addMember.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand showMembers = new SqlCommand("select * from Members m inner join Branches b on m.ID = b.ID", connection);
            SqlDataReader membersReader = showMembers.ExecuteReader();

            while (membersReader.Read())
            {
                Member mem = new Member();
                mem.name = membersReader["Ad"].ToString();
                mem.surname = membersReader["Soyad"].ToString();
                ListViewItem member = new ListViewItem();
                member.Text = mem.name + mem.surname;
                member.SubItems.Add(membersReader["Branch"].ToString());
                member.SubItems.Add(membersReader["eMail"].ToString());
                member.SubItems.Add(membersReader["UyelikTipi"].ToString());
                member.SubItems.Add(membersReader["Borc"].ToString());
                memberList.Items.Add(member);
            }
            connection.Close();
        }
    }
}
