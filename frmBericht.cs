using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Zeiterfassung
{
    struct Kat1Prozent
    {
       public string Kat1;
       public int Zeit;
       public string Prozent;
    }

    public partial class frmBericht : Form
    {
        private SQLCeConnection m_dbcon = new SQLCeConnection();

        private DateTime m_StartDate;
        private DateTime m_EndDate;

        public frmBericht(DateTime Start, DateTime End)
        {
            m_StartDate = Start;
            m_EndDate = End;
            InitializeComponent();
        }

        private void CreateData()
        {
            try
            {
                //Daten vorbereiten
                m_dbcon.Open();

                int Arbeitstag = (int)m_dbcon.SqlStatement("SELECT COUNT(TagArt) FROM Datum WHERE (TagArt = 'Arbeitstag') AND (Datum BETWEEN '" + m_StartDate.ToString("MM/dd/yyyy") + "' AND '" + m_EndDate.ToString("MM/dd/yyyy") + "')").ExecuteScalar();
                int Frei = (int)m_dbcon.SqlStatement("SELECT COUNT(TagArt) FROM Datum WHERE (TagArt = 'Frei') AND (Datum BETWEEN '" + m_StartDate.ToString("MM/dd/yyyy") + "' AND '" + m_EndDate.ToString("MM/dd/yyyy") + "')").ExecuteScalar();
                int Urlaub = (int)m_dbcon.SqlStatement("SELECT COUNT(TagArt) FROM Datum WHERE (TagArt = 'Urlaub') AND (Datum BETWEEN '" + m_StartDate.ToString("MM/dd/yyyy") + "' AND '" + m_EndDate.ToString("MM/dd/yyyy") + "')").ExecuteScalar();
                int Krank = (int)m_dbcon.SqlStatement("SELECT COUNT(TagArt) FROM Datum WHERE (TagArt = 'Krank') AND (Datum BETWEEN '" + m_StartDate.ToString("MM/dd/yyyy") + "' AND '" + m_EndDate.ToString("MM/dd/yyyy") + "')").ExecuteScalar();
                int GesamtZeit = (int)m_dbcon.SqlStatement("SELECT SUM(Dauer) FROM Zeit WHERE (Datum BETWEEN '" + m_StartDate.ToString("MM/dd/yyyy") + "' AND '" + m_EndDate.ToString("MM/dd/yyyy") + "')").ExecuteScalar();
                string StartDate = m_StartDate.ToShortDateString();
                string EndDate = m_EndDate.ToShortDateString();

                //Einzelne Datensätze auslesen
                m_dbcon.query = m_dbcon.SqlStatement("SELECT Kat1, Kat2, Kat3, SUM(Dauer) AS Dauer FROM Zeit WHERE (Datum BETWEEN '" + m_StartDate.ToString("MM/dd/yyyy") + "' AND '" + m_EndDate.ToString("MM/dd/yyyy") + "') GROUP BY Kat1, Kat2, Kat3").ExecuteReader();

                Bericht.BerichtZeitenRow dr;

                //Datensätze in Dataset schreiben
                while (m_dbcon.query.Read())
                {
                    dr = Bericht.BerichtZeiten.NewBerichtZeitenRow();

                    dr["Arbeitstag"] = Arbeitstag;
                    dr["Frei"] = Frei;
                    dr["Urlaub"] = Urlaub;
                    dr["Krank"] = Krank;
                    dr["StartDate"] = StartDate;
                    dr["EndDate"] = EndDate;
                    dr["GesamtZeit"] = m_ToTime(GesamtZeit);

                    dr["Dauer"] = m_ToTime(Convert.ToInt32(m_dbcon.query["Dauer"]));
                    dr["Kat1"] = m_dbcon.query["Kat1"].ToString();
                    dr["Kat2"] = m_dbcon.query["Kat2"].ToString();
                    dr["Kat3"] = m_dbcon.query["Kat3"].ToString();

                    //Prozentzahlen von Kat1 errechnen
                    int zstandKat1 = (int)m_dbcon.SqlStatement("SELECT SUM(Dauer) AS Dauer FROM Zeit WHERE (Kat1 = '" + dr["Kat1"] + "') AND (Datum BETWEEN '" + m_StartDate.ToString("MM/dd/yyyy") + "' AND '" + m_EndDate.ToString("MM/dd/yyyy") + "') GROUP BY Kat1").ExecuteScalar();
                    //Prozent von Kat1 Kategoriern errechnen
                    dr["ZStandKat1"] = m_ToTime(zstandKat1);
                    dr["ProzentKat1"] = (((float)zstandKat1 / (float)GesamtZeit) * 100).ToString("N2") + "%";

                    //Zur Berechnung des Zwischenstande
                    int zstand = (int)m_dbcon.SqlStatement("SELECT SUM(Dauer) AS Dauer FROM Zeit WHERE (Kat2 = '" + dr["Kat2"] + "') AND (Kat1 = '" + dr["Kat1"] + "') AND (Datum BETWEEN '" + m_StartDate.ToString("MM/dd/yyyy") + "' AND '" + m_EndDate.ToString("MM/dd/yyyy") + "') GROUP BY Kat1").ExecuteScalar();
                    //Prozente der einzelnen Kategorien berechnen
                    dr["ZStand"] = m_ToTime(zstand);
                    dr["Prozent"] = (((float)zstand / (float)GesamtZeit) * 100).ToString("N2") + "%";

                    Bericht.BerichtZeiten.AddBerichtZeitenRow(dr);
                }
                m_dbcon.Close();
            }
            catch(SystemException ex)
            {
                return;
            }
        }
        
        private string m_ToTime(int Minutes)
        {
            string min;
            min = (Minutes % 60).ToString();
            if (min == "0")
                min = "00";

            return (Minutes / 60).ToString() + ":" + min;
        }

        private void frmBericht_Load(object sender, EventArgs e)
        {
            CreateData();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
