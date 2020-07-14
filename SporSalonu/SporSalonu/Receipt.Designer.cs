namespace SporSalonu
{
    partial class Receipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receipt));
            this.cardTextBox = new System.Windows.Forms.TextBox();
            this.cardLbl = new System.Windows.Forms.Label();
            this.cashLbl = new System.Windows.Forms.Label();
            this.transferLbl = new System.Windows.Forms.Label();
            this.cashTextBox = new System.Windows.Forms.TextBox();
            this.transferTextBox = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.totalLbl = new System.Windows.Forms.Label();
            this.infoLbl = new System.Windows.Forms.Label();
            this.wrongLbl = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // cardTextBox
            // 
            this.cardTextBox.Location = new System.Drawing.Point(150, 36);
            this.cardTextBox.Name = "cardTextBox";
            this.cardTextBox.Size = new System.Drawing.Size(100, 22);
            this.cardTextBox.TabIndex = 3;
            this.cardTextBox.Text = "0";
            // 
            // cardLbl
            // 
            this.cardLbl.AutoSize = true;
            this.cardLbl.BackColor = System.Drawing.Color.Transparent;
            this.cardLbl.ForeColor = System.Drawing.Color.White;
            this.cardLbl.Location = new System.Drawing.Point(55, 39);
            this.cardLbl.Name = "cardLbl";
            this.cardLbl.Size = new System.Drawing.Size(78, 17);
            this.cardLbl.TabIndex = 0;
            this.cardLbl.Text = "Kredi Kartı:";
            // 
            // cashLbl
            // 
            this.cashLbl.AutoSize = true;
            this.cashLbl.BackColor = System.Drawing.Color.Transparent;
            this.cashLbl.ForeColor = System.Drawing.Color.White;
            this.cashLbl.Location = new System.Drawing.Point(55, 95);
            this.cashLbl.Name = "cashLbl";
            this.cashLbl.Size = new System.Drawing.Size(44, 17);
            this.cashLbl.TabIndex = 1;
            this.cashLbl.Text = "Nakit:";
            // 
            // transferLbl
            // 
            this.transferLbl.AutoSize = true;
            this.transferLbl.BackColor = System.Drawing.Color.Transparent;
            this.transferLbl.ForeColor = System.Drawing.Color.White;
            this.transferLbl.Location = new System.Drawing.Point(55, 67);
            this.transferLbl.Name = "transferLbl";
            this.transferLbl.Size = new System.Drawing.Size(56, 17);
            this.transferLbl.TabIndex = 2;
            this.transferLbl.Text = "Havale:";
            // 
            // cashTextBox
            // 
            this.cashTextBox.Location = new System.Drawing.Point(150, 92);
            this.cashTextBox.Name = "cashTextBox";
            this.cashTextBox.Size = new System.Drawing.Size(100, 22);
            this.cashTextBox.TabIndex = 4;
            // 
            // transferTextBox
            // 
            this.transferTextBox.Location = new System.Drawing.Point(150, 64);
            this.transferTextBox.Name = "transferTextBox";
            this.transferTextBox.Size = new System.Drawing.Size(100, 22);
            this.transferTextBox.TabIndex = 5;
            this.transferTextBox.Text = "0";
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(324, 39);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(136, 38);
            this.printBtn.TabIndex = 6;
            this.printBtn.Text = "Makbuzu Kaydet";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(324, 83);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(136, 29);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "İptal";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.BackColor = System.Drawing.Color.Transparent;
            this.totalLbl.ForeColor = System.Drawing.Color.White;
            this.totalLbl.Location = new System.Drawing.Point(147, 122);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(59, 17);
            this.totalLbl.TabIndex = 8;
            this.totalLbl.Text = "Toplam:";
            // 
            // infoLbl
            // 
            this.infoLbl.AutoSize = true;
            this.infoLbl.BackColor = System.Drawing.Color.Transparent;
            this.infoLbl.ForeColor = System.Drawing.Color.White;
            this.infoLbl.Location = new System.Drawing.Point(80, 9);
            this.infoLbl.Name = "infoLbl";
            this.infoLbl.Size = new System.Drawing.Size(31, 17);
            this.infoLbl.TabIndex = 9;
            this.infoLbl.Text = "Info";
            // 
            // wrongLbl
            // 
            this.wrongLbl.AutoSize = true;
            this.wrongLbl.BackColor = System.Drawing.Color.Transparent;
            this.wrongLbl.ForeColor = System.Drawing.Color.Red;
            this.wrongLbl.Location = new System.Drawing.Point(147, 139);
            this.wrongLbl.Name = "wrongLbl";
            this.wrongLbl.Size = new System.Drawing.Size(129, 17);
            this.wrongLbl.TabIndex = 10;
            this.wrongLbl.Text = "Hatalı tutar girdiniz!";
            this.wrongLbl.Visible = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xlsx";
            this.saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(513, 167);
            this.Controls.Add(this.wrongLbl);
            this.Controls.Add(this.infoLbl);
            this.Controls.Add(this.totalLbl);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.transferTextBox);
            this.Controls.Add(this.cashTextBox);
            this.Controls.Add(this.cardTextBox);
            this.Controls.Add(this.transferLbl);
            this.Controls.Add(this.cashLbl);
            this.Controls.Add(this.cardLbl);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cardLbl;
        private System.Windows.Forms.Label cashLbl;
        private System.Windows.Forms.Label transferLbl;
        private System.Windows.Forms.TextBox cashTextBox;
        private System.Windows.Forms.TextBox transferTextBox;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label infoLbl;
        private System.Windows.Forms.Label wrongLbl;
        private System.Windows.Forms.TextBox cardTextBox;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}