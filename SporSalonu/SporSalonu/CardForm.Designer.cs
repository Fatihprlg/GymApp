namespace SporSalonu
{
    partial class CardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.onYuz = new System.Windows.Forms.Panel();
            this.arkaYuz = new System.Windows.Forms.Panel();
            this.nameLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.branchLbl = new System.Windows.Forms.Label();
            this.titleLbl = new System.Windows.Forms.Label();
            this.birthDateLbl = new System.Windows.Forms.Label();
            this.bloodLbl = new System.Windows.Forms.Label();
            this.memberPic = new System.Windows.Forms.PictureBox();
            this.dernekLogo1 = new System.Windows.Forms.PictureBox();
            this.dernekLogo2 = new System.Windows.Forms.PictureBox();
            this.logoBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.onYuz.SuspendLayout();
            this.arkaYuz.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dernekLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dernekLogo2)).BeginInit();
            this.SuspendLayout();
            // 
            // onYuz
            // 
            this.onYuz.BackgroundImage = global::SporSalonu.Properties.Resources.kart_ön_yüz;
            this.onYuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.onYuz.Controls.Add(this.dernekLogo1);
            this.onYuz.Controls.Add(this.memberPic);
            this.onYuz.Controls.Add(this.titleLbl);
            this.onYuz.Controls.Add(this.branchLbl);
            this.onYuz.Controls.Add(this.surnameLbl);
            this.onYuz.Controls.Add(this.nameLbl);
            this.onYuz.Location = new System.Drawing.Point(12, 12);
            this.onYuz.Name = "onYuz";
            this.onYuz.Size = new System.Drawing.Size(502, 325);
            this.onYuz.TabIndex = 0;
            // 
            // arkaYuz
            // 
            this.arkaYuz.AutoSize = true;
            this.arkaYuz.BackgroundImage = global::SporSalonu.Properties.Resources.kart_arka_yüz;
            this.arkaYuz.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.arkaYuz.Controls.Add(this.dernekLogo2);
            this.arkaYuz.Controls.Add(this.bloodLbl);
            this.arkaYuz.Controls.Add(this.birthDateLbl);
            this.arkaYuz.Location = new System.Drawing.Point(534, 12);
            this.arkaYuz.Name = "arkaYuz";
            this.arkaYuz.Size = new System.Drawing.Size(502, 325);
            this.arkaYuz.TabIndex = 1;
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.BackColor = System.Drawing.Color.Transparent;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameLbl.Location = new System.Drawing.Point(121, 116);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(42, 25);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "lbl1";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.BackColor = System.Drawing.Color.Transparent;
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameLbl.Location = new System.Drawing.Point(121, 162);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(42, 25);
            this.surnameLbl.TabIndex = 1;
            this.surnameLbl.Text = "lbl1";
            // 
            // branchLbl
            // 
            this.branchLbl.AutoSize = true;
            this.branchLbl.BackColor = System.Drawing.Color.Transparent;
            this.branchLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.branchLbl.Location = new System.Drawing.Point(123, 207);
            this.branchLbl.Name = "branchLbl";
            this.branchLbl.Size = new System.Drawing.Size(42, 25);
            this.branchLbl.TabIndex = 2;
            this.branchLbl.Text = "lbl1";
            // 
            // titleLbl
            // 
            this.titleLbl.AutoSize = true;
            this.titleLbl.BackColor = System.Drawing.Color.Transparent;
            this.titleLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.titleLbl.Location = new System.Drawing.Point(123, 254);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(42, 25);
            this.titleLbl.TabIndex = 3;
            this.titleLbl.Text = "lbl1";
            // 
            // birthDateLbl
            // 
            this.birthDateLbl.AutoSize = true;
            this.birthDateLbl.BackColor = System.Drawing.Color.Transparent;
            this.birthDateLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birthDateLbl.Location = new System.Drawing.Point(39, 112);
            this.birthDateLbl.Name = "birthDateLbl";
            this.birthDateLbl.Size = new System.Drawing.Size(42, 25);
            this.birthDateLbl.TabIndex = 4;
            this.birthDateLbl.Text = "lbl1";
            // 
            // bloodLbl
            // 
            this.bloodLbl.AutoSize = true;
            this.bloodLbl.BackColor = System.Drawing.Color.Transparent;
            this.bloodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bloodLbl.Location = new System.Drawing.Point(39, 176);
            this.bloodLbl.Name = "bloodLbl";
            this.bloodLbl.Size = new System.Drawing.Size(0, 25);
            this.bloodLbl.TabIndex = 5;
            // 
            // memberPic
            // 
            this.memberPic.Location = new System.Drawing.Point(324, 76);
            this.memberPic.Name = "memberPic";
            this.memberPic.Size = new System.Drawing.Size(160, 222);
            this.memberPic.TabIndex = 4;
            this.memberPic.TabStop = false;
            // 
            // dernekLogo1
            // 
            this.dernekLogo1.BackColor = System.Drawing.Color.Transparent;
            this.dernekLogo1.Location = new System.Drawing.Point(123, 20);
            this.dernekLogo1.Name = "dernekLogo1";
            this.dernekLogo1.Size = new System.Drawing.Size(68, 66);
            this.dernekLogo1.TabIndex = 5;
            this.dernekLogo1.TabStop = false;
            // 
            // dernekLogo2
            // 
            this.dernekLogo2.BackColor = System.Drawing.Color.Transparent;
            this.dernekLogo2.Cursor = System.Windows.Forms.Cursors.Default;
            this.dernekLogo2.Location = new System.Drawing.Point(297, 20);
            this.dernekLogo2.Name = "dernekLogo2";
            this.dernekLogo2.Size = new System.Drawing.Size(68, 66);
            this.dernekLogo2.TabIndex = 6;
            this.dernekLogo2.TabStop = false;
            // 
            // logoBtn
            // 
            this.logoBtn.Location = new System.Drawing.Point(12, 353);
            this.logoBtn.Name = "logoBtn";
            this.logoBtn.Size = new System.Drawing.Size(101, 54);
            this.logoBtn.TabIndex = 2;
            this.logoBtn.Text = "Dernek Logosu Ekle";
            this.logoBtn.UseVisualStyleBackColor = true;
            this.logoBtn.Click += new System.EventHandler(this.logoBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(119, 353);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(101, 54);
            this.saveBtn.TabIndex = 3;
            this.saveBtn.Text = "Kartı Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(937, 353);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(101, 54);
            this.backBtn.TabIndex = 4;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            this.saveFileDialog1.Filter = "Bitmap Image (.bmp)|*.bmp|Gif Image (.gif)|*.gif|JPEG Image (.jpeg)|*.jpeg|Png Im" +
    "age (.png)|*.png|Tiff Image (.tiff)|*.tiff|Wmf Image (.wmf)|*.wmf";
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1050, 426);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.logoBtn);
            this.Controls.Add(this.arkaYuz);
            this.Controls.Add(this.onYuz);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CardForm";
            this.Load += new System.EventHandler(this.CardForm_Load);
            this.onYuz.ResumeLayout(false);
            this.onYuz.PerformLayout();
            this.arkaYuz.ResumeLayout(false);
            this.arkaYuz.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memberPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dernekLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dernekLogo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel onYuz;
        private System.Windows.Forms.Panel arkaYuz;
        private System.Windows.Forms.PictureBox dernekLogo1;
        private System.Windows.Forms.PictureBox memberPic;
        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label branchLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.PictureBox dernekLogo2;
        private System.Windows.Forms.Label bloodLbl;
        private System.Windows.Forms.Label birthDateLbl;
        private System.Windows.Forms.Button logoBtn;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}