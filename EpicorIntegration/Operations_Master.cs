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
        private EngWorkBench EngWB = new EngWorkBench(DataList.EpicConn);

        private EngWorkBenchDataSet _EngWBDS = new EngWorkBenchDataSet();

        private EngWorkBenchDataSet EngWBDS
        {
            get { return _EngWBDS; }
            set { _EngWBDS = value; }
        }

        public Operations_Master(string PartNumber, string GroupID, string Rev)
        {
            InitializeComponent();

            partnumber_txt.Text = PartNumber;

            rev_txt.Text = Rev;

            gid_txt.Text = GroupID;

            bool morePages;

            OpMaster OpMaster = new Epicor.Mfg.BO.OpMaster(DataList.EpicConn);

            DataSet ds = (DataSet)OpMaster.GetRows("", "", "", "", "", "", 100, 0, out morePages);

            opmast_cbo.DataSource = ds.Tables["OPMaster"];

            opmast_cbo.ValueMember = ds.Tables["OPMaster"].Columns["OPCode"].ToString();

            opmast_cbo.DisplayMember = ds.Tables["OPMaster"].Columns["OPDesc"].ToString();

            opnum_txt.Text = GetNextOp().ToString();

            EngWBDS = EngWB.GetDatasetForTree(gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "", DateTime.Today, false, false);

            OPDataGrid.DataSource = EngWBDS.Tables["ECOOpr"];
            
            DataList.EpicClose();
        }

        public Operations_Master()
        {
            InitializeComponent();

            bool morePages;

            OpMaster OpMaster = new Epicor.Mfg.BO.OpMaster(DataList.EpicConn);

            DataSet ds = (DataSet)OpMaster.GetRows("", "", "", "", "", "", 100, 0, out morePages);

            opmast_cbo.DataSource = ds.Tables["OPMaster"];

            opmast_cbo.ValueMember = ds.Tables["OPMaster"].Columns["OPCode"].ToString();

            opmast_cbo.DisplayMember = ds.Tables["OPMaster"].Columns["OPDesc"].ToString();

            opnum_txt.Text = GetNextOp().ToString();

            DataList.EpicClose();
        }

        private void Operations_Master_Load(object sender, EventArgs e)
        {


        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            DataList.EpicClose();

            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            EngWB.Update(EngWBDS);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            EngWB.GetNewECOOpr(EngWBDS, gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "");

            int RowIndex = OPDataGrid.Rows.Count - 1;

            EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["OpCode"] = opmast_cbo.SelectedValue.ToString();

            EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["OpDesc"] = opmast_cbo.Text;


        }

        private void removebtn_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EngWBDS = EngWB.GetDatasetForTree(gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "", DateTime.Today, false, false);

            OPDataGrid.DataSource = EngWBDS.Tables["ECOOpr"];
        }
    }
}
