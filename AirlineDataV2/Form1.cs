using System;
using DevExpress.XtraEditors;
using AirlineDataV2.DbModels;

namespace AirlineDataV2
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var context = new AirlineDbContext())
            {
                var ucaklar = context.Ucaklar.ToList();
                gridControl1.DataSource = ucaklar;
            }
        }
    }
}
