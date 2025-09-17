namespace AquaPalace
{
    partial class FrmOverzicht
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
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.btnNieuwAbonnementAanschaffen = new System.Windows.Forms.Button();
            this.btnVerlengenAbonnement = new System.Windows.Forms.Button();
            this.btnIncheckenViaZuilGast = new System.Windows.Forms.Button();
            this.btnGeschiedenisGast = new System.Windows.Forms.Button();
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.lblNaam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(68, 85);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(112, 55);
            this.btnOverzicht.TabIndex = 0;
            this.btnOverzicht.Text = "Overzicht Abonnementen";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            // 
            // btnNieuwAbonnementAanschaffen
            // 
            this.btnNieuwAbonnementAanschaffen.Location = new System.Drawing.Point(212, 85);
            this.btnNieuwAbonnementAanschaffen.Name = "btnNieuwAbonnementAanschaffen";
            this.btnNieuwAbonnementAanschaffen.Size = new System.Drawing.Size(105, 55);
            this.btnNieuwAbonnementAanschaffen.TabIndex = 1;
            this.btnNieuwAbonnementAanschaffen.Text = "Nieuw Abonnement";
            this.btnNieuwAbonnementAanschaffen.UseVisualStyleBackColor = true;
            // 
            // btnVerlengenAbonnement
            // 
            this.btnVerlengenAbonnement.Location = new System.Drawing.Point(68, 156);
            this.btnVerlengenAbonnement.Name = "btnVerlengenAbonnement";
            this.btnVerlengenAbonnement.Size = new System.Drawing.Size(112, 52);
            this.btnVerlengenAbonnement.TabIndex = 2;
            this.btnVerlengenAbonnement.Text = "Abonnement verlengen";
            this.btnVerlengenAbonnement.UseVisualStyleBackColor = true;
            // 
            // btnIncheckenViaZuilGast
            // 
            this.btnIncheckenViaZuilGast.Location = new System.Drawing.Point(212, 156);
            this.btnIncheckenViaZuilGast.Name = "btnIncheckenViaZuilGast";
            this.btnIncheckenViaZuilGast.Size = new System.Drawing.Size(105, 52);
            this.btnIncheckenViaZuilGast.TabIndex = 3;
            this.btnIncheckenViaZuilGast.Text = "Inchecken via zuil";
            this.btnIncheckenViaZuilGast.UseVisualStyleBackColor = true;
            // 
            // btnGeschiedenisGast
            // 
            this.btnGeschiedenisGast.Location = new System.Drawing.Point(68, 221);
            this.btnGeschiedenisGast.Name = "btnGeschiedenisGast";
            this.btnGeschiedenisGast.Size = new System.Drawing.Size(112, 54);
            this.btnGeschiedenisGast.TabIndex = 4;
            this.btnGeschiedenisGast.Text = "Geschiedenis";
            this.btnGeschiedenisGast.UseVisualStyleBackColor = true;
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(212, 221);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(105, 54);
            this.btnUitloggen.TabIndex = 5;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(173, 21);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(44, 16);
            this.lblNaam.TabIndex = 6;
            this.lblNaam.Text = "label1";
            // 
            // FrmOverzicht
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 343);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.btnGeschiedenisGast);
            this.Controls.Add(this.btnIncheckenViaZuilGast);
            this.Controls.Add(this.btnVerlengenAbonnement);
            this.Controls.Add(this.btnNieuwAbonnementAanschaffen);
            this.Controls.Add(this.btnOverzicht);
            this.Name = "FrmOverzicht";
            this.Text = "FrmOverzicht";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOverzicht;
        private System.Windows.Forms.Button btnNieuwAbonnementAanschaffen;
        private System.Windows.Forms.Button btnVerlengenAbonnement;
        private System.Windows.Forms.Button btnIncheckenViaZuilGast;
        private System.Windows.Forms.Button btnGeschiedenisGast;
        private System.Windows.Forms.Button btnUitloggen;
        private System.Windows.Forms.Label lblNaam;
    }
}