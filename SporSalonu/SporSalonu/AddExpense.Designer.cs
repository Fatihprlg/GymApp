namespace SporSalonu
{
    partial class AddExpense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddExpense));
            System.Windows.Forms.Label giden_ParaLabel;
            System.Windows.Forms.Label açıklamaLabel;
            System.Windows.Forms.Label tarihLabel;
            this.databaseDataSet = new SporSalonu.DatabaseDataSet();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountingTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.AccountingTableAdapter();
            this.tableAdapterManager = new SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.accountingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.accountingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.giden_ParaTextBox = new System.Windows.Forms.TextBox();
            this.açıklamaTextBox = new System.Windows.Forms.TextBox();
            this.tarihDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.backBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            giden_ParaLabel = new System.Windows.Forms.Label();
            açıklamaLabel = new System.Windows.Forms.Label();
            tarihLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingNavigator)).BeginInit();
            this.accountingBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "Accounting";
            this.accountingBindingSource.DataSource = this.databaseDataSet;
            // 
            // accountingTableAdapter
            // 
            this.accountingTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AccountingTableAdapter = this.accountingTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = null;
            this.tableAdapterManager.BransUyeTableAdapter = null;
            this.tableAdapterManager.businessOwnerTableAdapter = null;
            this.tableAdapterManager.CoachesTableAdapter = null;
            this.tableAdapterManager.memberInfoTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // accountingBindingNavigator
            // 
            this.accountingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.accountingBindingNavigator.BindingSource = this.accountingBindingSource;
            this.accountingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.accountingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.accountingBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.accountingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.accountingBindingNavigatorSaveItem});
            this.accountingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.accountingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.accountingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.accountingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.accountingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.accountingBindingNavigator.Name = "accountingBindingNavigator";
            this.accountingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.accountingBindingNavigator.Size = new System.Drawing.Size(467, 27);
            this.accountingBindingNavigator.TabIndex = 0;
            this.accountingBindingNavigator.Text = "bindingNavigator1";
            this.accountingBindingNavigator.Visible = false;
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(45, 24);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 27);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(29, 24);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // accountingBindingNavigatorSaveItem
            // 
            this.accountingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountingBindingNavigatorSaveItem.Image")));
            this.accountingBindingNavigatorSaveItem.Name = "accountingBindingNavigatorSaveItem";
            this.accountingBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.accountingBindingNavigatorSaveItem.Text = "Save Data";
            this.accountingBindingNavigatorSaveItem.Click += new System.EventHandler(this.accountingBindingNavigatorSaveItem_Click_1);
            // 
            // giden_ParaLabel
            // 
            giden_ParaLabel.AutoSize = true;
            giden_ParaLabel.BackColor = System.Drawing.Color.Transparent;
            giden_ParaLabel.ForeColor = System.Drawing.Color.Orange;
            giden_ParaLabel.Location = new System.Drawing.Point(19, 32);
            giden_ParaLabel.Name = "giden_ParaLabel";
            giden_ParaLabel.Size = new System.Drawing.Size(84, 17);
            giden_ParaLabel.TabIndex = 5;
            giden_ParaLabel.Text = "Giden Para:";
            // 
            // giden_ParaTextBox
            // 
            this.giden_ParaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "Giden Para", true));
            this.giden_ParaTextBox.Location = new System.Drawing.Point(109, 29);
            this.giden_ParaTextBox.Name = "giden_ParaTextBox";
            this.giden_ParaTextBox.Size = new System.Drawing.Size(200, 22);
            this.giden_ParaTextBox.TabIndex = 6;
            // 
            // açıklamaLabel
            // 
            açıklamaLabel.AutoSize = true;
            açıklamaLabel.BackColor = System.Drawing.Color.Transparent;
            açıklamaLabel.ForeColor = System.Drawing.Color.Orange;
            açıklamaLabel.Location = new System.Drawing.Point(19, 60);
            açıklamaLabel.Name = "açıklamaLabel";
            açıklamaLabel.Size = new System.Drawing.Size(68, 17);
            açıklamaLabel.TabIndex = 9;
            açıklamaLabel.Text = "Açıklama:";
            // 
            // açıklamaTextBox
            // 
            this.açıklamaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "Açıklama", true));
            this.açıklamaTextBox.Location = new System.Drawing.Point(109, 57);
            this.açıklamaTextBox.Name = "açıklamaTextBox";
            this.açıklamaTextBox.Size = new System.Drawing.Size(200, 22);
            this.açıklamaTextBox.TabIndex = 10;
            // 
            // tarihLabel
            // 
            tarihLabel.AutoSize = true;
            tarihLabel.BackColor = System.Drawing.Color.Transparent;
            tarihLabel.ForeColor = System.Drawing.Color.Orange;
            tarihLabel.Location = new System.Drawing.Point(19, 89);
            tarihLabel.Name = "tarihLabel";
            tarihLabel.Size = new System.Drawing.Size(45, 17);
            tarihLabel.TabIndex = 11;
            tarihLabel.Text = "Tarih:";
            // 
            // tarihDateTimePicker
            // 
            this.tarihDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.accountingBindingSource, "Tarih", true));
            this.tarihDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihDateTimePicker.Location = new System.Drawing.Point(109, 85);
            this.tarihDateTimePicker.Name = "tarihDateTimePicker";
            this.tarihDateTimePicker.Size = new System.Drawing.Size(86, 22);
            this.tarihDateTimePicker.TabIndex = 12;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(341, 76);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(91, 32);
            this.backBtn.TabIndex = 16;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(341, 30);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 32);
            this.saveBtn.TabIndex = 15;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // AddExpense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.colors_hd_backgrounds;
            this.ClientSize = new System.Drawing.Size(467, 141);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(giden_ParaLabel);
            this.Controls.Add(this.giden_ParaTextBox);
            this.Controls.Add(açıklamaLabel);
            this.Controls.Add(this.açıklamaTextBox);
            this.Controls.Add(tarihLabel);
            this.Controls.Add(this.tarihDateTimePicker);
            this.Controls.Add(this.accountingBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddExpense";
            this.Text = "AddExpense";
            this.Load += new System.EventHandler(this.AddExpense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingNavigator)).EndInit();
            this.accountingBindingNavigator.ResumeLayout(false);
            this.accountingBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource accountingBindingSource;
        private DatabaseDataSetTableAdapters.AccountingTableAdapter accountingTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator accountingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton accountingBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox giden_ParaTextBox;
        private System.Windows.Forms.TextBox açıklamaTextBox;
        private System.Windows.Forms.DateTimePicker tarihDateTimePicker;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}