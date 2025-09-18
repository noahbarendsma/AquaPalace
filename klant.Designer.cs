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
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.btnNieuwAbonnementAanschaffen = new System.Windows.Forms.Button();
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
            this.tcKlant.SuspendLayout();
            this.tpOverzichtAbonnementen.SuspendLayout();
            this.tpNieuwAbonnement.SuspendLayout();
            this.tpAbonnementVerlengen.SuspendLayout();
            this.tpIncheckenZuil.SuspendLayout();
            this.tpGeschiedenis.SuspendLayout();
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
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(71, 68);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(188, 55);
            this.btnOverzicht.TabIndex = 3;
            this.btnOverzicht.Text = "Overzicht Abonnementen";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            // 
            // btnNieuwAbonnementAanschaffen
            // 
            this.btnNieuwAbonnementAanschaffen.Location = new System.Drawing.Point(119, 37);
            this.btnNieuwAbonnementAanschaffen.Name = "btnNieuwAbonnementAanschaffen";
            this.btnNieuwAbonnementAanschaffen.Size = new System.Drawing.Size(186, 55);
            this.btnNieuwAbonnementAanschaffen.TabIndex = 4;
            this.btnNieuwAbonnementAanschaffen.Text = "Nieuw Abonnement";
            this.btnNieuwAbonnementAanschaffen.UseVisualStyleBackColor = true;
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
            this.tpOverzichtAbonnementen.Controls.Add(this.btnOverzicht);
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
            this.tpNieuwAbonnement.Controls.Add(this.btnNieuwAbonnementAanschaffen);
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
            this.tpGeschiedenis.Size = new System.Drawing.Size(530, 261);
            this.tpGeschiedenis.TabIndex = 5;
            this.tpGeschiedenis.Text = "Geschiedenis";
            this.tpGeschiedenis.UseVisualStyleBackColor = true;
            // 
            // klant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 384);
            this.Controls.Add(this.tcKlant);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "klant";
            this.Text = "klant";
            this.tcKlant.ResumeLayout(false);
            this.tpOverzichtAbonnementen.ResumeLayout(false);
            this.tpNieuwAbonnement.ResumeLayout(false);
            this.tpAbonnementVerlengen.ResumeLayout(false);
            this.tpIncheckenZuil.ResumeLayout(false);
            this.tpGeschiedenis.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.Button btnNieuwAbonnementAanschaffen;
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
    }
}