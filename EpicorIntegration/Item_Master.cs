using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epicor.Mfg.Core;
using Epicor.Mfg.BO;
using EpicorIntegration.Properties;

namespace EpicorIntegration
{
    public partial class Item_Master : Form
    {
        public Item_Master()
        {
            InitializeComponent();
        }

        private void Item_Master_Load(object sender, EventArgs e)
        {
            string user = Resources.ResourceManager.GetString("user");

            string passw = Resources.ResourceManager.GetString("passw");

            string svrname = Resources.ResourceManager.GetString("svrname");

            string svrport = Resources.ResourceManager.GetString("svrport");

            BLConnectionPool EpicConn = new BLConnectionPool(user,passw,"AppServerDC://" + svrname + ":" + svrport);

            Part EpicPart = new Part(EpicConn);
        }
    }
}
