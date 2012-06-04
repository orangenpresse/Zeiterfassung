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
    public partial class frmBerichtErstellen : Form
    {
        private SQLCeConnection m_dbcon = new SQLCeConnection();

        public frmBerichtErstellen()
        {
            InitializeComponent();
        }

        private void cmdErstellen_Click(object sender, EventArgs e)
        {
            frmBericht FormBericht = new frmBericht(dtpStart.Value, dtpEnd.Value);
            FormBericht.Show();
        }
    }
}
