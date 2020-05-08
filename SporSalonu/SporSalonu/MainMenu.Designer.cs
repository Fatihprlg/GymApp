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
            this.memberList = new System.Windows.Forms.ListView();
            this.AdSoyad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Brans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.eMail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UyelikTipi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Borc = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // newMemberBtn
            // 
            this.newMemberBtn.Location = new System.Drawing.Point(675, 12);
            this.newMemberBtn.Name = "newMemberBtn";
            this.newMemberBtn.Size = new System.Drawing.Size(113, 32);
            this.newMemberBtn.TabIndex = 1;
            this.newMemberBtn.Text = "Üye Ekle";
            this.newMemberBtn.UseVisualStyleBackColor = true;
            this.newMemberBtn.Click += new System.EventHandler(this.newMemberBtn_Click);
            // 
            // deleteMember
            // 
            this.deleteMember.Location = new System.Drawing.Point(675, 50);
            this.deleteMember.Name = "deleteMember";
            this.deleteMember.Size = new System.Drawing.Size(113, 32);
            this.deleteMember.TabIndex = 4;
            this.deleteMember.Text = "Üye Sil";
            this.deleteMember.UseVisualStyleBackColor = true;
            // 
            // showMemberStatus
            // 
            this.showMemberStatus.Location = new System.Drawing.Point(675, 88);
            this.showMemberStatus.Name = "showMemberStatus";
            this.showMemberStatus.Size = new System.Drawing.Size(113, 50);
            this.showMemberStatus.TabIndex = 5;
            this.showMemberStatus.Text = "Bilgileri Görüntüle";
            this.showMemberStatus.UseVisualStyleBackColor = true;
            // 
            // memberList
            // 
            this.memberList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.AdSoyad,
            this.Brans,
            this.eMail,
            this.UyelikTipi,
            this.Borc});
            this.memberList.HideSelection = false;
            this.memberList.Location = new System.Drawing.Point(12, 12);
            this.memberList.Name = "memberList";
            this.memberList.Size = new System.Drawing.Size(657, 426);
            this.memberList.TabIndex = 6;
            this.memberList.UseCompatibleStateImageBehavior = false;
            this.memberList.View = System.Windows.Forms.View.Details;
            // 
            // AdSoyad
            // 
            this.AdSoyad.Text = "Ad Soyad";
            this.AdSoyad.Width = 134;
            // 
            // Brans
            // 
            this.Brans.Text = "Branş";
            this.Brans.Width = 155;
            // 
            // eMail
            // 
            this.eMail.Text = "eMail";
            this.eMail.Width = 178;
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
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memberList);
            this.Controls.Add(this.showMemberStatus);
            this.Controls.Add(this.deleteMember);
            this.Controls.Add(this.newMemberBtn);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newMemberBtn;
        private System.Windows.Forms.Button deleteMember;
        private System.Windows.Forms.Button showMemberStatus;
        private System.Windows.Forms.ListView memberList;
        private System.Windows.Forms.ColumnHeader AdSoyad;
        private System.Windows.Forms.ColumnHeader Brans;
        private System.Windows.Forms.ColumnHeader eMail;
        private System.Windows.Forms.ColumnHeader UyelikTipi;
        private System.Windows.Forms.ColumnHeader Borc;
    }
}