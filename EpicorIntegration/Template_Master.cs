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
    public partial class Template_Master : Form
    {
        public Template_Master()
        {
            InitializeComponent();

            #region Fill DataLists

            type_cbo.Items.Add(new PartTypeCode("", ""));

            type_cbo.Items.Add(new PartTypeCode("Manufactured", "M"));

            type_cbo.Items.Add(new PartTypeCode("Purchased", "P"));

            type_cbo.Items.Add(new PartTypeCode("Sales Kit", "K"));

            type_cbo.DisplayMember = "Description";

            DataTable dt = DataList.ProdGrupDataSet().Tables[0];

            DataRow dr = dt.NewRow();

            dr["Description"] = "";

            dt.Rows.InsertAt(dr, 0);

            group_cbo.DataSource = dt;

            group_cbo.DisplayMember = "Description";

            group_cbo.ValueMember = "ProdCode";

            dt = DataList.PartClassDataSet().Tables[0];

            dr = dt.NewRow();

            dr["Description"] = "";

            dt.Rows.InsertAt(dr, 0);

            class_cbo.DataSource = dt;

            class_cbo.DisplayMember = DataList.PartClassDataSet().Tables[0].Columns["Description"].ToString();

            class_cbo.ValueMember = DataList.PartClassDataSet().Tables[0].Columns["ClassID"].ToString();

            dt = DataList.UOMClassDataSet().Tables[0];

            dr = dt.NewRow();

            dr["Description"] = "";

            dt.Rows.InsertAt(dr, 0);

            uomclass_cbo.DataSource = dt;

            uomclass_cbo.DisplayMember = DataList.UOMClassDataSet().Tables[0].Columns["Description"].ToString();

            dt = DataList.PlantDataSet().Tables[0];

            dr = dt.NewRow();

            dr["NAME"] = "";

            dt.Rows.InsertAt(dr, 0);

            plant_cbo.DataSource = dt;

            plant_cbo.DisplayMember = DataList.PlantDataSet().Tables[0].Columns["NAME"].ToString();

            plant_cbo.ValueMember = "Plant";

            dt = DataList.WarehseDataSet().Tables[0];

            dr = dt.NewRow();

            dr["Description"] = "";

            dt.Rows.InsertAt(dr, 0);

            whse_cbo.DataSource = dt;

            whse_cbo.DisplayMember = DataList.WarehseDataSet().Tables[0].Columns["Description"].ToString();

            whse_cbo.ValueMember = "WarehouseCode";

            DataSet DS = DataList.UOMSearchDataSet();

            DS.Tables[0].Columns.Add("FullCode", typeof(string), "UOMCode + ' - ' + UOMDesc");

            dr = DS.Tables[0].NewRow();

            dr["FullCode"] = "";

            DS.Tables[0].Rows.InsertAt(dr, 0);

            uom_cbo.DataSource = DS.Tables[0];

            uom_cbo.DisplayMember = DS.Tables[0].Columns["FullCode"].ToString();

            uom_cbo.ValueMember = "UOMCode";

            uomclass_cbo.SelectedIndex = 2;

            type_cbo.SelectedIndex = 0;

            dt = DataList.UOMVolumeDataSet().Tables[0];

            dr = dt.NewRow();

            dr["UOMCode"] = "";

            dt.Rows.InsertAt(dr, 0);

            uomvol_cbo.DataSource = dt;

            uomvol_cbo.DisplayMember = DataList.UOMVolumeDataSet().Tables[0].Columns["UOMCode"].ToString();

            uomvol_cbo.ValueMember = "UOMCode";

            dt = DataList.UOMWeightDataSet().Tables[0];

            dr = dt.NewRow();

            dr["UOMCode"] = "";

            dt.Rows.InsertAt(dr, 0);

            uomweight_cbo.DataSource = dt;

            uomweight_cbo.DisplayMember = DataList.UOMWeightDataSet().Tables[0].Columns["UOMCode"].ToString();

            uomweight_cbo.ValueMember = "UOMCode";

            #endregion
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Template_Master_Load(object sender, EventArgs e)
        {
            this.Size = new Size(538, 542);

            tabControl.SelectedIndexChanged += tabControl_SelectedIndexChanged;

            this.itemTemplateTableAdapter.Fill(this.engDataDataSet.ItemTemplate);

            ItemTemplateList.ClearSelection();

            ItemTemplateList.CurrentCellChanged += ItemTemplateList_CurrentCellChanged;
        }

        void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab == tabControl.TabPages["ItemTab"])
                this.Size = new Size(538, 542);
            else
                this.Size = new Size(731, 542);
        }

        public PartData pdata = new PartData();

        private void SaveVals()
        {
            DataRow dr = engDataDataSet.Tables[0].Rows[ItemTemplateList.CurrentCellAddress.Y];

                pdata.Description = dr["Desc"].ToString();

                pdata.PMT = dr["Type"].ToString();

                pdata.UOM_Class = dr["UOMClass"].ToString();

                decimal fail = 0;

                decimal.TryParse(dr["NetWeight"].ToString(), out fail);

                pdata.Net_Weight = fail;

                pdata.Net_Weight_UM = dr["UOMWeight"].ToString();

                decimal.TryParse(dr["NetVol"].ToString(),out fail);

                pdata.Net_Vol = fail;

                pdata.Net_Vol_UM = dr["UOMVol"].ToString();

                pdata.Primary_UOM = dr["UOM"].ToString();

                pdata.PartGroup = dr["Group"].ToString();

                pdata.PartClass = dr["Class"].ToString();

                pdata.PartPlant = dr["Plant"].ToString();

                pdata.PlantWhse = dr["Whse"].ToString();
        }

        void ItemTemplateList_CurrentCellChanged(object sender, EventArgs e)
        {
            SaveVals();

            try
            {                    
                Description_txt.Text = pdata.Description;
                    
                type_cbo.SelectedText = pdata.PMT;
                    
                uomclass_cbo.SelectedText = pdata.UOM_Class;
                    
                NetWeight.Value = pdata.Net_Weight;
                
                uomweight_cbo.SelectedText = pdata.Net_Weight_UM;
                
                NetVolume.Value = pdata.Net_Vol;
                
                uomvol_cbo.SelectedText = pdata.Net_Vol_UM;
                
                uom_cbo.SelectedText = pdata.Primary_UOM;
                
                group_cbo.SelectedText = pdata.PartGroup;
                
                class_cbo.SelectedText = pdata.PartClass;
                
                plant_cbo.SelectedText = pdata.PartPlant;

                whse_cbo.SelectedText = pdata.PlantWhse;
            }
            catch { }
        }
    }
}
