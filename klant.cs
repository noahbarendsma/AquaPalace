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
            Klanten.GetAbonnementGeschiedenis(LoggedInUserId, dgvAbonnementGeschiedenis);
            VulAbonnementenComboBox();

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

                Klanten.LoadAbonnementen(LoggedInUserId, dgvOverzichtAbonnementen);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fout bij toevoegen abonnement: " + ex.Message);
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.ActiveForm.Show();
        }

        private void dgvOverzichtAbonnementen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void VulAbonnementenComboBox()
        {
            var abonnementen = Klanten.GetAbonnementenByUserId(LoggedInUserId);

            cmbAbonnementen.Items.Clear();
            foreach (var ab in abonnementen)
            {
                cmbAbonnementen.Items.Add(ab);
            }

            if (cmbAbonnementen.Items.Count > 0)
                cmbAbonnementen.SelectedIndex = 0;

            if (cmbAbonnementen.Items.Count > 0)
                cmbAbonnementen.SelectedIndex = 0;
        }

        private class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }
            public override string ToString()
            {
                return Text;
            }
        }


        private void btnVerlengen_Click(object sender, EventArgs e)
        {
            if (cmbAbonnementen.SelectedItem is Abonnementen selectedAbonnement)
            {
                DateTime nieuweEindDatum = dtpNieuweEindDatum.Value;

                try
                {
                    Klanten.VerlengAbonnement(selectedAbonnement.Id, nieuweEindDatum);
                    MessageBox.Show("Abonnement succesvol verlengd!");

                    Klanten.LoadAbonnementen(LoggedInUserId, dgvOverzichtAbonnementen);
                    VulAbonnementenComboBox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij verlengen: " + ex.Message);
                }
            }
        }



        private void btnInchecken_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUser.Text, out int userId))
            {
                lblResultaat.ForeColor = Color.Red;
                lblResultaat.Text = "Voer een geldig klantnummer (userId) in.";
                return;
            }

            string locatie = txtLocatie.Text.Trim();
            if (string.IsNullOrEmpty(locatie))
            {
                lblResultaat.ForeColor = Color.Red;
                lblResultaat.Text = "Voer een locatie in.";
                return;
            }

            try
            {
                Klanten.RegistreerIncheckViaUser(userId, locatie);

                lblResultaat.ForeColor = Color.Green;
                lblResultaat.Text = "Incheck geslaagd!";
            }
            catch (Exception ex)
            {
                lblResultaat.ForeColor = Color.Red;
                lblResultaat.Text = ex.Message; // bijv. "Geen geldig abonnement gevonden"
            }
        }

        private void dgvAbonnementGeschiedenis_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
