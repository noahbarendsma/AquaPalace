using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BCrypt.Net;

namespace AquaPalace
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnInloggen_Click(object sender, EventArgs e)
        {
            using (MySqlConnection con = Database.start())
            {
                try
                {
                    con.Open();

                    // Haal alleen de gebruiker op met deze gebruikersnaam
                    string sql = "SELECT user_password FROM users WHERE user_username = @gebruikersnaam";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@gebruikersnaam", txtGebruikersnaam.Text);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string hashedPassword = result.ToString();

                            // Controleer of het ingevoerde wachtwoord klopt
                            if (BCrypt.Net.BCrypt.EnhancedVerify(txtWachtwoord.Text, hashedPassword))
                            {
                                MessageBox.Show("Ingelogd!");
                                FrmOverzicht frm = new FrmOverzicht();
                                frm.Show();
                                txtGebruikersnaam.Clear();
                                txtWachtwoord.Clear();
                            }
                            else
                            {
                                MessageBox.Show("Onjuist wachtwoord.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Gebruiker niet gevonden.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fout bij verbinden met de database: " + ex.Message);
                }
            }
        }
    }
}
