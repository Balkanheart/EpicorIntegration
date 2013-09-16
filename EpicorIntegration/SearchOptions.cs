using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicorIntegration
{
    public partial class SearchOptions : Form
    {
        public SearchOptions()
        {
            InitializeComponent();

            allresults.Checked = Properties.Settings.Default.allresults;

            rowlimit_txt.Text = Properties.Settings.Default.linelimit.ToString();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.allresults = allresults.Checked;

            Properties.Settings.Default.linelimit = (int)double.Parse(rowlimit_txt.Text);

            Properties.Settings.Default.Save();

            this.Close();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void allresults_CheckedChanged(object sender, EventArgs e)
        {
            rowlimit_txt.ReadOnly = allresults.Checked;
        }
    }
}
