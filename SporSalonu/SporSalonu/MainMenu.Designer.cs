namespace SporSalonu
{
    partial class MainMenu
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
            this.newMemberBtn = new System.Windows.Forms.Button();
            this.deleteMember = new System.Windows.Forms.Button();
            this.showMemberStatus = new System.Windows.Forms.Button();
            this.AdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyelikTipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Borc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.memberList = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.coachsBtn = new System.Windows.Forms.Button();
            this.branchs = new System.Windows.Forms.Button();
            this.productsBtn = new System.Windows.Forms.Button();
            this.accountingBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // newMemberBtn
            // 
            this.newMemberBtn.Location = new System.Drawing.Point(730, 12);
            this.newMemberBtn.Name = "newMemberBtn";
            this.newMemberBtn.Size = new System.Drawing.Size(113, 32);
            this.newMemberBtn.TabIndex = 1;
            this.newMemberBtn.Text = "Üye Ekle";
            this.newMemberBtn.UseVisualStyleBackColor = true;
            this.newMemberBtn.Click += new System.EventHandler(this.newMemberBtn_Click);
            // 
            // deleteMember
            // 
            this.deleteMember.Location = new System.Drawing.Point(730, 50);
            this.deleteMember.Name = "deleteMember";
            this.deleteMember.Size = new System.Drawing.Size(113, 32);
            this.deleteMember.TabIndex = 4;
            this.deleteMember.Text = "Üye Sil";
            this.deleteMember.UseVisualStyleBackColor = true;
            this.deleteMember.Click += new System.EventHandler(this.deleteMember_Click);
            // 
            // showMemberStatus
            // 
            this.showMemberStatus.Location = new System.Drawing.Point(730, 88);
            this.showMemberStatus.Name = "showMemberStatus";
            this.showMemberStatus.Size = new System.Drawing.Size(113, 50);
            this.showMemberStatus.TabIndex = 5;
            this.showMemberStatus.Text = "Bilgileri Görüntüle";
            this.showMemberStatus.UseVisualStyleBackColor = true;
            this.showMemberStatus.Click += new System.EventHandler(this.showMemberStatus_Click);
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
            // UyelikTipi
            // 
            this.UyelikTipi.Text = "Uyelik Tipi";
            this.UyelikTipi.Width = 126;
            // 
            // Borc
            // 
            this.Borc.Text = "Borç";
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
            this.UyelikTipi,
            this.Borc});
            this.memberList.ForeColor = System.Drawing.Color.Black;
            this.memberList.HideSelection = false;
            this.memberList.Location = new System.Drawing.Point(12, 12);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(712, 477);
            this.memberList.TabIndex = 6;
            this.memberList.UseCompatibleStateImageBehavior = false;
            this.memberList.View = System.Windows.Forms.View.Details;
            this.memberList.SelectedIndexChanged += new System.EventHandler(this.memberList_SelectedIndexChanged);
            this.memberList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.memberList_MouseClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // coachsBtn
            // 
            this.coachsBtn.Location = new System.Drawing.Point(730, 144);
            this.coachsBtn.Name = "coachsBtn";
            this.coachsBtn.Size = new System.Drawing.Size(113, 57);
            this.coachsBtn.TabIndex = 7;
            this.coachsBtn.Text = "Antrenörler";
            this.coachsBtn.UseVisualStyleBackColor = true;
            this.coachsBtn.Click += new System.EventHandler(this.coachsBtn_Click);
            // 
            // branchs
            // 
            this.branchs.Location = new System.Drawing.Point(730, 207);
            this.branchs.Name = "branchs";
            this.branchs.Size = new System.Drawing.Size(113, 57);
            this.branchs.TabIndex = 8;
            this.branchs.Text = "Branşlar";
            this.branchs.UseVisualStyleBackColor = true;
            // 
            // productsBtn
            // 
            this.productsBtn.Location = new System.Drawing.Point(730, 270);
            this.productsBtn.Name = "productsBtn";
            this.productsBtn.Size = new System.Drawing.Size(113, 57);
            this.productsBtn.TabIndex = 9;
            this.productsBtn.Text = "Ürünler";
            this.productsBtn.UseVisualStyleBackColor = true;
            // 
            // accountingBtn
            // 
            this.accountingBtn.Location = new System.Drawing.Point(730, 333);
            this.accountingBtn.Name = "accountingBtn";
            this.accountingBtn.Size = new System.Drawing.Size(113, 57);
            this.accountingBtn.TabIndex = 10;
            this.accountingBtn.Text = "Muhasebe";
            this.accountingBtn.UseVisualStyleBackColor = true;
            this.accountingBtn.Click += new System.EventHandler(this.accountingBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SporSalonu.Properties.Resources.logout;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(800, 443);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(43, 46);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.colors_hd_backgrounds;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(855, 501);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.accountingBtn);
            this.Controls.Add(this.productsBtn);
            this.Controls.Add(this.branchs);
            this.Controls.Add(this.coachsBtn);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.showMemberStatus);
            this.Controls.Add(this.deleteMember);
            this.Controls.Add(this.newMemberBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newMemberBtn;
        private System.Windows.Forms.Button deleteMember;
        private System.Windows.Forms.Button showMemberStatus;
        private System.Windows.Forms.ColumnHeader AdSoyad;
        private System.Windows.Forms.ColumnHeader Brans;
        private System.Windows.Forms.ColumnHeader eMail;
        private System.Windows.Forms.ColumnHeader UyelikTipi;
        private System.Windows.Forms.ColumnHeader Borc;
        private System.Windows.Forms.ListView memberList;
        private System.Windows.Forms.Button coachsBtn;
        private System.Windows.Forms.Button branchs;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.Button productsBtn;
        private System.Windows.Forms.Button accountingBtn;
        private System.Windows.Forms.Button button1;
    }
}