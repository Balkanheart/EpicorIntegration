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
    public partial class Bill_CopyFrom : Form
    {
        private EngWorkBench EngWB = new EngWorkBench(DataList.EpicConn);

        private EngWorkBenchDataSet _EngWBDS = new EngWorkBenchDataSet();

        private EngWorkBenchDataSet EngWBDS
        {
            get { return _EngWBDS; }
            set { _EngWBDS = value; }
        }

        public Bill_CopyFrom()
        {
            InitializeComponent();
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void useselected_btn_Click(object sender, EventArgs e)
        {
            if (template_cbo.Text == "Other")
            {
                
            }
            else
            {
                //Use Template
            }
        }
    }
}
