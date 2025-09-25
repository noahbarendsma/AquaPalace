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
                    string sql = "SELECT user_id, user_password, user_role FROM users WHERE user_username = @gebruikersnaam";

                    using (MySqlCommand cmd = new MySqlCommand(sql, con))
                    {
                        cmd.Parameters.AddWithValue("@gebruikersnaam", txtGebruikersnaam.Text);

                        MySqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            int userId = reader.GetInt32("user_id");
                            string hashedPassword = reader.GetString("user_password");
                            string userRole = reader.GetString("user_role");

                            // Controleer of het ingevoerde wachtwoord klopt
                            if (BCrypt.Net.BCrypt.EnhancedVerify(txtWachtwoord.Text, hashedPassword))
                            {

                                if (userRole == "admin")
                                {
                                    MessageBox.Show("Welkom administrator");
                                    administrator FormAdministrator = new administrator();
                                    FormAdministrator.Show();
                                    txtGebruikersnaam.Clear();
                                    txtWachtwoord.Clear();
                                    this.Hide();
                                }
                                else if (userRole == "werknemer")
                                {
                                    MessageBox.Show("Welkom werknemer");
                                    werknemer FormWerknemer = new werknemer();
                                    FormWerknemer.Show();
                                    txtGebruikersnaam.Clear();
                                    txtWachtwoord.Clear();
                                }
                                else // Klant
                                {
                                    MessageBox.Show("Welkom klant");
                                    klant Formklant = new klant();
                                    Formklant.LoggedInUserId = userId;
                                    Formklant.Show();
                                    txtGebruikersnaam.Clear();
                                    txtWachtwoord.Clear();
                                }
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }


//admin: 
//eva_j
//Eva@123

//werknemer:
//ava_d
//Ava#456

//klant:
//isabella_j
//Isabella@789
    }
}
