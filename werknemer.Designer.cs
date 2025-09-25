namespace AquaPalace
{
    partial class werknemer
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
            this.label1 = new System.Windows.Forms.Label();
            this.Abbonementen = new System.Windows.Forms.TabControl();
            this.tpAbonnementen = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNieuweKlant = new System.Windows.Forms.ComboBox();
            this.btnKoppelAbonnement = new System.Windows.Forms.Button();
            this.lblNieuweKlantKoppel = new System.Windows.Forms.Label();
            this.dgvAlleAbonnementen = new System.Windows.Forms.DataGridView();
            this.txtKlantzoeken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.lblTypeAbonnement = new System.Windows.Forms.Label();
            this.tpKlantbeheer = new System.Windows.Forms.TabPage();
            this.gbKlantGegevens = new System.Windows.Forms.GroupBox();
            this.lblKlantId = new System.Windows.Forms.Label();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnZoek = new System.Windows.Forms.Button();
            this.txtZoek = new System.Windows.Forms.TextBox();
            this.dgvKlanten = new System.Windows.Forms.DataGridView();
            this.tpAbonnementInchecken = new System.Windows.Forms.TabPage();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.txtIncheck = new System.Windows.Forms.TextBox();
            this.btnInchecken = new System.Windows.Forms.Button();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.lblGebruikerId = new System.Windows.Forms.Label();
            this.tpNieuwAbonnement = new System.Windows.Forms.TabPage();
            this.dtpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDatum = new System.Windows.Forms.DateTimePicker();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblType = new System.Windows.Forms.Label();
            this.lblEind = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnNieuwAbonnement = new System.Windows.Forms.Button();
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.Abbonementen.SuspendLayout();
            this.tpAbonnementen.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlleAbonnementen)).BeginInit();
            this.tpKlantbeheer.SuspendLayout();
            this.gbKlantGegevens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlanten)).BeginInit();
            this.tpAbonnementInchecken.SuspendLayout();
            this.tpNieuwAbonnement.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Werknemer";
            // 
            // Abbonementen
            // 
            this.Abbonementen.Controls.Add(this.tpAbonnementen);
            this.Abbonementen.Controls.Add(this.tpKlantbeheer);
            this.Abbonementen.Controls.Add(this.tpAbonnementInchecken);
            this.Abbonementen.Controls.Add(this.tpNieuwAbonnement);
            this.Abbonementen.Location = new System.Drawing.Point(73, 107);
            this.Abbonementen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Abbonementen.Name = "Abbonementen";
            this.Abbonementen.SelectedIndex = 0;
            this.Abbonementen.Size = new System.Drawing.Size(1151, 551);
            this.Abbonementen.TabIndex = 3;
            // 
            // tpAbonnementen
            // 
            this.tpAbonnementen.AccessibleDescription = "Abonnementen";
            this.tpAbonnementen.Controls.Add(this.groupBox1);
            this.tpAbonnementen.Controls.Add(this.dgvAlleAbonnementen);
            this.tpAbonnementen.Controls.Add(this.txtKlantzoeken);
            this.tpAbonnementen.Controls.Add(this.label2);
            this.tpAbonnementen.Controls.Add(this.cbFilterType);
            this.tpAbonnementen.Controls.Add(this.lblTypeAbonnement);
            this.tpAbonnementen.Location = new System.Drawing.Point(4, 25);
            this.tpAbonnementen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpAbonnementen.Name = "tpAbonnementen";
            this.tpAbonnementen.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpAbonnementen.Size = new System.Drawing.Size(1143, 522);
            this.tpAbonnementen.TabIndex = 1;
            this.tpAbonnementen.Text = "Abonnementen";
            this.tpAbonnementen.UseVisualStyleBackColor = true;
            this.tpAbonnementen.Click += new System.EventHandler(this.tpAbonnementen_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNieuweKlant);
            this.groupBox1.Controls.Add(this.btnKoppelAbonnement);
            this.groupBox1.Controls.Add(this.lblNieuweKlantKoppel);
            this.groupBox1.Location = new System.Drawing.Point(347, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(767, 102);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klant koppelen aan abonnement";
            // 
            // cbNieuweKlant
            // 
            this.cbNieuweKlant.FormattingEnabled = true;
            this.cbNieuweKlant.Location = new System.Drawing.Point(173, 48);
            this.cbNieuweKlant.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbNieuweKlant.Name = "cbNieuweKlant";
            this.cbNieuweKlant.Size = new System.Drawing.Size(160, 24);
            this.cbNieuweKlant.TabIndex = 13;
            // 
            // btnKoppelAbonnement
            // 
            this.btnKoppelAbonnement.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnKoppelAbonnement.ForeColor = System.Drawing.SystemColors.Info;
            this.btnKoppelAbonnement.Location = new System.Drawing.Point(365, 42);
            this.btnKoppelAbonnement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKoppelAbonnement.Name = "btnKoppelAbonnement";
            this.btnKoppelAbonnement.Size = new System.Drawing.Size(213, 34);
            this.btnKoppelAbonnement.TabIndex = 11;
            this.btnKoppelAbonnement.Text = "Koppel abonnement";
            this.btnKoppelAbonnement.UseVisualStyleBackColor = false;
            this.btnKoppelAbonnement.Click += new System.EventHandler(this.btnKoppelAbonnement_Click_1);
            // 
            // lblNieuweKlantKoppel
            // 
            this.lblNieuweKlantKoppel.AutoSize = true;
            this.lblNieuweKlantKoppel.Location = new System.Drawing.Point(8, 52);
            this.lblNieuweKlantKoppel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNieuweKlantKoppel.Name = "lblNieuweKlantKoppel";
            this.lblNieuweKlantKoppel.Size = new System.Drawing.Size(145, 16);
            this.lblNieuweKlantKoppel.TabIndex = 6;
            this.lblNieuweKlantKoppel.Text = "Nieuwe Klant Koppelen";
            // 
            // dgvAlleAbonnementen
            // 
            this.dgvAlleAbonnementen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlleAbonnementen.Location = new System.Drawing.Point(4, 117);
            this.dgvAlleAbonnementen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvAlleAbonnementen.Name = "dgvAlleAbonnementen";
            this.dgvAlleAbonnementen.RowHeadersWidth = 51;
            this.dgvAlleAbonnementen.Size = new System.Drawing.Size(1132, 399);
            this.dgvAlleAbonnementen.TabIndex = 5;
            this.dgvAlleAbonnementen.SelectionChanged += new System.EventHandler(this.dgvAlleAbonnementen_SelectionChanged);
            // 
            // txtKlantzoeken
            // 
            this.txtKlantzoeken.Location = new System.Drawing.Point(159, 59);
            this.txtKlantzoeken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtKlantzoeken.Name = "txtKlantzoeken";
            this.txtKlantzoeken.Size = new System.Drawing.Size(132, 22);
            this.txtKlantzoeken.TabIndex = 3;
            this.txtKlantzoeken.TextChanged += new System.EventHandler(this.txtKlantzoeken_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klant zoeken:";
            // 
            // cbFilterType
            // 
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Items.AddRange(new object[] {
            "Alle",
            "Basis",
            "Standaard",
            "Premium"});
            this.cbFilterType.Location = new System.Drawing.Point(159, 18);
            this.cbFilterType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(160, 24);
            this.cbFilterType.TabIndex = 1;
            this.cbFilterType.SelectedIndexChanged += new System.EventHandler(this.cbFilterType_SelectedIndexChanged);
            // 
            // lblTypeAbonnement
            // 
            this.lblTypeAbonnement.AutoSize = true;
            this.lblTypeAbonnement.Location = new System.Drawing.Point(23, 22);
            this.lblTypeAbonnement.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTypeAbonnement.Name = "lblTypeAbonnement";
            this.lblTypeAbonnement.Size = new System.Drawing.Size(120, 16);
            this.lblTypeAbonnement.TabIndex = 0;
            this.lblTypeAbonnement.Text = "Type abonnement:";
            // 
            // tpKlantbeheer
            // 
            this.tpKlantbeheer.Controls.Add(this.gbKlantGegevens);
            this.tpKlantbeheer.Controls.Add(this.btnZoek);
            this.tpKlantbeheer.Controls.Add(this.txtZoek);
            this.tpKlantbeheer.Controls.Add(this.dgvKlanten);
            this.tpKlantbeheer.Location = new System.Drawing.Point(4, 25);
            this.tpKlantbeheer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpKlantbeheer.Name = "tpKlantbeheer";
            this.tpKlantbeheer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpKlantbeheer.Size = new System.Drawing.Size(1143, 522);
            this.tpKlantbeheer.TabIndex = 0;
            this.tpKlantbeheer.Text = "Klant beheer";
            this.tpKlantbeheer.UseVisualStyleBackColor = true;
            // 
            // gbKlantGegevens
            // 
            this.gbKlantGegevens.Controls.Add(this.lblKlantId);
            this.gbKlantGegevens.Controls.Add(this.btnOpslaan);
            this.gbKlantGegevens.Controls.Add(this.txtEmail);
            this.gbKlantGegevens.Controls.Add(this.txtAchternaam);
            this.gbKlantGegevens.Controls.Add(this.txtVoornaam);
            this.gbKlantGegevens.Controls.Add(this.lblVoornaam);
            this.gbKlantGegevens.Controls.Add(this.lblAchternaam);
            this.gbKlantGegevens.Controls.Add(this.lblEmail);
            this.gbKlantGegevens.Location = new System.Drawing.Point(328, 7);
            this.gbKlantGegevens.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKlantGegevens.Name = "gbKlantGegevens";
            this.gbKlantGegevens.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbKlantGegevens.Size = new System.Drawing.Size(804, 91);
            this.gbKlantGegevens.TabIndex = 3;
            this.gbKlantGegevens.TabStop = false;
            this.gbKlantGegevens.Text = "Klant gegevens";
            // 
            // lblKlantId
            // 
            this.lblKlantId.AutoSize = true;
            this.lblKlantId.Location = new System.Drawing.Point(9, 43);
            this.lblKlantId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKlantId.Name = "lblKlantId";
            this.lblKlantId.Size = new System.Drawing.Size(50, 16);
            this.lblKlantId.TabIndex = 12;
            this.lblKlantId.Text = "Klant id";
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnOpslaan.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOpslaan.Location = new System.Drawing.Point(600, 30);
            this.btnOpslaan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(133, 34);
            this.btnOpslaan.TabIndex = 11;
            this.btnOpslaan.Text = "Wijzigen";
            this.btnOpslaan.UseVisualStyleBackColor = false;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(427, 36);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(132, 22);
            this.txtEmail.TabIndex = 10;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(285, 36);
            this.txtAchternaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(132, 22);
            this.txtAchternaam.TabIndex = 9;
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(144, 36);
            this.txtVoornaam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(132, 22);
            this.txtVoornaam.TabIndex = 8;
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(172, 16);
            this.lblVoornaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(70, 16);
            this.lblVoornaam.TabIndex = 7;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(307, 16);
            this.lblAchternaam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(79, 16);
            this.lblAchternaam.TabIndex = 6;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(469, 16);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 16);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // btnZoek
            // 
            this.btnZoek.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnZoek.ForeColor = System.Drawing.SystemColors.Control;
            this.btnZoek.Location = new System.Drawing.Point(208, 43);
            this.btnZoek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(100, 28);
            this.btnZoek.TabIndex = 2;
            this.btnZoek.Text = "Zoek";
            this.btnZoek.UseVisualStyleBackColor = false;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
            // 
            // txtZoek
            // 
            this.txtZoek.Location = new System.Drawing.Point(47, 43);
            this.txtZoek.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtZoek.Name = "txtZoek";
            this.txtZoek.Size = new System.Drawing.Size(132, 22);
            this.txtZoek.TabIndex = 1;
            // 
            // dgvKlanten
            // 
            this.dgvKlanten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlanten.Location = new System.Drawing.Point(8, 106);
            this.dgvKlanten.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvKlanten.Name = "dgvKlanten";
            this.dgvKlanten.RowHeadersWidth = 51;
            this.dgvKlanten.Size = new System.Drawing.Size(1124, 406);
            this.dgvKlanten.TabIndex = 0;
            this.dgvKlanten.SelectionChanged += new System.EventHandler(this.dgvKlanten_SelectionChanged);
            // 
            // tpAbonnementInchecken
            // 
            this.tpAbonnementInchecken.BackColor = System.Drawing.Color.DarkGray;
            this.tpAbonnementInchecken.Controls.Add(this.lblResultaat);
            this.tpAbonnementInchecken.Controls.Add(this.txtLocatie);
            this.tpAbonnementInchecken.Controls.Add(this.txtIncheck);
            this.tpAbonnementInchecken.Controls.Add(this.btnInchecken);
            this.tpAbonnementInchecken.Controls.Add(this.lblLocatie);
            this.tpAbonnementInchecken.Controls.Add(this.lblGebruikerId);
            this.tpAbonnementInchecken.Location = new System.Drawing.Point(4, 25);
            this.tpAbonnementInchecken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpAbonnementInchecken.Name = "tpAbonnementInchecken";
            this.tpAbonnementInchecken.Size = new System.Drawing.Size(1143, 522);
            this.tpAbonnementInchecken.TabIndex = 2;
            this.tpAbonnementInchecken.Text = "Abonnement Inchecken";
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Location = new System.Drawing.Point(196, 204);
            this.lblResultaat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(64, 16);
            this.lblResultaat.TabIndex = 5;
            this.lblResultaat.Text = "Resultaat";
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(172, 78);
            this.txtLocatie.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(132, 22);
            this.txtLocatie.TabIndex = 4;
            // 
            // txtIncheck
            // 
            this.txtIncheck.Location = new System.Drawing.Point(172, 36);
            this.txtIncheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIncheck.Name = "txtIncheck";
            this.txtIncheck.Size = new System.Drawing.Size(132, 22);
            this.txtIncheck.TabIndex = 3;
            // 
            // btnInchecken
            // 
            this.btnInchecken.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnInchecken.ForeColor = System.Drawing.SystemColors.Control;
            this.btnInchecken.Location = new System.Drawing.Point(153, 127);
            this.btnInchecken.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInchecken.Name = "btnInchecken";
            this.btnInchecken.Size = new System.Drawing.Size(165, 60);
            this.btnInchecken.TabIndex = 2;
            this.btnInchecken.Text = "Inchecken";
            this.btnInchecken.UseVisualStyleBackColor = false;
            this.btnInchecken.Click += new System.EventHandler(this.btnInchecken_Click);
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(57, 86);
            this.lblLocatie.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(47, 16);
            this.lblLocatie.TabIndex = 1;
            this.lblLocatie.Text = "locatie";
            // 
            // lblGebruikerId
            // 
            this.lblGebruikerId.AutoSize = true;
            this.lblGebruikerId.Location = new System.Drawing.Point(57, 39);
            this.lblGebruikerId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGebruikerId.Name = "lblGebruikerId";
            this.lblGebruikerId.Size = new System.Drawing.Size(80, 16);
            this.lblGebruikerId.TabIndex = 0;
            this.lblGebruikerId.Text = "Gebruiker id";
            // 
            // tpNieuwAbonnement
            // 
            this.tpNieuwAbonnement.BackColor = System.Drawing.Color.DarkGray;
            this.tpNieuwAbonnement.Controls.Add(this.dtpEindDatum);
            this.tpNieuwAbonnement.Controls.Add(this.dtpBeginDatum);
            this.tpNieuwAbonnement.Controls.Add(this.cmbType);
            this.tpNieuwAbonnement.Controls.Add(this.txtUser);
            this.tpNieuwAbonnement.Controls.Add(this.lblType);
            this.tpNieuwAbonnement.Controls.Add(this.lblEind);
            this.tpNieuwAbonnement.Controls.Add(this.lblBegin);
            this.tpNieuwAbonnement.Controls.Add(this.lblUser);
            this.tpNieuwAbonnement.Controls.Add(this.btnNieuwAbonnement);
            this.tpNieuwAbonnement.Location = new System.Drawing.Point(4, 25);
            this.tpNieuwAbonnement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpNieuwAbonnement.Name = "tpNieuwAbonnement";
            this.tpNieuwAbonnement.Size = new System.Drawing.Size(1143, 522);
            this.tpNieuwAbonnement.TabIndex = 3;
            this.tpNieuwAbonnement.Text = "Nieuw Abonnement";
            // 
            // dtpEindDatum
            // 
            this.dtpEindDatum.Location = new System.Drawing.Point(167, 112);
            this.dtpEindDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpEindDatum.Name = "dtpEindDatum";
            this.dtpEindDatum.Size = new System.Drawing.Size(265, 22);
            this.dtpEindDatum.TabIndex = 17;
            // 
            // dtpBeginDatum
            // 
            this.dtpBeginDatum.Location = new System.Drawing.Point(167, 74);
            this.dtpBeginDatum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpBeginDatum.Name = "dtpBeginDatum";
            this.dtpBeginDatum.Size = new System.Drawing.Size(265, 22);
            this.dtpBeginDatum.TabIndex = 16;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Alle",
            "Basis",
            "Standaard",
            "Premium"});
            this.cmbType.Location = new System.Drawing.Point(167, 166);
            this.cmbType.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(160, 24);
            this.cmbType.TabIndex = 13;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(167, 26);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(132, 22);
            this.txtUser.TabIndex = 12;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(31, 176);
            this.lblType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(42, 16);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // lblEind
            // 
            this.lblEind.AutoSize = true;
            this.lblEind.Location = new System.Drawing.Point(31, 122);
            this.lblEind.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEind.Name = "lblEind";
            this.lblEind.Size = new System.Drawing.Size(74, 16);
            this.lblEind.TabIndex = 10;
            this.lblEind.Text = "Einddatum:";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(31, 74);
            this.lblBegin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(82, 16);
            this.lblBegin.TabIndex = 9;
            this.lblBegin.Text = "Begindatum:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(31, 30);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(39, 16);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User:";
            // 
            // btnNieuwAbonnement
            // 
            this.btnNieuwAbonnement.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnNieuwAbonnement.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNieuwAbonnement.Location = new System.Drawing.Point(167, 222);
            this.btnNieuwAbonnement.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNieuwAbonnement.Name = "btnNieuwAbonnement";
            this.btnNieuwAbonnement.Size = new System.Drawing.Size(176, 28);
            this.btnNieuwAbonnement.TabIndex = 7;
            this.btnNieuwAbonnement.Text = "Nieuw Abonnement";
            this.btnNieuwAbonnement.UseVisualStyleBackColor = false;
            this.btnNieuwAbonnement.Click += new System.EventHandler(this.btnNieuwAbonnement_Click_1);
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnUitloggen.ForeColor = System.Drawing.SystemColors.Info;
            this.btnUitloggen.Location = new System.Drawing.Point(927, 38);
            this.btnUitloggen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(199, 62);
            this.btnUitloggen.TabIndex = 4;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = false;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // werknemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 688);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.Abbonementen);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "werknemer";
            this.Text = "werknemer";
            this.Load += new System.EventHandler(this.werknemer_Load);
            this.Abbonementen.ResumeLayout(false);
            this.tpAbonnementen.ResumeLayout(false);
            this.tpAbonnementen.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlleAbonnementen)).EndInit();
            this.tpKlantbeheer.ResumeLayout(false);
            this.tpKlantbeheer.PerformLayout();
            this.gbKlantGegevens.ResumeLayout(false);
            this.gbKlantGegevens.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlanten)).EndInit();
            this.tpAbonnementInchecken.ResumeLayout(false);
            this.tpAbonnementInchecken.PerformLayout();
            this.tpNieuwAbonnement.ResumeLayout(false);
            this.tpNieuwAbonnement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl Abbonementen;
        private System.Windows.Forms.TabPage tpKlantbeheer;
        private System.Windows.Forms.TabPage tpAbonnementen;
        private System.Windows.Forms.TabPage tpAbonnementInchecken;
        private System.Windows.Forms.ComboBox cbFilterType;
        private System.Windows.Forms.Label lblTypeAbonnement;
        private System.Windows.Forms.TextBox txtKlantzoeken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvAlleAbonnementen;
        private System.Windows.Forms.TabPage tpNieuwAbonnement;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblEind;
        private System.Windows.Forms.Label lblBegin;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnNieuwAbonnement;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.DateTimePicker dtpBeginDatum;
        private System.Windows.Forms.DateTimePicker dtpEindDatum;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblGebruikerId;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.TextBox txtIncheck;
        private System.Windows.Forms.Button btnInchecken;
        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.Button btnUitloggen;
        private System.Windows.Forms.GroupBox gbKlantGegevens;
        private System.Windows.Forms.Button btnZoek;
        private System.Windows.Forms.TextBox txtZoek;
        private System.Windows.Forms.DataGridView dgvKlanten;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAchternaam;
        private System.Windows.Forms.TextBox txtVoornaam;
        private System.Windows.Forms.Label lblVoornaam;
        private System.Windows.Forms.Label lblAchternaam;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Button btnOpslaan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbNieuweKlant;
        private System.Windows.Forms.Button btnKoppelAbonnement;
        private System.Windows.Forms.Label lblNieuweKlantKoppel;
        private System.Windows.Forms.Label lblKlantId;
    }
}