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
    public partial class EpicLogin : Form
    {
        public EpicLogin()
        {
            InitializeComponent();
        }

        private void EpicLogin_Load(object sender, EventArgs e)
        {

        }

        private const int CP_NOCLOSE_BUTTON = 0x200;

	    protected override CreateParams CreateParams
	    {
            get
		    {
			    CreateParams mdiCp = base.CreateParams;
			    mdiCp.ClassStyle = mdiCp.ClassStyle | CP_NOCLOSE_BUTTON;
			    return mdiCp;
		    }
	    }

        private void Cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            //save settings to resource file then test settings to connect
        }
    }
}
