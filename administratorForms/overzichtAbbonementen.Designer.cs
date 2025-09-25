namespace AquaPalace.administrator
{
    partial class overzichtAbbonementen
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
            this.terugbutton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toonbutton = new System.Windows.Forms.Button();
            this.abonementgeldigheidCombobox = new System.Windows.Forms.ComboBox();
            this.abonementtypeCombobox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // terugbutton
            // 
            this.terugbutton.Location = new System.Drawing.Point(12, 12);
            this.terugbutton.Name = "terugbutton";
            this.terugbutton.Size = new System.Drawing.Size(193, 81);
            this.terugbutton.TabIndex = 91;
            this.terugbutton.Text = "Terug";
            this.terugbutton.UseVisualStyleBackColor = true;
            this.terugbutton.Click += new System.EventHandler(this.terugbutton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(167, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(753, 339);
            this.dataGridView1.TabIndex = 99;
            // 
            // toonbutton
            // 
            this.toonbutton.Location = new System.Drawing.Point(696, 56);
            this.toonbutton.Name = "toonbutton";
            this.toonbutton.Size = new System.Drawing.Size(203, 81);
            this.toonbutton.TabIndex = 102;
            this.toonbutton.Text = "Toon";
            this.toonbutton.UseVisualStyleBackColor = true;
            this.toonbutton.Click += new System.EventHandler(this.toonbutton_Click);
            // 
            // abonementgeldigheidCombobox
            // 
            this.abonementgeldigheidCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abonementgeldigheidCombobox.FormattingEnabled = true;
            this.abonementgeldigheidCombobox.Location = new System.Drawing.Point(435, 105);
            this.abonementgeldigheidCombobox.Name = "abonementgeldigheidCombobox";
            this.abonementgeldigheidCombobox.Size = new System.Drawing.Size(121, 21);
            this.abonementgeldigheidCombobox.TabIndex = 106;
            // 
            // abonementtypeCombobox
            // 
            this.abonementtypeCombobox.AccessibleDescription = "";
            this.abonementtypeCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.abonementtypeCombobox.FormattingEnabled = true;
            this.abonementtypeCombobox.Location = new System.Drawing.Point(240, 105);
            this.abonementtypeCombobox.Name = "abonementtypeCombobox";
            this.abonementtypeCombobox.Size = new System.Drawing.Size(121, 21);
            this.abonementtypeCombobox.TabIndex = 105;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 24);
            this.label2.TabIndex = 104;
            this.label2.Text = "Geldigheid van abonement";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(236, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 24);
            this.label1.TabIndex = 103;
            this.label1.Text = "Type van abonement";
            // 
            // overzichtAbbonementen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 539);
            this.Controls.Add(this.abonementgeldigheidCombobox);
            this.Controls.Add(this.abonementtypeCombobox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toonbutton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.terugbutton);
            this.Name = "overzichtAbbonementen";
            this.Text = "overzichtAbbonementen";
            this.Load += new System.EventHandler(this.overzichtAbbonementen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button terugbutton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button toonbutton;
        private System.Windows.Forms.ComboBox abonementgeldigheidCombobox;
        private System.Windows.Forms.ComboBox abonementtypeCombobox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}