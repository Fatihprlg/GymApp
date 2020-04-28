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
            this.membersView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.membersView)).BeginInit();
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
            this.deleteMember.Click += new System.EventHandler(this.deleteMember_Click);
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
            // membersView
            // 
            this.membersView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersView.Location = new System.Drawing.Point(12, 12);
            this.membersView.Name = "membersView";
            this.membersView.RowHeadersWidth = 51;
            this.membersView.RowTemplate.Height = 24;
            this.membersView.Size = new System.Drawing.Size(657, 426);
            this.membersView.TabIndex = 6;
            this.membersView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.membersView_CellClick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.membersView);
            this.Controls.Add(this.showMemberStatus);
            this.Controls.Add(this.deleteMember);
            this.Controls.Add(this.newMemberBtn);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.membersView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button newMemberBtn;
        private System.Windows.Forms.Button deleteMember;
        private System.Windows.Forms.Button showMemberStatus;
        private System.Windows.Forms.DataGridView membersView;
    }
}