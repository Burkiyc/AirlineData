namespace AirlineDataV2.Forms
{
    partial class BakimKayitlariList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BakimKayitlariList));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            kayitEditBtn = new DevExpress.XtraEditors.SimpleButton();
            kayitSilBtn = new DevExpress.XtraEditors.SimpleButton();
            kayitEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(kayitEditBtn);
            panelControl1.Controls.Add(kayitSilBtn);
            panelControl1.Controls.Add(kayitEkleBtn);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(845, 72);
            panelControl1.TabIndex = 2;
            // 
            // kayitEditBtn
            // 
            kayitEditBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("kayitEditBtn.ImageOptions.SvgImage");
            kayitEditBtn.ImageOptions.SvgImageSize = new Size(18, 18);
            kayitEditBtn.Location = new Point(121, 5);
            kayitEditBtn.Name = "kayitEditBtn";
            kayitEditBtn.Size = new Size(103, 29);
            kayitEditBtn.TabIndex = 2;
            kayitEditBtn.Text = "Kaydı Düzenle";
            kayitEditBtn.Click += kayitEditBtn_Click;
            // 
            // kayitSilBtn
            // 
            kayitSilBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("kayitSilBtn.ImageOptions.SvgImage");
            kayitSilBtn.ImageOptions.SvgImageSize = new Size(24, 24);
            kayitSilBtn.Location = new Point(121, 37);
            kayitSilBtn.Name = "kayitSilBtn";
            kayitSilBtn.Size = new Size(103, 29);
            kayitSilBtn.TabIndex = 1;
            kayitSilBtn.Text = "Kaydı Sil";
            kayitSilBtn.Click += kayitSilBtn_Click;
            // 
            // kayitEkleBtn
            // 
            kayitEkleBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("kayitEkleBtn.ImageOptions.SvgImage");
            kayitEkleBtn.Location = new Point(5, 5);
            kayitEkleBtn.Name = "kayitEkleBtn";
            kayitEkleBtn.Size = new Size(110, 61);
            kayitEkleBtn.TabIndex = 0;
            kayitEkleBtn.Text = "Kayıt Oluştur";
            kayitEkleBtn.Click += kayitEkleBtn_Click;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 72);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(845, 432);
            gridControl1.TabIndex = 3;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Click += gridControl1_Click;
            // 
            // gridView1
            // 
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            gridView1.Appearance.ViewCaption.ForeColor = Color.MidnightBlue;
            gridView1.Appearance.ViewCaption.Options.UseFont = true;
            gridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn2, gridColumn3 });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsBehavior.Editable = false;
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowViewCaption = true;
            gridView1.ViewCaption = "Bakım Kayıtları";
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Kuyruk No";
            gridColumn1.FieldName = "KuyrukNo";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.AllowEdit = false;
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 80;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Bakım Tarihi";
            gridColumn2.FieldName = "BakimTarihi";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.OptionsColumn.AllowEdit = false;
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 1;
            gridColumn2.Width = 100;
            // 
            // gridColumn3
            // 
            gridColumn3.Caption = "Personeller";
            gridColumn3.FieldName = "Personeller";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.OptionsColumn.AllowEdit = false;
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 2;
            gridColumn3.Width = 633;
            // 
            // BakimKayitlariList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Name = "BakimKayitlariList";
            Size = new Size(845, 504);
            Load += BakimKayitlariList_Load;
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton kayitEditBtn;
        private DevExpress.XtraEditors.SimpleButton kayitSilBtn;
        private DevExpress.XtraEditors.SimpleButton kayitEkleBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
    }
}
