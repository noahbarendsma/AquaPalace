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
            this.btnVerlengenAbonnement = new System.Windows.Forms.Button();
            this.btnIncheckenViaZuilGast = new System.Windows.Forms.Button();
            this.btnGeschiedenisGast = new System.Windows.Forms.Button();
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.tcKlant = new System.Windows.Forms.TabControl();
            this.tpOverzichtAbonnementen = new System.Windows.Forms.TabPage();
            this.tpNieuwAbonnement = new System.Windows.Forms.TabPage();
            this.tpAbonnementVerlengen = new System.Windows.Forms.TabPage();
            this.tpIncheckenZuil = new System.Windows.Forms.TabPage();
            this.tpGeschiedenis = new System.Windows.Forms.TabPage();
            this.dgvOverzichtAbonnementen = new System.Windows.Forms.DataGridView();
            this.lblBeginDatum = new System.Windows.Forms.Label();
            this.lblEindDatum = new System.Windows.Forms.Label();
            this.dtpBeginDatum = new System.Windows.Forms.DateTimePicker();
            this.dtpEindDatum = new System.Windows.Forms.DateTimePicker();
            this.lblType = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.btnToevoegen = new System.Windows.Forms.Button();
            this.tcKlant.SuspendLayout();
            this.tpOverzichtAbonnementen.SuspendLayout();
            this.tpNieuwAbonnement.SuspendLayout();
            this.tpAbonnementVerlengen.SuspendLayout();
            this.tpIncheckenZuil.SuspendLayout();
            this.tpGeschiedenis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverzichtAbonnementen)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Klant";
            // 
            // btnVerlengenAbonnement
            // 
            this.btnVerlengenAbonnement.Location = new System.Drawing.Point(48, 81);
            this.btnVerlengenAbonnement.Name = "btnVerlengenAbonnement";
            this.btnVerlengenAbonnement.Size = new System.Drawing.Size(188, 52);
            this.btnVerlengenAbonnement.TabIndex = 5;
            this.btnVerlengenAbonnement.Text = "Abonnement verlengen";
            this.btnVerlengenAbonnement.UseVisualStyleBackColor = true;
            // 
            // btnIncheckenViaZuilGast
            // 
            this.btnIncheckenViaZuilGast.Location = new System.Drawing.Point(157, 80);
            this.btnIncheckenViaZuilGast.Name = "btnIncheckenViaZuilGast";
            this.btnIncheckenViaZuilGast.Size = new System.Drawing.Size(186, 52);
            this.btnIncheckenViaZuilGast.TabIndex = 6;
            this.btnIncheckenViaZuilGast.Text = "Inchecken via zuil";
            this.btnIncheckenViaZuilGast.UseVisualStyleBackColor = true;
            // 
            // btnGeschiedenisGast
            // 
            this.btnGeschiedenisGast.Location = new System.Drawing.Point(97, 83);
            this.btnGeschiedenisGast.Name = "btnGeschiedenisGast";
            this.btnGeschiedenisGast.Size = new System.Drawing.Size(188, 54);
            this.btnGeschiedenisGast.TabIndex = 7;
            this.btnGeschiedenisGast.Text = "Geschiedenis";
            this.btnGeschiedenisGast.UseVisualStyleBackColor = true;
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(480, 23);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(186, 54);
            this.btnUitloggen.TabIndex = 8;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            // 
            // tcKlant
            // 
            this.tcKlant.Controls.Add(this.tpOverzichtAbonnementen);
            this.tcKlant.Controls.Add(this.tpNieuwAbonnement);
            this.tcKlant.Controls.Add(this.tpAbonnementVerlengen);
            this.tcKlant.Controls.Add(this.tpIncheckenZuil);
            this.tcKlant.Controls.Add(this.tpGeschiedenis);
            this.tcKlant.Location = new System.Drawing.Point(16, 83);
            this.tcKlant.Name = "tcKlant";
            this.tcKlant.SelectedIndex = 0;
            this.tcKlant.Size = new System.Drawing.Size(654, 290);
            this.tcKlant.TabIndex = 9;
            // 
            // tpOverzichtAbonnementen
            // 
            this.tpOverzichtAbonnementen.Controls.Add(this.dgvOverzichtAbonnementen);
            this.tpOverzichtAbonnementen.Location = new System.Drawing.Point(4, 25);
            this.tpOverzichtAbonnementen.Name = "tpOverzichtAbonnementen";
            this.tpOverzichtAbonnementen.Padding = new System.Windows.Forms.Padding(3);
            this.tpOverzichtAbonnementen.Size = new System.Drawing.Size(646, 261);
            this.tpOverzichtAbonnementen.TabIndex = 1;
            this.tpOverzichtAbonnementen.Text = "Overzicht Abonnementen";
            this.tpOverzichtAbonnementen.UseVisualStyleBackColor = true;
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
            this.tpNieuwAbonnement.Size = new System.Drawing.Size(646, 261);
            this.tpNieuwAbonnement.TabIndex = 2;
            this.tpNieuwAbonnement.Text = "Nieuw Abonnement";
            this.tpNieuwAbonnement.UseVisualStyleBackColor = true;
            // 
            // tpAbonnementVerlengen
            // 
            this.tpAbonnementVerlengen.Controls.Add(this.btnVerlengenAbonnement);
            this.tpAbonnementVerlengen.Location = new System.Drawing.Point(4, 25);
            this.tpAbonnementVerlengen.Name = "tpAbonnementVerlengen";
            this.tpAbonnementVerlengen.Padding = new System.Windows.Forms.Padding(3);
            this.tpAbonnementVerlengen.Size = new System.Drawing.Size(646, 261);
            this.tpAbonnementVerlengen.TabIndex = 3;
            this.tpAbonnementVerlengen.Text = "Abonnement verlengen";
            this.tpAbonnementVerlengen.UseVisualStyleBackColor = true;
            // 
            // tpIncheckenZuil
            // 
            this.tpIncheckenZuil.Controls.Add(this.btnIncheckenViaZuilGast);
            this.tpIncheckenZuil.Location = new System.Drawing.Point(4, 25);
            this.tpIncheckenZuil.Name = "tpIncheckenZuil";
            this.tpIncheckenZuil.Padding = new System.Windows.Forms.Padding(3);
            this.tpIncheckenZuil.Size = new System.Drawing.Size(646, 261);
            this.tpIncheckenZuil.TabIndex = 4;
            this.tpIncheckenZuil.Text = "Inchecken via zuil";
            this.tpIncheckenZuil.UseVisualStyleBackColor = true;
            // 
            // tpGeschiedenis
            // 
            this.tpGeschiedenis.Controls.Add(this.btnGeschiedenisGast);
            this.tpGeschiedenis.Location = new System.Drawing.Point(4, 25);
            this.tpGeschiedenis.Name = "tpGeschiedenis";
            this.tpGeschiedenis.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeschiedenis.Size = new System.Drawing.Size(646, 261);
            this.tpGeschiedenis.TabIndex = 5;
            this.tpGeschiedenis.Text = "Geschiedenis";
            this.tpGeschiedenis.UseVisualStyleBackColor = true;
            // 
            // dgvOverzichtAbonnementen
            // 
            this.dgvOverzichtAbonnementen.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.dgvOverzichtAbonnementen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOverzichtAbonnementen.Location = new System.Drawing.Point(6, 3);
            this.dgvOverzichtAbonnementen.Name = "dgvOverzichtAbonnementen";
            this.dgvOverzichtAbonnementen.RowHeadersWidth = 51;
            this.dgvOverzichtAbonnementen.RowTemplate.Height = 24;
            this.dgvOverzichtAbonnementen.Size = new System.Drawing.Size(634, 252);
            this.dgvOverzichtAbonnementen.TabIndex = 0;
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
            // lblEindDatum
            // 
            this.lblEindDatum.AutoSize = true;
            this.lblEindDatum.Location = new System.Drawing.Point(42, 50);
            this.lblEindDatum.Name = "lblEindDatum";
            this.lblEindDatum.Size = new System.Drawing.Size(76, 16);
            this.lblEindDatum.TabIndex = 1;
            this.lblEindDatum.Text = "Eind Datum";
            // 
            // dtpBeginDatum
            // 
            this.dtpBeginDatum.Location = new System.Drawing.Point(157, 7);
            this.dtpBeginDatum.Name = "dtpBeginDatum";
            this.dtpBeginDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpBeginDatum.TabIndex = 2;
            // 
            // dtpEindDatum
            // 
            this.dtpEindDatum.Location = new System.Drawing.Point(157, 45);
            this.dtpEindDatum.Name = "dtpEindDatum";
            this.dtpEindDatum.Size = new System.Drawing.Size(200, 22);
            this.dtpEindDatum.TabIndex = 3;
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
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(157, 74);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(121, 24);
            this.cmbType.TabIndex = 5;
            // 
            // btnToevoegen
            // 
            this.btnToevoegen.Location = new System.Drawing.Point(157, 121);
            this.btnToevoegen.Name = "btnToevoegen";
            this.btnToevoegen.Size = new System.Drawing.Size(200, 40);
            this.btnToevoegen.TabIndex = 6;
            this.btnToevoegen.Text = "Toevoegen";
            this.btnToevoegen.UseVisualStyleBackColor = true;
            this.btnToevoegen.Click += new System.EventHandler(this.btnToevoegen_Click);
            // 
            // klant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 384);
            this.Controls.Add(this.tcKlant);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "klant";
            this.Text = "klant";
            this.Load += new System.EventHandler(this.klant_Load);
            this.tcKlant.ResumeLayout(false);
            this.tpOverzichtAbonnementen.ResumeLayout(false);
            this.tpNieuwAbonnement.ResumeLayout(false);
            this.tpNieuwAbonnement.PerformLayout();
            this.tpAbonnementVerlengen.ResumeLayout(false);
            this.tpIncheckenZuil.ResumeLayout(false);
            this.tpGeschiedenis.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverzichtAbonnementen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnVerlengenAbonnement;
        private System.Windows.Forms.Button btnIncheckenViaZuilGast;
        private System.Windows.Forms.Button btnGeschiedenisGast;
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
    }
}