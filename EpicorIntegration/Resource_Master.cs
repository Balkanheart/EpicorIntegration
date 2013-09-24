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
        public void FormStart()
        {
            DataSet ds = DataList.ResourceGroup();

            resourcegrp_cbo.DataSource = ds.Tables[0];

            resourcegrp_cbo.ValueMember = ds.Tables[0].Columns["ResourceGrpID"].ToString();

            resourcegrp_cbo.DisplayMember = ds.Tables[0].Columns["Description"].ToString();

            resourcegrp_cbo.Invalidate();

            resourcegrp_cbo.Update();

            resourcegrp_cbo.Refresh();
        }

        public Resource_Master(string PartNumber, string Rev, string GroupID, string Operation,EngWorkBenchDataSet EngWBDS)
        {
            InitializeComponent();

            FormStart();
        }

        private void Resource_Master_Load(object sender, EventArgs e)
        {

        }

        private void resourcegrp_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = DataList.Resource(resourcegrp_cbo.SelectedValue.ToString());

            resource_cbo.DataSource = ds.Tables[0];

            resource_cbo.DisplayMember = ds.Tables[0].Columns["Description"].ToString();

            resource_cbo.ValueMember = ds.Tables[0].Columns["ResourceID"].ToString();
        }
    }
}
