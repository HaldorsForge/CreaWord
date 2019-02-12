using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
//using System.Data;
using System.IO;

namespace CreaWordv4
{
    public partial class MainForm : Form { 
    
        public MainForm()
        {
            InitializeComponent();
            
        }
        createTable tables = new createTable();

        DataSet datasetThema = new DataSet();
        DataSet datasetKategorie = new DataSet();
        DataSet datasetWort = new DataSet();

        


        private void MainForm_Load(object sender, EventArgs e)
        {
            tables.Thema();
            tables.Kategorie();
            tables.Wort();
            tables.Favorit();
            tables.Liste();
            

        }

        private void tabWuerfeln_Layout(object sender, LayoutEventArgs e)
        {
            DateTime d = DateTime.Now; // frühling(3-5), sommer(6-8), herbst(9-11), winter(12-2)
            int month = d.Month;
            if (month >= 3 && month <= 5)
            {
                tabWuerfeln.BackgroundImage = CreaWordv4.Properties.Resources.Frühling;
            }
            else if (month >= 6 && month <= 8)
            {
                tabWuerfeln.BackgroundImage = CreaWordv4.Properties.Resources.Sommer;
            }
            else if (month >= 9 && month <= 11)
            {
                tabWuerfeln.BackgroundImage = CreaWordv4.Properties.Resources.Herbst;
            }
            else
            {
                tabWuerfeln.BackgroundImage = CreaWordv4.Properties.Resources.Winter;
                
            }

            cbWortanzahl.Select(0,1);

            string dir = Directory.GetCurrentDirectory();
            textBox1.Text = dir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anzahl = new int();
            anzahl = int.Parse(cbWortanzahl.Text);

            addObjects add = new addObjects();
            add.wuerfelnWort(anzahl,flowpanelWort);
            add.wuerfelnOpts(flowpanelOptButtons);
            
        }

        private void cbWortanzahl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int anzahl = new int();
            anzahl = int.Parse(cbWortanzahl.Text);
            addObjects add = new addObjects();
            add.wuerfelnSet(anzahl, flowpanelTheKat);

            //connection.ConnectionString = "Data Source = " + /*dir + */dbfilename;
            //connection.Open();

            ////--------------Einlesen der Themen aus der DB
            //listThema.Items.Clear();

            ////DataSet datasetThema = new DataSet();
            //string commandThema = "SELECT * FROM Thema";
            //SQLiteCommand SqlcmdT = new SQLiteCommand();
            //SqlcmdT.CommandType = System.Data.CommandType.Text;
            //SqlcmdT.CommandText = commandThema;
            //SqlcmdT.Connection = connection;
            //SQLiteDataAdapter dataAdapterCbT = new SQLiteDataAdapter(SqlcmdT);
            //dataAdapterCbT.Fill(datasetThema);
            
            //for (int i = 0; i < anzahl; i++)
            //{
                
            //}

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            flowpanelOptButtons.Controls.Clear();
            flowpanelTheKat.Controls.Clear();
            flowpanelWort.Controls.Clear();
            cbWortanzahl.SelectedIndex = 0; //Selektion leeren
        }

        private void tabWort_Layout(object sender, LayoutEventArgs e)
        {
            DateTime d = DateTime.Now; // frühling(3-5), sommer(6-8), herbst(9-11), winter(12-2)
            int month = d.Month;
            if (month >= 3 && month <= 5)
            {
                tabWort.BackgroundImage = CreaWordv4.Properties.Resources.Frühling;
            }
            else if (month >= 6 && month <= 8)
            {
                tabWort.BackgroundImage = CreaWordv4.Properties.Resources.Sommer;
            }
            else if (month >= 9 && month <= 11)
            {
                tabWort.BackgroundImage = CreaWordv4.Properties.Resources.Herbst;
            }
            else
            {
                tabWort.BackgroundImage = CreaWordv4.Properties.Resources.Winter;

            }
        }

        private void tabFavo_Layout(object sender, LayoutEventArgs e)
        {
            DateTime d = DateTime.Now; // frühling(3-5), sommer(6-8), herbst(9-11), winter(12-2)
            int month = d.Month;
            if (month >= 3 && month <= 5)
            {
                tabFavo.BackgroundImage = CreaWordv4.Properties.Resources.Frühling;
            }
            else if (month >= 6 && month <= 8)
            {
                tabFavo.BackgroundImage = CreaWordv4.Properties.Resources.Sommer;
            }
            else if (month >= 9 && month <= 11)
            {
                tabFavo.BackgroundImage = CreaWordv4.Properties.Resources.Herbst;
            }
            else
            {
                tabFavo.BackgroundImage = CreaWordv4.Properties.Resources.Winter;

            }
        }

        private void tabListen_Layout(object sender, LayoutEventArgs e)
        {
            DateTime d = DateTime.Now; // frühling(3-5), sommer(6-8), herbst(9-11), winter(12-2)
            int month = d.Month;
            if (month >= 3 && month <= 5)
            {
                tabListen.BackgroundImage = CreaWordv4.Properties.Resources.Frühling;
            }
            else if (month >= 6 && month <= 8)
            {
                tabListen.BackgroundImage = CreaWordv4.Properties.Resources.Sommer;
            }
            else if (month >= 9 && month <= 11)
            {
                tabListen.BackgroundImage = CreaWordv4.Properties.Resources.Herbst;
            }
            else
            {
                tabListen.BackgroundImage = CreaWordv4.Properties.Resources.Winter;

            }
        }

        private void tabWort_Enter(object sender, EventArgs e)  
        {
            //--------------Verbinden und Öffnen der DB
            //string dir = Directory.GetCurrentDirectory();   //pfadstandpunkt liegt im debug-ordner??

            String dbfilename =  @"\DBank.s3db"; //TODO korrekter Pfad
            SQLiteConnection connection = new SQLiteConnection();

            connection.ConnectionString = "Data Source = " + /*dir + */dbfilename;
            connection.Open();

            //--------------Einlesen der Themen aus der DB
            listThema.Items.Clear();

            //DataSet datasetThema = new DataSet();
            string commandThema = "SELECT * FROM Thema";
            SQLiteCommand SqlcmdT = new SQLiteCommand();
            SqlcmdT.CommandType = System.Data.CommandType.Text;
            SqlcmdT.CommandText = commandThema;
            SqlcmdT.Connection = connection;
            SQLiteDataAdapter dataAdapterT = new SQLiteDataAdapter(SqlcmdT);
            dataAdapterT.Fill(datasetThema);
            int tablesCounterT = datasetThema.Tables[datasetThema.Tables[0].TableName].Columns.Count;
            for (int i = 0; i < tablesCounterT; i++)
            {
                ListViewItem lviThema = new ListViewItem(datasetThema.Tables[datasetThema.Tables[0].TableName].Rows[i]["ID"].ToString());
                lviThema.SubItems.Add((String)datasetThema.Tables[datasetThema.Tables[0].TableName].Rows[i]["BEZ"]);
                listThema.Items.Add(lviThema);
            }
            //listThema.Items[0].Focused = true;
            listThema.Items[0].Selected = true;
            listThema.Select();


            //--------------Einlesen der Kategorien aus der DB
            //DataSet datasetKategorie = new DataSet();
            string commandKat = "SELECT * FROM Kategorie";
            SQLiteCommand SqlcmdK = new SQLiteCommand();
            SqlcmdK.CommandType = System.Data.CommandType.Text;
            SqlcmdK.CommandText = commandKat;
            SqlcmdK.Connection = connection;
            SQLiteDataAdapter dataAdapterK = new SQLiteDataAdapter(SqlcmdK);
            dataAdapterK.Fill(datasetKategorie);


            //---------------Einlesen der Wörter aus der DB
            //DataSet datasetWort = new DataSet();
            string commandW = "SELECT * FROM Wort";
            SQLiteCommand SqlcmdW = new SQLiteCommand();
            SqlcmdW.CommandType = System.Data.CommandType.Text;
            SqlcmdW.CommandText = commandW;
            SqlcmdW.Connection = connection;
            SQLiteDataAdapter dataAdapterW = new SQLiteDataAdapter(SqlcmdW);
            dataAdapterW.Fill(datasetWort);
            
            

            //---------------Schließen der DB-Verbingung
            connection.Close();
        }

        private void listThema_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Rund 1: Thema = 1; Kategorie = ok / Runde 2: Thema = 2; Kategorie = ko / Runde 3: Thema = ko --> häääää???????????????????? --> TODO!!!!!!!!!

            listKategorie.Items.Clear();
            ListView.SelectedListViewItemCollection testColl = new ListView.SelectedListViewItemCollection(listThema);

            //string dsKat = datasetKategorie.Tables[datasetKategorie.Tables[0].TableName].Rows[0]["Thema"].ToString();

            testColl = listThema.SelectedItems;
            if (testColl.Count == 0)    //test
            {
                listThema.Items[1].Selected = true;
                listThema.Select();
            }
            if (testColl.Count > 0)
            {
                testColl = listThema.SelectedItems;
                string siItem = testColl[0]/*.SubItems[0]*/.Text;

                int tablesCounterK = datasetKategorie.Tables[datasetKategorie.Tables[0].TableName].Columns.Count;
                for (int i = 0; i < tablesCounterK; i++)
                {
                    if (datasetKategorie.Tables[datasetKategorie.Tables[0].TableName].Rows[i]["Thema"].ToString() == siItem)
                    {
                        ListViewItem lviKategorie = new ListViewItem(datasetKategorie.Tables[datasetKategorie.Tables[0].TableName].Rows[i]["ID"].ToString());
                        lviKategorie.SubItems.Add((String)datasetKategorie.Tables[datasetKategorie.Tables[0].TableName].Rows[i]["BEZ"]);
                        listKategorie.Items.Add(lviKategorie);
                    }
                }
                int katCount = listKategorie.Items.Count;
                if (katCount > 0)
                {
                    listThema.Items[siItem].Selected = true;    //test
                    listKategorie.Items[0].Focused = true;
                    listKategorie.Items[0].Selected = true;
                    listKategorie.Select();
                }
            }
            else
            {
                ListViewItem lviKategorie = new ListViewItem("!!!");
                lviKategorie.SubItems.Add("SelectedListViewItemCollection = null!!");
                listKategorie.Items.Add(lviKategorie);
            }

        }

        private void listKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            listWort.Items.Clear();
            ListView.SelectedListViewItemCollection testColl2 = new ListView.SelectedListViewItemCollection(listKategorie);
            
            testColl2 = listKategorie.SelectedItems;
            if (testColl2.Count > 0)
            {
                string siItem2 = testColl2[0]/*.SubItems[0]*/.Text;

                int tablesCounterW = datasetWort.Tables[datasetWort.Tables[0].TableName].Columns.Count;
                for (int i = 0; i < tablesCounterW; i++)
                {
                    if (datasetWort.Tables[datasetWort.Tables[0].TableName].Rows[i]["Kategorie"].ToString() == siItem2)
                    {
                        ListViewItem lviWort = new ListViewItem(datasetWort.Tables[datasetWort.Tables[0].TableName].Rows[i]["ID"].ToString());
                        lviWort.SubItems.Add((String)datasetWort.Tables[datasetWort.Tables[0].TableName].Rows[i]["BEZ"]);
                        listWort.Items.Add(lviWort);
                    }
                }
                //listWort.Items[0].Focused = true;
                listWort.Items[0].Selected = true;
                listWort.Select();
            }
            else
            {
                ListViewItem lviWort = new ListViewItem("!!!");
                lviWort.SubItems.Add("SelectedListViewItemCollection = null!!");
                listWort.Items.Add(lviWort);
            }

        }

        private void listThema_ItemActivate(object sender, EventArgs e)
        {
            
        }

        private void listThema_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)   //wird auch von listKategorie und listWort verwendet
        {
            e.Cancel = true;
            e.NewWidth = listThema.Columns[e.ColumnIndex].Width;
        }

        private void menuitemBeaWort_Click(object sender, EventArgs e)
        {
            this.tabWort.Show();    //TODO tabWort zeigen
        }
    }
}
