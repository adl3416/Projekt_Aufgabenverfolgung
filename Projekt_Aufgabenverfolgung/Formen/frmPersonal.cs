using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using Projekt_Aufgabenverfolgung.Entity;

namespace Projekt_Aufgabenverfolgung.Formen
{
    public partial class frmPersonal : Form
    {
        public frmPersonal()
        {
            InitializeComponent();
        }

        DbAuftragsverfolgungEntities db = new DbAuftragsverfolgungEntities();
        void personeller()
        {
            var degerler = from x in db.TblPersonal
                           select new
                           {
                               x.ID,
                               x.Vorname,
                               x.Name,
                               x.Mail,
                               x.TelNummer,
                               departman=x.TblAbteilungen.Name,
                               x.Statu

                           };
            gridControl1.DataSource = degerler.Where (x=> x.Statu== true).ToList();
        }
        private void frmPersonal_Load(object sender, EventArgs e)
        {
            personeller();

            var abteilung = (from x in db.TblAbteilungen
                             select new
                             {
                                 x.ID,
                                 x.Name
                             }).ToList();

            lookUpEdit1.Properties.ValueMember = "ID";
            lookUpEdit1.Properties.DisplayMember = "Name";
            lookUpEdit1.Properties.DataSource = abteilung;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            personeller();
        }

        private void labelControl2_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            TblPersonal t = new TblPersonal();
            t.Vorname = TxtVorname.Text;
            t.Name = TxtName.Text;
            t.Mail = TxtMail.Text;
            t.Bild= TxtBild.Text;
            t.Abteilung=int.Parse(lookUpEdit1.EditValue.ToString());
            db.TblPersonal.Add(t);
            db.SaveChanges();
            XtraMessageBox.Show("Die neue Personalregistrierung wurde erfolgreich durchgeführt.",
                "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            personeller();



        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var x = int.Parse(TxtID.Text);
            var deger = db.TblPersonal.Find(x);
            deger.Statu = false;
            db.SaveChanges();
            XtraMessageBox.Show("Personal wurde erfolgreich gelöscht. Sie können über die Liste auf die gelöschten Personalinformationen zugreifen.",
                "Info",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            personeller();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {

            TxtID.Text = gridView1.GetFocusedRowCellValue("ID").ToString();
            TxtVorname.Text = gridView1.GetFocusedRowCellValue("Vorname").ToString();
            TxtName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            TxtMail.Text = gridView1.GetFocusedRowCellValue("Mail").ToString();
            //TxtBild.Text = gridView1.GetFocusedRowCellValue("Bild").ToString();
             //lookUpEdit1.EditValue = gridView1.GetFocusedRowCellValue("departman").ToString();

        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            int x = int.Parse(TxtID.Text);
            var deger = db.TblPersonal.Find(x);
            deger.Vorname = TxtVorname.Text;
            deger.Name= TxtName.Text;
            deger.Mail= TxtMail.Text;
            deger.Bild=TxtBild.Text; 
            deger.Abteilung=int.Parse(lookUpEdit1.EditValue.ToString());
            db.SaveChanges();
            XtraMessageBox.Show("Das Personal wurde erfolgreich aktualisiert ",
                "Info", MessageBoxButtons.OK, MessageBoxIcon.Question);
            personeller();


        }
    }
}
