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
using System.Net.Mail;

namespace SporSalonu
{
    public partial class smsMailPage : Form
    {
        SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Database.mdf;Integrated Security=True;Connect Timeout=30");

        public smsMailPage()
        {
            InitializeComponent();
        }

        private void memberList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        List<string> mails = new List<string>();
        List<string> numbers = new List<string>();
        private void smsMailPage_Load(object sender, EventArgs e)
        {
            memberList.FullRowSelect = true;

            connection.Open();
            SqlCommand showMembers = new SqlCommand("select * from Members m inner join Branches b on m.Brans = b.Id ", connection);
            SqlDataReader membersReader = showMembers.ExecuteReader();

            while (membersReader.Read())
            {
                ListViewItem member = new ListViewItem();
                member.Text = membersReader["Id"].ToString();
                member.SubItems.Add(membersReader["Ad"].ToString() + " " + membersReader["Soyad"].ToString());
                member.SubItems.Add(membersReader["Brans Adi"].ToString());
                member.SubItems.Add(membersReader["eMail"].ToString());
                member.SubItems.Add(membersReader["Numara"].ToString());
                member.SubItems.Add(membersReader["Uyelik Tipi"].ToString());
                member.SubItems.Add(membersReader["Borc"].ToString());
                if (float.Parse(membersReader["Borc"].ToString()) > 0)
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
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
            this.Hide();
        }

        private void addMailBtn_Click(object sender, EventArgs e)
        {
            if (!mails.Contains(memberList.SelectedItems[0].SubItems[3].Text))
            {
                mails.Add(memberList.SelectedItems[0].SubItems[3].Text);
            }
        }

        private void addDebtBtnMail_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < memberList.Items.Count; i++)
            {
                if (float.Parse(memberList.Items[i].SubItems[6].Text) > 0)
                {
                    if (!mails.Contains(memberList.Items[i].SubItems[3].Text))
                    {
                        mails.Add(memberList.Items[i].SubItems[3].Text);
                    }
                }
            }
        }

        private void addAllBtnMail_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < memberList.Items.Count; i++)
            {
                if (!mails.Contains(memberList.Items[i].SubItems[3].Text))
                {
                    mails.Add(memberList.Items[i].SubItems[3].Text);
                }
            }
        }
        MailMessage mailMessage = new MailMessage();

        private void sendMail_Click(object sender, EventArgs e)
        {
            try
            {
                mailMessage.From = new MailAddress("sisbilgisistemleri@outlook.com");
                for (int i = 0; i < mails.Count; i++)
                {
                    mailMessage.To.Add(mails[i]);
                }
                mailMessage.Subject = subjectTxtMail.Text;
                mailMessage.Body = contentTxtMail.Text;

                SmtpClient smtp = new SmtpClient();
                smtp.Credentials = new System.Net.NetworkCredential("sisbilgisistemleri@outlook.com", "m45313v4tp53");
                smtp.Host = "smtp.live.com";
                smtp.EnableSsl = true;
                smtp.Port = 587;
                smtp.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
