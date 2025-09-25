using AquaPalace.administrator;
using AquaPalace.administratorForms;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace AquaPalace
{
    public partial class Administrator : Form
    {
        public static Administrator instance;
        public string username;
        public Administrator()
        {
            InitializeComponent();

            instance = this;

            if (Administrator.ActiveForm != null)
            {
                Administrator.ActiveForm.Hide();
            }
        }
       
        private void administrator_Load(object sender, EventArgs e)
        {
            label1.Text = "Administrator " + username;
        }

        private void btnNieuwAbonnementAanschaffen_Click(object sender, EventArgs e)
        {
            overzichtGebruikers overzichtGebruikerform = new overzichtGebruikers();
            overzichtGebruikers.instance.username = username;
            overzichtGebruikerform.Show();
            this.Hide();
        }

        private void btnOverzicht_Click(object sender, EventArgs e)
        {
            overzichtAbbonementen overzichtAbbonementenform = new overzichtAbbonementen();
            overzichtAbbonementenform.Show();
            this.Hide();
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Software, Software word gesloten");
            Application.Exit();
        }
    }
}
