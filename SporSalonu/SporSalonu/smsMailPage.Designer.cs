namespace SporSalonu
{
    partial class smsMailPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(smsMailPage));
            this.memberList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addNmbrBtn = new System.Windows.Forms.Button();
            this.addDebtBtnSms = new System.Windows.Forms.Button();
            this.addAllBtnSms = new System.Windows.Forms.Button();
            this.addMailBtn = new System.Windows.Forms.Button();
            this.addDebtBtnMail = new System.Windows.Forms.Button();
            this.addAllBtnMail = new System.Windows.Forms.Button();
            this.subjectTxtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.contentTxtMail = new System.Windows.Forms.TextBox();
            this.sendMail = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.numara = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.smsSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memberList
            // 
            this.memberList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.memberList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.memberList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.AdSoyad,
            this.Brans,
            this.eMail,
            this.numara,
            this.columnHeader1,
            this.columnHeader2});
            this.memberList.ForeColor = System.Drawing.Color.Black;
            this.memberList.HideSelection = false;
            this.memberList.Location = new System.Drawing.Point(12, 409);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(948, 131);
            this.memberList.TabIndex = 7;
            this.memberList.UseCompatibleStateImageBehavior = false;
            this.memberList.View = System.Windows.Forms.View.Details;
            this.memberList.SelectedIndexChanged += new System.EventHandler(this.memberList_SelectedIndexChanged);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // AdSoyad
            // 
            this.AdSoyad.Text = "Ad Soyad";
            this.AdSoyad.Width = 134;
            // 
            // Brans
            // 
            this.Brans.Text = "Branş";
            this.Brans.Width = 114;
            // 
            // eMail
            // 
            this.eMail.Text = "eMail";
            this.eMail.Width = 158;
            // 
            // addNmbrBtn
            // 
            this.addNmbrBtn.Location = new System.Drawing.Point(12, 356);
            this.addNmbrBtn.Name = "addNmbrBtn";
            this.addNmbrBtn.Size = new System.Drawing.Size(92, 47);
            this.addNmbrBtn.TabIndex = 8;
            this.addNmbrBtn.Text = "Numarayı Ekle";
            this.addNmbrBtn.UseVisualStyleBackColor = true;
            // 
            // addDebtBtnSms
            // 
            this.addDebtBtnSms.Location = new System.Drawing.Point(110, 356);
            this.addDebtBtnSms.Name = "addDebtBtnSms";
            this.addDebtBtnSms.Size = new System.Drawing.Size(99, 47);
            this.addDebtBtnSms.TabIndex = 9;
            this.addDebtBtnSms.Text = "Borcu Olanları Ekle";
            this.addDebtBtnSms.UseVisualStyleBackColor = true;
            // 
            // addAllBtnSms
            // 
            this.addAllBtnSms.Location = new System.Drawing.Point(215, 356);
            this.addAllBtnSms.Name = "addAllBtnSms";
            this.addAllBtnSms.Size = new System.Drawing.Size(106, 47);
            this.addAllBtnSms.TabIndex = 10;
            this.addAllBtnSms.Text = "Tümünü Ekle";
            this.addAllBtnSms.UseVisualStyleBackColor = true;
            // 
            // addMailBtn
            // 
            this.addMailBtn.Location = new System.Drawing.Point(868, 356);
            this.addMailBtn.Name = "addMailBtn";
            this.addMailBtn.Size = new System.Drawing.Size(92, 47);
            this.addMailBtn.TabIndex = 11;
            this.addMailBtn.Text = "Maili Ekle";
            this.addMailBtn.UseVisualStyleBackColor = true;
            this.addMailBtn.Click += new System.EventHandler(this.addMailBtn_Click);
            // 
            // addDebtBtnMail
            // 
            this.addDebtBtnMail.Location = new System.Drawing.Point(763, 356);
            this.addDebtBtnMail.Name = "addDebtBtnMail";
            this.addDebtBtnMail.Size = new System.Drawing.Size(99, 47);
            this.addDebtBtnMail.TabIndex = 12;
            this.addDebtBtnMail.Text = "Borcu Olanları Ekle";
            this.addDebtBtnMail.UseVisualStyleBackColor = true;
            this.addDebtBtnMail.Click += new System.EventHandler(this.addDebtBtnMail_Click);
            // 
            // addAllBtnMail
            // 
            this.addAllBtnMail.Location = new System.Drawing.Point(654, 356);
            this.addAllBtnMail.Name = "addAllBtnMail";
            this.addAllBtnMail.Size = new System.Drawing.Size(103, 47);
            this.addAllBtnMail.TabIndex = 13;
            this.addAllBtnMail.Text = "Tümünü Ekle";
            this.addAllBtnMail.UseVisualStyleBackColor = true;
            this.addAllBtnMail.Click += new System.EventHandler(this.addAllBtnMail_Click);
            // 
            // subjectTxtMail
            // 
            this.subjectTxtMail.Location = new System.Drawing.Point(655, 54);
            this.subjectTxtMail.Name = "subjectTxtMail";
            this.subjectTxtMail.Size = new System.Drawing.Size(305, 22);
            this.subjectTxtMail.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(600, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Konu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(600, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "İçerik:";
            // 
            // contentTxtMail
            // 
            this.contentTxtMail.Location = new System.Drawing.Point(654, 92);
            this.contentTxtMail.Multiline = true;
            this.contentTxtMail.Name = "contentTxtMail";
            this.contentTxtMail.Size = new System.Drawing.Size(305, 203);
            this.contentTxtMail.TabIndex = 16;
            // 
            // sendMail
            // 
            this.sendMail.Location = new System.Drawing.Point(867, 303);
            this.sendMail.Name = "sendMail";
            this.sendMail.Size = new System.Drawing.Size(92, 47);
            this.sendMail.TabIndex = 18;
            this.sendMail.Text = "Mail Gönder";
            this.sendMail.UseVisualStyleBackColor = true;
            this.sendMail.Click += new System.EventHandler(this.sendMail_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(445, 356);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(92, 47);
            this.cancelBtn.TabIndex = 19;
            this.cancelBtn.Text = "İptal";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // numara
            // 
            this.numara.Text = "Numara";
            this.numara.Width = 140;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Uyelik Tipi";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Borc";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 21;
            this.label3.Text = "İçerik:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 59);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(305, 238);
            this.textBox1.TabIndex = 20;
            // 
            // smsSend
            // 
            this.smsSend.Location = new System.Drawing.Point(12, 303);
            this.smsSend.Name = "smsSend";
            this.smsSend.Size = new System.Drawing.Size(92, 47);
            this.smsSend.TabIndex = 22;
            this.smsSend.Text = "Sms Gönder";
            this.smsSend.UseVisualStyleBackColor = true;
            // 
            // smsMailPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(975, 552);
            this.Controls.Add(this.smsSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sendMail);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contentTxtMail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectTxtMail);
            this.Controls.Add(this.addAllBtnMail);
            this.Controls.Add(this.addDebtBtnMail);
            this.Controls.Add(this.addMailBtn);
            this.Controls.Add(this.addAllBtnSms);
            this.Controls.Add(this.addDebtBtnSms);
            this.Controls.Add(this.addNmbrBtn);
            this.Controls.Add(this.memberList);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "smsMailPage";
            this.Text = "smsMailPage";
            this.Load += new System.EventHandler(this.smsMailPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView memberList;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader AdSoyad;
        private System.Windows.Forms.ColumnHeader Brans;
        private System.Windows.Forms.ColumnHeader eMail;
        private System.Windows.Forms.ColumnHeader numara;
        private System.Windows.Forms.Button addNmbrBtn;
        private System.Windows.Forms.Button addDebtBtnSms;
        private System.Windows.Forms.Button addAllBtnSms;
        private System.Windows.Forms.Button addMailBtn;
        private System.Windows.Forms.Button addDebtBtnMail;
        private System.Windows.Forms.Button addAllBtnMail;
        private System.Windows.Forms.TextBox subjectTxtMail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contentTxtMail;
        private System.Windows.Forms.Button sendMail;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button smsSend;
    }
}