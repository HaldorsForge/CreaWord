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
using CreaWordv4.Repositories;

namespace CreaWordv4
{
    public partial class MainForm : Form
    {

        private readonly IDbConnection dbConnection;
        public MainForm()
        {
            // Do DB initialisation first to avoid the user can click buttons befor.
            dbConnection = new SQLiteConnection();
            dbConnection.ConnectionString = "Data Source = " + @".\DBank.s3db";
            dbConnection.Open();
            InitializeComponent();
        }

        //createTable tables;
        //DBLoad dbLoad;
        //global global;

        Timer t = new Timer();

        private void MainForm_Load(object sender, EventArgs e)
        {
            //tables.Thema();
            //tables.Kategorie();
            //tables.Wort();
            //tables.Favorit();
            //tables.Liste();



        }

        private void tabWuerfeln_Layout(object sender, LayoutEventArgs e)
        {
            //DBLoad dbLoad = new DBLoad();
            //dbLoad.Load();  //Einlesen der DB-Inhalte in die Datasets
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

            cbWortanzahl.Select(0, 1);

            string dir = Directory.GetCurrentDirectory();
            textBox1.Text = dir;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int anzahl = new int();
            anzahl = int.Parse(cbWortanzahl.Text);

            addObjects add = new addObjects();
            add.wuerfelnWort(anzahl, flowpanelWort);
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
            var repository = new ThemaRepository(dbConnection);
            listThema.Items.Clear();
            foreach (var thema in repository.GetThemas())
            {
                var lviThema = new ListViewItem(thema.ID.ToString());
                lviThema.SubItems.Add(thema.BEZ);
                listThema.Items.Add(lviThema);
            }
            // Set the focus in the table on the first element
            if (listThema.Items.Count > 0)
            {
                listThema.Items[0].Focused = true;
                listThema.Items[0].Selected = true;
                listThema.Select();
            }
        }

        private void listThema_SelectedIndexChanged(object sender, EventArgs e)
        {
            global global = new global();
            //Rund 1: Thema = 1; Kategorie = ok / Runde 2: Thema = 2; Kategorie = ko / Runde 3: Thema = ko --> häääää???????????????????? --> TODO!!!!!!!!!            
            listKategorie.Items.Clear();

            //string dsKat = datasetKategorie.Tables[datasetKategorie.Tables[0].TableName].Rows[0]["Thema"].ToString();

            // read data from the datasource
            var repository = new KategorieRepository(dbConnection);
            foreach (var kategorie in repository.GetKategories())
            {
                var lviKategorie = new ListViewItem(kategorie.ID.ToString());
                lviKategorie.SubItems.Add(kategorie.BEZ);
                listKategorie.Items.Add(lviKategorie);
            }

            // select the first item in the table
            if (listKategorie.Items.Count > 0)
            {
                listKategorie.Items[0].Selected = true;    //test
                listKategorie.Items[0].Focused = true;
                listKategorie.Items[0].Selected = true;
                listKategorie.Select();
            }

            // TODO: I remove here some logic. I don't know what it was doing. Hopefully it was not important 🤞          
        }

        private void listKategorie_SelectedIndexChanged(object sender, EventArgs e)
        {
            global global = new global();
            listWort.Items.Clear();
            var repository = new WortRepository(dbConnection);
            foreach (var wort in repository.GetWorts())
            {
                var lviWort = new ListViewItem(wort.ID.ToString());
                lviWort.SubItems.Add(wort.BEZ);
                listWort.Items.Add(lviWort);
            }

            if (listWort.Items.Count > 0)
            {
                listWort.Items[0].Selected = true;    //test
                listWort.Items[0].Focused = true;
                listWort.Items[0].Selected = true;
                listWort.Select();
            }

            // TODO: I remove here some logic. I don't know what it was doing. Hopefully it was not important 🤞          
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
        private void t_Tick(object sender, EventArgs e)
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

        public void Dispose()
        {
            dbConnection.Close();
            dbConnection.Dispose();
        }
    }
}
