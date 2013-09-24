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

        public void FillProdStd()
        {
            List<ProdStdType> ProdStdDS = new List<ProdStdType>();

            ProdStdDS.Add(new ProdStdType("Minutes/Piece", "MP"));

            ProdStdDS.Add(new ProdStdType("Hours/Piece", "HP"));

            ProdStdDS.Add(new ProdStdType("Pieces/Minute", "PM"));

            ProdStdDS.Add(new ProdStdType("Pieces/Hour", "HM"));

            ProdStdDS.Add(new ProdStdType("Operations/Minute", "OM"));

            ProdStdDS.Add(new ProdStdType("Operations/Hour", "OH"));

            ProdStdDS.Add(new ProdStdType("Fixed Hours", "HR"));

            BindingSource bind = new BindingSource();

            bind.DataSource = ProdStdDS;

            prodstd_cbo.DataSource = bind;

            prodstd_cbo.DisplayMember = "Description";

            prodstd_cbo.ValueMember = "Code";

            prodstd_cbo.SelectedIndex = 0;
        }

        public Operations_Master(string PartNumber, string GroupID, string Rev)
        {
            InitializeComponent();

            OPDataGrid.AutoGenerateColumns = false;

            partnumber_txt.Text = PartNumber;

            rev_txt.Text = Rev;

            gid_txt.Text = GroupID;

            bool morePages;

            OpMaster OpMaster = new Epicor.Mfg.BO.OpMaster(DataList.EpicConn);

            DataSet ds = (DataSet)OpMaster.GetRows("", "", "", "", "", "", 100, 0, out morePages);

            opmast_cbo.DataSource = ds.Tables["OPMaster"];

            opmast_cbo.ValueMember = ds.Tables["OPMaster"].Columns["OPCode"].ToString();

            opmast_cbo.DisplayMember = ds.Tables["OPMaster"].Columns["OPDesc"].ToString();

            EngWBDS = EngWB.GetDatasetForTree(gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "", DateTime.Today, false, false);

            OPDataGrid.DataSource = EngWBDS.Tables["ECOOpr"];
            
            DataList.EpicClose();
        }

        public Operations_Master()
        {
            InitializeComponent();

            OPDataGrid.AutoGenerateColumns = false;

            bool morePages;

            OpMaster OpMaster = new Epicor.Mfg.BO.OpMaster(DataList.EpicConn);

            DataSet ds = (DataSet)OpMaster.GetRows("", "", "", "", "", "", 100, 0, out morePages);

            opmast_cbo.DataSource = ds.Tables["OPMaster"];

            opmast_cbo.ValueMember = ds.Tables["OPMaster"].Columns["OPCode"].ToString();

            opmast_cbo.DisplayMember = ds.Tables["OPMaster"].Columns["OPDesc"].ToString();

            DataList.EpicClose();
        }

        private void Operations_Master_Load(object sender, EventArgs e)
        {
            OPDataGrid.SelectionChanged += OPDataGrid_SelectionChanged;

            FillProdStd();
        }

        void OPDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string CurrentOp = OPDataGrid["OpDesc", OPDataGrid.CurrentCellAddress.Y].Value.ToString();

                string CurrentStd = (OPDataGrid["Stdformat", OPDataGrid.CurrentCellAddress.Y].Value.ToString());

                int CurrentProd = (int)double.Parse(OPDataGrid["ProdStandard", OPDataGrid.CurrentCellAddress.Y].Value.ToString());
               
                if (CurrentOp != null)
                    opmast_cbo.SelectedIndex = opmast_cbo.FindStringExact(CurrentOp);
                else
                    opmast_cbo.SelectedIndex = 1;

                if (CurrentStd != null)
                {
                    prodstd_cbo.SelectedValue = CurrentStd;
                }
                else
                    prodstd_cbo.SelectedIndex = 1;

                prodhrs_num.Value = CurrentProd;
            }
            catch { }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            DataList.EpicClose();

            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            EngWB.Update(EngWBDS);

            EngWB.ResequenceOperations(gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "", DateTime.Today, false, true, true, false);

            resource_show.Enabled = true;

            EngWBDS = EngWB.GetDatasetForTree(gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "", DateTime.Today, false, false);

            OPDataGrid.DataSource = EngWBDS.Tables["ECOOpr"];
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            EngWB.GetNewECOOpr(EngWBDS, gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "");

            int RowIndex = OPDataGrid.Rows.Count - 1;

            OPDataGrid.ClearSelection();

            OPDataGrid.CurrentCell = OPDataGrid.Rows[RowIndex].Cells[0];

            EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["OpCode"] = opmast_cbo.SelectedValue.ToString();

            EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["OpDesc"] = opmast_cbo.Text;

            EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["ProdStandard"] = prodhrs_num.Value;

            resource_show.Enabled = false;
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            int RowIndex = OPDataGrid.CurrentCell.RowIndex;

            EngWBDS.Tables["ECOOpr"].Rows[RowIndex].Delete();

            EngWB.ResequenceOperations(gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "", DateTime.Today, false, true, true, false);

            resource_show.Enabled = false;
        }

        private void refresh_btn_Click(object sender, EventArgs e)
        {
            EngWBDS = EngWB.GetDatasetForTree(gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "", DateTime.Today, false, false);

            OPDataGrid.DataSource = EngWBDS.Tables["ECOOpr"];
        }

        private void opmast_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = OPDataGrid.CurrentCell.RowIndex;

                EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["OpCode"] = opmast_cbo.SelectedValue.ToString();

                EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["OpDesc"] = opmast_cbo.Text;

                EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["ProdStandard"] = prodhrs_num.Value;

                resource_show.Enabled = false;
            }
            catch { }
        }

        private void prodhrs_num_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = OPDataGrid.CurrentCell.RowIndex;

                EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["ProdStandard"] = prodhrs_num.Value;

                resource_show.Enabled = false;
            }
            catch { }
        }

        private void resource_show_Click(object sender, EventArgs e)
        {

        }

        private void prodstd_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int RowIndex = OPDataGrid.CurrentCell.RowIndex;

                EngWBDS.Tables["ECOOpr"].Rows[RowIndex]["Stdformat"] = prodstd_cbo.SelectedItem.ToString();

                resource_show.Enabled = false;
            }
            catch { }
        }
    }
}
