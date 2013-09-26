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
    public partial class Resource_Master : Form
    {
        private EngWorkBench EngWB = new EngWorkBench(DataList.EpicConn);

        /// <summary>
        /// List of original indicides of shown data (to correctly edit inside of dataset)
        /// </summary>
        private List<int> indicies = new List<int>();

        private int MaxIndex = new int();

        public EngWorkBenchDataSet EngWB_DS;

        public void FormStart()
        {
            DataSet ds = DataList.ResourceGroup();

            resourcegrp_cbo.DataSource = ds.Tables[0];

            resourcegrp_cbo.ValueMember = ds.Tables[0].Columns["ResourceGrpID"].ToString();

            resourcegrp_cbo.DisplayMember = ds.Tables[0].Columns["Description"].ToString();

            ds = DataList.Resource(resourcegrp_cbo.SelectedValue.ToString());

            DataRow dr = ds.Tables[0].NewRow();

            dr["Description"] = "";

            dr["ResourceID"] = "";

            ds.Tables[0].Rows.InsertAt(dr,0);

            resource_cbo.DataSource = ds.Tables[0];

            resource_cbo.DisplayMember = ds.Tables[0].Columns["Description"].ToString();

            resource_cbo.ValueMember = ds.Tables[0].Columns["ResourceID"].ToString();
        }

        public Resource_Master(string PartNumber, string Rev, string GroupID, string Operation,EngWorkBenchDataSet EngWBDS)
        {
            InitializeComponent();

            FormStart();

            partnumber_txt.Text = PartNumber;

            rev_txt.Text = Rev;

            gid_txt.Text = GroupID;

            operation_txt.Text = Operation;

            EngWB_DS = EngWBDS;

            DataView DV = EngWB_DS.Tables["ECOOpDtl"].DefaultView;

            ResourceGrid.DataSource = DV;

            MaxIndex = ResourceGrid.Rows.Count;

            for (int i = 0; i < ResourceGrid.Rows.Count; i++)
            {
                if (operation_txt.Text == ResourceGrid["OprSeq", i].Value.ToString())
                    indicies.Add(i);
            }

            DV.RowFilter = string.Format("OprSeq = " + operation_txt.Text);
        }

        public Resource_Master()
        {
            InitializeComponent();

            FormStart();
        }

        private void Resource_Master_Load(object sender, EventArgs e)
        {
            ResourceGrid.SelectionChanged += ResourceGrid_SelectionChanged;

            ResourceGrid.AutoGenerateColumns = false;
        }

        void ResourceGrid_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                string CurrentGroup = ResourceGrid["ResourceGrpID", ResourceGrid.CurrentCellAddress.Y].Value.ToString();

                string CurrentRes = ResourceGrid["ResourceID", ResourceGrid.CurrentCellAddress.Y].Value.ToString();

                resourcegrp_cbo.SelectedValue = CurrentGroup;

                resource_cbo.SelectedValue = CurrentRes;
            }
            catch { }
        }

        private void resourcegrp_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Fill Resource list

            DataSet ds = DataList.Resource(resourcegrp_cbo.SelectedValue.ToString());

            DataRow dr = ds.Tables[0].NewRow();

            dr["Description"] = "";

            dr["ResourceID"] = "";

            ds.Tables[0].Rows.InsertAt(dr,0);

            resource_cbo.DataSource = ds.Tables[0];

            resource_cbo.DisplayMember = ds.Tables[0].Columns["Description"].ToString();

            resource_cbo.ValueMember = ds.Tables[0].Columns["ResourceID"].ToString();

            #endregion

            try
            {
                EngWB_DS.Tables["ECOOpDtl"].Rows[indicies[ResourceGrid.CurrentCellAddress.Y]]["OpDtlDesc"] = resourcegrp_cbo.Text;

                EngWB_DS.Tables["ECOOpDtl"].Rows[indicies[ResourceGrid.CurrentCellAddress.Y]]["ResourceGrpID"] = resourcegrp_cbo.SelectedValue.ToString();

                EngWB_DS.Tables["ECOOpDtl"].Rows[indicies[ResourceGrid.CurrentCellAddress.Y]]["ResourceGrpDesc"] = resourcegrp_cbo.Text;
            }
            catch { }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;

            this.Close();
        }

        private void resource_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                EngWB_DS.Tables["ECOOpDtl"].Rows[indicies[ResourceGrid.CurrentCellAddress.Y]]["ResourceID"] = resource_cbo.SelectedValue.ToString();

                EngWB_DS.Tables["ECOOpDtl"].Rows[indicies[ResourceGrid.CurrentCellAddress.Y]]["ResourceDesc"] = resource_cbo.Text;
            }
            catch { }
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            EngWB.Update(EngWB_DS);
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (ResourceGrid.Rows.Count > 1)
                MessageBox.Show("No additional ECO Operation Detail is allowed. Advanced Scheduling license is required.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            else
                EngWB.GetNewECOOpDtl(EngWB_DS, gid_txt.Text, partnumber_txt.Text, rev_txt.Text, "", int.Parse(operation_txt.Text));

            indicies.Add(MaxIndex);;
        }

        private void removebtn_Click(object sender, EventArgs e)
        {
            if (ResourceGrid.Rows.Count < 2)
                MessageBox.Show("Cannot delete last resource!","Warning!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                EngWB_DS.Tables["ECOOpDtl"].Rows.RemoveAt(indicies[ResourceGrid.CurrentCellAddress.Y]);
        }
    }
}
