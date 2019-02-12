using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CreaWordv4
{
    class createTable
    {
        DataTable table = new DataTable();
        DataSet dataSet = new DataSet();

        public void Thema()
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Bezeichnung", typeof(String));
        }
        public void Kategorie()
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Bezeichnung", typeof(String));
        }
        public void Wort()
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Bezeichnung", typeof(String));
        }
        public void Favorit()
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Wörter", typeof(String));
        }
        public void Liste()
        {
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Titel", typeof(String));
            table.Columns.Add("Wörter", typeof(String));
        }
    }
}
