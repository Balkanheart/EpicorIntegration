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

namespace EpicorIntegration
{
    public partial class Undo_Checkout : Form
    {
        public Undo_Checkout()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void undo_btn_Click(object sender, EventArgs e)
        {
            EngWorkBench EngWB = new EngWorkBench(DataList.EpicConn);

            EngWorkBenchDataSet EngWBDS = new EngWorkBenchDataSet();

            //string Message;

            //EngWB.CheckIn("AZ", "Test12", "C", "", null, false, true, false, false, false, "Test", out Message);

            //EngWB.CheckOut("AZ", "Test12", "A", "", null, false, false, false, false, false, out Rev, out Method, out altMethodFlg);

            EngWBDS = EngWB.GetDatasetForTree(gid_txt.Text, pnum_txt.Text, rev_txt.Text, "", null, false, false);

            EngWB.UndoCheckOut(gid_txt.Text, pnum_txt.Text, rev_txt.Text, "", null, false, false, false, false, EngWBDS);

            MessageBox.Show("Complete!");
        }
    }
}
