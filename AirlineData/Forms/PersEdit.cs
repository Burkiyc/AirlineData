using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineData.Forms
{
    public partial class PersEdit : EditRecord
    {
        public PersEdit()
        {
            InitializeComponent();
        }
        public override void okBtn_Click(object sender, EventArgs e)
        {
            base.okBtn_Click(sender, e);


        }
    }
}
