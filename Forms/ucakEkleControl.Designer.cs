namespace AirlineData.Forms
{
    partial class ucakEkleControl
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
            textBox1 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.CharacterCasing = CharacterCasing.Upper;
            textBox1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(112, 24);
            textBox1.TabIndex = 0;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Font = new Font("Segoe UI", 9.5F);
            numericUpDown1.Location = new Point(3, 62);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(89, 24);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(3, 33);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 91);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(112, 23);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 149);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(112, 23);
            textBox4.TabIndex = 5;
            textBox4.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(3, 120);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(112, 23);
            comboBox1.TabIndex = 6;
            // 
            // ucakEkleControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox1);
            Name = "ucakEkleControl";
            Size = new Size(228, 275);
            Load += ucakEkleControl_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private NumericUpDown numericUpDown1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private ComboBox comboBox1;
    }
}
