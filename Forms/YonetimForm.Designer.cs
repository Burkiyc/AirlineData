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
            ucakDataGrid = new DataGridView();
            addDataBtn = new Button();
            tabControl1 = new TabControl();
            PersYonetmTab = new TabPage();
            filoYonetimTab = new TabPage();
            ucakEkleBtn = new Button();
            dataGridView1 = new DataGridView();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)ucakDataGrid).BeginInit();
            tabControl1.SuspendLayout();
            PersYonetmTab.SuspendLayout();
            filoYonetimTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ucakDataGrid
            // 
            ucakDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucakDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ucakDataGrid.Location = new Point(8, 130);
            ucakDataGrid.Name = "ucakDataGrid";
            ucakDataGrid.Size = new Size(831, 489);
            ucakDataGrid.TabIndex = 0;
            // 
            // addDataBtn
            // 
            addDataBtn.Location = new Point(8, 93);
            addDataBtn.Name = "addDataBtn";
            addDataBtn.Size = new Size(87, 31);
            addDataBtn.TabIndex = 1;
            addDataBtn.Text = "Ekle";
            addDataBtn.UseVisualStyleBackColor = true;
            addDataBtn.Click += addDataBtn_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(PersYonetmTab);
            tabControl1.Controls.Add(filoYonetimTab);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1107, 655);
            tabControl1.TabIndex = 2;
            // 
            // PersYonetmTab
            // 
            PersYonetmTab.Controls.Add(panel1);
            PersYonetmTab.Controls.Add(ucakDataGrid);
            PersYonetmTab.Controls.Add(addDataBtn);
            PersYonetmTab.Location = new Point(4, 24);
            PersYonetmTab.Name = "PersYonetmTab";
            PersYonetmTab.Padding = new Padding(3);
            PersYonetmTab.Size = new Size(1099, 627);
            PersYonetmTab.TabIndex = 0;
            PersYonetmTab.Text = "Personel Yönetimi";
            PersYonetmTab.UseVisualStyleBackColor = true;
            // 
            // filoYonetimTab
            // 
            filoYonetimTab.Controls.Add(ucakEkleBtn);
            filoYonetimTab.Controls.Add(dataGridView1);
            filoYonetimTab.Location = new Point(4, 24);
            filoYonetimTab.Name = "filoYonetimTab";
            filoYonetimTab.Padding = new Padding(3);
            filoYonetimTab.Size = new Size(1031, 609);
            filoYonetimTab.TabIndex = 1;
            filoYonetimTab.Text = "Filo Yönetimi";
            filoYonetimTab.UseVisualStyleBackColor = true;
            // 
            // ucakEkleBtn
            // 
            ucakEkleBtn.Location = new Point(8, 54);
            ucakEkleBtn.Name = "ucakEkleBtn";
            ucakEkleBtn.Size = new Size(88, 31);
            ucakEkleBtn.TabIndex = 2;
            ucakEkleBtn.Text = "Uçak Ekle";
            ucakEkleBtn.UseVisualStyleBackColor = true;
            ucakEkleBtn.Click += ucakEkleBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(8, 91);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1015, 510);
            dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.Location = new Point(845, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 615);
            panel1.TabIndex = 2;
            // 
            // YonetimForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 655);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "YonetimForm";
            ShowIcon = false;
            Text = "Yönetim Paneli";
            Load += YonetimForm_Load;
            ((System.ComponentModel.ISupportInitialize)ucakDataGrid).EndInit();
            tabControl1.ResumeLayout(false);
            PersYonetmTab.ResumeLayout(false);
            filoYonetimTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ucakDataGrid;
        private Button addDataBtn;
        private TabControl tabControl1;
        private TabPage filoYonetimTab;
        private DataGridView dataGridView1;
        private TabPage PersYonetmTab;
        private Button ucakEkleBtn;
        private Panel panel1;
    }
}