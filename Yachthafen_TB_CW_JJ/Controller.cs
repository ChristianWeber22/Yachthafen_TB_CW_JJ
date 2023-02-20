using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Yachthafen_TB_CW_JJ
{
    class Controller
    {

        public DataTable showAllLiegeplatz()
        {
            MySqlConnection myConn = new MySqlConnection("SERVER=localhost; DATABASE=yachthafen;UID=root;PASSWORD=");
            string query = "SELECT * FROM liegeplatz";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = cmd;
            DataTable dTable = new DataTable();
            mySqlDataAdapter.Fill(dTable);

            return dTable;

        }

        public void UpdateAllLiegeplatz(DataTable ds)
        {
            MySqlConnection myConn = new MySqlConnection("SERVER=localhost; DATABASE=yachthafen;UID=root;PASSWORD=");
            string query = "SELECT * FROM liegeplatz";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, myConn);
            MySqlCommandBuilder cmb = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.Update(ds);

        }

        public DataTable showAllLiegeplatzWhereFrei()
        {
            MySqlConnection myConn = new MySqlConnection("SERVER=localhost; DATABASE=yachthafen;UID=root;PASSWORD=");
            string query = "SELECT * FROM liegeplatz WHERE status = 'FREI'";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = cmd;
            DataTable dTable = new DataTable();
            mySqlDataAdapter.Fill(dTable);

            return dTable;

        }

 

        public void UpdateAllKunden(DataTable data)
        {
            MySqlConnection myConn = new MySqlConnection("SERVER=localhost; DATABASE=yachthafen;UID=root;PASSWORD=");
            string query = "SELECT * FROM kunde";
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter(query, myConn);
            MySqlCommandBuilder cmb = new MySqlCommandBuilder(mySqlDataAdapter);

            mySqlDataAdapter.Update(data);
        }

        public DataTable showAllKunden()
        {
            MySqlConnection myConn = new MySqlConnection("SERVER=localhost; DATABASE=yachthafen;UID=root;PASSWORD=");
            string query = "SELECT * FROM kunde";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = cmd;
            DataTable dTable = new DataTable();
            mySqlDataAdapter.Fill(dTable);

            return dTable;

        }

        public DataTable getAllBuchungenForList()
        {
            MySqlConnection myConn = new MySqlConnection("SERVER=localhost; DATABASE=yachthafen;UID=root;PASSWORD=");
            string query = "SELECT * FROM buchung";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = cmd;
            DataTable dTable = new DataTable();
            mySqlDataAdapter.Fill(dTable);

            return dTable;
        }





        public DataTable showAllBuchungen()
        {
            MySqlConnection myConn = new MySqlConnection("SERVER=localhost; DATABASE=yachthafen;UID=root;PASSWORD=");
            string query = "SELECT buchung.id, buchung.startdatum, buchung.enddatum, buchung.preis, kunde.name, liegeplatz.bezeichnung FROM buchung INNER JOIN kunde ON buchung.idKunde = kunde.id INNER JOIN liegeplatz ON buchung.idLiegeplatz = liegeplatz.id;";
            MySqlCommand cmd = new MySqlCommand(query, myConn);
            MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = cmd;
            DataTable dTable = new DataTable();
            mySqlDataAdapter.Fill(dTable);

            return dTable;
        }

        public void deleteSelectedBuchung(int idBuchung)
        {
            MySqlConnection myConn = new MySqlConnection("SERVER=localhost; DATABASE=yachthafen;UID=root;PASSWORD=");
            string cmdText = "DELETE FROM buchung WHERE id = @idbuchung";
            MySqlCommand cmd = new MySqlCommand(cmdText, myConn);
            cmd.Parameters.AddWithValue("@idbuchung", idBuchung);

            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

        }



        public bool addNewBuchung(int kundeId, int liegeplatzId, String firstDate, String endDate, double price)
        {

            try
            {
                MySqlConnection myConn = new MySqlConnection("SERVER=localhost; DATABASE=yachthafen;UID=root;PASSWORD=");

                string cmdText = "INSERT INTO buchung(idKunde, idLiegeplatz, startdatum, enddatum, preis) VALUES (@idKunde, @idLiegeplatz, @startdatum, @enddatum, @preis)";
                MySqlCommand cmd = new MySqlCommand(cmdText, myConn);
                cmd.Parameters.AddWithValue("@idKunde", kundeId);
                cmd.Parameters.AddWithValue("@idLiegeplatz", liegeplatzId);
                cmd.Parameters.AddWithValue("@startdatum", firstDate);

                cmd.Parameters.AddWithValue("@enddatum", endDate);

                cmd.Parameters.AddWithValue("@preis", price);
                myConn.Open();
                cmd.ExecuteNonQuery();
                myConn.Close();

                return true;
            }
            catch (Exception)
            {

                return false;
            }
         
        }


    }
}