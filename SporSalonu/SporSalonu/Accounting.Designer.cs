namespace SporSalonu
{
    partial class Accounting
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
            this.accountingList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDate = new System.Windows.Forms.DateTimePicker();
            this.endDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.incomeBtn = new System.Windows.Forms.Button();
            this.expenseBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.receiptBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // accountingList
            // 
            this.accountingList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.accountingList.CheckBoxes = true;
            this.accountingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.accountingList.ForeColor = System.Drawing.SystemColors.MenuText;
            this.accountingList.FullRowSelect = true;
            this.accountingList.HideSelection = false;
            this.accountingList.Location = new System.Drawing.Point(12, 9);
            this.accountingList.Name = "accountingList";
            this.accountingList.Size = new System.Drawing.Size(463, 426);
            this.accountingList.TabIndex = 0;
            this.accountingList.UseCompatibleStateImageBehavior = false;
            this.accountingList.View = System.Windows.Forms.View.Details;
            this.accountingList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.accountingList_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 34;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Miktar";
            this.columnHeader2.Width = 90;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Müşteri";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Açıklama";
            this.columnHeader4.Width = 102;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tarih";
            this.columnHeader5.Width = 80;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tahsil";
            // 
            // startDate
            // 
            this.startDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.startDate.Location = new System.Drawing.Point(481, 29);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(146, 22);
            this.startDate.TabIndex = 1;
            // 
            // endDate
            // 
            this.endDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDate.Location = new System.Drawing.Point(633, 29);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(142, 22);
            this.endDate.TabIndex = 2;
            this.endDate.Value = new System.DateTime(2020, 7, 8, 2, 46, 3, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(481, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Başlangıç Tarihi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(630, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bitiş Tarihi";
            // 
            // incomeBtn
            // 
            this.incomeBtn.Location = new System.Drawing.Point(580, 57);
            this.incomeBtn.Name = "incomeBtn";
            this.incomeBtn.Size = new System.Drawing.Size(100, 46);
            this.incomeBtn.TabIndex = 5;
            this.incomeBtn.Text = "Gelir Ekle";
            this.incomeBtn.UseVisualStyleBackColor = true;
            this.incomeBtn.Click += new System.EventHandler(this.incomeBtn_Click);
            // 
            // expenseBtn
            // 
            this.expenseBtn.Location = new System.Drawing.Point(580, 109);
            this.expenseBtn.Name = "expenseBtn";
            this.expenseBtn.Size = new System.Drawing.Size(100, 46);
            this.expenseBtn.TabIndex = 6;
            this.expenseBtn.Text = "Gider Ekle";
            this.expenseBtn.UseVisualStyleBackColor = true;
            this.expenseBtn.Click += new System.EventHandler(this.expenseBtn_Click);
            // 
            // reportBtn
            // 
            this.reportBtn.Location = new System.Drawing.Point(580, 161);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(100, 46);
            this.reportBtn.TabIndex = 7;
            this.reportBtn.Text = "Rapor";
            this.reportBtn.UseVisualStyleBackColor = true;
            this.reportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // receiptBtn
            // 
            this.receiptBtn.Enabled = false;
            this.receiptBtn.Location = new System.Drawing.Point(580, 213);
            this.receiptBtn.Name = "receiptBtn";
            this.receiptBtn.Size = new System.Drawing.Size(100, 46);
            this.receiptBtn.TabIndex = 8;
            this.receiptBtn.Text = "Makbuz";
            this.receiptBtn.UseVisualStyleBackColor = true;
            this.receiptBtn.Click += new System.EventHandler(this.receiptBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(580, 389);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(100, 46);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xlsx";
            this.saveFileDialog1.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
            // 
            // Accounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.receiptBtn);
            this.Controls.Add(this.reportBtn);
            this.Controls.Add(this.expenseBtn);
            this.Controls.Add(this.incomeBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.endDate);
            this.Controls.Add(this.startDate);
            this.Controls.Add(this.accountingList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accounting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounting";
            this.Load += new System.EventHandler(this.Accounting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView accountingList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.DateTimePicker startDate;
        private System.Windows.Forms.DateTimePicker endDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button incomeBtn;
        private System.Windows.Forms.Button expenseBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button receiptBtn;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}