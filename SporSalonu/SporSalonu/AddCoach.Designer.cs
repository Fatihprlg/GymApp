namespace SporSalonu
{
    partial class AddCoach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddCoach));
            this.databaseDataSet = new SporSalonu.DatabaseDataSet();
            this.coachesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coachesTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.CoachesTableAdapter();
            this.tableAdapterManager = new SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.bransTextBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.numaraTextBox = new System.Windows.Forms.TextBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
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
            this.coachesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.coachesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            adLabel = new System.Windows.Forms.Label();
            soyadLabel = new System.Windows.Forms.Label();
            bransLabel = new System.Windows.Forms.Label();
            numaraLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingNavigator)).BeginInit();
            this.coachesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.BackColor = System.Drawing.Color.Transparent;
            adLabel.ForeColor = System.Drawing.Color.White;
            adLabel.Location = new System.Drawing.Point(38, 42);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(29, 17);
            adLabel.TabIndex = 4;
            adLabel.Text = "Ad:";
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.BackColor = System.Drawing.Color.Transparent;
            soyadLabel.ForeColor = System.Drawing.Color.White;
            soyadLabel.Location = new System.Drawing.Point(38, 70);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new System.Drawing.Size(52, 17);
            soyadLabel.TabIndex = 6;
            soyadLabel.Text = "Soyad:";
            // 
            // bransLabel
            // 
            bransLabel.AutoSize = true;
            bransLabel.BackColor = System.Drawing.Color.Transparent;
            bransLabel.ForeColor = System.Drawing.Color.White;
            bransLabel.Location = new System.Drawing.Point(38, 98);
            bransLabel.Name = "bransLabel";
            bransLabel.Size = new System.Drawing.Size(49, 17);
            bransLabel.TabIndex = 8;
            bransLabel.Text = "Brans:";
            // 
            // numaraLabel
            // 
            numaraLabel.AutoSize = true;
            numaraLabel.BackColor = System.Drawing.Color.Transparent;
            numaraLabel.ForeColor = System.Drawing.Color.White;
            numaraLabel.Location = new System.Drawing.Point(38, 126);
            numaraLabel.Name = "numaraLabel";
            numaraLabel.Size = new System.Drawing.Size(62, 17);
            numaraLabel.TabIndex = 11;
            numaraLabel.Text = "Numara:";
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.BackColor = System.Drawing.Color.Transparent;
            eMailLabel.ForeColor = System.Drawing.Color.White;
            eMailLabel.Location = new System.Drawing.Point(38, 154);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(49, 17);
            eMailLabel.TabIndex = 12;
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
            // adTextBox
            // 
            this.adTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "Ad", true));
            this.adTextBox.Location = new System.Drawing.Point(106, 39);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(100, 22);
            this.adTextBox.TabIndex = 5;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "Soyad", true));
            this.soyadTextBox.Location = new System.Drawing.Point(106, 67);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(100, 22);
            this.soyadTextBox.TabIndex = 7;
            // 
            // bransTextBox
            // 
            this.bransTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "Brans", true));
            this.bransTextBox.Location = new System.Drawing.Point(106, 95);
            this.bransTextBox.Name = "bransTextBox";
            this.bransTextBox.Size = new System.Drawing.Size(100, 22);
            this.bransTextBox.TabIndex = 9;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(283, 42);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Ekle";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(283, 92);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(75, 25);
            this.backBtn.TabIndex = 11;
            this.backBtn.Text = "İptal";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // numaraTextBox
            // 
            this.numaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "Numara", true));
            this.numaraTextBox.Location = new System.Drawing.Point(106, 123);
            this.numaraTextBox.Name = "numaraTextBox";
            this.numaraTextBox.Size = new System.Drawing.Size(100, 22);
            this.numaraTextBox.TabIndex = 12;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.coachesBindingSource, "eMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(106, 151);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(100, 22);
            this.eMailTextBox.TabIndex = 13;
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // coachesBindingNavigator
            // 
            this.coachesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.coachesBindingNavigator.BindingSource = this.coachesBindingSource;
            this.coachesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.coachesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.coachesBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
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
            this.coachesBindingNavigator.Size = new System.Drawing.Size(445, 27);
            this.coachesBindingNavigator.TabIndex = 0;
            this.coachesBindingNavigator.Text = "bindingNavigator1";
            this.coachesBindingNavigator.Visible = false;
            // 
            // AddCoach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.ClientSize = new System.Drawing.Size(445, 212);
            this.Controls.Add(eMailLabel);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(numaraLabel);
            this.Controls.Add(this.numaraTextBox);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(adLabel);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(soyadLabel);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(bransLabel);
            this.Controls.Add(this.bransTextBox);
            this.Controls.Add(this.coachesBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddCoach";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddCoach";
            this.Load += new System.EventHandler(this.AddCoach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coachesBindingNavigator)).EndInit();
            this.coachesBindingNavigator.ResumeLayout(false);
            this.coachesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource coachesBindingSource;
        private DatabaseDataSetTableAdapters.CoachesTableAdapter coachesTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox bransTextBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.TextBox numaraTextBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton coachesBindingNavigatorSaveItem;
        private System.Windows.Forms.BindingNavigator coachesBindingNavigator;
    }
}