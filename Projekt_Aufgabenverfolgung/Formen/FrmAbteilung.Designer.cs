﻿
namespace Projekt_Aufgabenverfolgung.Formen
{
    partial class FrmAbteilung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAbteilung));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.BtnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.TxtName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.BtnListele = new DevExpress.XtraEditors.SimpleButton();
            this.TxtID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-5, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(672, 407);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gridView1_FocusedRowChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.BtnEkle);
            this.groupControl1.Controls.Add(this.TxtName);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.BtnListele);
            this.groupControl1.Controls.Add(this.TxtID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(673, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(282, 395);
            this.groupControl1.TabIndex = 5;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(65, 272);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(202, 28);
            this.BtnGuncelle.TabIndex = 7;
            this.BtnGuncelle.Text = "Update";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // BtnSil
            // 
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(65, 238);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(202, 28);
            this.BtnSil.TabIndex = 6;
            this.BtnSil.Text = "Löschen";
            this.BtnSil.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnEkle.ImageOptions.Image")));
            this.BtnEkle.Location = new System.Drawing.Point(65, 204);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(202, 28);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "Hinzufügen";
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtName
            // 
            this.TxtName.Location = new System.Drawing.Point(98, 75);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(179, 22);
            this.TxtName.TabIndex = 4;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(0, 81);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(91, 16);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "AbteilungName:";
            // 
            // BtnListele
            // 
            this.BtnListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnListele.ImageOptions.Image")));
            this.BtnListele.Location = new System.Drawing.Point(65, 170);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(202, 28);
            this.BtnListele.TabIndex = 2;
            this.BtnListele.Text = "Liste";
            this.BtnListele.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // TxtID
            // 
            this.TxtID.Location = new System.Drawing.Point(98, 39);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(179, 22);
            this.TxtID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(0, 42);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "AbteilungID:";
            // 
            // FrmAbteilung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 482);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmAbteilung";
            this.Text = "Abteilung";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtID.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit TxtName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnListele;
        private DevExpress.XtraEditors.TextEdit TxtID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private DevExpress.XtraEditors.SimpleButton BtnEkle;
    }
}