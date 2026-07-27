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
            filoYonetmTab = new TabPage();
            refreshBtn = new Button();
            panel1 = new Panel();
            ucakEkleControl1 = new AirlineData.Forms.ucakEkleControl();
            persYonetmTab = new TabPage();
            refreshBtn2 = new Button();
            dataGridView1 = new DataGridView();
            panel2 = new Panel();
            ucakEkleControl2 = new AirlineData.Forms.ucakEkleControl();
            ((System.ComponentModel.ISupportInitialize)ucakDataGrid).BeginInit();
            tabControl1.SuspendLayout();
            filoYonetmTab.SuspendLayout();
            panel1.SuspendLayout();
            persYonetmTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // ucakDataGrid
            // 
            ucakDataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ucakDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ucakDataGrid.Location = new Point(6, 132);
            ucakDataGrid.Name = "ucakDataGrid";
            ucakDataGrid.Size = new Size(833, 489);
            ucakDataGrid.TabIndex = 0;
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
            // 
            // filoYonetmTab
            // 
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
            panel1.Controls.Add(ucakEkleControl1);
            panel1.Controls.Add(addDataBtn);
            panel1.Location = new Point(845, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 615);
            panel1.TabIndex = 2;
            // 
            // ucakEkleControl1
            // 
            ucakEkleControl1.Location = new Point(0, 0);
            ucakEkleControl1.Name = "ucakEkleControl1";
            ucakEkleControl1.Size = new Size(248, 361);
            ucakEkleControl1.TabIndex = 0;
            // 
            // persYonetmTab
            // 
            persYonetmTab.Controls.Add(refreshBtn2);
            persYonetmTab.Controls.Add(dataGridView1);
            persYonetmTab.Controls.Add(panel2);
            persYonetmTab.Location = new Point(4, 24);
            persYonetmTab.Name = "persYonetmTab";
            persYonetmTab.Padding = new Padding(3);
            persYonetmTab.Size = new Size(1099, 627);
            persYonetmTab.TabIndex = 1;
            persYonetmTab.Text = "Personel Yönetimi";
            persYonetmTab.UseVisualStyleBackColor = true;
            // 
            // refreshBtn2
            // 
            refreshBtn2.Location = new Point(711, 100);
            refreshBtn2.Name = "refreshBtn2";
            refreshBtn2.Size = new Size(128, 26);
            refreshBtn2.TabIndex = 5;
            refreshBtn2.Text = "Yenile/Tekrar Yükle";
            refreshBtn2.UseVisualStyleBackColor = true;
            refreshBtn2.Click += refreshBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 132);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(833, 489);
            dataGridView1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(ucakEkleControl2);
            panel2.Location = new Point(845, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(248, 615);
            panel2.TabIndex = 3;
            // 
            // ucakEkleControl2
            // 
            ucakEkleControl2.Location = new Point(0, 0);
            ucakEkleControl2.Name = "ucakEkleControl2";
            ucakEkleControl2.Size = new Size(228, 275);
            ucakEkleControl2.TabIndex = 0;
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
            filoYonetmTab.ResumeLayout(false);
            panel1.ResumeLayout(false);
            persYonetmTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
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
        private DataGridView dataGridView1;
        private Button refreshBtn2;
        private Forms.ucakEkleControl ucakEkleControl2;
    }
}