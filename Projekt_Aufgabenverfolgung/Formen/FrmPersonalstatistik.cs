using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_Aufgabenverfolgung.Entity;

namespace Projekt_Aufgabenverfolgung.Formen
{
    public partial class FrmPersonalstatistik : Form
    {
        public FrmPersonalstatistik()
        {
            InitializeComponent();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        DbAuftragsverfolgungEntities db = new DbAuftragsverfolgungEntities();
        private void FrmPersonalstatistik_Load(object sender, EventArgs e)
        {
            lblToplamDepartman.Text=db.TblAbteilungen.Count().ToString();
            LblToplamFirma.Text = db.TblFirmen.Count().ToString();
            LblToplamPersonel.Text = db.TblPersonal.Count().ToString();
        }
    }
}
