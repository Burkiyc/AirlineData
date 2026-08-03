namespace AirlineData
{
    partial class YonetimForm
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
            ucakDataGrid = new DataGridView();
            addDataBtn = new Button();
            tabControl1 = new TabControl();
            filoYonetmTab = new TabPage();
            qinfLbl1 = new Label();
            refreshBtn = new Button();
            panel1 = new Panel();
            label2 = new Label();
            ucakEkleControl1 = new AirlineData.Forms.ucakEkleControl();
            persYonetmTab = new TabPage();
            qinfLbl2 = new Label();
            refreshBtn2 = new Button();
            persDataGrid = new DataGridView();
            panel2 = new Panel();
            atMeydancbx = new ComboBox();
            uzmanlikTbx = new TextBox();
            label1 = new Label();
            persAdtbx = new TextBox();
            prsEkleBtn = new Button();
            yontimCtxMenu = new ContextMenuStrip(components);
            kaydıSilToolStripMenuItem = new ToolStripMenuItem();
            kaydıDüzenleToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)ucakDataGrid).BeginInit();
            tabControl1.SuspendLayout();
            filoYonetmTab.SuspendLayout();
            panel1.SuspendLayout();
            persYonetmTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)persDataGrid).BeginInit();
            panel2.SuspendLayout();
            yontimCtxMenu.SuspendLayout();
            SuspendLayout();
            // 
            // ucakDataGrid
            // 
            ucakDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucakDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ucakDataGrid.Location = new Point(6, 132);
            ucakDataGrid.Name = "ucakDataGrid";
            ucakDataGrid.ReadOnly = true;
            ucakDataGrid.Size = new Size(833, 468);
            ucakDataGrid.TabIndex = 0;
            ucakDataGrid.CellMouseDown += ucakDataGrid_CellMouseDown;
            // 
            // addDataBtn
            // 
            addDataBtn.Location = new Point(158, 586);
            addDataBtn.Name = "addDataBtn";
            addDataBtn.Size = new Size(87, 26);
            addDataBtn.TabIndex = 1;
            addDataBtn.Text = "Ekle";
            addDataBtn.UseVisualStyleBackColor = true;
            addDataBtn.Click += addDataBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(filoYonetmTab);
            tabControl1.Controls.Add(persYonetmTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1107, 655);
            tabControl1.TabIndex = 2;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // filoYonetmTab
            // 
            filoYonetmTab.Controls.Add(qinfLbl1);
            filoYonetmTab.Controls.Add(refreshBtn);
            filoYonetmTab.Controls.Add(panel1);
            filoYonetmTab.Controls.Add(ucakDataGrid);
            filoYonetmTab.Location = new Point(4, 24);
            filoYonetmTab.Name = "filoYonetmTab";
            filoYonetmTab.Padding = new Padding(3);
            filoYonetmTab.Size = new Size(1099, 627);
            filoYonetmTab.TabIndex = 0;
            filoYonetmTab.Text = "Filo Yönetimi";
            filoYonetmTab.UseVisualStyleBackColor = true;
            filoYonetmTab.Click += filoYonetmTab_Click;
            // 
            // qinfLbl1
            // 
            qinfLbl1.AutoSize = true;
            qinfLbl1.Location = new Point(8, 603);
            qinfLbl1.Name = "qinfLbl1";
            qinfLbl1.Size = new Size(93, 15);
            qinfLbl1.TabIndex = 4;
            qinfLbl1.Text = "Sunucu çalışıyor";
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(711, 100);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(128, 26);
            refreshBtn.TabIndex = 3;
            refreshBtn.Text = "Yenile/Tekrar Yükle";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(ucakEkleControl1);
            panel1.Controls.Add(addDataBtn);
            panel1.Location = new Point(845, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 615);
            panel1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Uçak Kayıt";
            // 
            // ucakEkleControl1
            // 
            ucakEkleControl1.Location = new Point(0, 18);
            ucakEkleControl1.Name = "ucakEkleControl1";
            ucakEkleControl1.Size = new Size(248, 361);
            ucakEkleControl1.TabIndex = 0;
            // 
            // persYonetmTab
            // 
            persYonetmTab.Controls.Add(qinfLbl2);
            persYonetmTab.Controls.Add(refreshBtn2);
            persYonetmTab.Controls.Add(persDataGrid);
            persYonetmTab.Controls.Add(panel2);
            persYonetmTab.Location = new Point(4, 24);
            persYonetmTab.Name = "persYonetmTab";
            persYonetmTab.Padding = new Padding(3);
            persYonetmTab.Size = new Size(1099, 627);
            persYonetmTab.TabIndex = 1;
            persYonetmTab.Text = "Personel Yönetimi";
            persYonetmTab.UseVisualStyleBackColor = true;
            // 
            // qinfLbl2
            // 
            qinfLbl2.AutoSize = true;
            qinfLbl2.Location = new Point(8, 606);
            qinfLbl2.Name = "qinfLbl2";
            qinfLbl2.Size = new Size(93, 15);
            qinfLbl2.TabIndex = 6;
            qinfLbl2.Text = "Sunucu çalışıyor";
            // 
            // refreshBtn2
            // 
            refreshBtn2.Location = new Point(711, 100);
            refreshBtn2.Name = "refreshBtn2";
            refreshBtn2.Size = new Size(128, 26);
            refreshBtn2.TabIndex = 5;
            refreshBtn2.Text = "Yenile/Tekrar Yükle";
            refreshBtn2.UseVisualStyleBackColor = true;
            refreshBtn2.Click += refreshBtn2_Click;
            // 
            // persDataGrid
            // 
            persDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            persDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            persDataGrid.Location = new Point(6, 132);
            persDataGrid.Name = "persDataGrid";
            persDataGrid.ReadOnly = true;
            persDataGrid.Size = new Size(833, 471);
            persDataGrid.TabIndex = 4;
            persDataGrid.CellMouseDown += persDataGrid_CellMouseDown;
            // 
            // panel2
            // 
            panel2.Controls.Add(atMeydancbx);
            panel2.Controls.Add(uzmanlikTbx);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(persAdtbx);
            panel2.Controls.Add(prsEkleBtn);
            panel2.Location = new Point(845, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 615);
            panel2.TabIndex = 3;
            // 
            // atMeydancbx
            // 
            atMeydancbx.FormattingEnabled = true;
            atMeydancbx.Location = new Point(3, 76);
            atMeydancbx.Name = "atMeydancbx";
            atMeydancbx.Size = new Size(121, 23);
            atMeydancbx.TabIndex = 4;
            // 
            // uzmanlikTbx
            // 
            uzmanlikTbx.Location = new Point(3, 47);
            uzmanlikTbx.Name = "uzmanlikTbx";
            uzmanlikTbx.Size = new Size(242, 23);
            uzmanlikTbx.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 2;
            label1.Text = "Personel Kayıt";
            // 
            // persAdtbx
            // 
            persAdtbx.Location = new Point(3, 18);
            persAdtbx.Name = "persAdtbx";
            persAdtbx.Size = new Size(160, 23);
            persAdtbx.TabIndex = 1;
            // 
            // prsEkleBtn
            // 
            prsEkleBtn.Location = new Point(159, 126);
            prsEkleBtn.Name = "prsEkleBtn";
            prsEkleBtn.Size = new Size(86, 28);
            prsEkleBtn.TabIndex = 0;
            prsEkleBtn.Text = "Oluştur";
            prsEkleBtn.UseVisualStyleBackColor = true;
            prsEkleBtn.Click += prsEkleBtn_Click;
            // 
            // yontimCtxMenu
            // 
            yontimCtxMenu.Items.AddRange(new ToolStripItem[] { kaydıSilToolStripMenuItem, kaydıDüzenleToolStripMenuItem });
            yontimCtxMenu.Name = "yontimCtxMenu";
            yontimCtxMenu.Size = new Size(149, 48);
            // 
            // kaydıSilToolStripMenuItem
            // 
            kaydıSilToolStripMenuItem.Name = "kaydıSilToolStripMenuItem";
            kaydıSilToolStripMenuItem.Size = new Size(148, 22);
            kaydıSilToolStripMenuItem.Text = "Kaydı Sil";
            kaydıSilToolStripMenuItem.Click += kaydıSilToolStripMenuItem_Click;
            // 
            // kaydıDüzenleToolStripMenuItem
            // 
            kaydıDüzenleToolStripMenuItem.Name = "kaydıDüzenleToolStripMenuItem";
            kaydıDüzenleToolStripMenuItem.Size = new Size(148, 22);
            kaydıDüzenleToolStripMenuItem.Text = "Kaydı Düzenle";
            kaydıDüzenleToolStripMenuItem.Click += kaydıDüzenleToolStripMenuItem_Click;
            // 
            // YonetimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 655);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "YonetimForm";
            Text = "Yönetim Paneli";
            Load += YonetimForm_Load;
            ((System.ComponentModel.ISupportInitialize)ucakDataGrid).EndInit();
            tabControl1.ResumeLayout(false);
            filoYonetmTab.ResumeLayout(false);
            filoYonetmTab.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            persYonetmTab.ResumeLayout(false);
            persYonetmTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)persDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            yontimCtxMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ucakDataGrid;
        private Button addDataBtn;
        private TabControl tabControl1;
        private TabPage persYonetmTab;
        private TabPage filoYonetmTab;
        private Panel panel1;
        private Forms.ucakEkleControl ucakEkleControl1;
        private Button refreshBtn;
        private Panel panel2;
        private DataGridView persDataGrid;
        private Button refreshBtn2;
        private TextBox persAdtbx;
        private Button prsEkleBtn;
        private Label label1;
        private TextBox uzmanlikTbx;
        private ComboBox atMeydancbx;
        private Label label2;
        private Label qinfLbl1;
        private Label qinfLbl2;
        private ContextMenuStrip yontimCtxMenu;
        private ToolStripMenuItem kaydıSilToolStripMenuItem;
        private ToolStripMenuItem kaydıDüzenleToolStripMenuItem;
    }
}