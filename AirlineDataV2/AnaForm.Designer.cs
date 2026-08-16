namespace AirlineDataV2
{
    partial class AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaForm));
            ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            btnUcakListesi = new DevExpress.XtraBars.BarButtonItem();
            btnPersonel = new DevExpress.XtraBars.BarButtonItem();
            btnBakimKayitlari = new DevExpress.XtraBars.BarButtonItem();
            barBtnPersnl = new DevExpress.XtraBars.BarButtonItem();
            ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            Raporlaa = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            panel1 = new Panel();
            ucAirlineList1 = new AirlineDataV2.Forms.UcAirlineList();
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ribbonControl1
            // 
            ribbonControl1.ExpandCollapseItem.Id = 0;
            ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl1.ExpandCollapseItem, btnUcakListesi, btnPersonel, btnBakimKayitlari, barBtnPersnl });
            ribbonControl1.Location = new Point(0, 0);
            ribbonControl1.MaxItemId = 6;
            ribbonControl1.Name = "ribbonControl1";
            ribbonControl1.OptionsCustomizationForm.FormIcon = (Icon)resources.GetObject("resource.FormIcon");
            ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
            ribbonControl1.Size = new Size(1232, 201);
            // 
            // btnUcakListesi
            // 
            btnUcakListesi.Caption = "Uçaklar";
            btnUcakListesi.Id = 1;
            btnUcakListesi.Name = "btnUcakListesi";
            btnUcakListesi.ItemClick += btnUcakListesi_ItemClick;
            // 
            // btnPersonel
            // 
            btnPersonel.Caption = "Personeller";
            btnPersonel.Id = 3;
            btnPersonel.Name = "btnPersonel";
            // 
            // btnBakimKayitlari
            // 
            btnBakimKayitlari.Caption = "Bakım Kayıtları";
            btnBakimKayitlari.Id = 4;
            btnBakimKayitlari.Name = "btnBakimKayitlari";
            btnBakimKayitlari.ItemClick += btnBakimKayitlari_ItemClick;
            // 
            // barBtnPersnl
            // 
            barBtnPersnl.Caption = "Personeller";
            barBtnPersnl.Id = 5;
            barBtnPersnl.Name = "barBtnPersnl";
            barBtnPersnl.ItemClick += barBtnPersnl_ItemClick;
            // 
            // ribbonPage1
            // 
            ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1, Raporlaa });
            ribbonPage1.Name = "ribbonPage1";
            ribbonPage1.Text = "Yönetim";
            // 
            // ribbonPageGroup1
            // 
            ribbonPageGroup1.ItemLinks.Add(btnUcakListesi);
            ribbonPageGroup1.ItemLinks.Add(btnBakimKayitlari);
            ribbonPageGroup1.ItemLinks.Add(barBtnPersnl);
            ribbonPageGroup1.Name = "ribbonPageGroup1";
            ribbonPageGroup1.Text = "Listeler";
            // 
            // Raporlaa
            // 
            Raporlaa.Name = "Raporlaa";
            Raporlaa.Text = "Filtrele";
            Raporlaa.Visible = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(ucAirlineList1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 201);
            panel1.Name = "panel1";
            panel1.Size = new Size(1232, 649);
            panel1.TabIndex = 1;
            // 
            // ucAirlineList1
            // 
            ucAirlineList1.Dock = DockStyle.Fill;
            ucAirlineList1.Location = new Point(0, 0);
            ucAirlineList1.Name = "ucAirlineList1";
            ucAirlineList1.Size = new Size(1232, 649);
            ucAirlineList1.TabIndex = 0;
            // 
            // AnaForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1232, 850);
            Controls.Add(panel1);
            Controls.Add(ribbonControl1);
            IconOptions.Icon = (Icon)resources.GetObject("AnaForm.IconOptions.Icon");
            Name = "AnaForm";
            Ribbon = ribbonControl1;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AirlineDataV2";
            ((System.ComponentModel.ISupportInitialize)ribbonControl1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnUcakListesi;
        private Panel panel1;
        private DevExpress.XtraBars.BarButtonItem btnPersonel;
        private Forms.UcAirlineList ucAirlineList1;
        private DevExpress.XtraBars.BarButtonItem btnBakimKayitlari;
        private DevExpress.XtraBars.BarButtonItem barBtnPersnl;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup Raporlaa;
    }
}