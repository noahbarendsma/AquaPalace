using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaPalace
{
    public partial class klant : Form
    {
        public int LoggedInUserId { get; set; }

        public klant()
        {
            InitializeComponent();
        }

        private void klant_Load(object sender, EventArgs e)
        {
            Klanten.LoadAbonnementen(LoggedInUserId, dgvOverzichtAbonnementen);

            cmbType.Items.Clear();
            cmbType.Items.Add("Standaard");
            cmbType.Items.Add("Premium");
            cmbType.Items.Add("VIP");

            if (cmbType.Items.Count > 0)
                cmbType.SelectedIndex = 0;
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            try
            {
                var beginDatum = dtpBeginDatum.Value;
                var eindDatum = dtpEindDatum.Value;
                var type = cmbType.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(type))
                {
                    MessageBox.Show("Selecteer een abonnement type.");
                    return;
                }

                Klanten.VoegAbonnementToe(LoggedInUserId, beginDatum, eindDatum, type);
                MessageBox.Show("Abonnement succesvol toegevoegd!");

                // Refresh DataGridView
                Klanten.LoadAbonnementen(LoggedInUserId, dgvOverzichtAbonnementen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij toevoegen abonnement: " + ex.Message);
            }
        }
    }

}
