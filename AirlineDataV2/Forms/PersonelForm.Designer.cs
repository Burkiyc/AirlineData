namespace AirlineDataV2.Forms
{
    partial class PersonelForm
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
            nameTextBox = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            prsKytEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            onaylaBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)nameTextBox.Properties).BeginInit();
            SuspendLayout();
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(64, 12);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(297, 28);
            nameTextBox.TabIndex = 0;
            nameTextBox.KeyDown += nameTextBox_KeyDown;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(12, 19);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(46, 13);
            labelControl1.TabIndex = 1;
            labelControl1.Text = "Ad Soyad";
            // 
            // prsKytEkleBtn
            // 
            prsKytEkleBtn.Location = new Point(491, 12);
            prsKytEkleBtn.Name = "prsKytEkleBtn";
            prsKytEkleBtn.Size = new Size(108, 28);
            prsKytEkleBtn.TabIndex = 2;
            prsKytEkleBtn.Text = "Kayıt Ekle";
            prsKytEkleBtn.Click += prsKytEkleBtn_Click;
            // 
            // onaylaBtn
            // 
            onaylaBtn.Location = new Point(491, 12);
            onaylaBtn.Name = "onaylaBtn";
            onaylaBtn.Size = new Size(108, 28);
            onaylaBtn.TabIndex = 3;
            onaylaBtn.Text = "Onayla";
            onaylaBtn.Visible = false;
            onaylaBtn.Click += onaylaBtn_Click;
            // 
            // PersonelForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 117);
            Controls.Add(onaylaBtn);
            Controls.Add(prsKytEkleBtn);
            Controls.Add(labelControl1);
            Controls.Add(nameTextBox);
            Name = "PersonelForm";
            Text = "Personel Ekle";
            ((System.ComponentModel.ISupportInitialize)nameTextBox.Properties).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit nameTextBox;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton prsKytEkleBtn;
        private DevExpress.XtraEditors.SimpleButton onaylaBtn;
    }
}