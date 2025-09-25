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
            this.tpKlantbeheer = new System.Windows.Forms.TabPage();
            this.tpAbonnementen = new System.Windows.Forms.TabPage();
            this.tpAbonnementInchecken = new System.Windows.Forms.TabPage();
            this.lblTypeAbonnement = new System.Windows.Forms.Label();
            this.cbFilterType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKlantzoeken = new System.Windows.Forms.TextBox();
            this.dgvAlleAbonnementen = new System.Windows.Forms.DataGridView();
            this.tpNieuwAbonnement = new System.Windows.Forms.TabPage();
            this.btnNieuwAbonnement = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblBegin = new System.Windows.Forms.Label();
            this.lblEind = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.dtpBeginDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.lblGebruikerId = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.btnInchecken = new System.Windows.Forms.Button();
            this.txtIncheck = new System.Windows.Forms.TextBox();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.dgvKlanten = new System.Windows.Forms.DataGridView();
            this.txtZoek = new System.Windows.Forms.TextBox();
            this.btnZoek = new System.Windows.Forms.Button();
            this.gbKlantGegevens = new System.Windows.Forms.GroupBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAchternaam = new System.Windows.Forms.Label();
            this.lblVoornaam = new System.Windows.Forms.Label();
            this.txtVoornaam = new System.Windows.Forms.TextBox();
            this.txtAchternaam = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnOpslaan = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbNieuweKlant = new System.Windows.Forms.ComboBox();
            this.btnKoppelAbonnement = new System.Windows.Forms.Button();
            this.lblNieuweKlantKoppel = new System.Windows.Forms.Label();
            this.lblKlantId = new System.Windows.Forms.Label();
            this.Abbonementen.SuspendLayout();
            this.tpKlantbeheer.SuspendLayout();
            this.tpAbonnementen.SuspendLayout();
            this.tpAbonnementInchecken.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlleAbonnementen)).BeginInit();
            this.tpNieuwAbonnement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlanten)).BeginInit();
            this.gbKlantGegevens.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Werknemer";
            // 
            // Abbonementen
            // 
            this.Abbonementen.Controls.Add(this.tpAbonnementen);
            this.Abbonementen.Controls.Add(this.tpKlantbeheer);
            this.Abbonementen.Controls.Add(this.tpAbonnementInchecken);
            this.Abbonementen.Controls.Add(this.tpNieuwAbonnement);
            this.Abbonementen.Location = new System.Drawing.Point(55, 87);
            this.Abbonementen.Name = "Abbonementen";
            this.Abbonementen.SelectedIndex = 0;
            this.Abbonementen.Size = new System.Drawing.Size(863, 448);
            this.Abbonementen.TabIndex = 3;
            // 
            // tpKlantbeheer
            // 
            this.tpKlantbeheer.Controls.Add(this.gbKlantGegevens);
            this.tpKlantbeheer.Controls.Add(this.btnZoek);
            this.tpKlantbeheer.Controls.Add(this.txtZoek);
            this.tpKlantbeheer.Controls.Add(this.dgvKlanten);
            this.tpKlantbeheer.Location = new System.Drawing.Point(4, 22);
            this.tpKlantbeheer.Name = "tpKlantbeheer";
            this.tpKlantbeheer.Padding = new System.Windows.Forms.Padding(3);
            this.tpKlantbeheer.Size = new System.Drawing.Size(855, 422);
            this.tpKlantbeheer.TabIndex = 0;
            this.tpKlantbeheer.Text = "Klant beheer";
            this.tpKlantbeheer.UseVisualStyleBackColor = true;
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
            this.tpAbonnementen.Location = new System.Drawing.Point(4, 22);
            this.tpAbonnementen.Name = "tpAbonnementen";
            this.tpAbonnementen.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbonnementen.Size = new System.Drawing.Size(855, 422);
            this.tpAbonnementen.TabIndex = 1;
            this.tpAbonnementen.Text = "Abonnementen";
            this.tpAbonnementen.UseVisualStyleBackColor = true;
            this.tpAbonnementen.Click += new System.EventHandler(this.tpAbonnementen_Click);
            // 
            // tpAbonnementInchecken
            // 
            this.tpAbonnementInchecken.Controls.Add(this.lblResultaat);
            this.tpAbonnementInchecken.Controls.Add(this.txtLocatie);
            this.tpAbonnementInchecken.Controls.Add(this.txtIncheck);
            this.tpAbonnementInchecken.Controls.Add(this.btnInchecken);
            this.tpAbonnementInchecken.Controls.Add(this.lblLocatie);
            this.tpAbonnementInchecken.Controls.Add(this.lblGebruikerId);
            this.tpAbonnementInchecken.Location = new System.Drawing.Point(4, 22);
            this.tpAbonnementInchecken.Name = "tpAbonnementInchecken";
            this.tpAbonnementInchecken.Size = new System.Drawing.Size(855, 422);
            this.tpAbonnementInchecken.TabIndex = 2;
            this.tpAbonnementInchecken.Text = "Abonnement Inchecken";
            this.tpAbonnementInchecken.UseVisualStyleBackColor = true;
            // 
            // lblTypeAbonnement
            // 
            this.lblTypeAbonnement.AutoSize = true;
            this.lblTypeAbonnement.Location = new System.Drawing.Point(17, 18);
            this.lblTypeAbonnement.Name = "lblTypeAbonnement";
            this.lblTypeAbonnement.Size = new System.Drawing.Size(96, 13);
            this.lblTypeAbonnement.TabIndex = 0;
            this.lblTypeAbonnement.Text = "Type abonnement:";
            // 
            // cbFilterType
            // 
            this.cbFilterType.FormattingEnabled = true;
            this.cbFilterType.Items.AddRange(new object[] {
            "Alle",
            "Basis",
            "Standaard",
            "Premium"});
            this.cbFilterType.Location = new System.Drawing.Point(119, 15);
            this.cbFilterType.Name = "cbFilterType";
            this.cbFilterType.Size = new System.Drawing.Size(121, 21);
            this.cbFilterType.TabIndex = 1;
            this.cbFilterType.SelectedIndexChanged += new System.EventHandler(this.cbFilterType_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Klant zoeken:";
            // 
            // txtKlantzoeken
            // 
            this.txtKlantzoeken.Location = new System.Drawing.Point(119, 48);
            this.txtKlantzoeken.Name = "txtKlantzoeken";
            this.txtKlantzoeken.Size = new System.Drawing.Size(100, 20);
            this.txtKlantzoeken.TabIndex = 3;
            this.txtKlantzoeken.TextChanged += new System.EventHandler(this.txtKlantzoeken_TextChanged);
            // 
            // dgvAlleAbonnementen
            // 
            this.dgvAlleAbonnementen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlleAbonnementen.Location = new System.Drawing.Point(3, 95);
            this.dgvAlleAbonnementen.Name = "dgvAlleAbonnementen";
            this.dgvAlleAbonnementen.Size = new System.Drawing.Size(849, 324);
            this.dgvAlleAbonnementen.TabIndex = 5;
            this.dgvAlleAbonnementen.SelectionChanged += new System.EventHandler(this.dgvAlleAbonnementen_SelectionChanged);
            // 
            // tpNieuwAbonnement
            // 
            this.tpNieuwAbonnement.Controls.Add(this.dtpEindDatum);
            this.tpNieuwAbonnement.Controls.Add(this.dtpBeginDatum);
            this.tpNieuwAbonnement.Controls.Add(this.cmbType);
            this.tpNieuwAbonnement.Controls.Add(this.txtUser);
            this.tpNieuwAbonnement.Controls.Add(this.lblType);
            this.tpNieuwAbonnement.Controls.Add(this.lblEind);
            this.tpNieuwAbonnement.Controls.Add(this.lblBegin);
            this.tpNieuwAbonnement.Controls.Add(this.lblUser);
            this.tpNieuwAbonnement.Controls.Add(this.btnNieuwAbonnement);
            this.tpNieuwAbonnement.Location = new System.Drawing.Point(4, 22);
            this.tpNieuwAbonnement.Name = "tpNieuwAbonnement";
            this.tpNieuwAbonnement.Size = new System.Drawing.Size(855, 422);
            this.tpNieuwAbonnement.TabIndex = 3;
            this.tpNieuwAbonnement.Text = "Nieuw Abonnement";
            this.tpNieuwAbonnement.UseVisualStyleBackColor = true;
            // 
            // btnNieuwAbonnement
            // 
            this.btnNieuwAbonnement.Location = new System.Drawing.Point(26, 189);
            this.btnNieuwAbonnement.Name = "btnNieuwAbonnement";
            this.btnNieuwAbonnement.Size = new System.Drawing.Size(132, 23);
            this.btnNieuwAbonnement.TabIndex = 7;
            this.btnNieuwAbonnement.Text = "Nieuw Abonnement";
            this.btnNieuwAbonnement.UseVisualStyleBackColor = true;
            this.btnNieuwAbonnement.Click += new System.EventHandler(this.btnNieuwAbonnement_Click_1);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(23, 24);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(32, 13);
            this.lblUser.TabIndex = 8;
            this.lblUser.Text = "User:";
            // 
            // lblBegin
            // 
            this.lblBegin.AutoSize = true;
            this.lblBegin.Location = new System.Drawing.Point(23, 60);
            this.lblBegin.Name = "lblBegin";
            this.lblBegin.Size = new System.Drawing.Size(66, 13);
            this.lblBegin.TabIndex = 9;
            this.lblBegin.Text = "Begindatum:";
            // 
            // lblEind
            // 
            this.lblEind.AutoSize = true;
            this.lblEind.Location = new System.Drawing.Point(23, 99);
            this.lblEind.Name = "lblEind";
            this.lblEind.Size = new System.Drawing.Size(60, 13);
            this.lblEind.TabIndex = 10;
            this.lblEind.Text = "Einddatum:";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(23, 143);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(34, 13);
            this.lblType.TabIndex = 11;
            this.lblType.Text = "Type:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(125, 21);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 20);
            this.txtUser.TabIndex = 12;
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Items.AddRange(new object[] {
            "Alle",
            "Basis",
            "Standaard",
            "Premium"});
            this.cmbType.Location = new System.Drawing.Point(125, 135);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 21);
            this.cmbType.TabIndex = 13;
            // 
            // dtpBeginDatum
            // 
            this.dtpBeginDatum.Location = new System.Drawing.Point(125, 60);
            this.dtpBeginDatum.Name = "dtpBeginDatum";
            this.dtpBeginDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpBeginDatum.TabIndex = 16;
            // 
            // dtpEindDatum
            // 
            this.dtpEindDatum.Location = new System.Drawing.Point(125, 91);
            this.dtpEindDatum.Name = "dtpEindDatum";
            this.dtpEindDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpEindDatum.TabIndex = 17;
            // 
            // lblGebruikerId
            // 
            this.lblGebruikerId.AutoSize = true;
            this.lblGebruikerId.Location = new System.Drawing.Point(43, 32);
            this.lblGebruikerId.Name = "lblGebruikerId";
            this.lblGebruikerId.Size = new System.Drawing.Size(64, 13);
            this.lblGebruikerId.TabIndex = 0;
            this.lblGebruikerId.Text = "Gebruiker id";
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(43, 70);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(38, 13);
            this.lblLocatie.TabIndex = 1;
            this.lblLocatie.Text = "locatie";
            // 
            // btnInchecken
            // 
            this.btnInchecken.Location = new System.Drawing.Point(115, 103);
            this.btnInchecken.Name = "btnInchecken";
            this.btnInchecken.Size = new System.Drawing.Size(124, 49);
            this.btnInchecken.TabIndex = 2;
            this.btnInchecken.Text = "Inchecken";
            this.btnInchecken.UseVisualStyleBackColor = true;
            this.btnInchecken.Click += new System.EventHandler(this.btnInchecken_Click);
            // 
            // txtIncheck
            // 
            this.txtIncheck.Location = new System.Drawing.Point(129, 29);
            this.txtIncheck.Name = "txtIncheck";
            this.txtIncheck.Size = new System.Drawing.Size(100, 20);
            this.txtIncheck.TabIndex = 3;
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(129, 63);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(100, 20);
            this.txtLocatie.TabIndex = 4;
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Location = new System.Drawing.Point(147, 166);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(52, 13);
            this.lblResultaat.TabIndex = 5;
            this.lblResultaat.Text = "Resultaat";
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(695, 31);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(149, 50);
            this.btnUitloggen.TabIndex = 4;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // dgvKlanten
            // 
            this.dgvKlanten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKlanten.Location = new System.Drawing.Point(6, 86);
            this.dgvKlanten.Name = "dgvKlanten";
            this.dgvKlanten.Size = new System.Drawing.Size(843, 330);
            this.dgvKlanten.TabIndex = 0;
            this.dgvKlanten.SelectionChanged += new System.EventHandler(this.dgvKlanten_SelectionChanged);
            // 
            // txtZoek
            // 
            this.txtZoek.Location = new System.Drawing.Point(35, 35);
            this.txtZoek.Name = "txtZoek";
            this.txtZoek.Size = new System.Drawing.Size(100, 20);
            this.txtZoek.TabIndex = 1;
            // 
            // btnZoek
            // 
            this.btnZoek.Location = new System.Drawing.Point(156, 35);
            this.btnZoek.Name = "btnZoek";
            this.btnZoek.Size = new System.Drawing.Size(75, 23);
            this.btnZoek.TabIndex = 2;
            this.btnZoek.Text = "Zoek";
            this.btnZoek.UseVisualStyleBackColor = true;
            this.btnZoek.Click += new System.EventHandler(this.btnZoek_Click);
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
            this.gbKlantGegevens.Location = new System.Drawing.Point(246, 6);
            this.gbKlantGegevens.Name = "gbKlantGegevens";
            this.gbKlantGegevens.Size = new System.Drawing.Size(603, 74);
            this.gbKlantGegevens.TabIndex = 3;
            this.gbKlantGegevens.TabStop = false;
            this.gbKlantGegevens.Text = "Klant gegevens";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(352, 13);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email";
            // 
            // lblAchternaam
            // 
            this.lblAchternaam.AutoSize = true;
            this.lblAchternaam.Location = new System.Drawing.Point(230, 13);
            this.lblAchternaam.Name = "lblAchternaam";
            this.lblAchternaam.Size = new System.Drawing.Size(64, 13);
            this.lblAchternaam.TabIndex = 6;
            this.lblAchternaam.Text = "Achternaam";
            // 
            // lblVoornaam
            // 
            this.lblVoornaam.AutoSize = true;
            this.lblVoornaam.Location = new System.Drawing.Point(129, 13);
            this.lblVoornaam.Name = "lblVoornaam";
            this.lblVoornaam.Size = new System.Drawing.Size(55, 13);
            this.lblVoornaam.TabIndex = 7;
            this.lblVoornaam.Text = "Voornaam";
            // 
            // txtVoornaam
            // 
            this.txtVoornaam.Location = new System.Drawing.Point(108, 29);
            this.txtVoornaam.Name = "txtVoornaam";
            this.txtVoornaam.Size = new System.Drawing.Size(100, 20);
            this.txtVoornaam.TabIndex = 8;
            // 
            // txtAchternaam
            // 
            this.txtAchternaam.Location = new System.Drawing.Point(214, 29);
            this.txtAchternaam.Name = "txtAchternaam";
            this.txtAchternaam.Size = new System.Drawing.Size(100, 20);
            this.txtAchternaam.TabIndex = 9;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(320, 29);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 10;
            // 
            // btnOpslaan
            // 
            this.btnOpslaan.Location = new System.Drawing.Point(450, 24);
            this.btnOpslaan.Name = "btnOpslaan";
            this.btnOpslaan.Size = new System.Drawing.Size(100, 28);
            this.btnOpslaan.TabIndex = 11;
            this.btnOpslaan.Text = "Wijzigen";
            this.btnOpslaan.UseVisualStyleBackColor = true;
            this.btnOpslaan.Click += new System.EventHandler(this.btnOpslaan_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbNieuweKlant);
            this.groupBox1.Controls.Add(this.btnKoppelAbonnement);
            this.groupBox1.Controls.Add(this.lblNieuweKlantKoppel);
            this.groupBox1.Location = new System.Drawing.Point(260, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(575, 83);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Klant koppelen aan abonnement";
            // 
            // cbNieuweKlant
            // 
            this.cbNieuweKlant.FormattingEnabled = true;
            this.cbNieuweKlant.Location = new System.Drawing.Point(130, 39);
            this.cbNieuweKlant.Name = "cbNieuweKlant";
            this.cbNieuweKlant.Size = new System.Drawing.Size(121, 21);
            this.cbNieuweKlant.TabIndex = 13;
            // 
            // btnKoppelAbonnement
            // 
            this.btnKoppelAbonnement.Location = new System.Drawing.Point(274, 34);
            this.btnKoppelAbonnement.Name = "btnKoppelAbonnement";
            this.btnKoppelAbonnement.Size = new System.Drawing.Size(160, 28);
            this.btnKoppelAbonnement.TabIndex = 11;
            this.btnKoppelAbonnement.Text = "Koppel abonnement";
            this.btnKoppelAbonnement.UseVisualStyleBackColor = true;
            this.btnKoppelAbonnement.Click += new System.EventHandler(this.btnKoppelAbonnement_Click_1);
            // 
            // lblNieuweKlantKoppel
            // 
            this.lblNieuweKlantKoppel.AutoSize = true;
            this.lblNieuweKlantKoppel.Location = new System.Drawing.Point(6, 42);
            this.lblNieuweKlantKoppel.Name = "lblNieuweKlantKoppel";
            this.lblNieuweKlantKoppel.Size = new System.Drawing.Size(118, 13);
            this.lblNieuweKlantKoppel.TabIndex = 6;
            this.lblNieuweKlantKoppel.Text = "Nieuwe Klant Koppelen";
            // 
            // lblKlantId
            // 
            this.lblKlantId.AutoSize = true;
            this.lblKlantId.Location = new System.Drawing.Point(7, 35);
            this.lblKlantId.Name = "lblKlantId";
            this.lblKlantId.Size = new System.Drawing.Size(42, 13);
            this.lblKlantId.TabIndex = 12;
            this.lblKlantId.Text = "Klant id";
            // 
            // werknemer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 559);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.Abbonementen);
            this.Controls.Add(this.label1);
            this.Name = "werknemer";
            this.Text = "werknemer";
            this.Load += new System.EventHandler(this.werknemer_Load);
            this.Abbonementen.ResumeLayout(false);
            this.tpKlantbeheer.ResumeLayout(false);
            this.tpKlantbeheer.PerformLayout();
            this.tpAbonnementen.ResumeLayout(false);
            this.tpAbonnementen.PerformLayout();
            this.tpAbonnementInchecken.ResumeLayout(false);
            this.tpAbonnementInchecken.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlleAbonnementen)).EndInit();
            this.tpNieuwAbonnement.ResumeLayout(false);
            this.tpNieuwAbonnement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKlanten)).EndInit();
            this.gbKlantGegevens.ResumeLayout(false);
            this.gbKlantGegevens.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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