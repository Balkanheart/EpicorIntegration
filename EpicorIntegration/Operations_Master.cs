using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epicor.Mfg.BO;
using Epicor.Mfg.Core;
using Epicor.Mfg.Lib;

namespace EpicorIntegration
{
    public partial class Operations_Master : Form
    {
        public Operations_Master()
        {
            InitializeComponent();
        }

        private void Operations_Master_Load(object sender, EventArgs e)
        {
            BOReader BOReader = new BOReader(DataList.EpicConn);

            try
            {
                bool morePages;

                OpMaster OpMaster = new Epicor.Mfg.BO.OpMaster(DataList.EpicConn);

                DataSet ds = (DataSet)OpMaster.GetRows("OpMaster.OpType <> 'MNT' BY OpDesc", "", "", "", "", "", 100, 0, out morePages);

                comboBox1.DataSource = ds;

            }
            catch
            {

                MessageBox.Show("hey");
            }

            DataList.EpicClose();

        }
    }
}
