using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_Aufgabenverfolgung.Entity;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Projekt_Aufgabenverfolgung.Formen
{
    public partial class FrmAbteilung : Form
    {
        public FrmAbteilung()
         {
            InitializeComponent();
        }
        // crud -->> create read update delete

        DbAuftragsverfolgungEntities db = new DbAuftragsverfolgungEntities();
        void Listele()
        {
            
            var degerler = (from x in db.TblAbteilungen
                            select new 
                           {
                               x.ID,
                               x.Name
                           }).ToList();
            gridControl1.DataSource = degerler;
        }




        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblAbteilungen.Find(x);
            db.TblAbteilungen.Remove(deger);
            db.SaveChanges();
            XtraMessageBox.Show("Die Abteilungslöschung wurde erfolgreich abgeschlossen.",
                "information", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            Listele();
        }

        private void BtnEkle_Click(object sender, EventArgs e)

        {
            TblAbteilungen t = new TblAbteilungen();
            t.Name = TxtName.Text;
            db.TblAbteilungen.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Abteilungen wurden erfolgreich im System registriert.", 
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Listele();


            
            
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblAbteilungen.Find(x);
            deger.Name=TxtName.Text;
            db.SaveChanges();
            XtraMessageBox.Show("Die Abteilungupdate wurde erfolgreich abgeschlossen.",
                "information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            Listele();
        }
    }
}
