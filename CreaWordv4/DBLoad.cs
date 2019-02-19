using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;
using System.IO;


namespace CreaWordv4
{
    class DBLoad
    {
        public void Load()
        {
            global global = new global();
            //--------------Verbinden und Öffnen der DB
            SQLiteConnection connection = new SQLiteConnection();

            connection.ConnectionString = "Data Source = " + global.dbPfad;
            connection.Open();
            
            //-------------Einlesen der Themen aus der DB
            string commandThema = "SELECT * FROM Thema";
            SQLiteCommand SqlcmdT = new SQLiteCommand();
            SqlcmdT.CommandType = System.Data.CommandType.Text;
            SqlcmdT.CommandText = commandThema;
            SqlcmdT.Connection = connection;
            SQLiteDataAdapter dataAdapterT = new SQLiteDataAdapter(SqlcmdT);
            dataAdapterT.FillSchema(global.datasetThema, SchemaType.Source);
            dataAdapterT.Fill(global.datasetThema);
            
            //--------------Einlesen der Kategorien aus der DB
            string commandKat = "SELECT * FROM Kategorie";
            SQLiteCommand SqlcmdK = new SQLiteCommand();
            SqlcmdK.CommandType = System.Data.CommandType.Text;
            SqlcmdK.CommandText = commandKat;
            SqlcmdK.Connection = connection;
            SQLiteDataAdapter dataAdapterK = new SQLiteDataAdapter(SqlcmdK);
            dataAdapterK.Fill(global.datasetKategorie);
            
            //---------------Einlesen der Wörter aus der DB
            string commandW = "SELECT * FROM Wort";
            SQLiteCommand SqlcmdW = new SQLiteCommand();
            SqlcmdW.CommandType = System.Data.CommandType.Text;
            SqlcmdW.CommandText = commandW;
            SqlcmdW.Connection = connection;
            SQLiteDataAdapter dataAdapterW = new SQLiteDataAdapter(SqlcmdW);
            dataAdapterW.Fill(global.datasetWort);

            //---------------Einlesen der Favoriten aus der DB
            string commandF = "SELECT * FROM Favorit";
            SQLiteCommand SqlcmdF = new SQLiteCommand();
            SqlcmdW.CommandType = System.Data.CommandType.Text;
            SqlcmdW.CommandText = commandW;
            SqlcmdW.Connection = connection;
            SQLiteDataAdapter dataAdapterF = new SQLiteDataAdapter(SqlcmdW);
            dataAdapterW.Fill(global.datasetFavorit);

            //---------------Einlesen der Listen aus der DB
            string commandL = "SELECT * FROM Liste";
            SQLiteCommand SqlcmdL = new SQLiteCommand();
            SqlcmdW.CommandType = System.Data.CommandType.Text;
            SqlcmdW.CommandText = commandW;
            SqlcmdW.Connection = connection;
            SQLiteDataAdapter dataAdapterL = new SQLiteDataAdapter(SqlcmdW);
            dataAdapterW.Fill(global.datasetListe);

            //---------------Schließen der DB-Verbingung
            connection.Close();

        }
    }
}
