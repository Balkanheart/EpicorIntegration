using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EpicorIntegration
{
    public partial class Warehouse_Master : Form
    {
        public PartData Pdata = new PartData();

        public Warehouse_Master(PartData _Pdata)
        {
            InitializeComponent();

            Pdata = _Pdata;
        }

        private void Warehouse_Master_Load(object sender, EventArgs e)
        {
            whse_cbo.DataSource = DataList.WarehseDataSet().Tables[0];

            whse_cbo.DisplayMember = DataList.WarehseDataSet().Tables[0].Columns["Description"].ToString();

            whse_cbo.ValueMember = "WarehouseCode";
        }
    }
}
