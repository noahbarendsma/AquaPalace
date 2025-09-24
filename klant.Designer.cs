namespace AquaPalace
{
    partial class klant
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
            this.btnVerlengen = new System.Windows.Forms.Button();
            this.btnInchecken = new System.Windows.Forms.Button();
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.tcKlant = new System.Windows.Forms.TabControl();
            this.tpOverzichtAbonnementen = new System.Windows.Forms.TabPage();
            this.dgvOverzichtAbonnementen = new System.Windows.Forms.DataGridView();
            this.tpNieuwAbonnement = new System.Windows.Forms.TabPage();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.dtpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpBeginDatum = new System.Windows.Forms.DateTimePicker();
            this.lblEindDatum = new System.Windows.Forms.Label();
            this.lblBeginDatum = new System.Windows.Forms.Label();
            this.tpAbonnementVerlengen = new System.Windows.Forms.TabPage();
            this.tpIncheckenZuil = new System.Windows.Forms.TabPage();
            this.tpGeschiedenis = new System.Windows.Forms.TabPage();
            this.lblAbonnement = new System.Windows.Forms.Label();
            this.lblNieuweEindDatum = new System.Windows.Forms.Label();
            this.cmbAbonnementen = new System.Windows.Forms.ComboBox();
            this.dtpNieuweEindDatum = new System.Windows.Forms.DateTimePicker();
            this.lblUserId = new System.Windows.Forms.Label();
            this.lblLocatie = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtLocatie = new System.Windows.Forms.TextBox();
            this.lblResultaat = new System.Windows.Forms.Label();
            this.dgvAbonnementGeschiedenis = new System.Windows.Forms.DataGridView();
            this.tcKlant.SuspendLayout();
            this.tpOverzichtAbonnementen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverzichtAbonnementen)).BeginInit();
            this.tpNieuwAbonnement.SuspendLayout();
            this.tpAbonnementVerlengen.SuspendLayout();
            this.tpIncheckenZuil.SuspendLayout();
            this.tpGeschiedenis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonnementGeschiedenis)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klant";
            // 
            // btnVerlengen
            // 
            this.btnVerlengen.Location = new System.Drawing.Point(209, 122);
            this.btnVerlengen.Name = "btnVerlengen";
            this.btnVerlengen.Size = new System.Drawing.Size(213, 46);
            this.btnVerlengen.TabIndex = 5;
            this.btnVerlengen.Text = "Abonnement verlengen";
            this.btnVerlengen.UseVisualStyleBackColor = true;
            this.btnVerlengen.Click += new System.EventHandler(this.btnVerlengen_Click);
            // 
            // btnInchecken
            // 
            this.btnInchecken.Location = new System.Drawing.Point(116, 88);
            this.btnInchecken.Name = "btnInchecken";
            this.btnInchecken.Size = new System.Drawing.Size(186, 52);
            this.btnInchecken.TabIndex = 6;
            this.btnInchecken.Text = "Inchecken via zuil";
            this.btnInchecken.UseVisualStyleBackColor = true;
            this.btnInchecken.Click += new System.EventHandler(this.btnInchecken_Click);
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(507, 3);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(186, 54);
            this.btnUitloggen.TabIndex = 8;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // tcKlant
            // 
            this.tcKlant.Controls.Add(this.tpOverzichtAbonnementen);
            this.tcKlant.Controls.Add(this.tpNieuwAbonnement);
            this.tcKlant.Controls.Add(this.tpAbonnementVerlengen);
            this.tcKlant.Controls.Add(this.tpIncheckenZuil);
            this.tcKlant.Controls.Add(this.tpGeschiedenis);
            this.tcKlant.Location = new System.Drawing.Point(1, 63);
            this.tcKlant.Name = "tcKlant";
            this.tcKlant.SelectedIndex = 0;
            this.tcKlant.Size = new System.Drawing.Size(692, 290);
            this.tcKlant.TabIndex = 9;
            // 
            // tpOverzichtAbonnementen
            // 
            this.tpOverzichtAbonnementen.Controls.Add(this.dgvOverzichtAbonnementen);
            this.tpOverzichtAbonnementen.Location = new System.Drawing.Point(4, 25);
            this.tpOverzichtAbonnementen.Name = "tpOverzichtAbonnementen";
            this.tpOverzichtAbonnementen.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverzichtAbonnementen.Size = new System.Drawing.Size(684, 261);
            this.tpOverzichtAbonnementen.TabIndex = 1;
            this.tpOverzichtAbonnementen.Text = "Overzicht Abonnementen";
            this.tpOverzichtAbonnementen.UseVisualStyleBackColor = true;
            // 
            // dgvOverzichtAbonnementen
            // 
            this.dgvOverzichtAbonnementen.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvOverzichtAbonnementen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverzichtAbonnementen.Location = new System.Drawing.Point(6, 3);
            this.dgvOverzichtAbonnementen.Name = "dgvOverzichtAbonnementen";
            this.dgvOverzichtAbonnementen.RowHeadersWidth = 51;
            this.dgvOverzichtAbonnementen.RowTemplate.Height = 24;
            this.dgvOverzichtAbonnementen.Size = new System.Drawing.Size(672, 252);
            this.dgvOverzichtAbonnementen.TabIndex = 0;
            this.dgvOverzichtAbonnementen.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOverzichtAbonnementen_CellContentClick);
            // 
            // tpNieuwAbonnement
            // 
            this.tpNieuwAbonnement.Controls.Add(this.btnToevoegen);
            this.tpNieuwAbonnement.Controls.Add(this.cmbType);
            this.tpNieuwAbonnement.Controls.Add(this.lblType);
            this.tpNieuwAbonnement.Controls.Add(this.dtpEindDatum);
            this.tpNieuwAbonnement.Controls.Add(this.dtpBeginDatum);
            this.tpNieuwAbonnement.Controls.Add(this.lblEindDatum);
            this.tpNieuwAbonnement.Controls.Add(this.lblBeginDatum);
            this.tpNieuwAbonnement.Location = new System.Drawing.Point(4, 25);
            this.tpNieuwAbonnement.Name = "tpNieuwAbonnement";
            this.tpNieuwAbonnement.Padding = new System.Windows.Forms.Padding(3);
            this.tpNieuwAbonnement.Size = new System.Drawing.Size(684, 261);
            this.tpNieuwAbonnement.TabIndex = 2;
            this.tpNieuwAbonnement.Text = "Abonnement Aanschaffen";
            this.tpNieuwAbonnement.UseVisualStyleBackColor = true;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(157, 121);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(200, 40);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Aanschaffen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(157, 74);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 5;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(42, 83);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(39, 16);
            this.lblType.TabIndex = 4;
            this.lblType.Text = "Type";
            // 
            // dtpEindDatum
            // 
            this.dtpEindDatum.Location = new System.Drawing.Point(157, 45);
            this.dtpEindDatum.Name = "dtpEindDatum";
            this.dtpEindDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpEindDatum.TabIndex = 3;
            // 
            // dtpBeginDatum
            // 
            this.dtpBeginDatum.Location = new System.Drawing.Point(157, 7);
            this.dtpBeginDatum.Name = "dtpBeginDatum";
            this.dtpBeginDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpBeginDatum.TabIndex = 2;
            // 
            // lblEindDatum
            // 
            this.lblEindDatum.AutoSize = true;
            this.lblEindDatum.Location = new System.Drawing.Point(42, 50);
            this.lblEindDatum.Name = "lblEindDatum";
            this.lblEindDatum.Size = new System.Drawing.Size(76, 16);
            this.lblEindDatum.TabIndex = 1;
            this.lblEindDatum.Text = "Eind Datum";
            // 
            // lblBeginDatum
            // 
            this.lblBeginDatum.AutoSize = true;
            this.lblBeginDatum.Location = new System.Drawing.Point(42, 13);
            this.lblBeginDatum.Name = "lblBeginDatum";
            this.lblBeginDatum.Size = new System.Drawing.Size(84, 16);
            this.lblBeginDatum.TabIndex = 0;
            this.lblBeginDatum.Text = "Begin Datum";
            // 
            // tpAbonnementVerlengen
            // 
            this.tpAbonnementVerlengen.Controls.Add(this.dtpNieuweEindDatum);
            this.tpAbonnementVerlengen.Controls.Add(this.cmbAbonnementen);
            this.tpAbonnementVerlengen.Controls.Add(this.lblNieuweEindDatum);
            this.tpAbonnementVerlengen.Controls.Add(this.lblAbonnement);
            this.tpAbonnementVerlengen.Controls.Add(this.btnVerlengen);
            this.tpAbonnementVerlengen.Location = new System.Drawing.Point(4, 25);
            this.tpAbonnementVerlengen.Name = "tpAbonnementVerlengen";
            this.tpAbonnementVerlengen.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbonnementVerlengen.Size = new System.Drawing.Size(684, 261);
            this.tpAbonnementVerlengen.TabIndex = 3;
            this.tpAbonnementVerlengen.Text = "Abonnement verlengen";
            this.tpAbonnementVerlengen.UseVisualStyleBackColor = true;
            // 
            // tpIncheckenZuil
            // 
            this.tpIncheckenZuil.Controls.Add(this.lblResultaat);
            this.tpIncheckenZuil.Controls.Add(this.txtLocatie);
            this.tpIncheckenZuil.Controls.Add(this.txtUser);
            this.tpIncheckenZuil.Controls.Add(this.lblLocatie);
            this.tpIncheckenZuil.Controls.Add(this.lblUserId);
            this.tpIncheckenZuil.Controls.Add(this.btnInchecken);
            this.tpIncheckenZuil.Location = new System.Drawing.Point(4, 25);
            this.tpIncheckenZuil.Name = "tpIncheckenZuil";
            this.tpIncheckenZuil.Padding = new System.Windows.Forms.Padding(3);
            this.tpIncheckenZuil.Size = new System.Drawing.Size(684, 261);
            this.tpIncheckenZuil.TabIndex = 4;
            this.tpIncheckenZuil.Text = "Inchecken via zuil";
            this.tpIncheckenZuil.UseVisualStyleBackColor = true;
            // 
            // tpGeschiedenis
            // 
            this.tpGeschiedenis.Controls.Add(this.dgvAbonnementGeschiedenis);
            this.tpGeschiedenis.Location = new System.Drawing.Point(4, 25);
            this.tpGeschiedenis.Name = "tpGeschiedenis";
            this.tpGeschiedenis.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeschiedenis.Size = new System.Drawing.Size(684, 261);
            this.tpGeschiedenis.TabIndex = 5;
            this.tpGeschiedenis.Text = "Geschiedenis";
            this.tpGeschiedenis.UseVisualStyleBackColor = true;
            // 
            // lblAbonnement
            // 
            this.lblAbonnement.AutoSize = true;
            this.lblAbonnement.Location = new System.Drawing.Point(31, 24);
            this.lblAbonnement.Name = "lblAbonnement";
            this.lblAbonnement.Size = new System.Drawing.Size(144, 16);
            this.lblAbonnement.TabIndex = 6;
            this.lblAbonnement.Text = "Selecteer Abonnement";
            // 
            // lblNieuweEindDatum
            // 
            this.lblNieuweEindDatum.AutoSize = true;
            this.lblNieuweEindDatum.Location = new System.Drawing.Point(31, 79);
            this.lblNieuweEindDatum.Name = "lblNieuweEindDatum";
            this.lblNieuweEindDatum.Size = new System.Drawing.Size(119, 16);
            this.lblNieuweEindDatum.TabIndex = 7;
            this.lblNieuweEindDatum.Text = "Nieuwe Einddatum";
            // 
            // cmbAbonnementen
            // 
            this.cmbAbonnementen.FormattingEnabled = true;
            this.cmbAbonnementen.Location = new System.Drawing.Point(209, 24);
            this.cmbAbonnementen.Name = "cmbAbonnementen";
            this.cmbAbonnementen.Size = new System.Drawing.Size(213, 24);
            this.cmbAbonnementen.TabIndex = 8;
            // 
            // dtpNieuweEindDatum
            // 
            this.dtpNieuweEindDatum.Location = new System.Drawing.Point(209, 72);
            this.dtpNieuweEindDatum.Name = "dtpNieuweEindDatum";
            this.dtpNieuweEindDatum.Size = new System.Drawing.Size(213, 22);
            this.dtpNieuweEindDatum.TabIndex = 9;
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Location = new System.Drawing.Point(33, 17);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(80, 16);
            this.lblUserId.TabIndex = 7;
            this.lblUserId.Text = "Gebruiker id";
            // 
            // lblLocatie
            // 
            this.lblLocatie.AutoSize = true;
            this.lblLocatie.Location = new System.Drawing.Point(33, 59);
            this.lblLocatie.Name = "lblLocatie";
            this.lblLocatie.Size = new System.Drawing.Size(51, 16);
            this.lblLocatie.TabIndex = 8;
            this.lblLocatie.Text = "Locatie";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(163, 14);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 22);
            this.txtUser.TabIndex = 9;
            // 
            // txtLocatie
            // 
            this.txtLocatie.Location = new System.Drawing.Point(163, 59);
            this.txtLocatie.Name = "txtLocatie";
            this.txtLocatie.Size = new System.Drawing.Size(100, 22);
            this.txtLocatie.TabIndex = 10;
            // 
            // lblResultaat
            // 
            this.lblResultaat.AutoSize = true;
            this.lblResultaat.Location = new System.Drawing.Point(173, 143);
            this.lblResultaat.Name = "lblResultaat";
            this.lblResultaat.Size = new System.Drawing.Size(64, 16);
            this.lblResultaat.TabIndex = 11;
            this.lblResultaat.Text = "Resultaat";
            // 
            // dgvAbonnementGeschiedenis
            // 
            this.dgvAbonnementGeschiedenis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAbonnementGeschiedenis.Location = new System.Drawing.Point(4, 4);
            this.dgvAbonnementGeschiedenis.Name = "dgvAbonnementGeschiedenis";
            this.dgvAbonnementGeschiedenis.RowHeadersWidth = 51;
            this.dgvAbonnementGeschiedenis.RowTemplate.Height = 24;
            this.dgvAbonnementGeschiedenis.Size = new System.Drawing.Size(674, 254);
            this.dgvAbonnementGeschiedenis.TabIndex = 0;
            this.dgvAbonnementGeschiedenis.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAbonnementGeschiedenis_CellContentClick);
            // 
            // klant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 372);
            this.Controls.Add(this.tcKlant);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "klant";
            this.Text = "klant";
            this.Load += new System.EventHandler(this.klant_Load);
            this.tcKlant.ResumeLayout(false);
            this.tpOverzichtAbonnementen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverzichtAbonnementen)).EndInit();
            this.tpNieuwAbonnement.ResumeLayout(false);
            this.tpNieuwAbonnement.PerformLayout();
            this.tpAbonnementVerlengen.ResumeLayout(false);
            this.tpAbonnementVerlengen.PerformLayout();
            this.tpIncheckenZuil.ResumeLayout(false);
            this.tpIncheckenZuil.PerformLayout();
            this.tpGeschiedenis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAbonnementGeschiedenis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerlengen;
        private System.Windows.Forms.Button btnInchecken;
        private System.Windows.Forms.Button btnUitloggen;
        private System.Windows.Forms.TabControl tcKlant;
        private System.Windows.Forms.TabPage tpOverzichtAbonnementen;
        private System.Windows.Forms.TabPage tpNieuwAbonnement;
        private System.Windows.Forms.TabPage tpAbonnementVerlengen;
        private System.Windows.Forms.TabPage tpIncheckenZuil;
        private System.Windows.Forms.TabPage tpGeschiedenis;
        private System.Windows.Forms.DataGridView dgvOverzichtAbonnementen;
        private System.Windows.Forms.Label lblEindDatum;
        private System.Windows.Forms.Label lblBeginDatum;
        private System.Windows.Forms.Button btnToevoegen;
        private System.Windows.Forms.ComboBox cmbType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.DateTimePicker dtpEindDatum;
        private System.Windows.Forms.DateTimePicker dtpBeginDatum;
        private System.Windows.Forms.Label lblNieuweEindDatum;
        private System.Windows.Forms.Label lblAbonnement;
        private System.Windows.Forms.ComboBox cmbAbonnementen;
        private System.Windows.Forms.DateTimePicker dtpNieuweEindDatum;
        private System.Windows.Forms.TextBox txtLocatie;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblLocatie;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.Label lblResultaat;
        private System.Windows.Forms.DataGridView dgvAbonnementGeschiedenis;
    }
}