using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AquaPalace.Werknemers;

namespace AquaPalace
{
    public partial class werknemer : Form
    {
        private AbonnementRepository repo = new AbonnementRepository();
        private KlantRepository klantRepo = new KlantRepository();
        public int LoggedInUserId { get; set; }
        public werknemer()
        {
            InitializeComponent();
        }

        private void werknemer_Load(object sender, EventArgs e)
        {
            Werknemers.LoadAlleAbonnementen(dgvAlleAbonnementen);
            Werknemers.LoadAlleKlanten(dgvKlanten);
            cbFilterType.Items.Clear();
            cbFilterType.Items.Add("Alle");
            cbFilterType.Items.Add("Basis");
            cbFilterType.Items.Add("Standaard");
            cbFilterType.Items.Add("Premium");
            cbFilterType.SelectedIndex = 0;

            LaadAbonnementen();
            VulKlantComboBox();
        }
        private void VulKlantComboBox()
        {
            var klanten = klantRepo.GetKlanten();
            cbNieuweKlant.DataSource = klanten;
            cbNieuweKlant.DisplayMember = "VolledigeNaam";
            cbNieuweKlant.ValueMember = "Id";
        }
        private void LaadAbonnementen()
        {
            string klant = txtKlantzoeken.Text.Trim();
            string type = cbFilterType.SelectedItem.ToString();

            var abonnementen = repo.GetAbonnementen(klant, type);
            dgvAlleAbonnementen.DataSource = abonnementen;
        }

        private void tpAbonnementen_Click(object sender, EventArgs e)
        {

        }

        private void btnNieuwAbonnement_Click(object sender, EventArgs e)
        {


        }

        private void btnNieuwAbonnement_Click_1(object sender, EventArgs e)
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

                int userID = 1;
                txtUser.Text = userID.ToString();
                Werknemers.VoegAbonnementToe(userID, beginDatum, eindDatum, type);

                MessageBox.Show("Abonnement succesvol toegevoegd!");

                Werknemers.LoadAlleAbonnementen(dgvAlleAbonnementen);

            }

            catch (Exception ex)

            {

                MessageBox.Show("Fout bij toevoegen abonnement: " + ex.Message);

            }

        }

        private void btnInchecken_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtIncheck.Text, out int userId))
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
                Werknemers.RegistreerIncheckViaUser(userId, locatie);

                lblResultaat.ForeColor = Color.Green;
                lblResultaat.Text = "Incheck geslaagd!";
            }
            catch (Exception ex)
            {
                lblResultaat.ForeColor = Color.Red;
                lblResultaat.Text = ex.Message; // bijv. "Geen geldig abonnement gevonden"
            }
        }

        private void btnUitloggen_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1.ActiveForm.Show();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {

        }

        private void cbFilterType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LaadAbonnementen();
        }

        private void txtKlantzoeken_TextChanged(object sender, EventArgs e)
        {
            LaadAbonnementen();
        }

        private void btnZoek_Click(object sender, EventArgs e)
        {
            string filter = txtZoek.Text.Trim();
            Werknemers.LoadAlleKlanten(dgvKlanten, filter);
        }

        private void dgvKlanten_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvKlanten.CurrentRow != null)
            {
                txtVoornaam.Text = dgvKlanten.CurrentRow.Cells["Voornaam"].Value?.ToString();
                txtAchternaam.Text = dgvKlanten.CurrentRow.Cells["Achternaam"].Value?.ToString();
                txtEmail.Text = dgvKlanten.CurrentRow.Cells["Email"].Value?.ToString();
                lblKlantId.Text = dgvKlanten.CurrentRow.Cells["Id"].Value?.ToString();
            }
        }

        private void btnOpslaan_Click(object sender, EventArgs e)
        {
            if (int.TryParse(lblKlantId.Text, out int id))
            {
                var klant = new Klant
                {
                    Id = id,
                    Voornaam = txtVoornaam.Text,
                    Achternaam = txtAchternaam.Text,
                    Email = txtEmail.Text
                };

                klantRepo.UpdateKlant(klant);
                MessageBox.Show("Klantgegevens bijgewerkt!");

                Werknemers.LoadAlleKlanten(dgvKlanten); // herladen
            }
        }

        private void btnKoppelAbonnement_Click(object sender, EventArgs e)
        {

        }

        private void dgvAlleAbonnementen_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAlleAbonnementen.CurrentRow != null)
            {
                string type = dgvAlleAbonnementen.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void btnKoppelAbonnement_Click_1(object sender, EventArgs e)
        {
            if (dgvAlleAbonnementen.CurrentRow != null)
            {
                int abonnementId = Convert.ToInt32(dgvAlleAbonnementen.CurrentRow.Cells["Id"].Value);

                if (cbNieuweKlant.SelectedItem is Klant nieuweKlant)
                {

                    Werknemers.WijzigAbonnementKlantEnType(abonnementId, nieuweKlant.Id);

                    MessageBox.Show("Abonnement succesvol aangepast!");
                    LaadAbonnementen(); // herlaad DataGridView
                }
                else
                {
                    MessageBox.Show("Selecteer een klant.");
                }
            }
            else
            {
                MessageBox.Show("Selecteer eerst een abonnement.");
            }
        }
    }
}
