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
    class DBConn
    {
        SQLiteConnection connection = new SQLiteConnection();
        DataSet myDataSet = new DataSet();

        public void Conn(String dbfilename)	//dbfilename = @"//DBank.s3db"; //TODO korrekter Pfad
        {
            connection.ConnectionString = "Data Source = " + dbfilename;
            connection.Open();

            string command = "SELECT * FROM dbo.Thema";
            SQLiteCommand Sqlcmd = new SQLiteCommand();
            Sqlcmd.CommandType = System.Data.CommandType.Text;
            Sqlcmd.CommandText = command;
            Sqlcmd.Connection = connection;


            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter(Sqlcmd);
            dataAdapter.Fill(myDataSet);
            connection.Close();



        }



    }
}
