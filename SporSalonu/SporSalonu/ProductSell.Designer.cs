namespace SporSalonu
{
    partial class ProductSell
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
            System.Windows.Forms.Label müşteriLabel;
            System.Windows.Forms.Label ürün_IDLabel;
            System.Windows.Forms.Label satış_TarihiLabel;
            System.Windows.Forms.Label ürün_AdıLabel;
            System.Windows.Forms.Label adetLabel;
            System.Windows.Forms.Label toplam_FiyatLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductSell));
            this.müşteriTextBox = new System.Windows.Forms.TextBox();
            this.mnyCheck = new System.Windows.Forms.CheckBox();
            this.ürün_IDTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.sellBtn = new System.Windows.Forms.Button();
            this.satış_TarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SporSalonu.DatabaseDataSet();
            this.ürün_AdıComboBox = new System.Windows.Forms.ComboBox();
            this.adetTextBox = new System.Windows.Forms.TextBox();
            this.toplam_FiyatLabel1 = new System.Windows.Forms.Label();
            this.sellTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.SellTableAdapter();
            this.tableAdapterManager = new SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.sellBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.sellBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            müşteriLabel = new System.Windows.Forms.Label();
            ürün_IDLabel = new System.Windows.Forms.Label();
            satış_TarihiLabel = new System.Windows.Forms.Label();
            ürün_AdıLabel = new System.Windows.Forms.Label();
            adetLabel = new System.Windows.Forms.Label();
            toplam_FiyatLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingNavigator)).BeginInit();
            this.sellBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // müşteriLabel
            // 
            müşteriLabel.AutoSize = true;
            müşteriLabel.BackColor = System.Drawing.Color.Transparent;
            müşteriLabel.ForeColor = System.Drawing.Color.White;
            müşteriLabel.Location = new System.Drawing.Point(18, 49);
            müşteriLabel.Name = "müşteriLabel";
            müşteriLabel.Size = new System.Drawing.Size(58, 17);
            müşteriLabel.TabIndex = 28;
            müşteriLabel.Text = "Müşteri:";
            // 
            // ürün_IDLabel
            // 
            ürün_IDLabel.AutoSize = true;
            ürün_IDLabel.BackColor = System.Drawing.Color.Transparent;
            ürün_IDLabel.ForeColor = System.Drawing.Color.White;
            ürün_IDLabel.Location = new System.Drawing.Point(18, 76);
            ürün_IDLabel.Name = "ürün_IDLabel";
            ürün_IDLabel.Size = new System.Drawing.Size(60, 17);
            ürün_IDLabel.TabIndex = 25;
            ürün_IDLabel.Text = "Ürün ID:";
            // 
            // satış_TarihiLabel
            // 
            satış_TarihiLabel.AutoSize = true;
            satış_TarihiLabel.BackColor = System.Drawing.Color.Transparent;
            satış_TarihiLabel.ForeColor = System.Drawing.Color.White;
            satış_TarihiLabel.Location = new System.Drawing.Point(18, 19);
            satış_TarihiLabel.Name = "satış_TarihiLabel";
            satış_TarihiLabel.Size = new System.Drawing.Size(83, 17);
            satış_TarihiLabel.TabIndex = 16;
            satış_TarihiLabel.Text = "Satış Tarihi:";
            // 
            // ürün_AdıLabel
            // 
            ürün_AdıLabel.AutoSize = true;
            ürün_AdıLabel.BackColor = System.Drawing.Color.Transparent;
            ürün_AdıLabel.ForeColor = System.Drawing.Color.White;
            ürün_AdıLabel.Location = new System.Drawing.Point(18, 104);
            ürün_AdıLabel.Name = "ürün_AdıLabel";
            ürün_AdıLabel.Size = new System.Drawing.Size(67, 17);
            ürün_AdıLabel.TabIndex = 18;
            ürün_AdıLabel.Text = "Ürün Adı:";
            // 
            // adetLabel
            // 
            adetLabel.AutoSize = true;
            adetLabel.BackColor = System.Drawing.Color.Transparent;
            adetLabel.ForeColor = System.Drawing.Color.White;
            adetLabel.Location = new System.Drawing.Point(18, 135);
            adetLabel.Name = "adetLabel";
            adetLabel.Size = new System.Drawing.Size(41, 17);
            adetLabel.TabIndex = 20;
            adetLabel.Text = "Adet:";
            // 
            // toplam_FiyatLabel
            // 
            toplam_FiyatLabel.AutoSize = true;
            toplam_FiyatLabel.BackColor = System.Drawing.Color.Transparent;
            toplam_FiyatLabel.ForeColor = System.Drawing.Color.White;
            toplam_FiyatLabel.Location = new System.Drawing.Point(18, 157);
            toplam_FiyatLabel.Name = "toplam_FiyatLabel";
            toplam_FiyatLabel.Size = new System.Drawing.Size(93, 17);
            toplam_FiyatLabel.TabIndex = 22;
            toplam_FiyatLabel.Text = "Toplam Fiyat:";
            // 
            // müşteriTextBox
            // 
            this.müşteriTextBox.Location = new System.Drawing.Point(117, 46);
            this.müşteriTextBox.Name = "müşteriTextBox";
            this.müşteriTextBox.Size = new System.Drawing.Size(100, 22);
            this.müşteriTextBox.TabIndex = 30;
            // 
            // mnyCheck
            // 
            this.mnyCheck.AutoSize = true;
            this.mnyCheck.BackColor = System.Drawing.Color.Transparent;
            this.mnyCheck.ForeColor = System.Drawing.Color.White;
            this.mnyCheck.Location = new System.Drawing.Point(219, 183);
            this.mnyCheck.Name = "mnyCheck";
            this.mnyCheck.Size = new System.Drawing.Size(98, 21);
            this.mnyCheck.TabIndex = 29;
            this.mnyCheck.Text = "Para Alındı";
            this.mnyCheck.UseVisualStyleBackColor = false;
            // 
            // ürün_IDTextBox
            // 
            this.ürün_IDTextBox.Enabled = false;
            this.ürün_IDTextBox.Location = new System.Drawing.Point(117, 73);
            this.ürün_IDTextBox.Name = "ürün_IDTextBox";
            this.ürün_IDTextBox.Size = new System.Drawing.Size(100, 22);
            this.ürün_IDTextBox.TabIndex = 27;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(360, 84);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(116, 41);
            this.cancelBtn.TabIndex = 26;
            this.cancelBtn.Text = "İptal";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // sellBtn
            // 
            this.sellBtn.Location = new System.Drawing.Point(360, 46);
            this.sellBtn.Name = "sellBtn";
            this.sellBtn.Size = new System.Drawing.Size(116, 36);
            this.sellBtn.TabIndex = 24;
            this.sellBtn.Text = "Satış Yap";
            this.sellBtn.UseVisualStyleBackColor = true;
            this.sellBtn.Click += new System.EventHandler(this.sellBtn_Click);
            // 
            // satış_TarihiDateTimePicker
            // 
            this.satış_TarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.sellBindingSource, "Satış Tarihi", true));
            this.satış_TarihiDateTimePicker.Enabled = false;
            this.satış_TarihiDateTimePicker.Location = new System.Drawing.Point(117, 15);
            this.satış_TarihiDateTimePicker.Name = "satış_TarihiDateTimePicker";
            this.satış_TarihiDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.satış_TarihiDateTimePicker.TabIndex = 17;
            this.satış_TarihiDateTimePicker.Value = new System.DateTime(2020, 7, 9, 17, 44, 57, 0);
            // 
            // sellBindingSource
            // 
            this.sellBindingSource.DataMember = "Sell";
            this.sellBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ürün_AdıComboBox
            // 
            this.ürün_AdıComboBox.FormattingEnabled = true;
            this.ürün_AdıComboBox.Location = new System.Drawing.Point(117, 101);
            this.ürün_AdıComboBox.Name = "ürün_AdıComboBox";
            this.ürün_AdıComboBox.Size = new System.Drawing.Size(200, 24);
            this.ürün_AdıComboBox.TabIndex = 19;
            this.ürün_AdıComboBox.SelectedIndexChanged += new System.EventHandler(this.ürün_AdıComboBox_SelectedIndexChanged);
            // 
            // adetTextBox
            // 
            this.adetTextBox.Location = new System.Drawing.Point(117, 132);
            this.adetTextBox.Name = "adetTextBox";
            this.adetTextBox.Size = new System.Drawing.Size(200, 22);
            this.adetTextBox.TabIndex = 21;
            this.adetTextBox.Leave += new System.EventHandler(this.adetTextBox_Leave);
            // 
            // toplam_FiyatLabel1
            // 
            this.toplam_FiyatLabel1.Location = new System.Drawing.Point(117, 157);
            this.toplam_FiyatLabel1.Name = "toplam_FiyatLabel1";
            this.toplam_FiyatLabel1.Size = new System.Drawing.Size(200, 23);
            this.toplam_FiyatLabel1.TabIndex = 23;
            this.toplam_FiyatLabel1.Text = "0";
            // 
            // sellTableAdapter
            // 
            this.sellTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = null;
            this.tableAdapterManager.BransUyeTableAdapter = null;
            this.tableAdapterManager.businessOwnerTableAdapter = null;
            this.tableAdapterManager.CoachesTableAdapter = null;
            this.tableAdapterManager.memberInfoTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = this.sellTableAdapter;
            this.tableAdapterManager.UpdateOrder = SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // sellBindingNavigator
            // 
            this.sellBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.sellBindingNavigator.BindingSource = this.sellBindingSource;
            this.sellBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.sellBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.sellBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sellBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.sellBindingNavigatorSaveItem});
            this.sellBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.sellBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.sellBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.sellBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.sellBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.sellBindingNavigator.Name = "sellBindingNavigator";
            this.sellBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.sellBindingNavigator.Size = new System.Drawing.Size(800, 27);
            this.sellBindingNavigator.TabIndex = 31;
            this.sellBindingNavigator.Text = "bindingNavigator1";
            this.sellBindingNavigator.Visible = false;
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 27);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // sellBindingNavigatorSaveItem
            // 
            this.sellBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.sellBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("sellBindingNavigatorSaveItem.Image")));
            this.sellBindingNavigatorSaveItem.Name = "sellBindingNavigatorSaveItem";
            this.sellBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.sellBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // ProductSell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(525, 229);
            this.Controls.Add(this.sellBindingNavigator);
            this.Controls.Add(müşteriLabel);
            this.Controls.Add(this.müşteriTextBox);
            this.Controls.Add(this.mnyCheck);
            this.Controls.Add(ürün_IDLabel);
            this.Controls.Add(this.ürün_IDTextBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.sellBtn);
            this.Controls.Add(satış_TarihiLabel);
            this.Controls.Add(this.satış_TarihiDateTimePicker);
            this.Controls.Add(ürün_AdıLabel);
            this.Controls.Add(this.ürün_AdıComboBox);
            this.Controls.Add(adetLabel);
            this.Controls.Add(this.adetTextBox);
            this.Controls.Add(toplam_FiyatLabel);
            this.Controls.Add(this.toplam_FiyatLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductSell";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProductSell";
            this.Load += new System.EventHandler(this.ProductSell_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingNavigator)).EndInit();
            this.sellBindingNavigator.ResumeLayout(false);
            this.sellBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox müşteriTextBox;
        private System.Windows.Forms.CheckBox mnyCheck;
        private System.Windows.Forms.TextBox ürün_IDTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button sellBtn;
        private System.Windows.Forms.DateTimePicker satış_TarihiDateTimePicker;
        private System.Windows.Forms.ComboBox ürün_AdıComboBox;
        private System.Windows.Forms.TextBox adetTextBox;
        private System.Windows.Forms.Label toplam_FiyatLabel1;
        private System.Windows.Forms.BindingSource sellBindingSource;
        private DatabaseDataSet databaseDataSet;
        private DatabaseDataSetTableAdapters.SellTableAdapter sellTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator sellBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton sellBindingNavigatorSaveItem;
    }
}