using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaPalace.classes
{
    class Abonnement
    {
        public int Id;
        public DateTime BeginDatum;
        public DateTime EindDatum;
        public string Type;
        public string Status;

        public override string ToString()
        {
            return $"Abonnement #{Id} | Type: {Type} | Status: {Status} | Begin: {BeginDatum.ToShortDateString()} | Eind: {EindDatum.ToShortDateString()}";
        }

        public static List<Abonnement> GetAll()
        {
            List<Abonnement> abonnementen = new List<Abonnement>();

            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT * FROM abonnementen;", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                Abonnement ab = new Abonnement
                {
                    Id = Convert.ToInt32(reader["abonnement_id"]),
                    BeginDatum = Convert.ToDateTime(reader["begin_datum"]),
                    EindDatum = Convert.ToDateTime(reader["eind_datum"]),
                    Type = Convert.ToString(reader["type"]),
                    Status = Convert.ToString(reader["status"])
                };
                abonnementen.Add(ab);
            }

            con.Close();
            return abonnementen;
        }

        public static int AddToDatabase(Abonnement ab)
        {
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(@"
        INSERT INTO abonnementen 
        (begin_datum, eind_datum, type, status)
        VALUES (@begin, @eind, @type, @status);", con);

            cmd.Parameters.AddWithValue("@begin", ab.BeginDatum);
            cmd.Parameters.AddWithValue("@eind", ab.EindDatum);
            cmd.Parameters.AddWithValue("@type", ab.Type);
            cmd.Parameters.AddWithValue("@status", ab.Status);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static int UpdateDatabase(Abonnement ab)
        {
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand(@"
        UPDATE abonnementen SET
            begin_datum = @begin,
            eind_datum = @eind,
            type = @type,
            status = @status
        WHERE abonnement_id = @id;", con);

            cmd.Parameters.AddWithValue("@begin", ab.BeginDatum);
            cmd.Parameters.AddWithValue("@eind", ab.EindDatum);
            cmd.Parameters.AddWithValue("@type", ab.Type);
            cmd.Parameters.AddWithValue("@status", ab.Status);
            cmd.Parameters.AddWithValue("@id", ab.Id);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static int DeleteFromDatabase(Abonnement ab)
        {
            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand("DELETE FROM abonnementen WHERE abonnement_id = @id;", con);
            cmd.Parameters.AddWithValue("@id", ab.Id);

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static List<string> GetTypes()
        {
            List<string> types = new List<string>();

            MySqlConnection con = Database.start();
            con.Open();

            MySqlCommand cmd = new MySqlCommand("SELECT DISTINCT type FROM abonnementen;", con);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                types.Add(Convert.ToString(reader["type"]));
            }

            con.Close();
            return types;
        }

        public static BindingSource ZoekTypeAndDate(string type, string geldigheid)
        {
            MySqlConnection con = Database.start();
            con.Open();

            MySqlDataAdapter MyDA = new MySqlDataAdapter();

            string sql = @"
    SELECT 
        abonnement_id,
        begin_datum,
        eind_datum,
        type,
        status
    FROM 
        abonnementen
    WHERE 1 = 1
    ";

            if (type != "Alle")
            {
                sql += " AND type LIKE @type";
            }

            DateTime nu = DateTime.Now;
            int maanden = 0;

            if (geldigheid != "Alle")
            {
                if (geldigheid == "Binnen 1 maand") maanden = 1;
                else if (geldigheid == "Binnen 2 maanden") maanden = 2;
                else if (geldigheid == "Binnen 3 maanden") maanden = 3;
                else if (geldigheid == "Binnen 4 maanden") maanden = 4;

                DateTime eindDatum = nu.AddMonths(maanden);
                sql += " AND eind_datum IS NOT NULL AND eind_datum >= @nu AND eind_datum <= @eindDatum";
            }

            MyDA.SelectCommand = new MySqlCommand(sql, con);

            if (type != "Alle")
            {
                MyDA.SelectCommand.Parameters.AddWithValue("@type", "%" + type + "%");
            }

            if (geldigheid != "Alle")
            {
                DateTime eindDatum = nu.AddMonths(maanden);
                MyDA.SelectCommand.Parameters.AddWithValue("@nu", nu.ToString("yyyy-MM-dd"));
                MyDA.SelectCommand.Parameters.AddWithValue("@eindDatum", eindDatum.ToString("yyyy-MM-dd"));
            }

            DataTable table = new DataTable();
            MyDA.Fill(table);

            BindingSource bSource = new BindingSource();
            bSource.DataSource = table;

            con.Close();
            return bSource;
        }


    }
}
