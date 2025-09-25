using AquaPalace.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AquaPalace.administrator
{
    public partial class overzichtAbbonementen : Form
    {
        public overzichtAbbonementen()
        {
            InitializeComponent();
        }

        private void overzichtAbbonementen_Load(object sender, EventArgs e)
        {
           // TYPE
            abonementtypeCombobox.Items.Add("Alle");
            abonementtypeCombobox.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (String abonementObject in Abonnement.GetTypes())
            {
                abonementtypeCombobox.Items.Add(abonementObject);
            }

            // DATUM
            abonementgeldigheidCombobox.Items.Add("Alle");
            abonementgeldigheidCombobox.Items.Add("Binnen 1 maand");
            abonementgeldigheidCombobox.Items.Add("Binnen 2 maanden");
            abonementgeldigheidCombobox.Items.Add("Binnen 3 maanden");
            abonementgeldigheidCombobox.Items.Add("Binnen 4 maanden");

            // Select 
            abonementtypeCombobox.SelectedIndex = 0;
            abonementgeldigheidCombobox.SelectedIndex = 0;
        }

        private void terugbutton_Click(object sender, EventArgs e)
        {
            Administrator.instance.Show();
            this.Hide();
        }

        private void toonbutton_Click(object sender, EventArgs e)
        {
            BindingSource bSource = Abonnement.ZoekTypeAndDate(abonementtypeCombobox.Text, abonementgeldigheidCombobox.Text);
            dataGridView1.DataSource = bSource;
            dataGridView1.Columns[0].HeaderText = "Abonnement";
        }
    }
}
