namespace SporSalonu
{
    partial class MemberDetails
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
            System.Windows.Forms.Label bransLabel;
            System.Windows.Forms.Label antrenorLabel;
            System.Windows.Forms.Label tCLabel;
            System.Windows.Forms.Label anne_AdiLabel;
            System.Windows.Forms.Label baba_AdiLabel;
            System.Windows.Forms.Label dogum_YeriLabel;
            System.Windows.Forms.Label dogum_TarihiLabel;
            System.Windows.Forms.Label cinsiyet_Label;
            System.Windows.Forms.Label boyLabel;
            System.Windows.Forms.Label kiloLabel;
            System.Windows.Forms.Label adLabel;
            System.Windows.Forms.Label soyadLabel;
            System.Windows.Forms.Label numaraLabel;
            System.Windows.Forms.Label uyelik_TipiLabel;
            System.Windows.Forms.Label eMailLabel;
            System.Windows.Forms.Label borcLabel;
            System.Windows.Forms.Label hakkindaLabel;
            System.Windows.Forms.Label adresLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDetails));
            this.bransComboBox = new System.Windows.Forms.ComboBox();
            this.antrenorComboBox = new System.Windows.Forms.ComboBox();
            this.tCTextBox = new System.Windows.Forms.TextBox();
            this.anne_AdiTextBox = new System.Windows.Forms.TextBox();
            this.baba_AdiTextBox = new System.Windows.Forms.TextBox();
            this.dogum_YeriTextBox = new System.Windows.Forms.TextBox();
            this.dogumTarihiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cinsiyet_TextBox = new System.Windows.Forms.TextBox();
            this.boyTextBox = new System.Windows.Forms.TextBox();
            this.kiloTextBox = new System.Windows.Forms.TextBox();
            this.adTextBox = new System.Windows.Forms.TextBox();
            this.soyadTextBox = new System.Windows.Forms.TextBox();
            this.numaraTextBox = new System.Windows.Forms.TextBox();
            this.uyelikTipiComboBox = new System.Windows.Forms.ComboBox();
            this.eMailTextBox = new System.Windows.Forms.TextBox();
            this.aidatTextBox = new System.Windows.Forms.TextBox();
            this.hakkindaTextBox = new System.Windows.Forms.TextBox();
            this.browseBox = new System.Windows.Forms.TextBox();
            this.browseBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.kayitTarihiLbl = new System.Windows.Forms.Label();
            this.updateBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.cardBtn = new System.Windows.Forms.Button();
            this.licenceBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.aktiflikCheck = new System.Windows.Forms.CheckBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.databaseDataSet = new SporSalonu.DatabaseDataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new SporSalonu.DatabaseDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager();
            this.membersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.membersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.adresTextBox = new System.Windows.Forms.TextBox();
            bransLabel = new System.Windows.Forms.Label();
            antrenorLabel = new System.Windows.Forms.Label();
            tCLabel = new System.Windows.Forms.Label();
            anne_AdiLabel = new System.Windows.Forms.Label();
            baba_AdiLabel = new System.Windows.Forms.Label();
            dogum_YeriLabel = new System.Windows.Forms.Label();
            dogum_TarihiLabel = new System.Windows.Forms.Label();
            cinsiyet_Label = new System.Windows.Forms.Label();
            boyLabel = new System.Windows.Forms.Label();
            kiloLabel = new System.Windows.Forms.Label();
            adLabel = new System.Windows.Forms.Label();
            soyadLabel = new System.Windows.Forms.Label();
            numaraLabel = new System.Windows.Forms.Label();
            uyelik_TipiLabel = new System.Windows.Forms.Label();
            eMailLabel = new System.Windows.Forms.Label();
            borcLabel = new System.Windows.Forms.Label();
            hakkindaLabel = new System.Windows.Forms.Label();
            adresLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).BeginInit();
            this.membersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bransLabel
            // 
            bransLabel.AutoSize = true;
            bransLabel.BackColor = System.Drawing.Color.Transparent;
            bransLabel.ForeColor = System.Drawing.Color.White;
            bransLabel.Location = new System.Drawing.Point(279, 292);
            bransLabel.Name = "bransLabel";
            bransLabel.Size = new System.Drawing.Size(49, 17);
            bransLabel.TabIndex = 110;
            bransLabel.Text = "Brans:";
            // 
            // antrenorLabel
            // 
            antrenorLabel.AutoSize = true;
            antrenorLabel.BackColor = System.Drawing.Color.Transparent;
            antrenorLabel.ForeColor = System.Drawing.Color.White;
            antrenorLabel.Location = new System.Drawing.Point(279, 262);
            antrenorLabel.Name = "antrenorLabel";
            antrenorLabel.Size = new System.Drawing.Size(67, 17);
            antrenorLabel.TabIndex = 107;
            antrenorLabel.Text = "Antrenor:";
            // 
            // tCLabel
            // 
            tCLabel.AutoSize = true;
            tCLabel.BackColor = System.Drawing.Color.Transparent;
            tCLabel.ForeColor = System.Drawing.Color.White;
            tCLabel.Location = new System.Drawing.Point(279, 38);
            tCLabel.Name = "tCLabel";
            tCLabel.Size = new System.Drawing.Size(30, 17);
            tCLabel.TabIndex = 92;
            tCLabel.Text = "TC:";
            // 
            // anne_AdiLabel
            // 
            anne_AdiLabel.AutoSize = true;
            anne_AdiLabel.BackColor = System.Drawing.Color.Transparent;
            anne_AdiLabel.ForeColor = System.Drawing.Color.White;
            anne_AdiLabel.Location = new System.Drawing.Point(279, 66);
            anne_AdiLabel.Name = "anne_AdiLabel";
            anne_AdiLabel.Size = new System.Drawing.Size(69, 17);
            anne_AdiLabel.TabIndex = 94;
            anne_AdiLabel.Text = "Anne Adi:";
            // 
            // baba_AdiLabel
            // 
            baba_AdiLabel.AutoSize = true;
            baba_AdiLabel.BackColor = System.Drawing.Color.Transparent;
            baba_AdiLabel.ForeColor = System.Drawing.Color.White;
            baba_AdiLabel.Location = new System.Drawing.Point(279, 94);
            baba_AdiLabel.Name = "baba_AdiLabel";
            baba_AdiLabel.Size = new System.Drawing.Size(69, 17);
            baba_AdiLabel.TabIndex = 96;
            baba_AdiLabel.Text = "Baba Adi:";
            // 
            // dogum_YeriLabel
            // 
            dogum_YeriLabel.AutoSize = true;
            dogum_YeriLabel.BackColor = System.Drawing.Color.Transparent;
            dogum_YeriLabel.ForeColor = System.Drawing.Color.White;
            dogum_YeriLabel.Location = new System.Drawing.Point(279, 122);
            dogum_YeriLabel.Name = "dogum_YeriLabel";
            dogum_YeriLabel.Size = new System.Drawing.Size(86, 17);
            dogum_YeriLabel.TabIndex = 98;
            dogum_YeriLabel.Text = "Dogum Yeri:";
            // 
            // dogum_TarihiLabel
            // 
            dogum_TarihiLabel.AutoSize = true;
            dogum_TarihiLabel.BackColor = System.Drawing.Color.Transparent;
            dogum_TarihiLabel.ForeColor = System.Drawing.Color.White;
            dogum_TarihiLabel.Location = new System.Drawing.Point(279, 151);
            dogum_TarihiLabel.Name = "dogum_TarihiLabel";
            dogum_TarihiLabel.Size = new System.Drawing.Size(97, 17);
            dogum_TarihiLabel.TabIndex = 100;
            dogum_TarihiLabel.Text = "Dogum Tarihi:";
            // 
            // cinsiyet_Label
            // 
            cinsiyet_Label.AutoSize = true;
            cinsiyet_Label.BackColor = System.Drawing.Color.Transparent;
            cinsiyet_Label.ForeColor = System.Drawing.Color.White;
            cinsiyet_Label.Location = new System.Drawing.Point(279, 178);
            cinsiyet_Label.Name = "cinsiyet_Label";
            cinsiyet_Label.Size = new System.Drawing.Size(65, 17);
            cinsiyet_Label.TabIndex = 102;
            cinsiyet_Label.Text = "Cinsiyet :";
            // 
            // boyLabel
            // 
            boyLabel.AutoSize = true;
            boyLabel.BackColor = System.Drawing.Color.Transparent;
            boyLabel.ForeColor = System.Drawing.Color.White;
            boyLabel.Location = new System.Drawing.Point(279, 206);
            boyLabel.Name = "boyLabel";
            boyLabel.Size = new System.Drawing.Size(36, 17);
            boyLabel.TabIndex = 104;
            boyLabel.Text = "Boy:";
            // 
            // kiloLabel
            // 
            kiloLabel.AutoSize = true;
            kiloLabel.BackColor = System.Drawing.Color.Transparent;
            kiloLabel.ForeColor = System.Drawing.Color.White;
            kiloLabel.Location = new System.Drawing.Point(279, 234);
            kiloLabel.Name = "kiloLabel";
            kiloLabel.Size = new System.Drawing.Size(35, 17);
            kiloLabel.TabIndex = 106;
            kiloLabel.Text = "Kilo:";
            // 
            // adLabel
            // 
            adLabel.AutoSize = true;
            adLabel.BackColor = System.Drawing.Color.Transparent;
            adLabel.ForeColor = System.Drawing.Color.White;
            adLabel.Location = new System.Drawing.Point(14, 40);
            adLabel.Name = "adLabel";
            adLabel.Size = new System.Drawing.Size(29, 17);
            adLabel.TabIndex = 78;
            adLabel.Text = "Ad:";
            // 
            // soyadLabel
            // 
            soyadLabel.AutoSize = true;
            soyadLabel.BackColor = System.Drawing.Color.Transparent;
            soyadLabel.ForeColor = System.Drawing.Color.White;
            soyadLabel.Location = new System.Drawing.Point(14, 68);
            soyadLabel.Name = "soyadLabel";
            soyadLabel.Size = new System.Drawing.Size(52, 17);
            soyadLabel.TabIndex = 80;
            soyadLabel.Text = "Soyad:";
            // 
            // numaraLabel
            // 
            numaraLabel.AutoSize = true;
            numaraLabel.BackColor = System.Drawing.Color.Transparent;
            numaraLabel.ForeColor = System.Drawing.Color.White;
            numaraLabel.Location = new System.Drawing.Point(14, 96);
            numaraLabel.Name = "numaraLabel";
            numaraLabel.Size = new System.Drawing.Size(62, 17);
            numaraLabel.TabIndex = 82;
            numaraLabel.Text = "Numara:";
            // 
            // uyelik_TipiLabel
            // 
            uyelik_TipiLabel.AutoSize = true;
            uyelik_TipiLabel.BackColor = System.Drawing.Color.Transparent;
            uyelik_TipiLabel.ForeColor = System.Drawing.Color.White;
            uyelik_TipiLabel.Location = new System.Drawing.Point(14, 124);
            uyelik_TipiLabel.Name = "uyelik_TipiLabel";
            uyelik_TipiLabel.Size = new System.Drawing.Size(77, 17);
            uyelik_TipiLabel.TabIndex = 84;
            uyelik_TipiLabel.Text = "Uyelik Tipi:";
            // 
            // eMailLabel
            // 
            eMailLabel.AutoSize = true;
            eMailLabel.BackColor = System.Drawing.Color.Transparent;
            eMailLabel.ForeColor = System.Drawing.Color.White;
            eMailLabel.Location = new System.Drawing.Point(14, 155);
            eMailLabel.Name = "eMailLabel";
            eMailLabel.Size = new System.Drawing.Size(51, 17);
            eMailLabel.TabIndex = 86;
            eMailLabel.Text = "E-Mail:";
            // 
            // borcLabel
            // 
            borcLabel.AutoSize = true;
            borcLabel.BackColor = System.Drawing.Color.Transparent;
            borcLabel.ForeColor = System.Drawing.Color.White;
            borcLabel.Location = new System.Drawing.Point(14, 183);
            borcLabel.Name = "borcLabel";
            borcLabel.Size = new System.Drawing.Size(44, 17);
            borcLabel.TabIndex = 88;
            borcLabel.Text = "Aidat:";
            // 
            // hakkindaLabel
            // 
            hakkindaLabel.AutoSize = true;
            hakkindaLabel.BackColor = System.Drawing.Color.Transparent;
            hakkindaLabel.ForeColor = System.Drawing.Color.White;
            hakkindaLabel.Location = new System.Drawing.Point(14, 259);
            hakkindaLabel.Name = "hakkindaLabel";
            hakkindaLabel.Size = new System.Drawing.Size(71, 17);
            hakkindaLabel.TabIndex = 90;
            hakkindaLabel.Text = "Hakkinda:";
            // 
            // adresLabel
            // 
            adresLabel.AutoSize = true;
            adresLabel.BackColor = System.Drawing.Color.Transparent;
            adresLabel.ForeColor = System.Drawing.Color.White;
            adresLabel.Location = new System.Drawing.Point(14, 211);
            adresLabel.Name = "adresLabel";
            adresLabel.Size = new System.Drawing.Size(49, 17);
            adresLabel.TabIndex = 122;
            adresLabel.Text = "Adres:";
            // 
            // bransComboBox
            // 
            this.bransComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.bransComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.bransComboBox.FormattingEnabled = true;
            this.bransComboBox.Location = new System.Drawing.Point(382, 289);
            this.bransComboBox.Name = "bransComboBox";
            this.bransComboBox.Size = new System.Drawing.Size(200, 24);
            this.bransComboBox.TabIndex = 111;
            // 
            // antrenorComboBox
            // 
            this.antrenorComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.antrenorComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.antrenorComboBox.FormattingEnabled = true;
            this.antrenorComboBox.Location = new System.Drawing.Point(382, 259);
            this.antrenorComboBox.Name = "antrenorComboBox";
            this.antrenorComboBox.Size = new System.Drawing.Size(200, 24);
            this.antrenorComboBox.TabIndex = 109;
            // 
            // tCTextBox
            // 
            this.tCTextBox.Location = new System.Drawing.Point(382, 35);
            this.tCTextBox.Name = "tCTextBox";
            this.tCTextBox.Size = new System.Drawing.Size(200, 22);
            this.tCTextBox.TabIndex = 93;
            // 
            // anne_AdiTextBox
            // 
            this.anne_AdiTextBox.Location = new System.Drawing.Point(382, 63);
            this.anne_AdiTextBox.Name = "anne_AdiTextBox";
            this.anne_AdiTextBox.Size = new System.Drawing.Size(200, 22);
            this.anne_AdiTextBox.TabIndex = 95;
            // 
            // baba_AdiTextBox
            // 
            this.baba_AdiTextBox.Location = new System.Drawing.Point(382, 91);
            this.baba_AdiTextBox.Name = "baba_AdiTextBox";
            this.baba_AdiTextBox.Size = new System.Drawing.Size(200, 22);
            this.baba_AdiTextBox.TabIndex = 97;
            // 
            // dogum_YeriTextBox
            // 
            this.dogum_YeriTextBox.Location = new System.Drawing.Point(382, 119);
            this.dogum_YeriTextBox.Name = "dogum_YeriTextBox";
            this.dogum_YeriTextBox.Size = new System.Drawing.Size(200, 22);
            this.dogum_YeriTextBox.TabIndex = 99;
            // 
            // dogumTarihiDateTimePicker
            // 
            this.dogumTarihiDateTimePicker.Location = new System.Drawing.Point(382, 147);
            this.dogumTarihiDateTimePicker.Name = "dogumTarihiDateTimePicker";
            this.dogumTarihiDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dogumTarihiDateTimePicker.TabIndex = 101;
            // 
            // cinsiyet_TextBox
            // 
            this.cinsiyet_TextBox.Location = new System.Drawing.Point(382, 175);
            this.cinsiyet_TextBox.Name = "cinsiyet_TextBox";
            this.cinsiyet_TextBox.Size = new System.Drawing.Size(200, 22);
            this.cinsiyet_TextBox.TabIndex = 103;
            // 
            // boyTextBox
            // 
            this.boyTextBox.Location = new System.Drawing.Point(382, 203);
            this.boyTextBox.Name = "boyTextBox";
            this.boyTextBox.Size = new System.Drawing.Size(200, 22);
            this.boyTextBox.TabIndex = 105;
            // 
            // kiloTextBox
            // 
            this.kiloTextBox.Location = new System.Drawing.Point(382, 231);
            this.kiloTextBox.Name = "kiloTextBox";
            this.kiloTextBox.Size = new System.Drawing.Size(200, 22);
            this.kiloTextBox.TabIndex = 108;
            // 
            // adTextBox
            // 
            this.adTextBox.Location = new System.Drawing.Point(97, 37);
            this.adTextBox.Name = "adTextBox";
            this.adTextBox.Size = new System.Drawing.Size(167, 22);
            this.adTextBox.TabIndex = 79;
            // 
            // soyadTextBox
            // 
            this.soyadTextBox.Location = new System.Drawing.Point(97, 65);
            this.soyadTextBox.Name = "soyadTextBox";
            this.soyadTextBox.Size = new System.Drawing.Size(167, 22);
            this.soyadTextBox.TabIndex = 81;
            // 
            // numaraTextBox
            // 
            this.numaraTextBox.Location = new System.Drawing.Point(97, 93);
            this.numaraTextBox.Name = "numaraTextBox";
            this.numaraTextBox.Size = new System.Drawing.Size(167, 22);
            this.numaraTextBox.TabIndex = 83;
            // 
            // uyelikTipiComboBox
            // 
            this.uyelikTipiComboBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uyelikTipiComboBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uyelikTipiComboBox.FormattingEnabled = true;
            this.uyelikTipiComboBox.Items.AddRange(new object[] {
            "Aylık",
            "Yıllık",
            "Premium"});
            this.uyelikTipiComboBox.Location = new System.Drawing.Point(97, 121);
            this.uyelikTipiComboBox.Name = "uyelikTipiComboBox";
            this.uyelikTipiComboBox.Size = new System.Drawing.Size(167, 24);
            this.uyelikTipiComboBox.TabIndex = 85;
            this.uyelikTipiComboBox.SelectedIndexChanged += new System.EventHandler(this.uyelikTipiComboBox_SelectedIndexChanged);
            // 
            // eMailTextBox
            // 
            this.eMailTextBox.Location = new System.Drawing.Point(97, 152);
            this.eMailTextBox.Name = "eMailTextBox";
            this.eMailTextBox.Size = new System.Drawing.Size(167, 22);
            this.eMailTextBox.TabIndex = 87;
            // 
            // aidatTextBox
            // 
            this.aidatTextBox.Location = new System.Drawing.Point(97, 180);
            this.aidatTextBox.Name = "aidatTextBox";
            this.aidatTextBox.Size = new System.Drawing.Size(167, 22);
            this.aidatTextBox.TabIndex = 89;
            // 
            // hakkindaTextBox
            // 
            this.hakkindaTextBox.Location = new System.Drawing.Point(97, 259);
            this.hakkindaTextBox.Multiline = true;
            this.hakkindaTextBox.Name = "hakkindaTextBox";
            this.hakkindaTextBox.Size = new System.Drawing.Size(167, 48);
            this.hakkindaTextBox.TabIndex = 91;
            // 
            // browseBox
            // 
            this.browseBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.browseBox.ForeColor = System.Drawing.Color.Black;
            this.browseBox.Location = new System.Drawing.Point(623, 229);
            this.browseBox.Name = "browseBox";
            this.browseBox.Size = new System.Drawing.Size(111, 22);
            this.browseBox.TabIndex = 114;
            // 
            // browseBtn
            // 
            this.browseBtn.ForeColor = System.Drawing.Color.Black;
            this.browseBtn.Location = new System.Drawing.Point(740, 228);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(33, 23);
            this.browseBtn.TabIndex = 113;
            this.browseBtn.Text = "...";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(235)))), ((int)(((byte)(255)))));
            this.pictureBox1.Location = new System.Drawing.Point(623, 35);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 188);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 112;
            this.pictureBox1.TabStop = false;
            // 
            // kayitTarihiLbl
            // 
            this.kayitTarihiLbl.AutoSize = true;
            this.kayitTarihiLbl.BackColor = System.Drawing.Color.Transparent;
            this.kayitTarihiLbl.ForeColor = System.Drawing.Color.White;
            this.kayitTarihiLbl.Location = new System.Drawing.Point(620, 292);
            this.kayitTarihiLbl.Name = "kayitTarihiLbl";
            this.kayitTarihiLbl.Size = new System.Drawing.Size(46, 17);
            this.kayitTarihiLbl.TabIndex = 116;
            this.kayitTarihiLbl.Text = "label2";
            // 
            // updateBtn
            // 
            this.updateBtn.ForeColor = System.Drawing.Color.Black;
            this.updateBtn.Location = new System.Drawing.Point(578, 337);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(101, 54);
            this.updateBtn.TabIndex = 117;
            this.updateBtn.Text = "Güncelle";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.ForeColor = System.Drawing.Color.Black;
            this.backBtn.Location = new System.Drawing.Point(685, 337);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(103, 54);
            this.backBtn.TabIndex = 118;
            this.backBtn.Text = "Geri";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // cardBtn
            // 
            this.cardBtn.ForeColor = System.Drawing.Color.Black;
            this.cardBtn.Location = new System.Drawing.Point(461, 337);
            this.cardBtn.Name = "cardBtn";
            this.cardBtn.Size = new System.Drawing.Size(111, 54);
            this.cardBtn.TabIndex = 119;
            this.cardBtn.Text = "Sporcu Kartı";
            this.cardBtn.UseVisualStyleBackColor = true;
            this.cardBtn.Click += new System.EventHandler(this.cardBtn_Click);
            // 
            // licenceBtn
            // 
            this.licenceBtn.ForeColor = System.Drawing.Color.Black;
            this.licenceBtn.Location = new System.Drawing.Point(356, 337);
            this.licenceBtn.Name = "licenceBtn";
            this.licenceBtn.Size = new System.Drawing.Size(99, 54);
            this.licenceBtn.TabIndex = 120;
            this.licenceBtn.Text = "Sporcu Lisansı";
            this.licenceBtn.UseVisualStyleBackColor = true;
            this.licenceBtn.Click += new System.EventHandler(this.licenceBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // aktiflikCheck
            // 
            this.aktiflikCheck.AutoSize = true;
            this.aktiflikCheck.BackColor = System.Drawing.Color.Transparent;
            this.aktiflikCheck.ForeColor = System.Drawing.Color.White;
            this.aktiflikCheck.Location = new System.Drawing.Point(600, 268);
            this.aktiflikCheck.Name = "aktiflikCheck";
            this.aktiflikCheck.Size = new System.Drawing.Size(98, 21);
            this.aktiflikCheck.TabIndex = 121;
            this.aktiflikCheck.Text = "checkBox1";
            this.aktiflikCheck.UseVisualStyleBackColor = false;
            this.aktiflikCheck.CheckedChanged += new System.EventHandler(this.aktiflikCheck_CheckedChanged);
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
            this.tableAdapterManager.memberInfoTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.ProductsTableAdapter = null;
            this.tableAdapterManager.SellTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = SporSalonu.DatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membersBindingNavigator
            // 
            this.membersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.membersBindingNavigator.BindingSource = this.membersBindingSource;
            this.membersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.membersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.membersBindingNavigator.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.membersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.membersBindingNavigatorSaveItem});
            this.membersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.membersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.membersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.membersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.membersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.membersBindingNavigator.Name = "membersBindingNavigator";
            this.membersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.membersBindingNavigator.Size = new System.Drawing.Size(808, 27);
            this.membersBindingNavigator.TabIndex = 122;
            this.membersBindingNavigator.Text = "bindingNavigator1";
            this.membersBindingNavigator.Visible = false;
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
            // membersBindingNavigatorSaveItem
            // 
            this.membersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.membersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("membersBindingNavigatorSaveItem.Image")));
            this.membersBindingNavigatorSaveItem.Name = "membersBindingNavigatorSaveItem";
            this.membersBindingNavigatorSaveItem.Size = new System.Drawing.Size(29, 24);
            this.membersBindingNavigatorSaveItem.Text = "Save Data";
            this.membersBindingNavigatorSaveItem.Click += new System.EventHandler(this.membersBindingNavigatorSaveItem_Click);
            // 
            // adresTextBox
            // 
            this.adresTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.membersBindingSource, "Adres", true));
            this.adresTextBox.Location = new System.Drawing.Point(97, 208);
            this.adresTextBox.Multiline = true;
            this.adresTextBox.Name = "adresTextBox";
            this.adresTextBox.Size = new System.Drawing.Size(167, 45);
            this.adresTextBox.TabIndex = 123;
            // 
            // MemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SporSalonu.Properties.Resources.gg;
            this.ClientSize = new System.Drawing.Size(808, 411);
            this.Controls.Add(adresLabel);
            this.Controls.Add(this.adresTextBox);
            this.Controls.Add(this.membersBindingNavigator);
            this.Controls.Add(this.aktiflikCheck);
            this.Controls.Add(this.licenceBtn);
            this.Controls.Add(this.cardBtn);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.kayitTarihiLbl);
            this.Controls.Add(this.browseBox);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.pictureBox1);
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
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberDetails";
            this.Load += new System.EventHandler(this.MemberDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).EndInit();
            this.membersBindingNavigator.ResumeLayout(false);
            this.membersBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox bransComboBox;
        private System.Windows.Forms.ComboBox antrenorComboBox;
        private System.Windows.Forms.TextBox tCTextBox;
        private System.Windows.Forms.TextBox anne_AdiTextBox;
        private System.Windows.Forms.TextBox baba_AdiTextBox;
        private System.Windows.Forms.TextBox dogum_YeriTextBox;
        private System.Windows.Forms.DateTimePicker dogumTarihiDateTimePicker;
        private System.Windows.Forms.TextBox cinsiyet_TextBox;
        private System.Windows.Forms.TextBox boyTextBox;
        private System.Windows.Forms.TextBox kiloTextBox;
        private System.Windows.Forms.TextBox adTextBox;
        private System.Windows.Forms.TextBox soyadTextBox;
        private System.Windows.Forms.TextBox numaraTextBox;
        private System.Windows.Forms.ComboBox uyelikTipiComboBox;
        private System.Windows.Forms.TextBox eMailTextBox;
        private System.Windows.Forms.TextBox aidatTextBox;
        private System.Windows.Forms.TextBox hakkindaTextBox;
        private System.Windows.Forms.TextBox browseBox;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label kayitTarihiLbl;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button cardBtn;
        private System.Windows.Forms.Button licenceBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.CheckBox aktiflikCheck;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private DatabaseDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private DatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator membersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton membersBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox adresTextBox;
    }
}