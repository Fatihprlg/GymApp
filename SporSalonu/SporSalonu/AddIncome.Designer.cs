﻿namespace SporSalonu
{
    partial class AddIncome
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
            System.Windows.Forms.Label gelen_ParaLabel;
            System.Windows.Forms.Label açıklamaLabel;
            System.Windows.Forms.Label tahsilLabel;
            System.Windows.Forms.Label tarihLabel1;
            System.Windows.Forms.Label müşteriLabel;
            System.Windows.Forms.Label label1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddIncome));
            this.accountingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.accountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet = new SporSalonu.DatabaseDataSet();
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
            this.accountingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.gelen_ParaTextBox = new System.Windows.Forms.TextBox();
            this.açıklamaTextBox = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.accountingTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.AccountingTableAdapter();
            this.tableAdapterManager = new SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.membersTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.MembersTableAdapter();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tahsilCheckBox = new System.Windows.Forms.CheckBox();
            this.tarihDateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.müşteriTextBox = new System.Windows.Forms.TextBox();
            this.aidatChck = new System.Windows.Forms.CheckBox();
            this.membersCBox = new System.Windows.Forms.ComboBox();
            gelen_ParaLabel = new System.Windows.Forms.Label();
            açıklamaLabel = new System.Windows.Forms.Label();
            tahsilLabel = new System.Windows.Forms.Label();
            tarihLabel1 = new System.Windows.Forms.Label();
            müşteriLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingNavigator)).BeginInit();
            this.accountingBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gelen_ParaLabel
            // 
            gelen_ParaLabel.AutoSize = true;
            gelen_ParaLabel.BackColor = System.Drawing.Color.Transparent;
            gelen_ParaLabel.ForeColor = System.Drawing.Color.White;
            gelen_ParaLabel.Location = new System.Drawing.Point(6, 15);
            gelen_ParaLabel.Name = "gelen_ParaLabel";
            gelen_ParaLabel.Size = new System.Drawing.Size(50, 17);
            gelen_ParaLabel.TabIndex = 3;
            gelen_ParaLabel.Text = "Miktar:";
            // 
            // açıklamaLabel
            // 
            açıklamaLabel.AutoSize = true;
            açıklamaLabel.BackColor = System.Drawing.Color.Transparent;
            açıklamaLabel.ForeColor = System.Drawing.Color.White;
            açıklamaLabel.Location = new System.Drawing.Point(6, 74);
            açıklamaLabel.Name = "açıklamaLabel";
            açıklamaLabel.Size = new System.Drawing.Size(68, 17);
            açıklamaLabel.TabIndex = 9;
            açıklamaLabel.Text = "Açıklama:";
            // 
            // tahsilLabel
            // 
            tahsilLabel.AutoSize = true;
            tahsilLabel.BackColor = System.Drawing.Color.Transparent;
            tahsilLabel.ForeColor = System.Drawing.Color.White;
            tahsilLabel.Location = new System.Drawing.Point(210, 101);
            tahsilLabel.Name = "tahsilLabel";
            tahsilLabel.Size = new System.Drawing.Size(50, 17);
            tahsilLabel.TabIndex = 15;
            tahsilLabel.Text = "Tahsil:";
            // 
            // tarihLabel1
            // 
            tarihLabel1.AutoSize = true;
            tarihLabel1.BackColor = System.Drawing.Color.Transparent;
            tarihLabel1.ForeColor = System.Drawing.Color.White;
            tarihLabel1.Location = new System.Drawing.Point(6, 102);
            tarihLabel1.Name = "tarihLabel1";
            tarihLabel1.Size = new System.Drawing.Size(45, 17);
            tarihLabel1.TabIndex = 16;
            tarihLabel1.Text = "Tarih:";
            // 
            // müşteriLabel
            // 
            müşteriLabel.AutoSize = true;
            müşteriLabel.BackColor = System.Drawing.Color.Transparent;
            müşteriLabel.ForeColor = System.Drawing.Color.White;
            müşteriLabel.Location = new System.Drawing.Point(6, 46);
            müşteriLabel.Name = "müşteriLabel";
            müşteriLabel.Size = new System.Drawing.Size(58, 17);
            müşteriLabel.TabIndex = 14;
            müşteriLabel.Text = "Müşteri:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(214, 120);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(44, 17);
            label1.TabIndex = 19;
            label1.Text = "Aidat:";
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
            this.accountingBindingNavigator.Size = new System.Drawing.Size(554, 27);
            this.accountingBindingNavigator.TabIndex = 0;
            this.accountingBindingNavigator.Text = "bindingNavigator1";
            this.accountingBindingNavigator.Visible = false;
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
            // accountingBindingSource
            // 
            this.accountingBindingSource.DataMember = "Accounting";
            this.accountingBindingSource.DataSource = this.databaseDataSet;
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // accountingBindingNavigatorSaveItem
            // 
            this.accountingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.accountingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("accountingBindingNavigatorSaveItem.Image")));
            this.accountingBindingNavigatorSaveItem.Name = "accountingBindingNavigatorSaveItem";
            this.accountingBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.accountingBindingNavigatorSaveItem.Text = "Save Data";
            this.accountingBindingNavigatorSaveItem.Click += new System.EventHandler(this.accountingBindingNavigatorSaveItem_Click);
            // 
            // gelen_ParaTextBox
            // 
            this.gelen_ParaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "Gelen Para", true));
            this.gelen_ParaTextBox.Location = new System.Drawing.Point(96, 12);
            this.gelen_ParaTextBox.Name = "gelen_ParaTextBox";
            this.gelen_ParaTextBox.Size = new System.Drawing.Size(200, 22);
            this.gelen_ParaTextBox.TabIndex = 4;
            // 
            // açıklamaTextBox
            // 
            this.açıklamaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "Açıklama", true));
            this.açıklamaTextBox.Location = new System.Drawing.Point(96, 71);
            this.açıklamaTextBox.Name = "açıklamaTextBox";
            this.açıklamaTextBox.Size = new System.Drawing.Size(200, 22);
            this.açıklamaTextBox.TabIndex = 10;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(341, 28);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(91, 32);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(341, 74);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(91, 32);
            this.backBtn.TabIndex = 14;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
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
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.databaseDataSet;
            // 
            // tahsilCheckBox
            // 
            this.tahsilCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.tahsilCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.accountingBindingSource, "Tahsil", true));
            this.tahsilCheckBox.Location = new System.Drawing.Point(264, 99);
            this.tahsilCheckBox.Name = "tahsilCheckBox";
            this.tahsilCheckBox.Size = new System.Drawing.Size(32, 24);
            this.tahsilCheckBox.TabIndex = 16;
            this.tahsilCheckBox.UseVisualStyleBackColor = false;
            // 
            // tarihDateTimePicker1
            // 
            this.tarihDateTimePicker1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "Tarih", true));
            this.tarihDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tarihDateTimePicker1.Location = new System.Drawing.Point(96, 99);
            this.tarihDateTimePicker1.Name = "tarihDateTimePicker1";
            this.tarihDateTimePicker1.Size = new System.Drawing.Size(91, 22);
            this.tarihDateTimePicker1.TabIndex = 17;
            this.tarihDateTimePicker1.Value = new System.DateTime(2020, 7, 9, 16, 46, 20, 0);
            // 
            // müşteriTextBox
            // 
            this.müşteriTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.accountingBindingSource, "Müşteri", true));
            this.müşteriTextBox.Location = new System.Drawing.Point(96, 43);
            this.müşteriTextBox.Name = "müşteriTextBox";
            this.müşteriTextBox.Size = new System.Drawing.Size(200, 22);
            this.müşteriTextBox.TabIndex = 15;
            // 
            // aidatChck
            // 
            this.aidatChck.AutoSize = true;
            this.aidatChck.BackColor = System.Drawing.Color.Transparent;
            this.aidatChck.Location = new System.Drawing.Point(264, 121);
            this.aidatChck.Name = "aidatChck";
            this.aidatChck.Size = new System.Drawing.Size(18, 17);
            this.aidatChck.TabIndex = 18;
            this.aidatChck.UseVisualStyleBackColor = false;
            this.aidatChck.CheckStateChanged += new System.EventHandler(this.aidatChck_CheckStateChanged);
            // 
            // membersCBox
            // 
            this.membersCBox.FormattingEnabled = true;
            this.membersCBox.Location = new System.Drawing.Point(96, 41);
            this.membersCBox.Name = "membersCBox";
            this.membersCBox.Size = new System.Drawing.Size(200, 24);
            this.membersCBox.TabIndex = 20;
            this.membersCBox.Visible = false;
            // 
            // AddIncome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.ClientSize = new System.Drawing.Size(554, 152);
            this.Controls.Add(this.membersCBox);
            this.Controls.Add(label1);
            this.Controls.Add(this.aidatChck);
            this.Controls.Add(tarihLabel1);
            this.Controls.Add(this.tarihDateTimePicker1);
            this.Controls.Add(tahsilLabel);
            this.Controls.Add(this.tahsilCheckBox);
            this.Controls.Add(müşteriLabel);
            this.Controls.Add(this.müşteriTextBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(gelen_ParaLabel);
            this.Controls.Add(this.gelen_ParaTextBox);
            this.Controls.Add(açıklamaLabel);
            this.Controls.Add(this.açıklamaTextBox);
            this.Controls.Add(this.accountingBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddIncome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIncome";
            this.Load += new System.EventHandler(this.AddIncome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingNavigator)).EndInit();
            this.accountingBindingNavigator.ResumeLayout(false);
            this.accountingBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
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
        private DatabaseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private System.Windows.Forms.TextBox gelen_ParaTextBox;
        private System.Windows.Forms.TextBox açıklamaTextBox;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.CheckBox tahsilCheckBox;
        private System.Windows.Forms.DateTimePicker tarihDateTimePicker1;
        private System.Windows.Forms.TextBox müşteriTextBox;
        private System.Windows.Forms.CheckBox aidatChck;
        private System.Windows.Forms.ComboBox membersCBox;
    }
}