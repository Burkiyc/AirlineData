using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AirlineData.Forms
{
    public partial class EditRecord : Form
    {
        public EditRecord()
        {
            InitializeComponent();
        }
        public EditRecord(DataTable data) : this()
        {
            this.dataTable = data;
        }
        DataTable dataTable;

        public virtual void okBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
