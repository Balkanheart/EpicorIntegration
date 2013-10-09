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
        private bool linechanged = false;
        
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

            ops_cbo.SelectedValue = "10";

            BillDataGrid.DataSource = EngWBDS.Tables["ECOMtl"];

            this.FormClosing += Bill_Master_FormClosing;
        }

        void Bill_Master_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                foreach (DataRow dr in EngWBDS.Tables["ECOMtl"].Rows)
                {
                    if (dr.RowState == DataRowState.Modified)
                    {
                        DialogResult DR = MessageBox.Show("Throw away unsaved changes?", "Save?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (DR == DialogResult.Yes)
                            SaveChanges();
                        else
                            return;
                    }
                }

                return;
            }
            catch { return; }
        }

        private void SaveChanges()
        {
            string opMessage;

            string opMsgType;

            foreach (DataRow DR in EngWBDS.Tables["ECOMtl"].Rows)
            {
                if (DR.RowState == DataRowState.Modified)
                {
                    //Validate all data

                    string partnumber = DR["MtlPartNum"].ToString();

                    string ops = DR["RelatedOperation"].ToString();

                    string mtlseq = DR["MtlSeq"].ToString();

                    EngWB.ChangeECOMtlQtyPer(EngWBDS);

                    EngWB.ChangeECOMtlRelatedOperation(int.Parse(ops), EngWBDS);

                    EngWB.CheckECOMtlMtlPartNum(partnumber, out opMessage, out opMsgType, EngWBDS);

                    EngWB.CheckECOMtlMtlSeqRelatedOperation(int.Parse(mtlseq), int.Parse(ops), "", out opMessage, out opMsgType, EngWBDS);

                    EngWB.ChangeECOMtlMtlPartNum(EngWBDS);
                }
            }
            //Still needs to correctly target billdatagrid fields

            EngWB.Update(EngWBDS);

            EngWB.ResequenceMaterials(gid_txt.Text, parent_txt.Text, parentrev_txt.Text, "", null, false, Properties.Settings.Default.mtlreqtype, false, false, false);

            EngWB.Update(EngWBDS);
        }

        void partnum_txt_Leave(object sender, EventArgs e)
        {
            if (linechanged)
            {
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

                    DataTable ds = DataList.PartUOM(partnum_txt.Text);

                    uom_cbo.DataSource = ds;

                    uom_cbo.DisplayMember = "UOMCode";

                    uom_cbo.ValueMember = "UOMCode";

                    linechanged = false;

                    //ViewAsAsm_chk.Checked = IsAssembly();
                }
            }
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

            BillDataGrid.ClearSelection();

            BillDataGrid.CurrentCell = BillDataGrid.Rows[0].Cells[0];
        }

        void BillDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            linechanged = false;

            UpdateFormFields();
        }

        private void newbtn_Click(object sender, EventArgs e)
        {
            EngWB.GetNewECOMtl(EngWBDS, gid_txt.Text, parent_txt.Text, parentrev_txt.Text, "");

            int rowindex = BillDataGrid.Rows.Count - 1;

            BillDataGrid.ClearSelection();

            BillDataGrid.CurrentCell = BillDataGrid.Rows[rowindex].Cells[0];

            ops_cbo.SelectedIndex = 0;

            EngWBDS.Tables["ECOMtl"].Rows[rowindex]["RelatedOperation"] = ops_cbo.SelectedValue;

            partnum_txt.Text = "";

            EngWBDS.Tables["ECOMtl"].Rows[rowindex]["QtyPer"] = 1;

            //EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNum"] = partnum_txt.Text;

            EngWBDS.Tables["ECOMtl"].Rows[rowindex]["UOMCode"] = uom_cbo.Text;
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            SaveChanges();
        }

        private bool IsAssembly()
        {
            bool retval = false;

            string currentrev = DataList.GetCurrentRev(partnum_txt.Text);

            EngWorkBenchDataSet temp = new EngWorkBenchDataSet();

            if (temp.Tables[0].Rows.Count > 0)
                    retval = true;

            return retval;
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            int rowindex = BillDataGrid.CurrentCellAddress.Y;

            EngWBDS.Tables["ECOMtl"].Rows[rowindex].Delete();

            //EngWB.Update(EngWBDS);

            //EngWBDS = EngWB.GetDatasetForTree(gid_txt.Text, parent_txt.Text, parentrev_txt.Text, "", null, false, false);

            //BillDataGrid.DataSource = EngWBDS.Tables["ECOMtl"];
        }

        private void copy_btn_Click(object sender, EventArgs e)
        {

        }

        private void UpdateDataSet()
        {
            if (linechanged)
            {
                int rowindex = BillDataGrid.CurrentCellAddress.Y;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["ViewAsAsm"] = ViewAsAsm_chk.Checked;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNum"] = partnum_txt.Text;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["RelatedOperation"] = ops_cbo.SelectedValue;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["OpDesc"] = EngWBDS.Tables["ECOOpr"].Rows[ops_cbo.SelectedIndex]["OpDesc"];

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["UOMCode"] = uom_cbo.Text;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNumPartDescription"] = desc_txt.Text;

                EngWBDS.Tables["ECOMtl"].Rows[rowindex]["QtyPer"] = qty_num.Value;

                linechanged = false;
            }
        }

        private void UpdateFormFields()
        {
            if (!linechanged)
            {
                qty_num.ValueChanged -= qty_num_ValueChanged;

                partnum_txt.TextChanged -= partnum_txt_TextChanged;

                ViewAsAsm_chk.CheckedChanged -= ViewAsAsm_chk_CheckedChanged;

                uom_cbo.SelectedIndexChanged -= uom_cbo_SelectedIndexChanged;

                ops_cbo.SelectedIndexChanged -= ops_cbo_SelectedIndexChanged;

                int rowindex = BillDataGrid.CurrentCellAddress.Y;

                mtlseq_txt.Text = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlSeq"].ToString();

                qty_num.Value = int.Parse(EngWBDS.Tables["ECOMtl"].Rows[rowindex]["QtyPer"].ToString());

                partnum_txt.Text = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNum"].ToString();

                desc_txt.Text = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNumPartDescription"].ToString();

                ops_cbo.SelectedValue = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["RelatedOperation"].ToString();

                partnum_txt.Text = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNum"].ToString();

                DataTable ds = DataList.PartUOM(partnum_txt.Text);

                uom_cbo.DataSource = ds;

                uom_cbo.DisplayMember = "UOMCode";

                uom_cbo.ValueMember = "UOMCode";

                uom_cbo.Text = EngWBDS.Tables["ECOMtl"].Rows[rowindex]["UOMCode"].ToString();

                ViewAsAsm_chk.Checked = Boolean.Parse(EngWBDS.Tables["ECOMtl"].Rows[rowindex]["ViewAsAsm"].ToString());

                linechanged = true;

                qty_num.ValueChanged += qty_num_ValueChanged;

                partnum_txt.TextChanged += partnum_txt_TextChanged;

                ViewAsAsm_chk.CheckedChanged += ViewAsAsm_chk_CheckedChanged;

                uom_cbo.SelectedIndexChanged += uom_cbo_SelectedIndexChanged;

                ops_cbo.SelectedIndexChanged += ops_cbo_SelectedIndexChanged;
            }
        }

        private void PartTimer_Tick(object sender, EventArgs e)
        {
            string opMessage;

            string opMsgType;

            try
            {
                if (partnum_txt.Text != "")
                {
                    PartTimer.Enabled = false;

                    UpdateDescField();

                    UpdateUOM();

                    //EngWBDS.Tables["ECOMtl"].Rows[rowindex]["MtlPartNum"] = partnum_txt.Text;

                    //EngWB.CheckECOMtlMtlPartNum(partnum_txt.Text, out opMessage, out opMsgType, EngWBDS);

                    //EngWB.ChangeECOMtlMtlPartNum(EngWBDS);

                    UpdateDataSet();
                }
            }
            catch { desc_txt.Text = ""; }
        }

        private void UpdateUOM()
        {
            DataTable ds = DataList.PartUOM(partnum_txt.Text);

            uom_cbo.DataSource = ds;

            uom_cbo.DisplayMember = "UOMCode";

            uom_cbo.ValueMember = "UOMCode";
        }

        private void UpdateDescField()
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
            catch { desc_txt.Text = ""; }
        }

        private void partnum_txt_TextChanged(object sender, EventArgs e)
        {
            linechanged = true;

            UpdateDescField();

            UpdateDataSet();

            //PartTimer.Enabled = true;
        }

        private void ViewAsAsm_chk_CheckedChanged(object sender, EventArgs e)
        {
            linechanged = true;

            UpdateDataSet();
        }

        private void uom_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            linechanged = true;

            UpdateDataSet();
        }

        private void qty_num_ValueChanged(object sender, EventArgs e)
        {
            linechanged = true;

            UpdateDataSet();
        }

        private void ops_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            linechanged = true;

            UpdateDataSet();
        }
    }
}
