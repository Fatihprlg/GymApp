namespace SporSalonu
{
    partial class signUpPage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label adLabel;
            System.Windows.Forms.Label soyadLabel;
            System.Windows.Forms.Label kulup_AdiLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label sifreLabel;
            this.signUpBtn = new System.Windows.Forms.Button();
            this.passAgainLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.passAgainBox = new System.Windows.Forms.TextBox();
            this.backBtn = new System.Windows.Forms.Button();
            this.passNotSameLbl = new System.Windows.Forms.Label();
            this.databaseDataSet = new SporSalonu.DatabaseDataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.businessOwnerTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.businessOwnerTableAdapter();
            this.businessOwnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nameBox = new System.Windows.Forms.TextBox();
            this.surnameBox = new System.Windows.Forms.TextBox();
            this.businessNameBox = new System.Windows.Forms.TextBox();
            this.eMailBox = new System.Windows.Forms.TextBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            adLabel = new System.Windows.Forms.Label();
            soyadLabel = new System.Windows.Forms.Label();
            kulup_AdiLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            sifreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessOwnerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.BackColor = System.Drawing.Color.Transparent;
            adLabel.ForeColor = System.Drawing.Color.Orange;
            adLabel.Location = new System.Drawing.Point(34, 57);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(29, 17);
            adLabel.TabIndex = 21;
            adLabel.Text = "Ad:";
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.BackColor = System.Drawing.Color.Transparent;
            soyadLabel.ForeColor = System.Drawing.Color.Orange;
            soyadLabel.Location = new System.Drawing.Point(34, 85);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new System.Drawing.Size(52, 17);
            soyadLabel.TabIndex = 23;
            soyadLabel.Text = "Soyad:";
            // 
            // kulup_AdiLabel
            // 
            kulup_AdiLabel.AutoSize = true;
            kulup_AdiLabel.BackColor = System.Drawing.Color.Transparent;
            kulup_AdiLabel.ForeColor = System.Drawing.Color.Orange;
            kulup_AdiLabel.Location = new System.Drawing.Point(34, 141);
            kulup_AdiLabel.Name = "kulup_AdiLabel";
            kulup_AdiLabel.Size = new System.Drawing.Size(72, 17);
            kulup_AdiLabel.TabIndex = 25;
            kulup_AdiLabel.Text = "Kulup Adi:";
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.BackColor = System.Drawing.Color.Transparent;
            eMailLabel.ForeColor = System.Drawing.Color.Orange;
            eMailLabel.Location = new System.Drawing.Point(34, 113);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(49, 17);
            eMailLabel.TabIndex = 27;
            eMailLabel.Text = "e Mail:";
            // 
            // sifreLabel
            // 
            sifreLabel.AutoSize = true;
            sifreLabel.BackColor = System.Drawing.Color.Transparent;
            sifreLabel.ForeColor = System.Drawing.Color.Orange;
            sifreLabel.Location = new System.Drawing.Point(34, 169);
            sifreLabel.Name = "sifreLabel";
            sifreLabel.Size = new System.Drawing.Size(41, 17);
            sifreLabel.TabIndex = 29;
            sifreLabel.Text = "Sifre:";
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(670, 203);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(85, 30);
            this.signUpBtn.TabIndex = 2;
            this.signUpBtn.Text = "Kaydol";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // passAgainLbl
            // 
            this.passAgainLbl.AutoSize = true;
            this.passAgainLbl.BackColor = System.Drawing.Color.Transparent;
            this.passAgainLbl.ForeColor = System.Drawing.Color.Orange;
            this.passAgainLbl.Location = new System.Drawing.Point(392, 169);
            this.passAgainLbl.Name = "passAgainLbl";
            this.passAgainLbl.Size = new System.Drawing.Size(83, 17);
            this.passAgainLbl.TabIndex = 16;
            this.passAgainLbl.Text = "Şifre Tekrar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 14;
            // 
            // passAgainBox
            // 
            this.passAgainBox.Location = new System.Drawing.Point(481, 166);
            this.passAgainBox.Name = "passAgainBox";
            this.passAgainBox.Size = new System.Drawing.Size(274, 22);
            this.passAgainBox.TabIndex = 13;
            this.passAgainBox.UseSystemPasswordChar = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(579, 203);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(85, 30);
            this.backBtn.TabIndex = 17;
            this.backBtn.Text = "Geri Dön";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // passNotSameLbl
            // 
            this.passNotSameLbl.AutoSize = true;
            this.passNotSameLbl.BackColor = System.Drawing.Color.Transparent;
            this.passNotSameLbl.ForeColor = System.Drawing.Color.Red;
            this.passNotSameLbl.Location = new System.Drawing.Point(112, 189);
            this.passNotSameLbl.Name = "passNotSameLbl";
            this.passNotSameLbl.Size = new System.Drawing.Size(129, 17);
            this.passNotSameLbl.TabIndex = 18;
            this.passNotSameLbl.Text = "Şifreler uyuşmuyor!";
            this.passNotSameLbl.Visible = false;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.databaseDataSet;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = null;
            this.tableAdapterManager.BransUyeTableAdapter = null;
            this.tableAdapterManager.businessOwnerTableAdapter = this.businessOwnerTableAdapter;
            this.tableAdapterManager.CoachesTableAdapter = null;
            this.tableAdapterManager.memberInfoTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // businessOwnerTableAdapter
            // 
            this.businessOwnerTableAdapter.ClearBeforeFill = true;
            // 
            // businessOwnerBindingSource
            // 
            this.businessOwnerBindingSource.DataMember = "businessOwner";
            this.businessOwnerBindingSource.DataSource = this.databaseDataSet;
            // 
            // nameBox
            // 
            this.nameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessOwnerBindingSource, "Ad", true));
            this.nameBox.Location = new System.Drawing.Point(112, 54);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(248, 22);
            this.nameBox.TabIndex = 22;
            // 
            // surnameBox
            // 
            this.surnameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessOwnerBindingSource, "Soyad", true));
            this.surnameBox.Location = new System.Drawing.Point(112, 82);
            this.surnameBox.Name = "surnameBox";
            this.surnameBox.Size = new System.Drawing.Size(248, 22);
            this.surnameBox.TabIndex = 24;
            // 
            // businessNameBox
            // 
            this.businessNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessOwnerBindingSource, "Kulup Adi", true));
            this.businessNameBox.Location = new System.Drawing.Point(112, 138);
            this.businessNameBox.Name = "businessNameBox";
            this.businessNameBox.Size = new System.Drawing.Size(248, 22);
            this.businessNameBox.TabIndex = 26;
            // 
            // eMailBox
            // 
            this.eMailBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessOwnerBindingSource, "eMail", true));
            this.eMailBox.Location = new System.Drawing.Point(112, 110);
            this.eMailBox.Name = "eMailBox";
            this.eMailBox.Size = new System.Drawing.Size(248, 22);
            this.eMailBox.TabIndex = 28;
            // 
            // passwordBox
            // 
            this.passwordBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.businessOwnerBindingSource, "Sifre", true));
            this.passwordBox.Location = new System.Drawing.Point(112, 166);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(248, 22);
            this.passwordBox.TabIndex = 30;
            this.passwordBox.UseSystemPasswordChar = true;
            // 
            // signUpPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.colors_hd_backgrounds;
            this.ClientSize = new System.Drawing.Size(800, 339);
            this.Controls.Add(adLabel);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(soyadLabel);
            this.Controls.Add(this.surnameBox);
            this.Controls.Add(kulup_AdiLabel);
            this.Controls.Add(this.businessNameBox);
            this.Controls.Add(eMailLabel);
            this.Controls.Add(this.eMailBox);
            this.Controls.Add(sifreLabel);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.passNotSameLbl);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.passAgainLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.passAgainBox);
            this.Controls.Add(this.signUpBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "signUpPage";
            this.Text = "signUpPage";
            this.Load += new System.EventHandler(this.signUpPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.businessOwnerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Label passAgainLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox passAgainBox;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label passNotSameLbl;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DatabaseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DatabaseDataSetTableAdapters.businessOwnerTableAdapter businessOwnerTableAdapter;
        private System.Windows.Forms.BindingSource businessOwnerBindingSource;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox surnameBox;
        private System.Windows.Forms.TextBox businessNameBox;
        private System.Windows.Forms.TextBox eMailBox;
        private System.Windows.Forms.TextBox passwordBox;
    }
}