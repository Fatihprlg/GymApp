namespace SporSalonu
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.databaseDataSet = new SporSalonu.DatabaseDataSet();
            this.coachesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachesTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.CoachesTableAdapter();
            this.tableAdapterManager = new SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.signUpBtn = new System.Windows.Forms.Button();
            this.enterBtn = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.remindMeChck = new System.Windows.Forms.CheckBox();
            this.girisLbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // coachesBindingSource
            // 
            this.coachesBindingSource.DataMember = "Coaches";
            this.coachesBindingSource.DataSource = this.databaseDataSet;
            // 
            // coachesTableAdapter
            // 
            this.coachesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = null;
            this.tableAdapterManager.BransUyeTableAdapter = null;
            this.tableAdapterManager.businessOwnerTableAdapter = null;
            this.tableAdapterManager.CoachesTableAdapter = this.coachesTableAdapter;
            this.tableAdapterManager.memberInfoTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::SporSalonu.Properties.Resources.Varlık_1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(805, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 36);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = global::SporSalonu.Properties.Resources.passwordnew;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Location = new System.Drawing.Point(544, 292);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3);
            this.panel3.Size = new System.Drawing.Size(20, 22);
            this.panel3.TabIndex = 21;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BackgroundImage = global::SporSalonu.Properties.Resources.user;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Location = new System.Drawing.Point(544, 251);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3);
            this.panel2.Size = new System.Drawing.Size(20, 22);
            this.panel2.TabIndex = 20;
            // 
            // signUpBtn
            // 
            this.signUpBtn.Location = new System.Drawing.Point(399, 325);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.Size = new System.Drawing.Size(75, 31);
            this.signUpBtn.TabIndex = 27;
            this.signUpBtn.Text = "Kaydol";
            this.signUpBtn.UseVisualStyleBackColor = true;
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click_1);
            // 
            // enterBtn
            // 
            this.enterBtn.BackColor = System.Drawing.Color.Transparent;
            this.enterBtn.Location = new System.Drawing.Point(489, 325);
            this.enterBtn.Name = "enterBtn";
            this.enterBtn.Size = new System.Drawing.Size(75, 31);
            this.enterBtn.TabIndex = 26;
            this.enterBtn.Text = "Giriş";
            this.enterBtn.UseVisualStyleBackColor = false;
            this.enterBtn.Click += new System.EventHandler(this.enterBtn_Click_1);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(290, 291);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(274, 22);
            this.passwordTextBox.TabIndex = 25;
            this.passwordTextBox.UseSystemPasswordChar = true;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(290, 250);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(274, 22);
            this.eMailTextBox.TabIndex = 24;
            // 
            // remindMeChck
            // 
            this.remindMeChck.AutoSize = true;
            this.remindMeChck.BackColor = System.Drawing.Color.Transparent;
            this.remindMeChck.ForeColor = System.Drawing.Color.White;
            this.remindMeChck.Location = new System.Drawing.Point(290, 331);
            this.remindMeChck.Name = "remindMeChck";
            this.remindMeChck.Size = new System.Drawing.Size(101, 21);
            this.remindMeChck.TabIndex = 23;
            this.remindMeChck.Text = "Beni hatırla";
            this.remindMeChck.UseVisualStyleBackColor = false;
            // 
            // girisLbl
            // 
            this.girisLbl.BackColor = System.Drawing.Color.Transparent;
            this.girisLbl.Font = new System.Drawing.Font("Roboto Lt", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.girisLbl.ForeColor = System.Drawing.Color.White;
            this.girisLbl.Location = new System.Drawing.Point(290, 179);
            this.girisLbl.Name = "girisLbl";
            this.girisLbl.Size = new System.Drawing.Size(274, 40);
            this.girisLbl.TabIndex = 22;
            this.girisLbl.Text = "Giriş Ekranı";
            this.girisLbl.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SporSalonu.Properties.Resources._128;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(338, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 500);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.signUpBtn);
            this.Controls.Add(this.enterBtn);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.remindMeChck);
            this.Controls.Add(this.girisLbl);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giris Ekranı";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource coachesBindingSource;
        private DatabaseDataSetTableAdapters.CoachesTableAdapter coachesTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button signUpBtn;
        private System.Windows.Forms.Button enterBtn;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.CheckBox remindMeChck;
        private System.Windows.Forms.Label girisLbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

