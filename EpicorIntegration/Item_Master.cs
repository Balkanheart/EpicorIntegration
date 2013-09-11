using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Epicor.Mfg.Core;
using Epicor.Mfg.BO;
using EpicorIntegration.Properties;
using Epicor.Mfg.Lib;

namespace EpicorIntegration
{
    public partial class Item_Master : Form
    {
        public Item_Master()
        {
            InitializeComponent();
        }

        private void Item_Master_Load(object sender, EventArgs e)
        {
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            try
            {

                DataList DL = new DataList();

                group_cbo.DataSource = DL.ProdGrupDataSet ().Tables[0];

                group_cbo.DisplayMember = "Description";

                class_cbo.DataSource = DL.PartClassDataSet().Tables[0];

                class_cbo.DisplayMember = "Description";

                uomclass_cbo.DataSource = DL.UOMClassDataSet().Tables[0];

                uomclass_cbo.DisplayMember = "Description";

                DataSet DS = DL.UOMSearchDataSet();

                DS.Tables[0].Columns.Add("FullCode", typeof(string), "UOMCode + ' ' + UOMDesc");

                uom_cbo.DataSource = DS.Tables[0];

                uom_cbo.DisplayMember = "FullCode";

                uomclass_cbo.SelectedIndex = 2;

                type_cbo.SelectedIndex = 0;

                plant_cbo.DataSource = DL.PlantDataSet();

                plant_cbo.DisplayMember = "NAME";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nThis application will now close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }


            //Part EpicPart = new Part(EpicConn);
        }
    }
}
