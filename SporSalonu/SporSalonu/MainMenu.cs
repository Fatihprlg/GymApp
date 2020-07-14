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
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");
        public MainMenu()
        {
            InitializeComponent();
        }
       public static int memberID;
        private void newMemberBtn_Click(object sender, EventArgs e)
        {
            addMember addMember = new addMember();
            addMember.Show();
            this.Hide();
        }
        float borc;
        float aidat;
        List<float> borclar = new List<float>();
        List<DateTime> ayTakibi = new List<DateTime>();
        private void MainMenu_Load(object sender, EventArgs e)
        {
            memberList.FullRowSelect = true;
            button1.FlatAppearance.BorderSize = 0;
            connection.Open();
            
            SqlCommand showMembers = new SqlCommand("select * from Members m inner join Branches b on m.Brans = b.Id ", connection);
            SqlDataReader membersReader = showMembers.ExecuteReader();

            while (membersReader.Read())
            {
                Member mem = new Member();
                mem.name = membersReader["Ad"].ToString();
                mem.surname = membersReader["Soyad"].ToString();
                ListViewItem member = new ListViewItem();
                member.Text = membersReader["ID"].ToString();
                member.SubItems.Add(mem.name + " " + mem.surname);
                member.SubItems.Add(membersReader["Brans Adi"].ToString());
                member.SubItems.Add(membersReader["eMail"].ToString());
                member.SubItems.Add(membersReader["Uyelik Tipi"].ToString());
                DateTime firstDate = Convert.ToDateTime(membersReader["Ay Takibi"]);
                TimeSpan result = DateTime.Now - firstDate;
                borc = float.Parse(membersReader["Borc"].ToString());
                aidat = float.Parse(membersReader["Aidat"].ToString());
                if (membersReader["Uyelik Tipi"].ToString() == "Aylık")
                {
                    if (Convert.ToInt32(result.TotalDays) >= 30)
                    {
                        borc += aidat;
                        firstDate.AddMonths(1);

                    }

                }
                else if (membersReader["Uyelik Tipi"].ToString() == "Yıllık")
                {
                    if (Convert.ToInt32(result.TotalDays) >= 365)
                    {
                        borc += aidat;
                        firstDate.AddMonths(12);
                    }
                   
                }
                borclar.Add(borc);
                ayTakibi.Add(firstDate);
                member.SubItems.Add(borc.ToString());
                if (borc > aidat)
                {
                    member.BackColor = Color.LightCoral;
                }
                else
                {
                    member.BackColor = Color.FromArgb(208, 235, 255);
                }
                memberList.Items.Add(member);
            }
            connection.Close(); 
            for (int i = 0; i < memberList.Items.Count; i++)
            {
                connection.Open();
                SqlCommand updateSubs = new SqlCommand("update Members set Borc = @borc, [Ay Takibi] = @ay where ID = @id", connection);
                updateSubs.Parameters.AddWithValue("@borc", borclar[i]);
                updateSubs.Parameters.AddWithValue("@ay", ayTakibi[i]);
                updateSubs.Parameters.AddWithValue("@id", i+1);
                updateSubs.ExecuteNonQuery();
                connection.Close();
            }

        }

        private void memberList_SelectedIndexChanged(object sender, EventArgs e)
        {
           // memberID = memberList.FocusedItem.Text;
        }

        private void coachsBtn_Click(object sender, EventArgs e)
        {
            Coachs coachs = new Coachs();
            coachs.Show();
            this.Hide();
        }

        private void deleteMember_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(memberList.FocusedItem.SubItems[1].ToString() + " Kisisini silmek istediginize emin misiniz?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    connection.Open();
                    SqlCommand delete = new SqlCommand("delete from Coaches where Id = '" + memberID + "'", connection);
                    delete.ExecuteNonQuery();
                    connection.Close();
                    memberList.Items.Clear();
                    MainMenu_Load(sender, e);
                }
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message);
            }
 
        }

        private void showMemberStatus_Click(object sender, EventArgs e)
        {
            MemberDetails memberDetails = new MemberDetails();
            memberDetails.Show();
            this.Hide();
        }

        private void memberList_MouseClick(object sender, MouseEventArgs e)
        {
            memberID = int.Parse(memberList.SelectedItems[0].SubItems[0].Text);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void accountingBtn_Click(object sender, EventArgs e)
        {
            Accounting accounting = new Accounting();
            accounting.Show();
            this.Hide();
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.Show();
            this.Hide();
        }

        private void smsMailBtn_Click(object sender, EventArgs e)
        {
            smsMailPage smsMail = new smsMailPage();
            smsMail.Show();
            this.Hide();
        }
    }
}
