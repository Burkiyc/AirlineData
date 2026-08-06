namespace AirlineDataV2.Forms {
    partial class UcAirlineList {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        ///  Required method for Designer support - do not modify 
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcAirlineList));
            gridControl1 = new DevExpress.XtraGrid.GridControl();
            gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ucakEditBtn = new DevExpress.XtraEditors.SimpleButton();
            ucakSilBtn = new DevExpress.XtraEditors.SimpleButton();
            ucakEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)gridControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).BeginInit();
            panelControl1.SuspendLayout();
            SuspendLayout();
            // 
            // gridControl1
            // 
            gridControl1.Dock = DockStyle.Fill;
            gridControl1.Location = new Point(0, 72);
            gridControl1.MainView = gridView1;
            gridControl1.Name = "gridControl1";
            gridControl1.Size = new Size(845, 432);
            gridControl1.TabIndex = 0;
            gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] { gridView1 });
            // 
            // gridView1
            // 
            gridView1.Appearance.ViewCaption.Font = new Font("Tahoma", 8.25F, FontStyle.Bold);
            gridView1.Appearance.ViewCaption.ForeColor = Color.MidnightBlue;
            gridView1.Appearance.ViewCaption.Options.UseFont = true;
            gridView1.Appearance.ViewCaption.Options.UseForeColor = true;
            gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] { gridColumn1, gridColumn3, gridColumn2, gridColumn4, gridColumn5 });
            gridView1.GridControl = gridControl1;
            gridView1.Name = "gridView1";
            gridView1.OptionsView.ShowGroupPanel = false;
            gridView1.OptionsView.ShowViewCaption = true;
            gridView1.ViewCaption = "Filo";
            // 
            // gridColumn1
            // 
            gridColumn1.Caption = "Kuyruk No";
            gridColumn1.FieldName = "KuyrukNo";
            gridColumn1.Name = "gridColumn1";
            gridColumn1.OptionsColumn.AllowEdit = false;
            gridColumn1.OptionsColumn.FixedWidth = true;
            gridColumn1.Visible = true;
            gridColumn1.VisibleIndex = 0;
            gridColumn1.Width = 80;
            // 
            // gridColumn3
            // 
            gridColumn3.FieldName = "Model";
            gridColumn3.Name = "gridColumn3";
            gridColumn3.OptionsColumn.AllowEdit = false;
            gridColumn3.Visible = true;
            gridColumn3.VisibleIndex = 1;
            gridColumn3.Width = 300;
            // 
            // gridColumn2
            // 
            gridColumn2.Caption = "Alım Yılı";
            gridColumn2.FieldName = "AlimYili";
            gridColumn2.Name = "gridColumn2";
            gridColumn2.OptionsColumn.AllowEdit = false;
            gridColumn2.Visible = true;
            gridColumn2.VisibleIndex = 2;
            gridColumn2.Width = 92;
            // 
            // gridColumn4
            // 
            gridColumn4.Caption = "Uçuş Saati";
            gridColumn4.FieldName = "UcusSaati";
            gridColumn4.Name = "gridColumn4";
            gridColumn4.OptionsColumn.AllowEdit = false;
            gridColumn4.Visible = true;
            gridColumn4.VisibleIndex = 3;
            gridColumn4.Width = 163;
            // 
            // gridColumn5
            // 
            gridColumn5.Caption = "Şimdiki Meydan";
            gridColumn5.FieldName = "SimdikiMeydan";
            gridColumn5.Name = "gridColumn5";
            gridColumn5.OptionsColumn.AllowEdit = false;
            gridColumn5.Visible = true;
            gridColumn5.VisibleIndex = 4;
            gridColumn5.Width = 178;
            // 
            // panelControl1
            // 
            panelControl1.Controls.Add(ucakEditBtn);
            panelControl1.Controls.Add(ucakSilBtn);
            panelControl1.Controls.Add(ucakEkleBtn);
            panelControl1.Dock = DockStyle.Top;
            panelControl1.Location = new Point(0, 0);
            panelControl1.Name = "panelControl1";
            panelControl1.Size = new Size(845, 72);
            panelControl1.TabIndex = 1;
            // 
            // ucakEditBtn
            // 
            ucakEditBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ucakEditBtn.ImageOptions.SvgImage");
            ucakEditBtn.ImageOptions.SvgImageSize = new Size(18, 18);
            ucakEditBtn.Location = new Point(112, 5);
            ucakEditBtn.Name = "ucakEditBtn";
            ucakEditBtn.Size = new Size(99, 29);
            ucakEditBtn.TabIndex = 2;
            ucakEditBtn.Text = "Uçağı Düzenle";
            ucakEditBtn.Click += ucakEditBtn_Click;
            // 
            // ucakSilBtn
            // 
            ucakSilBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ucakSilBtn.ImageOptions.SvgImage");
            ucakSilBtn.ImageOptions.SvgImageSize = new Size(24, 24);
            ucakSilBtn.Location = new Point(112, 37);
            ucakSilBtn.Name = "ucakSilBtn";
            ucakSilBtn.Size = new Size(99, 29);
            ucakSilBtn.TabIndex = 1;
            ucakSilBtn.Text = "Uçağı Sil";
            ucakSilBtn.Click += ucakSilBtn_Click;
            // 
            // ucakEkleBtn
            // 
            ucakEkleBtn.ImageOptions.SvgImage = (DevExpress.Utils.Svg.SvgImage)resources.GetObject("ucakEkleBtn.ImageOptions.SvgImage");
            ucakEkleBtn.Location = new Point(5, 5);
            ucakEkleBtn.Name = "ucakEkleBtn";
            ucakEkleBtn.Size = new Size(101, 61);
            ucakEkleBtn.TabIndex = 0;
            ucakEkleBtn.Text = "Uçak Ekle";
            ucakEkleBtn.Click += ucakEkleBtn_Click;
            // 
            // UcAirlineList
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gridControl1);
            Controls.Add(panelControl1);
            Name = "UcAirlineList";
            Size = new Size(845, 504);
            Load += UcAirlineList_Load;
            ((System.ComponentModel.ISupportInitialize)gridControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)gridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)panelControl1).EndInit();
            panelControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton ucakSilBtn;
        private DevExpress.XtraEditors.SimpleButton ucakEkleBtn;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton ucakEditBtn;
    }
}