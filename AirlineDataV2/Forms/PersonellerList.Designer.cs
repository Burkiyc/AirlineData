namespace AirlineDataV2.Forms
{
    partial class PersonellerList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonellerList));
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            persEditBtn = new DevExpress.XtraEditors.SimpleButton();
            persSilBtn = new DevExpress.XtraEditors.SimpleButton();
            persEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            SuspendLayout();
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(persEditBtn);
            panelControl1.Controls.Add(persSilBtn);
            panelControl1.Controls.Add(persEkleBtn);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(845, 72);
            panelControl1.TabIndex = 2;
            // 
            // persEditBtn
            // 
            persEditBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("persEditBtn.ImageOptions.SvgImage");
            persEditBtn.ImageOptions.SvgImageSize = new Size(18, 18);
            persEditBtn.Location = new Point(134, 5);
            persEditBtn.Name = "persEditBtn";
            persEditBtn.Size = new Size(171, 29);
            persEditBtn.TabIndex = 2;
            persEditBtn.Text = "Personel Detayını Düzenle";
            persEditBtn.Click += persEditBtn_Click;
            // 
            // persSilBtn
            // 
            persSilBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("persSilBtn.ImageOptions.SvgImage");
            persSilBtn.ImageOptions.SvgImageSize = new Size(24, 24);
            persSilBtn.Location = new Point(134, 37);
            persSilBtn.Name = "persSilBtn";
            persSilBtn.Size = new Size(129, 29);
            persSilBtn.TabIndex = 1;
            persSilBtn.Text = "Personeli Sil";
            persSilBtn.Click += persSilBtn_Click;
            // 
            // persEkleBtn
            // 
            persEkleBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("persEkleBtn.ImageOptions.SvgImage");
            persEkleBtn.Location = new Point(5, 5);
            persEkleBtn.Name = "persEkleBtn";
            persEkleBtn.Size = new Size(123, 61);
            persEkleBtn.TabIndex = 0;
            persEkleBtn.Text = "Personel Ekle";
            persEkleBtn.Click += persEkleBtn_Click;
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 72);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(845, 360);
            gridControl1.TabIndex = 3;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            gridControl1.Load += gridControl1_Load;
            // 
            // gridView1
            // 
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            gridView1.Appearance.ViewCaption.ForeColor = Color.MidnightBlue;
            gridView1.Appearance.ViewCaption.Options.UseFont = true;
            gridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1 });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowViewCaption = true;
            gridView1.ViewCaption = "Personeller";
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Ad Soyad";
            gridColumn1.FieldName = "AdSoyad";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.AllowEdit = false;
            gridColumn1.OptionsColumn.FixedWidth = true;
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 80;
            // 
            // PersonellerList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Name = "PersonellerList";
            Size = new Size(845, 432);
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton persEditBtn;
        private DevExpress.XtraEditors.SimpleButton persSilBtn;
        private DevExpress.XtraEditors.SimpleButton persEkleBtn;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}
