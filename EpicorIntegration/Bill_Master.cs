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
    public partial class Bill_Master : Form
    {
        private EngWorkBench EngWB = new EngWorkBench(DataList.EpicConn);

        private EngWorkBenchDataSet _EngWBDS = new EngWorkBenchDataSet();

        private EngWorkBenchDataSet EngWBDS
        {
            get { return _EngWBDS; }
            set { _EngWBDS = value; }
        }

        public Bill_Master()
        {
            InitializeComponent();

            BillDataGrid.AutoGenerateColumns = false;

            partnum_txt.Leave += partnum_txt_Leave;

            mtlseq_txt.Text = GetNextSeq().ToString();

            EngWBDS = EngWB.GetDatasetForTree(gid_txt.Text, parent_txt.Text, parentrev_txt.Text, "", null, false, false);

            EngWBDS.Tables["ECOOpr"].Columns.Add("FullCode", typeof(string), "OprSeq + ' - ' + OpDesc");

            ops_cbo.DataSource = EngWBDS.Tables["ECOOpr"];

            ops_cbo.DisplayMember = "FullCode";

            ops_cbo.ValueMember = "OprSeq";

            BillDataGrid.DataSource = EngWBDS.Tables["ECOMtl"];
        }

        void partnum_txt_Leave(object sender, EventArgs e)
        {
            try
            {
                Part Part = new Part(DataList.EpicConn);

                PartListDataSet PartList = new PartListDataSet();

                string WhereClause = "PartNum = '" + partnum_txt.Text + "'";

                int pagesize = 1;

                bool morePages;

                PartList = Part.GetList(WhereClause, pagesize, 0, out morePages);

                DataList.EpicClose();

                desc_txt.Text = PartList.Tables[0].Rows[0]["PartDescription"].ToString();

                Part = null;

                PartList.Dispose();

                PartList = null;
            }
            catch
            {
                desc_txt.Text = "";
            }
            int rowindex = BillDataGrid.CurrentCellAddress.Y;

            string cellval = BillDataGrid["MtlPartNum", rowindex].Value.ToString();

            if (cellval == "")
            {
                string opMessage;

                string opMsgType;

                string partnumber = partnum_txt.Text;

                EngWB.CheckECOMtlMtlPartNum(partnumber, out opMessage, out opMsgType, EngWBDS);
                
                rowindex = BillDataGrid.CurrentCellAddress.Y;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNum"] = partnumber;

                EngWB.ChangeECOMtlMtlPartNum(EngWBDS);
            }

            DataTable ds = DataList.PartUOM(partnum_txt.Text);

            uom_cbo.DataSource = ds;

            uom_cbo.DisplayMember = "UOMCode";

            uom_cbo.ValueMember = "UOMCode";

            //ViewAsAsm_chk.Checked = IsAssembly();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int GetNextSeq()
        {
            int rowcount = BillDataGrid.Rows.Count;

            return ++rowcount * 10;
        }

        private void findpart_btn_Click(object sender, EventArgs e)
        {
            SearchPart Searchfrm = new SearchPart("");

            Searchfrm.ShowDialog();

            if (Searchfrm.DialogResult == DialogResult.OK)
            {
                partnum_txt.Text = Searchfrm._PartNumber;

                desc_txt.Text = Searchfrm._Description;
            }

            Searchfrm.Close();

            Searchfrm.Dispose();
        }

        private void Bill_Master_Load(object sender, EventArgs e)
        {
            BillDataGrid.SelectionChanged += BillDataGrid_SelectionChanged;

            BillDataGrid.CellClick += BillDataGrid_CellClick;

            BillDataGrid.ClearSelection();

            BillDataGrid.CurrentCell = BillDataGrid.Rows[0].Cells[0];
        }

        void BillDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowindex = BillDataGrid.CurrentCellAddress.Y;

            qty_num.Value = int.Parse(EngWBDS.Tables["ECOMtl"].Rows[rowindex]["QtyPer"].ToString());

            partnum_txt.Text = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNum"].ToString();

            desc_txt.Text = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNumPartDescription"].ToString();

            ops_cbo.SelectedValue = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["RelatedOperation"].ToString();
        }

        void BillDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = BillDataGrid.CurrentCellAddress.Y;

            partnum_txt.Text = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNum"].ToString();

            DataTable ds = DataList.PartUOM(partnum_txt.Text);

            uom_cbo.DataSource = ds;

            uom_cbo.DisplayMember = "UOMCode";

            uom_cbo.ValueMember = "UOMCode";

            uom_cbo.Text = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["UOMCode"].ToString();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            int rowindex = BillDataGrid.CurrentCellAddress.Y;

            EngWB.GetNewECOMtl(EngWBDS, gid_txt.Text, parent_txt.Text, parentrev_txt.Text, "");

            string opMessage;

            string opMsgType;

            EngWB.CheckECOMtlMtlSeqRelatedOperation(int.Parse(mtlseq_txt.Text), int.Parse(ops_cbo.SelectedValue.ToString()), "", out opMessage, out opMsgType, EngWBDS);

            ops_cbo.SelectedIndex = 1;
            
            EngWB.ChangeECOMtlRelatedOperation(int.Parse(ops_cbo.SelectedValue.ToString()), EngWBDS);

            qty_num.Value = 1;

            EngWBDS.Tables["ECOMtl"].Rows[rowindex]["QtyPer"] = qty_num.Value;

            EngWB.ChangeECOMtlQtyPer(EngWBDS);

            EngWB.CheckECOMtlMtlPartNum(partnum_txt.Text, out opMessage, out opMsgType, EngWBDS);

            EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNum"] = partnum_txt.Text;

            EngWBDS.Tables["ECOMtl"].Rows[rowindex]["UOMCode"] = uom_cbo.Text;

            EngWB.ChangeECOMtlMtlPartNum(EngWBDS);
        }

        private void qty_num_ValueChanged(object sender, EventArgs e)
        {
            int rowindex = BillDataGrid.CurrentCellAddress.Y;

            EngWBDS.Tables["ECOMtl"].Rows[rowindex]["QtyPer"] = qty_num.Value;

            EngWB.ChangeECOMtlQtyPer(EngWBDS);
        }

        private void ops_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int rowindex = BillDataGrid.CurrentCellAddress.Y;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["RelatedOperation"] = ops_cbo.SelectedValue;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["UOMCode"] = uom_cbo.Text;
            }
            catch { }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            EngWB.Update(EngWBDS);
        }

        private void uom_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int rowindex = BillDataGrid.CurrentCellAddress.Y;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["UOMCode"] = uom_cbo.Text;
            }
            catch { }
        }

        private bool IsAssembly()
        {
            bool retval = false;

            try
            {
                string currentrev = DataList.GetCurrentRev(partnum_txt.Text);



                if (temp.Tables["ECOMtl"].Rows.Count > 0)
                    retval = true;
            }
            catch { }
            return retval;
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            int rowindex = BillDataGrid.CurrentCellAddress.Y;

            EngWBDS.Tables["ECOMtl"].Rows[rowindex].Delete();

            EngWB.Update(EngWBDS);

            EngWB.ResequenceMaterials(gid_txt.Text, parent_txt.Text, parentrev_txt.Text, "", null, false, Properties.Settings.Default.mtlreqtype, false, false, false);

            EngWBDS = EngWB.GetDatasetForTree(gid_txt.Text, parent_txt.Text, parentrev_txt.Text, "", null, false, false);

            BillDataGrid.DataSource = EngWBDS.Tables["ECOMtl"];
        }
    }
}
