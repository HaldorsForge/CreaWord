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
using System.IO;

namespace CreaWordv4
{
    public partial class MainForm : Form { 
    
        public MainForm()
        {
            InitializeComponent();
        }

        createTable tables;
        //DBLoad dbLoad;
        //global global;

        Timer t = new Timer();

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
            DBLoad dbLoad = new DBLoad();
            dbLoad.Load();  //Einlesen der DB-Inhalte in die Datasets
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
            
            addObjects add = new addObjects();
            add.wuerfelnSet(int.Parse(cbWortanzahl.Text), flowpanelTheKat);

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            flowpanelOptButtons.Controls.Clear();
            flowpanelTheKat.Controls.Clear();
            flowpanelWort.Controls.Clear();
            cbWortanzahl.SelectedIndex = 0;
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
            global global = new global();
            //--------------Einlesen der Themen aus der DB
            listThema.Items.Clear();
            int tablesCounterT = global.datasetThema.Tables.Count;
            try
            {
                tablesCounterT = global.datasetThema.Tables[global.datasetThema.Tables[0].TableName].Columns.Count;
            }
            catch (Exception ex)
            {
                string fehler = ex.ToString();
            }

            for (int i = 0; i < tablesCounterT; i++)
            {
                ListViewItem lviThema = new ListViewItem(global.datasetThema.Tables[global.datasetThema.Tables[0].TableName].Rows[i]["ID"].ToString());
                lviThema.SubItems.Add((String)global.datasetThema.Tables[global.datasetThema.Tables[0].TableName].Rows[i]["BEZ"]);
                listThema.Items.Add(lviThema);
            }

            if (listThema.Items.Count > 0)
            {
                listThema.Items[0].Focused = true;
                listThema.Items[0].Selected = true;
                listThema.Select();
            }
            else
            {
                int count = listThema.Items.Count;
            }
        }

        private void listThema_SelectedIndexChanged(object sender, EventArgs e)
        {
            global global = new global();
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

                int tablesCounterK = global.datasetKategorie.Tables[global.datasetKategorie.Tables[0].TableName].Columns.Count;
                for (int i = 0; i < tablesCounterK; i++)
                {
                    if (global.datasetKategorie.Tables[global.datasetKategorie.Tables[0].TableName].Rows[i]["Thema"].ToString() == siItem)
                    {
                        ListViewItem lviKategorie = new ListViewItem(global.datasetKategorie.Tables[global.datasetKategorie.Tables[0].TableName].Rows[i]["ID"].ToString());
                        lviKategorie.SubItems.Add((String)global.datasetKategorie.Tables[global.datasetKategorie.Tables[0].TableName].Rows[i]["BEZ"]);
                        listKategorie.Items.Add(lviKategorie);
                    }
                }
                int katCount = listKategorie.Items.Count;
                if (katCount > 0)
                {
                    listThema.Items[0].Selected = true;    //test
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
            global global = new global();
            listWort.Items.Clear();
            ListView.SelectedListViewItemCollection testColl2 = new ListView.SelectedListViewItemCollection(listKategorie);
            
            testColl2 = listKategorie.SelectedItems;
            if (testColl2.Count > 0)
            {
                string siItem2 = testColl2[0]/*.SubItems[0]*/.Text;

                int tablesCounterW = global.datasetWort.Tables[global.datasetWort.Tables[0].TableName].Columns.Count;
                for (int i = 0; i < tablesCounterW; i++)
                {
                    if (global.datasetWort.Tables[global.datasetWort.Tables[0].TableName].Rows[i]["Kategorie"].ToString() == siItem2)
                    {
                        ListViewItem lviWort = new ListViewItem(global.datasetWort.Tables[global.datasetWort.Tables[0].TableName].Rows[i]["ID"].ToString());
                        lviWort.SubItems.Add((String)global.datasetWort.Tables[global.datasetWort.Tables[0].TableName].Rows[i]["BEZ"]);
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
        
        private void listThema_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)   //wird auch von listKategorie und listWort verwendet
        {
            e.Cancel = true;
            e.NewWidth = listThema.Columns[e.ColumnIndex].Width;
        }
        
        private void menuStrip_Layout(object sender, LayoutEventArgs e)
        {
            t.Interval = 1000;
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();

            DateTime d = DateTime.Now;
            toolStripTextBoxDatum.Text = d.Date.ToShortDateString().ToString(/*"dd/MM/yyyy"*/);
            
        }
        private void t_Tick(object sender, EventArgs e )
        {
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            string time = "";

            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }
            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }
            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }
            toolStripTextBoxUhr.Text = time;
        }

//---------Menü Bearbeiten---------------------------------------------------------------
        private void menuitemBeaWort_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabWort);
        }

        private void menuitemBeaFavo_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabFavo);
        }

        private void menuitemBeaListen_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabListen);
        }
    }
}
