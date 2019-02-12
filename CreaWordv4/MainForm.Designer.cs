namespace CreaWordv4
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuDatei = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemDateiNeu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemNeuWuerfeln = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemNeuListen = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemSateiSpeichern = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemDateiExport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemDateiDruck = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemDateiBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBearbeiten = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemBeaWort = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemBeaFavo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemBeaListen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuEinstellungen = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEinstOption = new System.Windows.Forms.ToolStripMenuItem();
            this.spracheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemEinstDesign = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuitemEinstWerk = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHilfe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemHilfeTut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemHilfeDoku = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemHilfeFAQ = new System.Windows.Forms.ToolStripMenuItem();
            this.menuInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemInfoDev = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemInfoCrea = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemInfoFeedb = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemInfoHash = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemInfoVers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuitemInfoAGB = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabWuerfeln = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.cbWortanzahl = new System.Windows.Forms.ComboBox();
            this.flowpanelOptButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.flowpanelWort = new System.Windows.Forms.FlowLayoutPanel();
            this.flowpanelTheKat = new System.Windows.Forms.FlowLayoutPanel();
            this.labelWortanzahl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabWort = new System.Windows.Forms.TabPage();
            this.listWort = new System.Windows.Forms.ListView();
            this.columnWID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnWBEZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listKategorie = new System.Windows.Forms.ListView();
            this.columnKID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnKBEZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listThema = new System.Windows.Forms.ListView();
            this.columnTID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnTBEZ = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabFavo = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabListen = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabWuerfeln.SuspendLayout();
            this.tabWort.SuspendLayout();
            this.tabFavo.SuspendLayout();
            this.tabListen.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDatei,
            this.menuBearbeiten,
            this.menuEinstellungen,
            this.menuHilfe,
            this.menuInfo});
            resources.ApplyResources(this.menuStrip, "menuStrip");
            this.menuStrip.Name = "menuStrip";
            // 
            // menuDatei
            // 
            this.menuDatei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemDateiNeu,
            this.toolStripMenuItem1,
            this.menuitemSateiSpeichern,
            this.menuitemDateiExport,
            this.toolStripMenuItem2,
            this.menuitemDateiDruck,
            this.toolStripMenuItem3,
            this.menuitemDateiBeenden});
            this.menuDatei.Name = "menuDatei";
            resources.ApplyResources(this.menuDatei, "menuDatei");
            // 
            // menuitemDateiNeu
            // 
            this.menuitemDateiNeu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemNeuWuerfeln,
            this.menuitemNeuListen});
            this.menuitemDateiNeu.Name = "menuitemDateiNeu";
            resources.ApplyResources(this.menuitemDateiNeu, "menuitemDateiNeu");
            // 
            // menuitemNeuWuerfeln
            // 
            this.menuitemNeuWuerfeln.Name = "menuitemNeuWuerfeln";
            resources.ApplyResources(this.menuitemNeuWuerfeln, "menuitemNeuWuerfeln");
            // 
            // menuitemNeuListen
            // 
            this.menuitemNeuListen.Name = "menuitemNeuListen";
            resources.ApplyResources(this.menuitemNeuListen, "menuitemNeuListen");
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            // 
            // menuitemSateiSpeichern
            // 
            this.menuitemSateiSpeichern.Name = "menuitemSateiSpeichern";
            resources.ApplyResources(this.menuitemSateiSpeichern, "menuitemSateiSpeichern");
            // 
            // menuitemDateiExport
            // 
            this.menuitemDateiExport.Name = "menuitemDateiExport";
            resources.ApplyResources(this.menuitemDateiExport, "menuitemDateiExport");
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            // 
            // menuitemDateiDruck
            // 
            this.menuitemDateiDruck.Name = "menuitemDateiDruck";
            resources.ApplyResources(this.menuitemDateiDruck, "menuitemDateiDruck");
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            resources.ApplyResources(this.toolStripMenuItem3, "toolStripMenuItem3");
            // 
            // menuitemDateiBeenden
            // 
            this.menuitemDateiBeenden.Name = "menuitemDateiBeenden";
            resources.ApplyResources(this.menuitemDateiBeenden, "menuitemDateiBeenden");
            // 
            // menuBearbeiten
            // 
            this.menuBearbeiten.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemBeaWort,
            this.menuitemBeaFavo,
            this.menuitemBeaListen});
            this.menuBearbeiten.Name = "menuBearbeiten";
            resources.ApplyResources(this.menuBearbeiten, "menuBearbeiten");
            // 
            // menuitemBeaWort
            // 
            this.menuitemBeaWort.Name = "menuitemBeaWort";
            resources.ApplyResources(this.menuitemBeaWort, "menuitemBeaWort");
            this.menuitemBeaWort.Click += new System.EventHandler(this.menuitemBeaWort_Click);
            // 
            // menuitemBeaFavo
            // 
            this.menuitemBeaFavo.Name = "menuitemBeaFavo";
            resources.ApplyResources(this.menuitemBeaFavo, "menuitemBeaFavo");
            // 
            // menuitemBeaListen
            // 
            this.menuitemBeaListen.Name = "menuitemBeaListen";
            resources.ApplyResources(this.menuitemBeaListen, "menuitemBeaListen");
            // 
            // menuEinstellungen
            // 
            this.menuEinstellungen.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemEinstOption,
            this.menuitemEinstDesign,
            this.toolStripMenuItem4,
            this.menuitemEinstWerk});
            this.menuEinstellungen.Name = "menuEinstellungen";
            resources.ApplyResources(this.menuEinstellungen, "menuEinstellungen");
            // 
            // menuitemEinstOption
            // 
            this.menuitemEinstOption.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spracheToolStripMenuItem});
            this.menuitemEinstOption.Name = "menuitemEinstOption";
            resources.ApplyResources(this.menuitemEinstOption, "menuitemEinstOption");
            // 
            // spracheToolStripMenuItem
            // 
            this.spracheToolStripMenuItem.Name = "spracheToolStripMenuItem";
            resources.ApplyResources(this.spracheToolStripMenuItem, "spracheToolStripMenuItem");
            // 
            // menuitemEinstDesign
            // 
            this.menuitemEinstDesign.Name = "menuitemEinstDesign";
            resources.ApplyResources(this.menuitemEinstDesign, "menuitemEinstDesign");
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            resources.ApplyResources(this.toolStripMenuItem4, "toolStripMenuItem4");
            // 
            // menuitemEinstWerk
            // 
            this.menuitemEinstWerk.Name = "menuitemEinstWerk";
            resources.ApplyResources(this.menuitemEinstWerk, "menuitemEinstWerk");
            // 
            // menuHilfe
            // 
            this.menuHilfe.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemHilfeTut,
            this.menuitemHilfeDoku,
            this.menuitemHilfeFAQ});
            this.menuHilfe.Name = "menuHilfe";
            resources.ApplyResources(this.menuHilfe, "menuHilfe");
            // 
            // menuitemHilfeTut
            // 
            this.menuitemHilfeTut.Name = "menuitemHilfeTut";
            resources.ApplyResources(this.menuitemHilfeTut, "menuitemHilfeTut");
            // 
            // menuitemHilfeDoku
            // 
            this.menuitemHilfeDoku.Name = "menuitemHilfeDoku";
            resources.ApplyResources(this.menuitemHilfeDoku, "menuitemHilfeDoku");
            // 
            // menuitemHilfeFAQ
            // 
            this.menuitemHilfeFAQ.Name = "menuitemHilfeFAQ";
            resources.ApplyResources(this.menuitemHilfeFAQ, "menuitemHilfeFAQ");
            // 
            // menuInfo
            // 
            this.menuInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuitemInfoDev,
            this.menuitemInfoCrea,
            this.menuitemInfoFeedb,
            this.menuitemInfoHash,
            this.menuitemInfoVers,
            this.menuitemInfoAGB});
            this.menuInfo.Name = "menuInfo";
            resources.ApplyResources(this.menuInfo, "menuInfo");
            // 
            // menuitemInfoDev
            // 
            this.menuitemInfoDev.Name = "menuitemInfoDev";
            resources.ApplyResources(this.menuitemInfoDev, "menuitemInfoDev");
            // 
            // menuitemInfoCrea
            // 
            this.menuitemInfoCrea.Name = "menuitemInfoCrea";
            resources.ApplyResources(this.menuitemInfoCrea, "menuitemInfoCrea");
            // 
            // menuitemInfoFeedb
            // 
            this.menuitemInfoFeedb.Name = "menuitemInfoFeedb";
            resources.ApplyResources(this.menuitemInfoFeedb, "menuitemInfoFeedb");
            // 
            // menuitemInfoHash
            // 
            this.menuitemInfoHash.Name = "menuitemInfoHash";
            resources.ApplyResources(this.menuitemInfoHash, "menuitemInfoHash");
            // 
            // menuitemInfoVers
            // 
            this.menuitemInfoVers.Name = "menuitemInfoVers";
            resources.ApplyResources(this.menuitemInfoVers, "menuitemInfoVers");
            // 
            // menuitemInfoAGB
            // 
            this.menuitemInfoAGB.Name = "menuitemInfoAGB";
            resources.ApplyResources(this.menuitemInfoAGB, "menuitemInfoAGB");
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabWuerfeln);
            this.tabControl.Controls.Add(this.tabWort);
            this.tabControl.Controls.Add(this.tabFavo);
            this.tabControl.Controls.Add(this.tabListen);
            resources.ApplyResources(this.tabControl, "tabControl");
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            // 
            // tabWuerfeln
            // 
            resources.ApplyResources(this.tabWuerfeln, "tabWuerfeln");
            this.tabWuerfeln.Controls.Add(this.textBox1);
            this.tabWuerfeln.Controls.Add(this.btnReset);
            this.tabWuerfeln.Controls.Add(this.cbWortanzahl);
            this.tabWuerfeln.Controls.Add(this.flowpanelOptButtons);
            this.tabWuerfeln.Controls.Add(this.flowpanelWort);
            this.tabWuerfeln.Controls.Add(this.flowpanelTheKat);
            this.tabWuerfeln.Controls.Add(this.labelWortanzahl);
            this.tabWuerfeln.Controls.Add(this.button1);
            this.tabWuerfeln.Name = "tabWuerfeln";
            this.tabWuerfeln.UseVisualStyleBackColor = true;
            this.tabWuerfeln.Layout += new System.Windows.Forms.LayoutEventHandler(this.tabWuerfeln_Layout);
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // cbWortanzahl
            // 
            this.cbWortanzahl.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWortanzahl.Items.AddRange(new object[] {
            resources.GetString("cbWortanzahl.Items"),
            resources.GetString("cbWortanzahl.Items1"),
            resources.GetString("cbWortanzahl.Items2"),
            resources.GetString("cbWortanzahl.Items3"),
            resources.GetString("cbWortanzahl.Items4"),
            resources.GetString("cbWortanzahl.Items5"),
            resources.GetString("cbWortanzahl.Items6"),
            resources.GetString("cbWortanzahl.Items7"),
            resources.GetString("cbWortanzahl.Items8"),
            resources.GetString("cbWortanzahl.Items9")});
            resources.ApplyResources(this.cbWortanzahl, "cbWortanzahl");
            this.cbWortanzahl.Name = "cbWortanzahl";
            this.cbWortanzahl.SelectedIndexChanged += new System.EventHandler(this.cbWortanzahl_SelectedIndexChanged);
            // 
            // flowpanelOptButtons
            // 
            resources.ApplyResources(this.flowpanelOptButtons, "flowpanelOptButtons");
            this.flowpanelOptButtons.Name = "flowpanelOptButtons";
            // 
            // flowpanelWort
            // 
            resources.ApplyResources(this.flowpanelWort, "flowpanelWort");
            this.flowpanelWort.Name = "flowpanelWort";
            // 
            // flowpanelTheKat
            // 
            resources.ApplyResources(this.flowpanelTheKat, "flowpanelTheKat");
            this.flowpanelTheKat.Name = "flowpanelTheKat";
            // 
            // labelWortanzahl
            // 
            resources.ApplyResources(this.labelWortanzahl, "labelWortanzahl");
            this.labelWortanzahl.Name = "labelWortanzahl";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabWort
            // 
            resources.ApplyResources(this.tabWort, "tabWort");
            this.tabWort.Controls.Add(this.listWort);
            this.tabWort.Controls.Add(this.listKategorie);
            this.tabWort.Controls.Add(this.listThema);
            this.tabWort.Name = "tabWort";
            this.tabWort.UseVisualStyleBackColor = true;
            this.tabWort.Enter += new System.EventHandler(this.tabWort_Enter);
            this.tabWort.Layout += new System.Windows.Forms.LayoutEventHandler(this.tabWort_Layout);
            // 
            // listWort
            // 
            this.listWort.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnWID,
            this.columnWBEZ});
            this.listWort.FullRowSelect = true;
            this.listWort.GridLines = true;
            resources.ApplyResources(this.listWort, "listWort");
            this.listWort.Name = "listWort";
            this.listWort.UseCompatibleStateImageBehavior = false;
            this.listWort.View = System.Windows.Forms.View.Details;
            this.listWort.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listThema_ColumnWidthChanging);
            // 
            // columnWID
            // 
            resources.ApplyResources(this.columnWID, "columnWID");
            // 
            // columnWBEZ
            // 
            resources.ApplyResources(this.columnWBEZ, "columnWBEZ");
            // 
            // listKategorie
            // 
            this.listKategorie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnKID,
            this.columnKBEZ});
            this.listKategorie.FullRowSelect = true;
            this.listKategorie.GridLines = true;
            resources.ApplyResources(this.listKategorie, "listKategorie");
            this.listKategorie.Name = "listKategorie";
            this.listKategorie.UseCompatibleStateImageBehavior = false;
            this.listKategorie.View = System.Windows.Forms.View.Details;
            this.listKategorie.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listThema_ColumnWidthChanging);
            this.listKategorie.SelectedIndexChanged += new System.EventHandler(this.listKategorie_SelectedIndexChanged);
            // 
            // columnKID
            // 
            resources.ApplyResources(this.columnKID, "columnKID");
            // 
            // columnKBEZ
            // 
            resources.ApplyResources(this.columnKBEZ, "columnKBEZ");
            // 
            // listThema
            // 
            this.listThema.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTID,
            this.columnTBEZ});
            this.listThema.FullRowSelect = true;
            this.listThema.GridLines = true;
            this.listThema.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            resources.ApplyResources(this.listThema, "listThema");
            this.listThema.Name = "listThema";
            this.listThema.UseCompatibleStateImageBehavior = false;
            this.listThema.View = System.Windows.Forms.View.Details;
            this.listThema.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listThema_ColumnWidthChanging);
            this.listThema.ItemActivate += new System.EventHandler(this.listThema_ItemActivate);
            this.listThema.SelectedIndexChanged += new System.EventHandler(this.listThema_SelectedIndexChanged);
            // 
            // columnTID
            // 
            resources.ApplyResources(this.columnTID, "columnTID");
            // 
            // columnTBEZ
            // 
            resources.ApplyResources(this.columnTBEZ, "columnTBEZ");
            // 
            // tabFavo
            // 
            resources.ApplyResources(this.tabFavo, "tabFavo");
            this.tabFavo.Controls.Add(this.button3);
            this.tabFavo.Name = "tabFavo";
            this.tabFavo.UseVisualStyleBackColor = true;
            this.tabFavo.Layout += new System.Windows.Forms.LayoutEventHandler(this.tabFavo_Layout);
            // 
            // button3
            // 
            resources.ApplyResources(this.button3, "button3");
            this.button3.Name = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // tabListen
            // 
            resources.ApplyResources(this.tabListen, "tabListen");
            this.tabListen.Controls.Add(this.button4);
            this.tabListen.Name = "tabListen";
            this.tabListen.UseVisualStyleBackColor = true;
            this.tabListen.Layout += new System.Windows.Forms.LayoutEventHandler(this.tabListen_Layout);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabWuerfeln.ResumeLayout(false);
            this.tabWuerfeln.PerformLayout();
            this.tabWort.ResumeLayout(false);
            this.tabFavo.ResumeLayout(false);
            this.tabListen.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ToolStripMenuItem menuDatei;
        private System.Windows.Forms.ToolStripMenuItem menuBearbeiten;
        private System.Windows.Forms.ToolStripMenuItem menuEinstellungen;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabWuerfeln;
        private System.Windows.Forms.TabPage tabWort;
        private System.Windows.Forms.TabPage tabFavo;
        private System.Windows.Forms.TabPage tabListen;
        private System.Windows.Forms.ToolStripMenuItem menuitemDateiNeu;
        private System.Windows.Forms.ToolStripMenuItem menuitemNeuWuerfeln;
        private System.Windows.Forms.ToolStripMenuItem menuitemNeuListen;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuitemSateiSpeichern;
        private System.Windows.Forms.ToolStripMenuItem menuitemDateiExport;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem menuitemDateiDruck;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem menuitemDateiBeenden;
        private System.Windows.Forms.ToolStripMenuItem menuitemBeaWort;
        private System.Windows.Forms.ToolStripMenuItem menuitemBeaFavo;
        private System.Windows.Forms.ToolStripMenuItem menuitemBeaListen;
        private System.Windows.Forms.ToolStripMenuItem menuHilfe;
        private System.Windows.Forms.ToolStripMenuItem menuInfo;
        private System.Windows.Forms.ToolStripMenuItem menuitemEinstOption;
        private System.Windows.Forms.ToolStripMenuItem spracheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuitemEinstDesign;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem menuitemEinstWerk;
        private System.Windows.Forms.ToolStripMenuItem menuitemHilfeTut;
        private System.Windows.Forms.ToolStripMenuItem menuitemHilfeDoku;
        private System.Windows.Forms.ToolStripMenuItem menuitemHilfeFAQ;
        private System.Windows.Forms.ToolStripMenuItem menuitemInfoDev;
        private System.Windows.Forms.ToolStripMenuItem menuitemInfoCrea;
        private System.Windows.Forms.ToolStripMenuItem menuitemInfoFeedb;
        private System.Windows.Forms.ToolStripMenuItem menuitemInfoHash;
        private System.Windows.Forms.ToolStripMenuItem menuitemInfoVers;
        private System.Windows.Forms.ToolStripMenuItem menuitemInfoAGB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label labelWortanzahl;
        private System.Windows.Forms.FlowLayoutPanel flowpanelWort;
        private System.Windows.Forms.FlowLayoutPanel flowpanelTheKat;
        private System.Windows.Forms.FlowLayoutPanel flowpanelOptButtons;
        private System.Windows.Forms.ComboBox cbWortanzahl;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ListView listWort;
        private System.Windows.Forms.ColumnHeader columnWID;
        private System.Windows.Forms.ColumnHeader columnWBEZ;
        private System.Windows.Forms.ListView listKategorie;
        private System.Windows.Forms.ColumnHeader columnKID;
        private System.Windows.Forms.ColumnHeader columnKBEZ;
        private System.Windows.Forms.ListView listThema;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnTID;
        private System.Windows.Forms.ColumnHeader columnTBEZ;
    }
}

