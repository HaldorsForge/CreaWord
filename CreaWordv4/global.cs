using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data;

namespace CreaWordv4
{
    class global
    {
        //Allgemein
        public bool save = true;  //globale Variable zum abgleichen des Seichern-Status
        public static int intGlobal = 0;
        public static string stringGlobal = "";

        //Datenbank
        public string dbPfad = @"\DBank.s3db";
        public DataSet datasetThema = new DataSet();
        //public static DataSet datasetThema { get; set; }
        public DataSet datasetKategorie = new DataSet();
        public DataSet datasetWort = new DataSet();
        public DataSet datasetFavorit = new DataSet();
        public DataSet datasetListe = new DataSet();
    }
}