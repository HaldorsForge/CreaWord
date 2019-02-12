using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreaWordv4
{
    class addObjects
    {
        public void wuerfelnSet(int anzahl, FlowLayoutPanel panel)  //TODO + add panel!!!!!!
        {
            panel.Controls.Clear();

            for(int i = 1; i <= anzahl; i++)
            {
                ComboBox thema = new ComboBox();
                thema.Name = "cbThema" + i;
                thema.DropDownStyle = ComboBoxStyle.DropDownList;

                TextBox themaNum = new TextBox();
                themaNum.Name = "txtboxThemaNum" + i;
                themaNum.Width = thema.Width;
                themaNum.Text = i + ". Thema";
                themaNum.TextAlign = HorizontalAlignment.Center;


                TextBox katNum = new TextBox();
                katNum.Name = "txtboxKatNum" + i;
                katNum.Width = thema.Width;
                katNum.Text = i + ". Kategorie";
                katNum.TextAlign = HorizontalAlignment.Center;

                ComboBox kategorie = new ComboBox();
                kategorie.Name = "cbKat" + i;
                kategorie.DropDownStyle = ComboBoxStyle.DropDownList;

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
        public void wuerfelnWort(int anzahl, FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            for (int i = 1; i <= anzahl; i++)
            {
                TextBox wortBez = new TextBox();
                wortBez.Name = "txtboxWortBez" + i;
                wortBez.Text = "Wort " + i;  //gewürfeltes wort
                wortBez.TextAlign = HorizontalAlignment.Center;

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
        public void wuerfelnOpts(FlowLayoutPanel panel)
        {
            panel.Controls.Clear();

            Button favo = new Button();
            favo.Name = "btnFavo";
            favo.Text = "als Favorit speichern";
            favo.Width = 200;
            

            Button txt = new Button();
            txt.Name = "btnTXT";
            txt.Text = "Export als Textdatei";
            txt.Width = 200;

            Button liste = new Button();
            liste.Name = "btnListe";
            liste.Text = "in Liste hinzufügen";
            liste.Width = 200;

            panel.Controls.Add(favo);
            panel.Controls.Add(txt);
            panel.Controls.Add(liste);

        }
    }
}
