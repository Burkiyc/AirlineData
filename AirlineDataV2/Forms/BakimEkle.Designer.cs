namespace AirlineDataV2.Forms
{
    partial class BakimEkle
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
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            UcakLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            bakimEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            PersLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            assignPersBtn = new DevExpress.XtraEditors.SimpleButton();
            assgndPersList = new DevExpress.XtraEditors.ListBoxControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            onaylaBtn = new DevExpress.XtraEditors.SimpleButton();
            dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)UcakLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PersLookUpEdit.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)assgndPersList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).BeginInit();
            SuspendLayout();
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(12, 19);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(55, 13);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Uçak Seçimi";
            // 
            // UcakLookUpEdit
            // 
            UcakLookUpEdit.Location = new Point(91, 12);
            UcakLookUpEdit.Name = "UcakLookUpEdit";
            UcakLookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFitResizePopup;
            UcakLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            UcakLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("KuyrukNo", "Kuyruk No"), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Model", "Model") });
            UcakLookUpEdit.Properties.NullText = "Uçak Seçiniz ->";
            UcakLookUpEdit.Size = new Size(300, 28);
            UcakLookUpEdit.TabIndex = 2;
            UcakLookUpEdit.EditValueChanged += UcakLookUpEdit_EditValueChanged;
            // 
            // bakimEkleBtn
            // 
            bakimEkleBtn.Location = new Point(296, 324);
            bakimEkleBtn.Name = "bakimEkleBtn";
            bakimEkleBtn.Size = new Size(95, 34);
            bakimEkleBtn.TabIndex = 3;
            bakimEkleBtn.Text = "Bakım Oluştur";
            bakimEkleBtn.Click += bakimEkleBtn_Click;
            // 
            // PersLookUpEdit
            // 
            PersLookUpEdit.Location = new Point(91, 46);
            PersLookUpEdit.Name = "PersLookUpEdit";
            PersLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            PersLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] { new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Id", "Id", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default), new DevExpress.XtraEditors.Controls.LookUpColumnInfo("AdSoyad", "Ad Soyad") });
            PersLookUpEdit.Properties.NullText = "Personel Seçiniz ->";
            PersLookUpEdit.Size = new Size(300, 28);
            PersLookUpEdit.TabIndex = 4;
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(12, 53);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(73, 13);
            labelControl2.TabIndex = 6;
            labelControl2.Text = "Personel Seçimi";
            // 
            // assignPersBtn
            // 
            assignPersBtn.Location = new Point(309, 80);
            assignPersBtn.Name = "assignPersBtn";
            assignPersBtn.Size = new Size(82, 25);
            assignPersBtn.TabIndex = 7;
            assignPersBtn.Text = "Personel Ata";
            assignPersBtn.Click += assignPersBtn_Click;
            // 
            // assgndPersList
            // 
            assgndPersList.Location = new Point(12, 134);
            assgndPersList.Name = "assgndPersList";
            assgndPersList.Size = new Size(379, 184);
            assgndPersList.TabIndex = 8;
            assgndPersList.ToolTipTitle = "Kaldırmak için çift tıklayın";
            assgndPersList.MouseDown += assgndPersList_MouseDown;
            // 
            // labelControl3
            // 
            labelControl3.Appearance.Font = new Font("Tahoma", 8.25F, FontStyle.Italic);
            labelControl3.Appearance.ForeColor = Color.FromArgb(64, 64, 64);
            labelControl3.Appearance.Options.UseFont = true;
            labelControl3.Appearance.Options.UseForeColor = true;
            labelControl3.Location = new Point(23, 324);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(201, 13);
            labelControl3.TabIndex = 9;
            labelControl3.Text = "Seçilen personeli kaldırmak için sağ tıklayın";
            // 
            // onaylaBtn
            // 
            onaylaBtn.Location = new Point(296, 324);
            onaylaBtn.Name = "onaylaBtn";
            onaylaBtn.Size = new Size(95, 34);
            onaylaBtn.TabIndex = 10;
            onaylaBtn.Text = "Onayla";
            onaylaBtn.Click += onaylaBtn_Click;
            // 
            // dateEdit1
            // 
            dateEdit1.EditValue = null;
            dateEdit1.Location = new Point(91, 80);
            dateEdit1.Name = "dateEdit1";
            dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] { new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo) });
            dateEdit1.Properties.NullText = "Tarih seçiniz ->";
            dateEdit1.Size = new Size(169, 28);
            dateEdit1.TabIndex = 11;
            dateEdit1.Visible = false;
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(12, 86);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(56, 13);
            labelControl4.TabIndex = 12;
            labelControl4.Text = "Bakım Tarihi";
            labelControl4.Visible = false;
            // 
            // BakimEkle
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 370);
            Controls.Add(labelControl4);
            Controls.Add(dateEdit1);
            Controls.Add(onaylaBtn);
            Controls.Add(labelControl3);
            Controls.Add(assgndPersList);
            Controls.Add(assignPersBtn);
            Controls.Add(labelControl2);
            Controls.Add(PersLookUpEdit);
            Controls.Add(bakimEkleBtn);
            Controls.Add(UcakLookUpEdit);
            Controls.Add(labelControl1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "BakimEkle";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Bakım Ekle";
            Load += BakimEkle_Load;
            ((System.ComponentModel.ISupportInitialize)UcakLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)PersLookUpEdit.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)assgndPersList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties.CalendarTimeProperties).EndInit();
            ((System.ComponentModel.ISupportInitialize)dateEdit1.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit UcakLookUpEdit;
        private DevExpress.XtraEditors.SimpleButton bakimEkleBtn;
        private DevExpress.XtraEditors.LookUpEdit PersLookUpEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton assignPersBtn;
        private DevExpress.XtraEditors.ListBoxControl assgndPersList;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton onaylaBtn;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
    }
}