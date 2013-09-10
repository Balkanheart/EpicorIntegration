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
using Epicor.Mfg.Lib;

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
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            BLConnectionPool EpicConn = new BLConnectionPool(user,passw,"AppServerDC://" + svrname + ":" + svrport);

            BOReader BOReader = new BOReader(EpicConn);

            bool what;

            DataSet ds = (DataSet)BOReader.GetList("Plant", "", "Company,Plant,Name,Company");

            try
            {

                TestTableViewer test = new TestTableViewer(ds);

                test.ShowDialog();
            }
            catch (System.Exception ex)
            {
                this.Close();
            }


            //Part EpicPart = new Part(EpicConn);
        }
    }
}
