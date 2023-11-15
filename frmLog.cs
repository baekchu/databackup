using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Backup
{
    public partial class frmLog : Form
    {
        public frmLog()
        {
            InitializeComponent();
        }

        private void frmLog_Load(object sender, EventArgs e)
        {

        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            RichTextBox rtb = (RichTextBox)sender;
            if (rtb.Lines.Length > 1000)
                rtb.Clear();
        }

        private void frmLog_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Visible = false;
        }
    }
}
