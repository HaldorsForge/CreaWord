using CreaWordv4.Models.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaWordv4.Repositories
{
    public class KategorieRepository
    {
        private const string readSqlCommandText = "SELECT * FROM Kategorie;";
        private const string createTableCommandText = "CREATE TABLE [Kategorie](ID int, Auswahl varchar(255));";
        private readonly IDbConnection dbConnection;

        /// <summary>
        /// Create a new repsitory to provide IO to the data source of <see cref="Kategorie"/>.
        /// </summary>
        /// <param name="dbConnection"></param>
        public KategorieRepository(IDbConnection dbConnection)
        {
            if (dbConnection.State != ConnectionState.Open)
            {
                //TODO: Think about to implement IDisposable because we open here an connection but never closed it currently here.
                dbConnection.Open();
            }
            this.dbConnection = dbConnection;
            if (!tableExsists())
            {
                createTable();
            }
        }

        /// <summary>
        /// Get all <see cref="Kategorie"/>s from the datasource.
        /// </summary>
        /// <returns>This returns a enumerable of <see cref="Kategorie"/>s. it will be serialized if you request an item of this enumerable</returns>
        public IEnumerable<Kategorie> GetKategories()
        {
            var command = dbConnection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = readSqlCommandText;
            var reader = command.ExecuteReader();
            // Enumerates over all results form the command and return it
            while (reader.Read())
            {
                yield return new Kategorie
                {
                    ID = reader.GetInt32(0),
                    BEZ = reader.GetString(1)
                };
            }
        }

        private bool tableExsists()
        {
            //dbConnection.Database.

            var command = dbConnection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = readSqlCommandText;
            try
            {
                var results = command.ExecuteReader();
                if (!results.Read())
                {
                    return false;
                }
            }
            // TODO: find out the rigth exception
            catch (Exception ex)
            {
                // TODO: implement this again!!!!
                //throw new Exception("Something went wrong while executing an sql command of an maybe not existing table.", ex);
                return false;
            }
            return true;
        }

        private void createTable()
        {
            var command = dbConnection.CreateCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = createTableCommandText;
            command.ExecuteNonQuery();
        }

    }
}
