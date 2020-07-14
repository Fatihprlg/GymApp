namespace SporSalonu
{
    partial class addMember
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
            System.Windows.Forms.Label numaraLabel;
            System.Windows.Forms.Label uyelik_TipiLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label borcLabel;
            System.Windows.Forms.Label hakkindaLabel;
            System.Windows.Forms.Label tCLabel;
            System.Windows.Forms.Label anne_AdiLabel;
            System.Windows.Forms.Label baba_AdiLabel;
            System.Windows.Forms.Label dogum_YeriLabel;
            System.Windows.Forms.Label dogum_TarihiLabel;
            System.Windows.Forms.Label cinsiyet_Label;
            System.Windows.Forms.Label boyLabel;
            System.Windows.Forms.Label kiloLabel;
            System.Windows.Forms.Label antrenorLabel;
            System.Windows.Forms.Label bransLabel;
            System.Windows.Forms.Label adresLabel;
            this.saveBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.databaseDataSet = new SporSalonu.DatabaseDataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.memberInfoTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.memberInfoTableAdapter();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.numaraTextBox = new System.Windows.Forms.TextBox();
            this.uyelikTipiComboBox = new System.Windows.Forms.ComboBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.aidatTextBox = new System.Windows.Forms.TextBox();
            this.hakkindaTextBox = new System.Windows.Forms.TextBox();
            this.memberInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tCTextBox = new System.Windows.Forms.TextBox();
            this.anne_AdiTextBox = new System.Windows.Forms.TextBox();
            this.baba_AdiTextBox = new System.Windows.Forms.TextBox();
            this.dogum_YeriTextBox = new System.Windows.Forms.TextBox();
            this.dogumTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cinsiyet_TextBox = new System.Windows.Forms.TextBox();
            this.boyTextBox = new System.Windows.Forms.TextBox();
            this.kiloTextBox = new System.Windows.Forms.TextBox();
            this.antrenorComboBox = new System.Windows.Forms.ComboBox();
            this.bransComboBox = new System.Windows.Forms.ComboBox();
            this.browseBox = new System.Windows.Forms.TextBox();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            adLabel = new System.Windows.Forms.Label();
            soyadLabel = new System.Windows.Forms.Label();
            numaraLabel = new System.Windows.Forms.Label();
            uyelik_TipiLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            borcLabel = new System.Windows.Forms.Label();
            hakkindaLabel = new System.Windows.Forms.Label();
            tCLabel = new System.Windows.Forms.Label();
            anne_AdiLabel = new System.Windows.Forms.Label();
            baba_AdiLabel = new System.Windows.Forms.Label();
            dogum_YeriLabel = new System.Windows.Forms.Label();
            dogum_TarihiLabel = new System.Windows.Forms.Label();
            cinsiyet_Label = new System.Windows.Forms.Label();
            boyLabel = new System.Windows.Forms.Label();
            kiloLabel = new System.Windows.Forms.Label();
            antrenorLabel = new System.Windows.Forms.Label();
            bransLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberInfoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.BackColor = System.Drawing.Color.Transparent;
            adLabel.ForeColor = System.Drawing.Color.White;
            adLabel.Location = new System.Drawing.Point(55, 36);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(29, 17);
            adLabel.TabIndex = 45;
            adLabel.Text = "Ad:";
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.BackColor = System.Drawing.Color.Transparent;
            soyadLabel.ForeColor = System.Drawing.Color.White;
            soyadLabel.Location = new System.Drawing.Point(55, 64);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new System.Drawing.Size(52, 17);
            soyadLabel.TabIndex = 47;
            soyadLabel.Text = "Soyad:";
            // 
            // numaraLabel
            // 
            numaraLabel.AutoSize = true;
            numaraLabel.BackColor = System.Drawing.Color.Transparent;
            numaraLabel.ForeColor = System.Drawing.Color.White;
            numaraLabel.Location = new System.Drawing.Point(55, 92);
            numaraLabel.Name = "numaraLabel";
            numaraLabel.Size = new System.Drawing.Size(62, 17);
            numaraLabel.TabIndex = 49;
            numaraLabel.Text = "Numara:";
            // 
            // uyelik_TipiLabel
            // 
            uyelik_TipiLabel.AutoSize = true;
            uyelik_TipiLabel.BackColor = System.Drawing.Color.Transparent;
            uyelik_TipiLabel.ForeColor = System.Drawing.Color.White;
            uyelik_TipiLabel.Location = new System.Drawing.Point(55, 120);
            uyelik_TipiLabel.Name = "uyelik_TipiLabel";
            uyelik_TipiLabel.Size = new System.Drawing.Size(77, 17);
            uyelik_TipiLabel.TabIndex = 51;
            uyelik_TipiLabel.Text = "Uyelik Tipi:";
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.BackColor = System.Drawing.Color.Transparent;
            eMailLabel.ForeColor = System.Drawing.Color.White;
            eMailLabel.Location = new System.Drawing.Point(55, 151);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(51, 17);
            eMailLabel.TabIndex = 53;
            eMailLabel.Text = "E-Mail:";
            // 
            // borcLabel
            // 
            borcLabel.AutoSize = true;
            borcLabel.BackColor = System.Drawing.Color.Transparent;
            borcLabel.ForeColor = System.Drawing.Color.White;
            borcLabel.Location = new System.Drawing.Point(55, 179);
            borcLabel.Name = "borcLabel";
            borcLabel.Size = new System.Drawing.Size(44, 17);
            borcLabel.TabIndex = 55;
            borcLabel.Text = "Aidat:";
            // 
            // hakkindaLabel
            // 
            hakkindaLabel.AutoSize = true;
            hakkindaLabel.BackColor = System.Drawing.Color.Transparent;
            hakkindaLabel.ForeColor = System.Drawing.Color.White;
            hakkindaLabel.Location = new System.Drawing.Point(46, 258);
            hakkindaLabel.Name = "hakkindaLabel";
            hakkindaLabel.Size = new System.Drawing.Size(71, 17);
            hakkindaLabel.TabIndex = 57;
            hakkindaLabel.Text = "Hakkinda:";
            // 
            // tCLabel
            // 
            tCLabel.AutoSize = true;
            tCLabel.BackColor = System.Drawing.Color.Transparent;
            tCLabel.ForeColor = System.Drawing.Color.White;
            tCLabel.Location = new System.Drawing.Point(320, 34);
            tCLabel.Name = "tCLabel";
            tCLabel.Size = new System.Drawing.Size(30, 17);
            tCLabel.TabIndex = 60;
            tCLabel.Text = "TC:";
            // 
            // anne_AdiLabel
            // 
            anne_AdiLabel.AutoSize = true;
            anne_AdiLabel.BackColor = System.Drawing.Color.Transparent;
            anne_AdiLabel.ForeColor = System.Drawing.Color.White;
            anne_AdiLabel.Location = new System.Drawing.Point(320, 62);
            anne_AdiLabel.Name = "anne_AdiLabel";
            anne_AdiLabel.Size = new System.Drawing.Size(69, 17);
            anne_AdiLabel.TabIndex = 62;
            anne_AdiLabel.Text = "Anne Adi:";
            // 
            // baba_AdiLabel
            // 
            baba_AdiLabel.AutoSize = true;
            baba_AdiLabel.BackColor = System.Drawing.Color.Transparent;
            baba_AdiLabel.ForeColor = System.Drawing.Color.White;
            baba_AdiLabel.Location = new System.Drawing.Point(320, 90);
            baba_AdiLabel.Name = "baba_AdiLabel";
            baba_AdiLabel.Size = new System.Drawing.Size(69, 17);
            baba_AdiLabel.TabIndex = 64;
            baba_AdiLabel.Text = "Baba Adi:";
            // 
            // dogum_YeriLabel
            // 
            dogum_YeriLabel.AutoSize = true;
            dogum_YeriLabel.BackColor = System.Drawing.Color.Transparent;
            dogum_YeriLabel.ForeColor = System.Drawing.Color.White;
            dogum_YeriLabel.Location = new System.Drawing.Point(320, 118);
            dogum_YeriLabel.Name = "dogum_YeriLabel";
            dogum_YeriLabel.Size = new System.Drawing.Size(86, 17);
            dogum_YeriLabel.TabIndex = 66;
            dogum_YeriLabel.Text = "Dogum Yeri:";
            // 
            // dogum_TarihiLabel
            // 
            dogum_TarihiLabel.AutoSize = true;
            dogum_TarihiLabel.BackColor = System.Drawing.Color.Transparent;
            dogum_TarihiLabel.ForeColor = System.Drawing.Color.White;
            dogum_TarihiLabel.Location = new System.Drawing.Point(320, 147);
            dogum_TarihiLabel.Name = "dogum_TarihiLabel";
            dogum_TarihiLabel.Size = new System.Drawing.Size(97, 17);
            dogum_TarihiLabel.TabIndex = 68;
            dogum_TarihiLabel.Text = "Dogum Tarihi:";
            // 
            // cinsiyet_Label
            // 
            cinsiyet_Label.AutoSize = true;
            cinsiyet_Label.BackColor = System.Drawing.Color.Transparent;
            cinsiyet_Label.ForeColor = System.Drawing.Color.White;
            cinsiyet_Label.Location = new System.Drawing.Point(320, 174);
            cinsiyet_Label.Name = "cinsiyet_Label";
            cinsiyet_Label.Size = new System.Drawing.Size(65, 17);
            cinsiyet_Label.TabIndex = 70;
            cinsiyet_Label.Text = "Cinsiyet :";
            // 
            // boyLabel
            // 
            boyLabel.AutoSize = true;
            boyLabel.BackColor = System.Drawing.Color.Transparent;
            boyLabel.ForeColor = System.Drawing.Color.White;
            boyLabel.Location = new System.Drawing.Point(320, 202);
            boyLabel.Name = "boyLabel";
            boyLabel.Size = new System.Drawing.Size(36, 17);
            boyLabel.TabIndex = 72;
            boyLabel.Text = "Boy:";
            // 
            // kiloLabel
            // 
            kiloLabel.AutoSize = true;
            kiloLabel.BackColor = System.Drawing.Color.Transparent;
            kiloLabel.ForeColor = System.Drawing.Color.White;
            kiloLabel.Location = new System.Drawing.Point(320, 230);
            kiloLabel.Name = "kiloLabel";
            kiloLabel.Size = new System.Drawing.Size(35, 17);
            kiloLabel.TabIndex = 74;
            kiloLabel.Text = "Kilo:";
            // 
            // antrenorLabel
            // 
            antrenorLabel.AutoSize = true;
            antrenorLabel.BackColor = System.Drawing.Color.Transparent;
            antrenorLabel.ForeColor = System.Drawing.Color.White;
            antrenorLabel.Location = new System.Drawing.Point(320, 258);
            antrenorLabel.Name = "antrenorLabel";
            antrenorLabel.Size = new System.Drawing.Size(67, 17);
            antrenorLabel.TabIndex = 75;
            antrenorLabel.Text = "Antrenor:";
            // 
            // bransLabel
            // 
            bransLabel.AutoSize = true;
            bransLabel.BackColor = System.Drawing.Color.Transparent;
            bransLabel.ForeColor = System.Drawing.Color.White;
            bransLabel.Location = new System.Drawing.Point(320, 288);
            bransLabel.Name = "bransLabel";
            bransLabel.Size = new System.Drawing.Size(49, 17);
            bransLabel.TabIndex = 76;
            bransLabel.Text = "Brans:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.BackColor = System.Drawing.Color.Transparent;
            adresLabel.ForeColor = System.Drawing.Color.White;
            adresLabel.Location = new System.Drawing.Point(55, 209);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(49, 17);
            adresLabel.TabIndex = 124;
            adresLabel.Text = "Adres:";
            // 
            // saveBtn
            // 
            this.saveBtn.ForeColor = System.Drawing.Color.Black;
            this.saveBtn.Location = new System.Drawing.Point(736, 278);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 31);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Kaydet";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.ForeColor = System.Drawing.Color.Black;
            this.cancelBtn.Location = new System.Drawing.Point(655, 278);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 31);
            this.cancelBtn.TabIndex = 17;
            this.cancelBtn.Text = "İptal";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(653, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // browseBtn
            // 
            this.browseBtn.ForeColor = System.Drawing.Color.Black;
            this.browseBtn.Location = new System.Drawing.Point(770, 205);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(33, 23);
            this.browseBtn.TabIndex = 37;
            this.browseBtn.Text = "...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.tableAdapterManager.AccountingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BranchesTableAdapter = null;
            this.tableAdapterManager.BransUyeTableAdapter = null;
            this.tableAdapterManager.businessOwnerTableAdapter = null;
            this.tableAdapterManager.CoachesTableAdapter = null;
            this.tableAdapterManager.memberInfoTableAdapter = this.memberInfoTableAdapter;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // memberInfoTableAdapter
            // 
            this.memberInfoTableAdapter.ClearBeforeFill = true;
            // 
            // adTextBox
            // 
            this.adTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Ad", true));
            this.adTextBox.Location = new System.Drawing.Point(138, 33);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(167, 22);
            this.adTextBox.TabIndex = 46;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Soyad", true));
            this.soyadTextBox.Location = new System.Drawing.Point(138, 61);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(167, 22);
            this.soyadTextBox.TabIndex = 48;
            // 
            // numaraTextBox
            // 
            this.numaraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Numara", true));
            this.numaraTextBox.Location = new System.Drawing.Point(138, 89);
            this.numaraTextBox.Name = "numaraTextBox";
            this.numaraTextBox.Size = new System.Drawing.Size(167, 22);
            this.numaraTextBox.TabIndex = 50;
            // 
            // uyelikTipiComboBox
            // 
            this.uyelikTipiComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uyelikTipiComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uyelikTipiComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Uyelik Tipi", true));
            this.uyelikTipiComboBox.FormattingEnabled = true;
            this.uyelikTipiComboBox.Items.AddRange(new object[] {
            "Aylık",
            "Yıllık",
            "Premium"});
            this.uyelikTipiComboBox.Location = new System.Drawing.Point(138, 117);
            this.uyelikTipiComboBox.Name = "uyelikTipiComboBox";
            this.uyelikTipiComboBox.Size = new System.Drawing.Size(167, 24);
            this.uyelikTipiComboBox.TabIndex = 52;
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "eMail", true));
            this.eMailTextBox.Location = new System.Drawing.Point(138, 148);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(167, 22);
            this.eMailTextBox.TabIndex = 54;
            // 
            // aidatTextBox
            // 
            this.aidatTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Aidat", true));
            this.aidatTextBox.Location = new System.Drawing.Point(138, 176);
            this.aidatTextBox.Name = "aidatTextBox";
            this.aidatTextBox.Size = new System.Drawing.Size(167, 22);
            this.aidatTextBox.TabIndex = 56;
            // 
            // hakkindaTextBox
            // 
            this.hakkindaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Hakkinda", true));
            this.hakkindaTextBox.Location = new System.Drawing.Point(138, 258);
            this.hakkindaTextBox.Multiline = true;
            this.hakkindaTextBox.Name = "hakkindaTextBox";
            this.hakkindaTextBox.Size = new System.Drawing.Size(167, 47);
            this.hakkindaTextBox.TabIndex = 58;
            // 
            // memberInfoBindingSource
            // 
            this.memberInfoBindingSource.DataMember = "memberInfo";
            this.memberInfoBindingSource.DataSource = this.databaseDataSet;
            // 
            // tCTextBox
            // 
            this.tCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberInfoBindingSource, "TC", true));
            this.tCTextBox.Location = new System.Drawing.Point(423, 31);
            this.tCTextBox.Name = "tCTextBox";
            this.tCTextBox.Size = new System.Drawing.Size(200, 22);
            this.tCTextBox.TabIndex = 61;
            // 
            // anne_AdiTextBox
            // 
            this.anne_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberInfoBindingSource, "Anne Adi", true));
            this.anne_AdiTextBox.Location = new System.Drawing.Point(423, 59);
            this.anne_AdiTextBox.Name = "anne_AdiTextBox";
            this.anne_AdiTextBox.Size = new System.Drawing.Size(200, 22);
            this.anne_AdiTextBox.TabIndex = 63;
            // 
            // baba_AdiTextBox
            // 
            this.baba_AdiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberInfoBindingSource, "Baba Adi", true));
            this.baba_AdiTextBox.Location = new System.Drawing.Point(423, 87);
            this.baba_AdiTextBox.Name = "baba_AdiTextBox";
            this.baba_AdiTextBox.Size = new System.Drawing.Size(200, 22);
            this.baba_AdiTextBox.TabIndex = 65;
            // 
            // dogum_YeriTextBox
            // 
            this.dogum_YeriTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberInfoBindingSource, "Dogum Yeri", true));
            this.dogum_YeriTextBox.Location = new System.Drawing.Point(423, 115);
            this.dogum_YeriTextBox.Name = "dogum_YeriTextBox";
            this.dogum_YeriTextBox.Size = new System.Drawing.Size(200, 22);
            this.dogum_YeriTextBox.TabIndex = 67;
            // 
            // dogumTarihiDateTimePicker
            // 
            this.dogumTarihiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.memberInfoBindingSource, "Dogum Tarihi", true));
            this.dogumTarihiDateTimePicker.Location = new System.Drawing.Point(423, 143);
            this.dogumTarihiDateTimePicker.Name = "dogumTarihiDateTimePicker";
            this.dogumTarihiDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dogumTarihiDateTimePicker.TabIndex = 69;
            // 
            // cinsiyet_TextBox
            // 
            this.cinsiyet_TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberInfoBindingSource, "Cinsiyet", true));
            this.cinsiyet_TextBox.Location = new System.Drawing.Point(423, 171);
            this.cinsiyet_TextBox.Name = "cinsiyet_TextBox";
            this.cinsiyet_TextBox.Size = new System.Drawing.Size(200, 22);
            this.cinsiyet_TextBox.TabIndex = 71;
            // 
            // boyTextBox
            // 
            this.boyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberInfoBindingSource, "Boy", true));
            this.boyTextBox.Location = new System.Drawing.Point(423, 199);
            this.boyTextBox.Name = "boyTextBox";
            this.boyTextBox.Size = new System.Drawing.Size(200, 22);
            this.boyTextBox.TabIndex = 73;
            // 
            // kiloTextBox
            // 
            this.kiloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.memberInfoBindingSource, "Kilo", true));
            this.kiloTextBox.Location = new System.Drawing.Point(423, 227);
            this.kiloTextBox.Name = "kiloTextBox";
            this.kiloTextBox.Size = new System.Drawing.Size(200, 22);
            this.kiloTextBox.TabIndex = 75;
            // 
            // antrenorComboBox
            // 
            this.antrenorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.antrenorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.antrenorComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Antrenor", true));
            this.antrenorComboBox.FormattingEnabled = true;
            this.antrenorComboBox.Location = new System.Drawing.Point(423, 255);
            this.antrenorComboBox.Name = "antrenorComboBox";
            this.antrenorComboBox.Size = new System.Drawing.Size(200, 24);
            this.antrenorComboBox.TabIndex = 76;
            // 
            // bransComboBox
            // 
            this.bransComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bransComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bransComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Brans", true));
            this.bransComboBox.FormattingEnabled = true;
            this.bransComboBox.Location = new System.Drawing.Point(423, 285);
            this.bransComboBox.Name = "bransComboBox";
            this.bransComboBox.Size = new System.Drawing.Size(200, 24);
            this.bransComboBox.TabIndex = 77;
            // 
            // browseBox
            // 
            this.browseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.browseBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Fotograf", true));
            this.browseBox.ForeColor = System.Drawing.Color.Black;
            this.browseBox.Location = new System.Drawing.Point(653, 206);
            this.browseBox.Name = "browseBox";
            this.browseBox.Size = new System.Drawing.Size(111, 22);
            this.browseBox.TabIndex = 78;
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(138, 206);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(167, 45);
            this.adresTextBox.TabIndex = 125;
            // 
            // addMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.ClientSize = new System.Drawing.Size(831, 377);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.browseBox);
            this.Controls.Add(bransLabel);
            this.Controls.Add(this.bransComboBox);
            this.Controls.Add(antrenorLabel);
            this.Controls.Add(this.antrenorComboBox);
            this.Controls.Add(tCLabel);
            this.Controls.Add(this.tCTextBox);
            this.Controls.Add(anne_AdiLabel);
            this.Controls.Add(this.anne_AdiTextBox);
            this.Controls.Add(baba_AdiLabel);
            this.Controls.Add(this.baba_AdiTextBox);
            this.Controls.Add(dogum_YeriLabel);
            this.Controls.Add(this.dogum_YeriTextBox);
            this.Controls.Add(dogum_TarihiLabel);
            this.Controls.Add(this.dogumTarihiDateTimePicker);
            this.Controls.Add(cinsiyet_Label);
            this.Controls.Add(this.cinsiyet_TextBox);
            this.Controls.Add(boyLabel);
            this.Controls.Add(this.boyTextBox);
            this.Controls.Add(kiloLabel);
            this.Controls.Add(this.kiloTextBox);
            this.Controls.Add(adLabel);
            this.Controls.Add(this.adTextBox);
            this.Controls.Add(soyadLabel);
            this.Controls.Add(this.soyadTextBox);
            this.Controls.Add(numaraLabel);
            this.Controls.Add(this.numaraTextBox);
            this.Controls.Add(uyelik_TipiLabel);
            this.Controls.Add(this.uyelikTipiComboBox);
            this.Controls.Add(eMailLabel);
            this.Controls.Add(this.eMailTextBox);
            this.Controls.Add(borcLabel);
            this.Controls.Add(this.aidatTextBox);
            this.Controls.Add(hakkindaLabel);
            this.Controls.Add(this.hakkindaTextBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.saveBtn);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addMember";
            this.Text = "addMember";
            this.Load += new System.EventHandler(this.addMember_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberInfoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DatabaseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox numaraTextBox;
        private System.Windows.Forms.ComboBox uyelikTipiComboBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox aidatTextBox;
        private System.Windows.Forms.TextBox hakkindaTextBox;
        private DatabaseDataSetTableAdapters.memberInfoTableAdapter memberInfoTableAdapter;
        private System.Windows.Forms.BindingSource memberInfoBindingSource;
        private System.Windows.Forms.TextBox tCTextBox;
        private System.Windows.Forms.TextBox anne_AdiTextBox;
        private System.Windows.Forms.TextBox baba_AdiTextBox;
        private System.Windows.Forms.TextBox dogum_YeriTextBox;
        private System.Windows.Forms.DateTimePicker dogumTarihiDateTimePicker;
        private System.Windows.Forms.TextBox cinsiyet_TextBox;
        private System.Windows.Forms.TextBox boyTextBox;
        private System.Windows.Forms.TextBox kiloTextBox;
        private System.Windows.Forms.ComboBox antrenorComboBox;
        private System.Windows.Forms.ComboBox bransComboBox;
        private System.Windows.Forms.TextBox browseBox;
        private System.Windows.Forms.TextBox adresTextBox;
    }
}