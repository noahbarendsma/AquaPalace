using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaPalace
{
    internal class Werknemers
    {
        public class Abonnement
        {
            public int Id { get; set; }
            public string Klantnaam { get; set; }
            public string Abonnementstype { get; set; }
            public DateTime Startdatum { get; set; }
            public DateTime Einddatum { get; set; }
            public string Status
            {
                get
                {
                    return DateTime.Now <= Einddatum ? "Actief" : "Niet actief";
                }
            }
        }
        public class Klant
        {
            public int Id { get; set; }
            public string Voornaam { get; set; }
            public string Achternaam { get; set; }
            public string Email { get; set; }

            public string VolledigeNaam => $"{Voornaam} {Achternaam}";
        }
        public static void LoadAlleAbonnementen(DataGridView dgv)
        {
            using (MySqlConnection con = Database.start())
            {
                con.Open();
                string query = @"SELECT 
                            u.user_firstname AS 'First Name',
                            u.user_lastname  AS 'Last Name',
                            a.begin_datum    AS 'Begin Date',
                            a.eind_datum     AS 'End Date',
                            a.type           AS 'Type',
                            a.status         AS 'Status'
                         FROM abonnementen a
                         JOIN users u ON a.user_id = u.user_id";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt;
                }
            }
        }
        public static void LoadAlleKlanten(DataGridView dgv, string filter = "")
        {
            using (var con = Database.start())
            {
                con.Open();
                string query = @"SELECT 
                            user_id     AS 'Id',
                            user_firstname AS 'Voornaam',
                            user_lastname  AS 'Achternaam',
                            user_email AS 'Email'
                         FROM users
                         WHERE (@filter = '' 
                                OR user_firstname LIKE @like 
                                OR user_lastname LIKE @like
                                OR user_email LIKE @like)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@filter", filter);
                    cmd.Parameters.AddWithValue("@like", "%" + filter + "%");

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                        
                    dgv.DataSource = dt;
                }
            }
        }

        public static void NieuwAbonnement(int userId, DateTime beginDatum, DateTime eindDatum, string type)
        {
            using (MySqlConnection con = Database.start())
            {
                con.Open();
                string query = @"INSERT INTO abonnementen (user_id, begin_datum, eind_datum, type, status) 
                         VALUES (@userId, @begin, @eind, @type, @status)";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@begin", beginDatum);
                    cmd.Parameters.AddWithValue("@eind", eindDatum);
                    cmd.Parameters.AddWithValue("@type", type);
                    cmd.Parameters.AddWithValue("@status", DateTime.Now <= eindDatum ? "Actief" : "Niet actief");

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void VoegAbonnementToe(int userId, DateTime beginDatum, DateTime eindDatum, string type)
        {
            using (var con = Database.start())
            {
                con.Open();
                string query = @"INSERT INTO abonnementen (user_id, begin_datum, eind_datum, type, status)
                  VALUES (@userId, @beginDatum, @eindDatum, @type, 'Active')";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    cmd.Parameters.AddWithValue("@beginDatum", beginDatum);
                    cmd.Parameters.AddWithValue("@eindDatum", eindDatum);
                    cmd.Parameters.AddWithValue("@type", type);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void RegistreerIncheckViaUser(int userId, string locatie)
        {
            using (var con = Database.start())
            {
                con.Open();
                string query = @"SELECT abonnement_id 
                 FROM abonnementen 
                 WHERE user_id = @userId
                 AND begin_datum <= NOW() 
                 AND eind_datum >= NOW() 
                 AND status = 'Active'
                 ORDER BY eind_datum DESC
                 LIMIT 1"; // neem het meest recente actieve abo

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int abonnementId = Convert.ToInt32(result);

                        // hergebruik je bestaande methode
                        RegistreerIncheck(abonnementId, locatie);
                    }
                    else
                    {
                        throw new Exception("Geen geldig abonnement gevonden voor deze gebruiker.");
                    }
                }
            }
        }
        public static void RegistreerIncheck(int userId, string locatie)
        {
            using (var con = Database.start())
            {
                con.Open();
                string query = @"INSERT INTO incheck (datum, abonnement_id, locatie) 
                         VALUES (NOW(), @abonnementId, @locatie)";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@abonnementId", userId);
                    cmd.Parameters.AddWithValue("@locatie", locatie);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void WijzigAbonnementKlantEnType(int abonnementId, int nieuweUserId)
        {
            using (var con = Database.start())
            {
                con.Open();
                string query = @"UPDATE abonnementen
                         SET user_id = @userId,
                             status = CASE 
                                         WHEN NOW() <= eind_datum THEN 'Actief'
                                         ELSE 'Niet actief'
                                      END
                         WHERE abonnement_id = @abonnementId";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", nieuweUserId);   
                    cmd.Parameters.AddWithValue("@abonnementId", abonnementId);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public class AbonnementRepository
        {
            public List<Abonnement> GetAbonnementen(string klantFilter = "", string typeFilter = "Alle")
            {
                var result = new List<Abonnement>();

                using (var con = Database.start())
                {
                    con.Open();
                    string query = @"SELECT 
                                a.abonnement_id,
                                CONCAT(u.user_firstname, ' ', u.user_lastname) AS Klantnaam,
                                a.begin_datum,
                                a.eind_datum,
                                a.type
                             FROM abonnementen a
                             JOIN users u ON a.user_id = u.user_id
                             WHERE 1=1";

                    if (!string.IsNullOrEmpty(klantFilter))
                        query += " AND (u.user_firstname LIKE @klant OR u.user_lastname LIKE @klant)";

                    if (typeFilter != "Alle")
                        query += " AND a.type = @type";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        if (!string.IsNullOrEmpty(klantFilter))
                            cmd.Parameters.AddWithValue("@klant", "%" + klantFilter + "%");

                        if (typeFilter != "Alle")
                            cmd.Parameters.AddWithValue("@type", typeFilter);

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(new Abonnement
                                {
                                    Id = reader.GetInt32("abonnement_id"),
                                    Klantnaam = reader.GetString("Klantnaam"),
                                    Abonnementstype = reader.GetString("type"),
                                    Startdatum = reader.GetDateTime("begin_datum"),
                                    Einddatum = reader.GetDateTime("eind_datum")
                                });
                            }
                        }
                    }
                }

                return result;
            }
        }
        public class KlantRepository
        {
            public List<Klant> GetKlanten(string filter = "")
            {
                var result = new List<Klant>();
                using (var con = Database.start())
                {
                    con.Open();
                    string query = @"SELECT user_id, user_firstname, user_lastname, user_email 
                             FROM users
                             WHERE (@filter = '' OR user_firstname LIKE @like OR user_lastname LIKE @like)";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@filter", filter);
                        cmd.Parameters.AddWithValue("@like", "%" + filter + "%");

                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                result.Add(new Klant
                                {
                                    Id = reader.GetInt32("user_id"),
                                    Voornaam = reader.GetString("user_firstname"),
                                    Achternaam = reader.GetString("user_lastname"),
                                    Email = reader.GetString("user_email")
                                });
                            }
                        }
                    }
                }
                return result;
            }

            public void UpdateKlant(Klant klant)
            {
                using (var con = Database.start())
                {
                    con.Open();
                    string query = @"UPDATE users 
                             SET user_firstname = @voornaam, 
                                 user_lastname  = @achternaam, 
                                 user_email          = @mail
                             WHERE user_id = @id";

                    using (var cmd = new MySqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@voornaam", klant.Voornaam);
                        cmd.Parameters.AddWithValue("@achternaam", klant.Achternaam);
                        cmd.Parameters.AddWithValue("@mail", klant.Email);
                        cmd.Parameters.AddWithValue("@id", klant.Id);

                        cmd.ExecuteNonQuery();
                    }
                }
            }

        }

    }
}
//ava_d
//Ava#456
