using System;
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
    public partial class KatVerwaltung : Form
    {
        private frmStart m_zvw;
        private SQLCeConnection m_dbcon = new SQLCeConnection();

        public KatVerwaltung(frmStart zvw)
        {
            m_zvw = zvw;
            InitializeComponent();
        }

        private void KatVerwaltung_Load(object sender, EventArgs e)
        {
            LoadData();
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

        private void cmdKat1löschen_Click(object sender, EventArgs e)
        {
            KatLöschen(1);
        }

        private void cmdKat2löschen_Click(object sender, EventArgs e)
        {
            KatLöschen(2);
        }

        private void cmdKat3löschen_Click(object sender, EventArgs e)
        {
            KatLöschen(3);
        }

        private bool KatLöschen(int Kat)
        {
            if (lbKat1.SelectedItem == null && Kat == 1)
                return false;
            if (lbKat2.SelectedItem == null && Kat == 2)
                return false;
            if (lbKat3.SelectedItem == null && Kat == 3)
                return false;

            string name;
            name = Kat == 1 ? lbKat1.SelectedItem.ToString() : Kat == 2 ? lbKat2.SelectedItem.ToString() : Kat == 3 ? lbKat3.SelectedItem.ToString() : "";

            //Kategorie löschen
            m_dbcon.Open();
            switch (Kat)
            {
                case 1:
                {
                    //Unterkategorien löschen
                    m_dbcon.SqlStatement("DELETE FROM Kat1 WHERE Kategorie1 ='" + name + "'").ExecuteNonQuery();
                    m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat2 WHERE OberKat = '" + name + "'").ExecuteReader();
                    while (m_dbcon.query.Read())
                    {
                        m_dbcon.SqlStatement("DELETE FROM Kat3 WHERE OberKat ='" + m_dbcon.query["Kategorie2"].ToString() + "' AND OberKat2 = '" + name +"'").ExecuteNonQuery();
                    }
                    m_dbcon.SqlStatement("DELETE FROM Kat2 WHERE OberKat ='" + name + "'").ExecuteNonQuery();
                }break;

                case 2:
                {
                    //Unterkategorien löschen
                    m_dbcon.SqlStatement("DELETE FROM Kat2 WHERE Kategorie2 ='" + name + "' AND OberKat = '" + lbKat1.SelectedItem + "'").ExecuteNonQuery();
                    m_dbcon.SqlStatement("DELETE FROM Kat3 WHERE OberKat ='" + name + "' AND OberKat2 = '" + lbKat1.SelectedItem +"'").ExecuteNonQuery();
                }break;

                case 3:
                {
                    m_dbcon.SqlStatement("DELETE FROM Kat3 WHERE OberKat ='" + lbKat2.SelectedItem + "' AND OberKat2 = '" + lbKat1.SelectedItem + "'").ExecuteNonQuery();
                }break;

            };
 
            m_dbcon.Close();
            
            LoadData();

            return true;
        }

        private void LoadData()
        {
            //Alle Einträge aus Kat1 löschen
            lbKat1.Items.Clear();

            //Kategorie1 auslesen und in Listbox eintragen
            m_dbcon.Open();
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat1").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                lbKat1.Items.Add(m_dbcon.query["Kategorie1"].ToString());
            }

            //Alle Einträge aus Kat2 löschen
            lbKat2.Items.Clear();
            //Kategorie2 nach Auswahl von Kat1 befüllen
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat2 WHERE OberKat = '" + lbKat1.SelectedItem + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                lbKat2.Items.Add(m_dbcon.query["Kategorie2"].ToString());
            }

            //Alle Einträge aus Kat3 löschen
            lbKat3.Items.Clear();
            //Kategorie3 nach Auswahl von Kat2 befüllen
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat3 WHERE OberKat = '" + lbKat2.SelectedItem + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                lbKat3.Items.Add(m_dbcon.query["Kategorie3"].ToString());
            }
            m_dbcon.Close();
        }

        private void cmdKat1hinzu_Click(object sender, EventArgs e)
        {
            if (tbKat1.Text == "")
                return;

            m_dbcon.Open();
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat1 WHERE Kategorie1 = '" + tbKat1.Text + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                MessageBox.Show("Kategorie " + tbKat1.Text + " schon vorhanden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_dbcon.Close();
                return;
            }

            m_dbcon.SqlStatement("INSERT INTO Kat1(Kategorie1) VALUES('" + tbKat1.Text + "')").ExecuteNonQuery();
            m_dbcon.Close();

            LoadData();

            //Textbox zurücksetzen
            tbKat1.Text = "";
        }

        private void cmdKat2hinzu_Click(object sender, EventArgs e)
        {
            if (lbKat1.SelectedItem == null)
                return;
            if (tbKat2.Text == "")
                return;

            m_dbcon.Open();
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat2 WHERE Kategorie2 = '" + tbKat2.Text + "' AND OberKat = '" + lbKat1.SelectedItem.ToString() + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                MessageBox.Show("Kategorie " + tbKat2.Text + " schon vorhanden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_dbcon.Close();
                return;
            }

            m_dbcon.SqlStatement("INSERT INTO Kat2(Kategorie2,OberKat) VALUES('" + tbKat2.Text.ToString() + "','" + lbKat1.SelectedItem + "')").ExecuteNonQuery();

            //Alle Einträge aus Kat2 löschen
            lbKat2.Items.Clear();
            //Kategorie2 nach Auswahl von Kat1 befüllen
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat2 WHERE OberKat = '" + lbKat1.SelectedItem + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                lbKat2.Items.Add(m_dbcon.query["Kategorie2"].ToString());
            }

            //Alle Einträge aus Kat3 löschen
            lbKat3.Items.Clear();
            //Kategorie3 nach Auswahl von Kat2 befüllen
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat3 WHERE OberKat = '" + lbKat2.SelectedItem + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                lbKat3.Items.Add(m_dbcon.query["Kategorie3"].ToString());
            }
            m_dbcon.Close();

            //Textbox zurücksetzen
            tbKat2.Text = "";
        }

        private void cmdKat3hinzu_Click(object sender, EventArgs e)
        {
            if (lbKat1.SelectedItem == null)
                return;
            if (lbKat2.SelectedItem == null)
                return;
            if (tbKat3.Text == "")
                return;

            m_dbcon.Open();
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat3 WHERE OberKat = '" + lbKat2.SelectedItem + "'" + "AND OberKat2 = '" + lbKat1.SelectedItem + "' AND Kategorie3 = '" + tbKat3.Text + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                MessageBox.Show("Kategorie " + tbKat3.Text + " schon vorhanden!", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                m_dbcon.Close();
                return;
            }

            m_dbcon.SqlStatement("INSERT INTO Kat3(Kategorie3,OberKat,OberKat2) VALUES('" + tbKat3.Text + "','" + lbKat2.SelectedItem + "','" + lbKat1.SelectedItem +"')").ExecuteNonQuery();
            
            //Alle Einträge aus Kat3 löschen
            lbKat3.Items.Clear();
            //Kategorie3 nach Auswahl von Kat2 befüllen
            m_dbcon.query = m_dbcon.SqlStatement("SELECT * FROM Kat3 WHERE OberKat = '" + lbKat2.SelectedItem + "'").ExecuteReader();
            while (m_dbcon.query.Read())
            {
                lbKat3.Items.Add(m_dbcon.query["Kategorie3"].ToString());
            }
            m_dbcon.Close();

            //Textbox zurüclsetzen
            tbKat3.Text = "";
        }

        private void KatVerwaltung_Close(object sender, FormClosingEventArgs e)
        {
            m_zvw.Reload(sender);
        }

    }
}
