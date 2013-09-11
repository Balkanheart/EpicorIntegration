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
    public partial class Revision_Master : Form
    {
        public Revision_Master()
        {
            InitializeComponent();

            DataList DL = new DataList();

            gid_cbo.DataSource = DL.GroupIDDataSet().Tables[0];

            gid_cbo.ValueMember = "Description";

            gid_cbo.DisplayMember = "GroupID";
        }

        private void gid_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gid_desc.Text = gid_cbo.SelectedValue.ToString();
        }

        private void Revision_Master_Load(object sender, EventArgs e)
        {
            gid_cbo_SelectedIndexChanged(null, null);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //Not sure if I want to include changes from this form or add buttons to make changes...
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
