using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SporSalonu
{
    public partial class CardForm : Form
    {
        public CardForm()
        {
            InitializeComponent();
        }

        private void CardForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            System.Drawing.Drawing2D.GraphicsPath gp2 = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, dernekLogo1.Width - 1, dernekLogo1.Height - 2);
            gp2.AddEllipse(0, 0, dernekLogo2.Width - 1 , dernekLogo2.Height - 2);
            Region rg = new Region(gp);
            Region rg2 = new Region(gp2);
            dernekLogo1.Region = rg;
            dernekLogo2.Region = rg2;

            nameLbl.Text = MemberDetails.ad.ToUpper();
            surnameLbl.Text = MemberDetails.soyad.ToUpper();
            branchLbl.Text = MemberDetails.brans.ToUpper();
            titleLbl.Text = "SPORCU";
            birthDateLbl.Text = MemberDetails.dogumTarihi;
            memberPic.ImageLocation = MemberDetails.foto;
        }

        private void logoBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            dernekLogo1.ImageLocation = openFileDialog1.FileName;
            dernekLogo2.ImageLocation = openFileDialog1.FileName;

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            MemberDetails memberDetails = new MemberDetails();
            memberDetails.Show();
            this.Hide();

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            
            saveFileDialog1.ShowDialog();
            int width = onYuz.Size.Width;
            int height = onYuz.Size.Height;

            Bitmap bm = new Bitmap(width, height);
            onYuz.DrawToBitmap(bm, new Rectangle(0, 0, width, height));

            bm.Save(saveFileDialog1.FileName, ImageFormat.Png);
            width = arkaYuz.Size.Width;
            height = arkaYuz.Size.Height;

            Bitmap bm2 = new Bitmap(width, height);
            arkaYuz.DrawToBitmap(bm2, new Rectangle(0, 0, width, height));
            if (saveFileDialog1.FileName.Contains("."))
            {
                string yol = saveFileDialog1.FileName.TrimEnd('.', 'p', 'n', 'g') + "2" + ".png";
                bm2.Save(yol, ImageFormat.Bmp);
            }
            else
                bm2.Save(saveFileDialog1.FileName + "2", ImageFormat.Png);
        }
    }
}
