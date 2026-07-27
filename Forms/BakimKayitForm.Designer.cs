namespace AirlineData.Forms
{
    partial class BakimKayitForm
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
            refreshBtn2 = new Button();
            bakimDataGrid = new DataGridView();
            panel2 = new Panel();
            qprsSelBtn = new Button();
            textBox2 = new TextBox();
            generateBtn = new Button();
            textBox1 = new TextBox();
            quickInfoLbl = new Label();
            bakimContextMenu = new ContextMenuStrip(components);
            tumKayilar = new ToolStripMenuItem();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bakimDataGrid).BeginInit();
            panel2.SuspendLayout();
            bakimContextMenu.SuspendLayout();
            SuspendLayout();
            // 
            // refreshBtn2
            // 
            refreshBtn2.Location = new Point(734, 103);
            refreshBtn2.Name = "refreshBtn2";
            refreshBtn2.Size = new Size(128, 26);
            refreshBtn2.TabIndex = 8;
            refreshBtn2.Text = "Yenile/Tekrar Yükle";
            refreshBtn2.UseVisualStyleBackColor = true;
            refreshBtn2.Click += refreshBtn2_Click;
            // 
            // bakimDataGrid
            // 
            bakimDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bakimDataGrid.Location = new Point(12, 135);
            bakimDataGrid.Name = "bakimDataGrid";
            bakimDataGrid.Size = new Size(850, 489);
            bakimDataGrid.TabIndex = 7;
            bakimDataGrid.CellMouseClick += bakimDataGrid_CellMouseClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FloralWhite;
            panel2.Controls.Add(button1);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Controls.Add(qprsSelBtn);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(generateBtn);
            panel2.Controls.Add(textBox1);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(868, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 657);
            panel2.TabIndex = 6;
            // 
            // qprsSelBtn
            // 
            qprsSelBtn.Location = new Point(161, 41);
            qprsSelBtn.Name = "qprsSelBtn";
            qprsSelBtn.Size = new Size(62, 23);
            qprsSelBtn.TabIndex = 3;
            qprsSelBtn.Text = "Seç";
            qprsSelBtn.UseVisualStyleBackColor = true;
            qprsSelBtn.Click += qprsSelBtn_Click;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(11, 41);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(144, 23);
            textBox2.TabIndex = 2;
            // 
            // generateBtn
            // 
            generateBtn.Location = new Point(142, 619);
            generateBtn.Name = "generateBtn";
            generateBtn.Size = new Size(81, 26);
            generateBtn.TabIndex = 1;
            generateBtn.Text = "Oluştur";
            generateBtn.UseVisualStyleBackColor = true;
            generateBtn.Click += generateBtn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(212, 23);
            textBox1.TabIndex = 0;
            // 
            // quickInfoLbl
            // 
            quickInfoLbl.AutoSize = true;
            quickInfoLbl.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            quickInfoLbl.Location = new Point(12, 633);
            quickInfoLbl.Name = "quickInfoLbl";
            quickInfoLbl.Size = new Size(39, 15);
            quickInfoLbl.TabIndex = 9;
            quickInfoLbl.Text = "label1";
            // 
            // bakimContextMenu
            // 
            bakimContextMenu.Items.AddRange(new ToolStripItem[] { tumKayilar });
            bakimContextMenu.Name = "bakimContextMenu";
            bakimContextMenu.Size = new Size(199, 26);
            // 
            // tumKayilar
            // 
            tumKayilar.Name = "tumKayilar";
            tumKayilar.Size = new Size(198, 22);
            tumKayilar.Text = "Tüm kayıtları görüntüle";
            tumKayilar.Click += tumKayilar_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(11, 70);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(99, 23);
            dateTimePicker1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(148, 183);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 5;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // BakimKayitForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 657);
            Controls.Add(quickInfoLbl);
            Controls.Add(refreshBtn2);
            Controls.Add(bakimDataGrid);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "BakimKayitForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BakimKayitForm";
            Load += BakimKayitForm_Load;
            ((System.ComponentModel.ISupportInitialize)bakimDataGrid).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            bakimContextMenu.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button refreshBtn2;
        private DataGridView bakimDataGrid;
        private Panel panel2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button generateBtn;
        private Button qprsSelBtn;
        private Label quickInfoLbl;
        private ContextMenuStrip bakimContextMenu;
        private ToolStripMenuItem tumKayilar;
        private Button button1;
        private DateTimePicker dateTimePicker1;
    }
}