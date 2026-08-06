using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AirlineDataV2
{
    public partial class AnaForm : RibbonForm
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private void btnUcakListesi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            Forms.UcAirlineList ucAirlineList = new Forms.UcAirlineList();
            ucAirlineList.Dock = DockStyle.Fill;
            panel1.Controls.Add(ucAirlineList);
        }

        private void btnBakimKayitlari_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            Forms.BakimKayitlariList bakimKayitlariList = new Forms.BakimKayitlariList();
            bakimKayitlariList.Dock = DockStyle.Fill;
            panel1.Controls.Add(bakimKayitlariList);
        }

        private void barBtnPersnl_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panel1.Controls.Clear();
            Forms.PersonellerList personellerList = new Forms.PersonellerList();
            personellerList.Dock = DockStyle.Fill;
            panel1.Controls.Add(personellerList);
        }
    }
}