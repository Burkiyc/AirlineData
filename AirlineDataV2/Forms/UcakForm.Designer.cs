namespace AirlineDataV2.Forms
{
    partial class UcakForm
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
            components = new System.ComponentModel.Container();
            textEdit1 = new DevExpress.XtraEditors.TextEdit();
            textEdit2 = new DevExpress.XtraEditors.TextEdit();
            textEdit3 = new DevExpress.XtraEditors.TextEdit();
            textEdit4 = new DevExpress.XtraEditors.TextEdit();
            textEdit5 = new DevExpress.XtraEditors.TextEdit();
            labelControl1 = new DevExpress.XtraEditors.LabelControl();
            labelControl2 = new DevExpress.XtraEditors.LabelControl();
            labelControl3 = new DevExpress.XtraEditors.LabelControl();
            labelControl4 = new DevExpress.XtraEditors.LabelControl();
            labelControl5 = new DevExpress.XtraEditors.LabelControl();
            ucakEkleBtn = new DevExpress.XtraEditors.SimpleButton();
            onaylaBtn = new DevExpress.XtraEditors.SimpleButton();
            behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(components);
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).BeginInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).BeginInit();
            SuspendLayout();
            // 
            // textEdit1
            // 
            textEdit1.EditValue = "TC-";
            textEdit1.Location = new Point(94, 10);
            textEdit1.Name = "textEdit1";
            textEdit1.Properties.CharacterCasing = CharacterCasing.Upper;
            textEdit1.Properties.MaxLength = 6;
            textEdit1.Size = new Size(71, 28);
            textEdit1.TabIndex = 0;
            textEdit1.EditValueChanged += textEdit1_EditValueChanged;
            // 
            // textEdit2
            // 
            textEdit2.Location = new Point(94, 40);
            textEdit2.Name = "textEdit2";
            textEdit2.Size = new Size(144, 28);
            textEdit2.TabIndex = 1;
            // 
            // textEdit3
            // 
            textEdit3.Enabled = false;
            textEdit3.Location = new Point(94, 69);
            textEdit3.Name = "textEdit3";
            textEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit3.Size = new Size(92, 28);
            textEdit3.TabIndex = 2;
            // 
            // textEdit4
            // 
            textEdit4.Enabled = false;
            textEdit4.Location = new Point(94, 99);
            textEdit4.Name = "textEdit4";
            textEdit4.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            textEdit4.Size = new Size(92, 28);
            textEdit4.TabIndex = 3;
            // 
            // textEdit5
            // 
            textEdit5.Enabled = false;
            textEdit5.Location = new Point(94, 128);
            textEdit5.Name = "textEdit5";
            textEdit5.Properties.CharacterCasing = CharacterCasing.Upper;
            textEdit5.Properties.MaxLength = 4;
            textEdit5.Size = new Size(64, 28);
            textEdit5.TabIndex = 4;
            // 
            // labelControl1
            // 
            labelControl1.Location = new Point(10, 16);
            labelControl1.Name = "labelControl1";
            labelControl1.Size = new Size(49, 13);
            labelControl1.TabIndex = 5;
            labelControl1.Text = "Kuyruk No";
            // 
            // labelControl2
            // 
            labelControl2.Location = new Point(10, 46);
            labelControl2.Name = "labelControl2";
            labelControl2.Size = new Size(28, 13);
            labelControl2.TabIndex = 6;
            labelControl2.Text = "Model";
            // 
            // labelControl3
            // 
            labelControl3.Location = new Point(10, 75);
            labelControl3.Name = "labelControl3";
            labelControl3.Size = new Size(34, 13);
            labelControl3.TabIndex = 7;
            labelControl3.Text = "Alım Yılı";
            // 
            // labelControl4
            // 
            labelControl4.Location = new Point(10, 105);
            labelControl4.Name = "labelControl4";
            labelControl4.Size = new Size(50, 13);
            labelControl4.TabIndex = 8;
            labelControl4.Text = "Uçuş Saati";
            // 
            // labelControl5
            // 
            labelControl5.Location = new Point(10, 134);
            labelControl5.Name = "labelControl5";
            labelControl5.Size = new Size(72, 13);
            labelControl5.TabIndex = 9;
            labelControl5.Text = "Şimdiki Meydan";
            // 
            // ucakEkleBtn
            // 
            ucakEkleBtn.Location = new Point(194, 231);
            ucakEkleBtn.Name = "ucakEkleBtn";
            ucakEkleBtn.Size = new Size(81, 41);
            ucakEkleBtn.TabIndex = 10;
            ucakEkleBtn.Text = "Ekle";
            ucakEkleBtn.Click += ucakEkleBtn_Click;
            // 
            // onaylaBtn
            // 
            onaylaBtn.Location = new Point(194, 231);
            onaylaBtn.Name = "onaylaBtn";
            onaylaBtn.Size = new Size(81, 41);
            onaylaBtn.TabIndex = 11;
            onaylaBtn.Text = "Onayla";
            onaylaBtn.Click += onaylaBtn_Click;
            // 
            // UcakForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(287, 282);
            Controls.Add(onaylaBtn);
            Controls.Add(ucakEkleBtn);
            Controls.Add(labelControl5);
            Controls.Add(labelControl4);
            Controls.Add(labelControl3);
            Controls.Add(labelControl2);
            Controls.Add(labelControl1);
            Controls.Add(textEdit5);
            Controls.Add(textEdit4);
            Controls.Add(textEdit3);
            Controls.Add(textEdit2);
            Controls.Add(textEdit1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "UcakForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "UcakForm";
            Load += UcakForm_Load;
            ((System.ComponentModel.ISupportInitialize)textEdit1.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit2.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit3.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit4.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)textEdit5.Properties).EndInit();
            ((System.ComponentModel.ISupportInitialize)behaviorManager1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.TextEdit textEdit3;
        private DevExpress.XtraEditors.TextEdit textEdit4;
        private DevExpress.XtraEditors.TextEdit textEdit5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton ucakEkleBtn;
        private DevExpress.XtraEditors.SimpleButton onaylaBtn;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
    }
}