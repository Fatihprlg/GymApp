namespace SporSalonu
{
    partial class UpdateCoach
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
            System.Windows.Forms.Label bransLabel;
            System.Windows.Forms.Label numaraLabel;
            System.Windows.Forms.Label eMailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateCoach));
            this.databaseDataSet = new SporSalonu.DatabaseDataSet();
            this.coachesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachesTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.CoachesTableAdapter();
            this.tableAdapterManager = new SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.coachesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.coachesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.bransTextBox = new System.Windows.Forms.TextBox();
            this.numaraTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.coachesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            adLabel = new System.Windows.Forms.Label();
            soyadLabel = new System.Windows.Forms.Label();
            bransLabel = new System.Windows.Forms.Label();
            numaraLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingNavigator)).BeginInit();
            this.coachesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coachesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.BackColor = System.Drawing.Color.Transparent;
            adLabel.ForeColor = System.Drawing.Color.White;
            adLabel.Location = new System.Drawing.Point(43, 45);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(29, 17);
            adLabel.TabIndex = 3;
            adLabel.Text = "Ad:";
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.BackColor = System.Drawing.Color.Transparent;
            soyadLabel.ForeColor = System.Drawing.Color.White;
            soyadLabel.Location = new System.Drawing.Point(43, 73);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new System.Drawing.Size(52, 17);
            soyadLabel.TabIndex = 5;
            soyadLabel.Text = "Soyad:";
            // 
            // bransLabel
            // 
            bransLabel.AutoSize = true;
            bransLabel.BackColor = System.Drawing.Color.Transparent;
            bransLabel.ForeColor = System.Drawing.Color.White;
            bransLabel.Location = new System.Drawing.Point(43, 101);
            bransLabel.Name = "bransLabel";
            bransLabel.Size = new System.Drawing.Size(49, 17);
            bransLabel.TabIndex = 7;
            bransLabel.Text = "Brans:";
            // 
            // numaraLabel
            // 
            numaraLabel.AutoSize = true;
            numaraLabel.BackColor = System.Drawing.Color.Transparent;
            numaraLabel.ForeColor = System.Drawing.Color.White;
            numaraLabel.Location = new System.Drawing.Point(43, 129);
            numaraLabel.Name = "numaraLabel";
            numaraLabel.Size = new System.Drawing.Size(62, 17);
            numaraLabel.TabIndex = 9;
            numaraLabel.Text = "Numara:";
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.BackColor = System.Drawing.Color.Transparent;
            eMailLabel.ForeColor = System.Drawing.Color.White;
            eMailLabel.Location = new System.Drawing.Point(43, 157);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(49, 17);
            eMailLabel.TabIndex = 11;
            eMailLabel.Text = "e Mail:";
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
            // coachesBindingNavigator
            // 
            this.coachesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coachesBindingNavigator.BindingSource = this.coachesBindingSource;
            this.coachesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coachesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coachesBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.coachesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.coachesBindingNavigatorSaveItem});
            this.coachesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.coachesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.coachesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.coachesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.coachesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.coachesBindingNavigator.Name = "coachesBindingNavigator";
            this.coachesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.coachesBindingNavigator.Size = new System.Drawing.Size(639, 27);
            this.coachesBindingNavigator.TabIndex = 0;
            this.coachesBindingNavigator.Text = "bindingNavigator1";
            this.coachesBindingNavigator.Visible = false;
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
            // coachesBindingNavigatorSaveItem
            // 
            this.coachesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.coachesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("coachesBindingNavigatorSaveItem.Image")));
            this.coachesBindingNavigatorSaveItem.Name = "coachesBindingNavigatorSaveItem";
            this.coachesBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.coachesBindingNavigatorSaveItem.Text = "Save Data";
            this.coachesBindingNavigatorSaveItem.Click += new System.EventHandler(this.coachesBindingNavigatorSaveItem_Click);
            // 
            // adTextBox
            // 
            this.adTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "Ad", true));
            this.adTextBox.Location = new System.Drawing.Point(111, 42);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 22);
            this.adTextBox.TabIndex = 4;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "Soyad", true));
            this.soyadTextBox.Location = new System.Drawing.Point(111, 70);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(100, 22);
            this.soyadTextBox.TabIndex = 6;
            // 
            // bransTextBox
            // 
            this.bransTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "Brans", true));
            this.bransTextBox.Location = new System.Drawing.Point(111, 98);
            this.bransTextBox.Name = "bransTextBox";
            this.bransTextBox.Size = new System.Drawing.Size(100, 22);
            this.bransTextBox.TabIndex = 8;
            // 
            // numaraTextBox
            // 
            this.numaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "Numara", true));
            this.numaraTextBox.Location = new System.Drawing.Point(111, 126);
            this.numaraTextBox.Name = "numaraTextBox";
            this.numaraTextBox.Size = new System.Drawing.Size(100, 22);
            this.numaraTextBox.TabIndex = 10;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "eMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(111, 154);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(100, 22);
            this.eMailTextBox.TabIndex = 12;
            // 
            // coachesDataGridView
            // 
            this.coachesDataGridView.AutoGenerateColumns = false;
            this.coachesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.coachesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.coachesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.coachesDataGridView.DataSource = this.coachesBindingSource;
            this.coachesDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.coachesDataGridView.Location = new System.Drawing.Point(12, 192);
            this.coachesDataGridView.Name = "coachesDataGridView";
            this.coachesDataGridView.RowHeadersWidth = 51;
            this.coachesDataGridView.RowTemplate.Height = 24;
            this.coachesDataGridView.Size = new System.Drawing.Size(615, 140);
            this.coachesDataGridView.TabIndex = 12;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Ad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Ad";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Soyad";
            this.dataGridViewTextBoxColumn3.HeaderText = "Soyad";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Brans";
            this.dataGridViewTextBoxColumn4.HeaderText = "Brans";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Numara";
            this.dataGridViewTextBoxColumn5.HeaderText = "Numara";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "eMail";
            this.dataGridViewTextBoxColumn6.HeaderText = "eMail";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(496, 118);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(131, 25);
            this.saveBtn.TabIndex = 13;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(496, 149);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(131, 25);
            this.cancelBtn.TabIndex = 14;
            this.cancelBtn.Text = "Geri";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // UpdateCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(639, 344);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.coachesDataGridView);
            this.Controls.Add(adLabel);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(soyadLabel);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(bransLabel);
            this.Controls.Add(this.bransTextBox);
            this.Controls.Add(numaraLabel);
            this.Controls.Add(this.numaraTextBox);
            this.Controls.Add(eMailLabel);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(this.coachesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateCoach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCoach";
            this.Load += new System.EventHandler(this.UpdateCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingNavigator)).EndInit();
            this.coachesBindingNavigator.ResumeLayout(false);
            this.coachesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coachesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource coachesBindingSource;
        private DatabaseDataSetTableAdapters.CoachesTableAdapter coachesTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator coachesBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton coachesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox bransTextBox;
        private System.Windows.Forms.TextBox numaraTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.DataGridView coachesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}