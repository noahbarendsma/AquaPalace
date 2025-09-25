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
    internal class Klanten
    {
        public int Id { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }

        public string Display => $"{Voornaam} {Achternaam}";

        public static List<Klanten> GetKlanten()
        {
            var klanten = new List<Klanten>();
            using (var con = Database.start())
            {
                con.Open();
                var cmd = new MySqlCommand("SELECT user_id, user_firstname, user_lastname FROM users", con);
                var reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    klanten.Add(new Klanten
                    {
                        Id = Convert.ToInt32(reader["user_id"]),
                        Voornaam = reader["user_firstname"].ToString(),
                        Achternaam = reader["user_lastname"].ToString()
                    });
                }
            }
            return klanten;
        }
        public static void LoadAbonnementen(int userId, DataGridView dgv)
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
                 JOIN users u ON a.user_id = u.user_id
                 WHERE a.user_id = @userId
                 AND a.status = 'Active'";


                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgv.DataSource = dt;
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
        public static void VerlengAbonnement(int abonnementId, DateTime nieuweEindDatum)
        {
            using (var con = Database.start())
            {
                con.Open();
                string query = @"UPDATE abonnementen 
                         SET eind_datum = @nieuweEindDatum 
                         WHERE abonnement_id = @abonnementId";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@nieuweEindDatum", nieuweEindDatum);
                    cmd.Parameters.AddWithValue("@abonnementId", abonnementId);

                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static List<Abonnementen> GetAbonnementenByUserId(int userId)
        {
            var abonnementen = new List<Abonnementen>();

            using (var con = Database.start())
            {
                con.Open();
                string query = @"SELECT abonnement_id, type, eind_datum 
                         FROM abonnementen 
                         WHERE user_id = @userId";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            abonnementen.Add(new Abonnementen
                            {
                                Id = Convert.ToInt32(reader["abonnement_id"]),
                                Type = reader["type"].ToString(),
                                EindDatum = Convert.ToDateTime(reader["eind_datum"])
                            });
                        }
                    }
                }
            }

            return abonnementen;
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
        public static bool AbonnementIsGeldig(int abonnementId)
        {
            using (var con = Database.start())
            {
                con.Open();
                string query = @"SELECT COUNT(*) 
                         FROM abonnementen 
                         WHERE abonnement_id = @abonnementId
                         AND begin_datum <= NOW() 
                         AND eind_datum >= NOW() 
                         AND status = 'Active'";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@abonnementId", abonnementId);
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
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
        public static DataTable GetIncheckGeschiedenis(int userId)
        {
            using (var con = Database.start())
            {
                con.Open();
                string query = @"
            SELECT i.incheck_id AS 'Incheck ID',
                   i.datum AS 'Datum',
                   i.locatie AS 'Locatie',
                   a.type AS 'Abonnement Type'
            FROM incheck i
            JOIN abonnementen a ON i.abonnement_id = a.abonnement_id
            WHERE a.user_id = @userId
            ORDER BY i.datum DESC";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
        public static void GetAbonnementGeschiedenis(int userId, DataGridView dgv)
        {
            using (var con = Database.start())
            {
                con.Open();
                string query = @"
            SELECT abonnement_id AS 'Abonnement ID',
                   type AS 'Type',
                   begin_datum AS 'Begin Datum',
                   eind_datum AS 'Eind Datum',
                   status AS 'Status'
            FROM abonnementen
            WHERE user_id = @userId
            ORDER BY begin_datum DESC"; // voeg sortering toe
                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@userId", userId);
                    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dgv.DataSource = dt;
                }
            }
        }
    }
}
