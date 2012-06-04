using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Zeiterfassung.Properties;

namespace Zeiterfassung
{
    public partial class frmStart : Form
    {
        private SQLCeConnection m_dbcon = new SQLCeConnection();
        private bool m_mutex;

        public frmStart()
        {
            m_mutex = false;
            InitializeComponent();
        }

        private string m_ToTime(int Minutes)
        {
            string min;
            min = (Minutes % 60).ToString();
            if (min == "0")
                min = "00";

            return (Minutes / 60).ToString() + ":" + min;
        }

        private void mcKalender_DateChanged(object sender, DateRangeEventArgs e)
        {
            //Dataset leeren
            zeiterfassungDataSet.Clear();

            //DatagridView befüllen
            m_dbcon.Open();
            m_mutex = true;
            m_dbcon.query = m_dbcon.SqlStatement("SELECT ID, Datum, Kat1, Kat2, Kat3, Dauer FROM Zeit WHERE Datum = '" + mcKalender.SelectionStart.ToString("MM/dd/yyyy") + "'").ExecuteReader();
           
            ZeiterfassungDataSet.ZeitRow dr;

            while(m_dbcon.query.Read())
            {
                dr = zeiterfassungDataSet.Zeit.NewZeitRow();
                dr["ID"] = m_dbcon.query["ID"];
                dr["Datum"] = m_dbcon.query["Datum"];
                dr["Kat1"] = m_dbcon.query["Kat1"];
                dr["Kat2"] = m_dbcon.query["Kat2"];
                dr["Kat3"] = m_dbcon.query["Kat3"];
                dr["Dauer"] = m_ToTime(Convert.ToInt32(m_dbcon.query["Dauer"]));
                zeiterfassungDataSet.Zeit.AddZeitRow(dr);
            }

            try
            {
                int GesamtZeit = Convert.ToInt32(m_dbcon.SqlStatement("SELECT SUM(Dauer) FROM Zeit WHERE Datum = '" + mcKalender.SelectionStart.ToString("MM/dd/yyyy") + "'").ExecuteScalar());
                if (GesamtZeit != 0)
                {
                    dr = zeiterfassungDataSet.Zeit.NewZeitRow();
                    dr["Kat3"] = "Gesamt";
                    dr["Dauer"] = m_ToTime(GesamtZeit);
                    zeiterfassungDataSet.Zeit.AddZeitRow(dr);
                }
            
            }
            catch (System.Exception ex)
            {
            }

            dgvZeit.DataSource = zeiterfassungDataSet.Zeit;

            //Tag Art zurücksetzten
            rbKrank.Checked = false;
            rbArbeitstag.Checked = false;
            rbFrei.Checked = false;
            rbUrlaub.Checked = false;
            pbCVJM.Image = Zeiterfassung.Properties.Resources.cvjm_w;

            //Tag Art auslesen
            m_dbcon.query = m_dbcon.SqlStatement("SELECT TagArt FROM Datum WHERE Datum = '" + mcKalender.SelectionStart.ToString("MM/dd/yyyy") + "'").ExecuteReader();

            while (m_dbcon.query.Read())
            {
                switch (m_dbcon.query["TagArt"].ToString())
                {
                    case "Krank":
                        {
                            rbKrank.Checked = true;
                            pbCVJM.Image = Zeiterfassung.Properties.Resources.cvjm_r;
                        } break;
                    case "Arbeitstag":
                        {
                            rbArbeitstag.Checked = true;
                            pbCVJM.Image = Zeiterfassung.Properties.Resources.cvjm_y;
                        } break;
                    case "Frei":
                        {
                            rbFrei.Checked = true;
                            pbCVJM.Image = Zeiterfassung.Properties.Resources.cvjm_g;
                        } break;
                    case "Urlaub":
                        {
                            rbUrlaub.Checked = true;
                            pbCVJM.Image = Zeiterfassung.Properties.Resources.cvjm_b;
                        } break;
                }
            }

            m_dbcon.Close();
            m_mutex = false;
        }

        private void cmdEintragen_Click(object sender, EventArgs e)
        {
            m_dbcon.Open();
            //Eintragen der Zeit
            m_dbcon.SqlStatement("INSERT INTO Zeit(Datum,Kat1,Kat2,Kat3,Dauer) " +
                           "VALUES ('" + mcKalender.SelectionStart.ToString("MM/dd/yyyy") + "','" 
                           + lbKat1.SelectedItem + "','" 
                           + lbKat2.SelectedItem + "','" 
                           + lbKat3.SelectedItem + "'," 
                           + + (Convert.ToInt32(cbStunden.Text) * 60 + Convert.ToInt32(cbMinuten.Text)) + ")").ExecuteNonQuery();
            m_dbcon.Close();

            mcKalender_DateChanged(sender,null);
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            //Daten für heutiges Datum auslesen
            Reload(sender);
        }

        private void lbKat1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Alle Einträge aus Kat2 und 3 löschen
            lbKat2.Items.Clear();
            lbKat3.Items.Clear();

            //Kategorie2 nach Auswahl von Kat1 befüllen
            m_dbcon.Open();
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat2 WHERE OberKat = '" + lbKat1.SelectedItem + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                lbKat2.Items.Add(m_dbcon.query["Kategorie2"].ToString());
            }
            m_dbcon.Close();
        }

        private void lbKat2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Alle Einträge aus Kat3 löschen
            lbKat3.Items.Clear();
            //Kategorie3 nach Auswahl von Kat2 befüllen
            m_dbcon.Open();
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat3 WHERE OberKat = '" + lbKat2.SelectedItem + "'" + "AND OberKat2 = '" + lbKat1.SelectedItem + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                lbKat3.Items.Add(m_dbcon.query["Kategorie3"].ToString());
            }
            m_dbcon.Close();
        }

        private void cmdVerwalten_Click(object sender, EventArgs e)
        {
            Form katVer = new KatVerwaltung(this);
            katVer.Show();
        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvZeit_Click(object sender, MouseEventArgs e)
        {
            //Rechssklick zum entfernen
            Point Mouse = new Point(e.X+180, e.Y+40);
            if (e.Button.ToString() == "Right")
                contextMenuStrip1.Show(dgvZeit.TopLevelControl, Mouse);
               
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvZeit.RowCount == 0)
                return;

            m_dbcon.Open();
            m_dbcon.SqlStatement("DELETE FROM Zeit WHERE ID ='" + dgvZeit.SelectedRows[0].Cells["ID"].Value + "'").ExecuteNonQuery();
            m_dbcon.Close();

            //Daten aktualiesieren
            DateRangeEventArgs temp = null;
            mcKalender_DateChanged(sender, temp);
        }

        private void cmdBericht_Click(object sender, EventArgs e)
        {
            Form Bericht = new frmBerichtErstellen();
            Bericht.Show();
        }

        private void cmdEinstellungen_Click(object sender, EventArgs e)
        {
            Form Info = new frmInfo();
            Info.Show();
        }
        
        public void Reload(object sender)
        {
            //Daten für heutiges Datum auslesen
            DateRangeEventArgs temp = null;
            mcKalender_DateChanged(sender, temp);

            //Kategorie1 leeren
            lbKat1.Items.Clear();
            //Kategorie1 auslesen und in Listbox eintragen
            m_dbcon.Open();
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat1").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                lbKat1.Items.Add(m_dbcon.query["Kategorie1"].ToString());
            }
            m_dbcon.Close();
        }

        private void TagArtWechseln()
        {
            if (m_mutex == true)
                return;

            //Tag Art eintragen
            string TagArt;
            TagArt = rbArbeitstag.Checked ? "Arbeitstag" : rbKrank.Checked ? "Krank" : rbUrlaub.Checked ? "Urlaub" : rbFrei.Checked ? "Frei" : "undef";

            //Tag Art auslesen
            m_dbcon.Open();
            m_dbcon.query = m_dbcon.SqlStatement("SELECT TagArt FROM Datum WHERE Datum = '" + mcKalender.SelectionStart.ToString("MM/dd/yyyy") + "'").ExecuteReader();
            if (m_dbcon.query.Read())
            {
                m_dbcon.SqlStatement("UPDATE Datum SET TagArt = '" + TagArt + "' WHERE Datum = '" + mcKalender.SelectionStart.ToString("MM/dd/yyyy") + "'").ExecuteNonQuery();
            }
            else
            {
                m_dbcon.SqlStatement("INSERT INTO Datum(Datum, TagArt) " +
                               "VALUES ('" + mcKalender.SelectionStart.ToString("MM/dd/yyyy") + "','"
                                + TagArt + "')").ExecuteNonQuery();
            }
            m_dbcon.Close();

            mcKalender_DateChanged(null, null);
        }

        private void rbArbeitstag_CheckedChanged(object sender, EventArgs e)
        {
            TagArtWechseln();
        }

        private void rbKrank_CheckedChanged(object sender, EventArgs e)
        {
            TagArtWechseln();
        }

        private void rbUrlaub_CheckedChanged(object sender, EventArgs e)
        {
           TagArtWechseln();
        }

        private void rbFrei_CheckedChanged(object sender, EventArgs e)
        {
           TagArtWechseln();
        }

        //* IMPORT SCRIPT
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            String line = "";
            try
            {
                m_dbcon.Open();
                StreamReader reader = new StreamReader(@"C:\sql.txt", Encoding.Unicode, false);
                while ((line = reader.ReadLine()) != null)
                {
                    m_dbcon.SqlStatement(line).ExecuteNonQuery();
                    label1.Text = i.ToString();
                    i++;
                }
                reader.Close();
                MessageBox.Show("Daten eingefügt");
                m_dbcon.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Error in: " + line);
            }
        }

        //*/
    }
}
