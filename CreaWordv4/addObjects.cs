using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreaWordv4
{
    class addObjects    //Klasse zum erzeugen Objekten wärend der Laufzeit, wird für den "Würfeln"-Tab benötigt
    {
        //Die Methode wuerfelnSet() erzeugt unteranderem Comboboxen, die die Themen und deren Kategorien aus der DB auflisten damit der User den Wörterpool festlegen kann
        //wuerfelnSet() benötigt die Anzahl der zu würfelnden Wörter und das FlowLayoutPanel, in das die Objekte geladen werden sollen
        public void wuerfelnSet(int anzahl, FlowLayoutPanel panel)  //TODO mit DB-Daten füllen
        {
            //das zugewiesene FlowLayoutPanel wird vorab erstmal gecleart
            panel.Controls.Clear();

            //die Menge der Objektpackete richtet sich nach der gewünschten Wortanzahl
            //jedes Packet besteht aus 1 Textbox, 1 Comboboxen pro Thema und Kategorie und einem FlowLayoutPanel, das diese beinhaltet
            for(int i = 1; i <= anzahl; i++)
            {
                //Thema
                ComboBox thema = new ComboBox();    //TODO mit DB-Daten füllen
                thema.Name = "cbThema" + i;
                thema.DropDownStyle = ComboBoxStyle.DropDownList;

                TextBox themaNum = new TextBox();
                themaNum.Name = "txtboxThemaNum" + i;
                themaNum.Width = thema.Width;
                themaNum.Text = i + ". Thema";
                themaNum.TextAlign = HorizontalAlignment.Center;

                //Kategorie
                TextBox katNum = new TextBox();
                katNum.Name = "txtboxKatNum" + i;
                katNum.Width = thema.Width;
                katNum.Text = i + ". Kategorie";
                katNum.TextAlign = HorizontalAlignment.Center;

                ComboBox kategorie = new ComboBox();    //TODO mit DB-Daten füllen
                kategorie.Name = "cbKat" + i;
                kategorie.DropDownStyle = ComboBoxStyle.DropDownList;

                //beinhaltet Thema und Kategorie
                FlowLayoutPanel flow = new FlowLayoutPanel();
                flow.FlowDirection = FlowDirection.TopDown;
                flow.Name = "flowpanelThema" + i;
                flow.Width = thema.Width + 5;
                flow.Height = 110;
                flow.Controls.Add(themaNum);
                flow.Controls.Add(thema);
                flow.Controls.Add(katNum);
                flow.Controls.Add(kategorie);
                
                panel.Controls.Add(flow);
            }
        }

        //nach der Themen- und Kategorienauswahl wird wuerfelnWort() wird ein Packet aus 2 Textboxen und 1 FlowLayoutPanel pro Wort erzeugt
        //die Textbox wortBez beinhaltet das gewürfelte Wort
        public void wuerfelnWort(int anzahl, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            for (int i = 1; i <= anzahl; i++)
            {
                TextBox wortBez = new TextBox();
                wortBez.Name = "txtboxWortBez" + i;
                wortBez.Text = "Wort " + i;  //gewürfeltes wort
                wortBez.TextAlign = HorizontalAlignment.Center;
                wortBez.Width = 121;

                TextBox wortNummer = new TextBox();
                wortNummer.Name = "txtboxWortNum" + i;
                wortNummer.Text = i + ". Wort";
                wortNummer.TextAlign = HorizontalAlignment.Center;
                wortNummer.Width = wortBez.Width;
                
                FlowLayoutPanel flow = new FlowLayoutPanel();
                flow.FlowDirection = FlowDirection.TopDown;
                flow.Name = "flowpanelwort" + i;
                flow.Width = wortBez.Width + 5;
                flow.Height = 60;
                flow.Controls.Add(wortNummer);
                flow.Controls.Add(wortBez);

                panel.Controls.Add(flow);
            }
        }

        //nach dem gewürfelt wurde stehen dem User einige Optionen für die Wortauswahl zur Verfügung
        //aktuell "als Favorit speichern", "Export als Textdatei" oder "in Liste hinzufügen"
        public void wuerfelnOpts(FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            Button favo = new Button();
            favo.Name = "btnFavo";
            favo.Text = "als Favorit speichern";
            favo.Width = 150;
            

            Button txt = new Button();
            txt.Name = "btnTXT";
            txt.Text = "Export als Textdatei";
            txt.Width = 130;

            Button liste = new Button();
            liste.Name = "btnListe";
            liste.Text = "in Liste hinzufügen";
            liste.Width = 130;

            panel.Controls.Add(favo);
            panel.Controls.Add(txt);
            panel.Controls.Add(liste);

        }
    }
}
