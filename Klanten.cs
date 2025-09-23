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
                 WHERE a.user_id = @userId";


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

    }
}
