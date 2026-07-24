namespace AirlineData
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataTableA = new DataGridView();
            panel1 = new Panel();
            FiloYonetimiBtn = new Button();
            button1 = new Button();
            tableSelCbx = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataTableA).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataTableA
            // 
            dataTableA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataTableA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataTableA.Location = new Point(12, 41);
            dataTableA.Name = "dataTableA";
            dataTableA.Size = new Size(965, 557);
            dataTableA.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(FiloYonetimiBtn);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(983, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(144, 680);
            panel1.TabIndex = 1;
            // 
            // FiloYonetimiBtn
            // 
            FiloYonetimiBtn.Location = new Point(13, 12);
            FiloYonetimiBtn.Name = "FiloYonetimiBtn";
            FiloYonetimiBtn.Size = new Size(119, 33);
            FiloYonetimiBtn.TabIndex = 1;
            FiloYonetimiBtn.Text = "Filo Yönetimi";
            FiloYonetimiBtn.UseVisualStyleBackColor = true;
            FiloYonetimiBtn.Click += HvyoluYonetmiBtn_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(13, 635);
            button1.Name = "button1";
            button1.Size = new Size(119, 33);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // tableSelCbx
            // 
            tableSelCbx.FormattingEnabled = true;
            tableSelCbx.ItemHeight = 15;
            tableSelCbx.Location = new Point(66, 12);
            tableSelCbx.Name = "tableSelCbx";
            tableSelCbx.Size = new Size(202, 23);
            tableSelCbx.TabIndex = 2;
            tableSelCbx.SelectedIndexChanged += tableSelCbx_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Kaynak:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1127, 680);
            Controls.Add(label1);
            Controls.Add(tableSelCbx);
            Controls.Add(panel1);
            Controls.Add(dataTableA);
            Name = "Form1";
            ShowIcon = false;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataTableA).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataTableA;
        private Panel panel1;
        private Button button1;
        private ComboBox tableSelCbx;
        private Label label1;
        private Button FiloYonetimiBtn;
    }
}
