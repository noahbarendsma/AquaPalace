namespace AquaPalace
{
    partial class Administrator
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
            this.btnUitloggen = new System.Windows.Forms.Button();
            this.btnNieuwAbonnementAanschaffen = new System.Windows.Forms.Button();
            this.btnOverzicht = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrator";
            // 
            // btnUitloggen
            // 
            this.btnUitloggen.Location = new System.Drawing.Point(346, 208);
            this.btnUitloggen.Margin = new System.Windows.Forms.Padding(2);
            this.btnUitloggen.Name = "btnUitloggen";
            this.btnUitloggen.Size = new System.Drawing.Size(302, 100);
            this.btnUitloggen.TabIndex = 11;
            this.btnUitloggen.Text = "Uitloggen";
            this.btnUitloggen.UseVisualStyleBackColor = true;
            this.btnUitloggen.Click += new System.EventHandler(this.btnUitloggen_Click);
            // 
            // btnNieuwAbonnementAanschaffen
            // 
            this.btnNieuwAbonnementAanschaffen.Location = new System.Drawing.Point(495, 103);
            this.btnNieuwAbonnementAanschaffen.Margin = new System.Windows.Forms.Padding(2);
            this.btnNieuwAbonnementAanschaffen.Name = "btnNieuwAbonnementAanschaffen";
            this.btnNieuwAbonnementAanschaffen.Size = new System.Drawing.Size(302, 101);
            this.btnNieuwAbonnementAanschaffen.TabIndex = 7;
            this.btnNieuwAbonnementAanschaffen.Text = "Overzicht Gebruiker";
            this.btnNieuwAbonnementAanschaffen.UseVisualStyleBackColor = true;
            this.btnNieuwAbonnementAanschaffen.Click += new System.EventHandler(this.btnNieuwAbonnementAanschaffen_Click);
            // 
            // btnOverzicht
            // 
            this.btnOverzicht.Location = new System.Drawing.Point(184, 103);
            this.btnOverzicht.Margin = new System.Windows.Forms.Padding(2);
            this.btnOverzicht.Name = "btnOverzicht";
            this.btnOverzicht.Size = new System.Drawing.Size(307, 101);
            this.btnOverzicht.TabIndex = 6;
            this.btnOverzicht.Text = "Overzicht Abonnementen";
            this.btnOverzicht.UseVisualStyleBackColor = true;
            this.btnOverzicht.Click += new System.EventHandler(this.btnOverzicht_Click);
            // 
            // Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 434);
            this.Controls.Add(this.btnUitloggen);
            this.Controls.Add(this.btnNieuwAbonnementAanschaffen);
            this.Controls.Add(this.btnOverzicht);
            this.Controls.Add(this.label1);
            this.Name = "Administrator";
            this.Text = "administrator";
            this.Load += new System.EventHandler(this.administrator_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUitloggen;
        private System.Windows.Forms.Button btnNieuwAbonnementAanschaffen;
        private System.Windows.Forms.Button btnOverzicht;
    }


}