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
    public partial class Item_Template : Form
    {
        public PartData PartDatum
        {
            get
            {
                PartData PartDatum = new PartData();

                return PartDatum;
            }
        }

        public DataList DL
        {
            get
            {
                DataList DL = new DataList();

                return DL;
            }
        
        }

        public Item_Template()
        {
            InitializeComponent();
        }

        public Item_Template(PartData Part)
        {
            InitializeComponent();
            try
            {
                //Use Part to fill data fields

                Partnumber_txt.Text = Part.PartNumber;

                Description_txt.Text = Part.Description;

                type_cbo.SelectedIndex = type_cbo.Items.IndexOf(Part.PMT);

                NetWeight.Value = Part.Net_Weight;

                NetVolume.Value = Part.Net_Vol;

                group_cbo.SelectedIndex = group_cbo.Items.IndexOf(Part.PartGroup);

                class_cbo.SelectedIndex = class_cbo.Items.IndexOf(Part.PartClass);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing data fields.  Default values will show.\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public Item_Template(string PartNumber, string Description, string Type, decimal Weight, decimal Volume, string Group, string Class)
        {
            InitializeComponent();

            try
            {
                //Fill fields on form with inputs

                Partnumber_txt.Text = PartNumber;

                Description_txt.Text = Description;

                type_cbo.SelectedIndex = type_cbo.Items.IndexOf(Type);

                NetWeight.Value = Weight;

                NetVolume.Value = Volume;

                group_cbo.SelectedIndex = group_cbo.Items.IndexOf(Group);

                class_cbo.SelectedIndex = class_cbo.Items.IndexOf(Class);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing data fields.  Default values will show.\n" + ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void Item_Update_Load(object sender, EventArgs e)
        {
            try
            {
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
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\nThis application will now close.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                this.Close();
            }
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            try
            {
                #region Commit to Epicor
                //Commit Part Changes

                /*Part Part = new Part(DataList.EpicConn);

                PartDataSet Pdata = new PartDataSet();

                string PartNumber = Partnumber_txt.Text;

                    //Retrieve Data
                    Pdata = Part.GetByID(PartNumber);

                    //Part.ChangePartNum(PartNumber, Pdata);

                    DataList.UpdateDatum(Pdata, "Part", 0, "PartDescription", Description_txt.Text);
            
                    //SearchWord has 8 character limit
                    if (Description_txt.Text.Length > 8)
                        DataList.UpdateDatum(Pdata, "Part", 0, "SearchWord", Description_txt.Text.Substring(0, 8));
                    else
                        DataList.UpdateDatum(Pdata, "Part", 0, "SearchWord", Description_txt.Text);

                    DataList.UpdateDatum(Pdata, "Part", 0, "NetWeight", NetWeight.Text);

                    DataList.UpdateDatum(Pdata, "Part", 0, "NetWeightUOM", uomweight_cbo.SelectedValue.ToString());

                    DataList.UpdateDatum(Pdata, "Part", 0, "NetVolume", NetVolume.Text);

                    DataList.UpdateDatum(Pdata, "Part", 0, "NetVolumeUOM", uomvol_cbo.SelectedValue.ToString());

                    DataList.UpdateDatum(Pdata, "Part", 0, "IUM", uom_cbo.SelectedValue.ToString());

                    DataList.UpdateDatum(Pdata, "Part", 0, "ClassID", class_cbo.SelectedValue.ToString());

                    string Type_Code = type_cbo.SelectedItem.ToString();

                    Part.ChangePartTypeCode(Type_Code, Pdata);

                    Part.ChangePartProdCode(group_cbo.SelectedValue.ToString(), Pdata);

                    //Add data to allow BO to create plant tables
                    Part.Update(Pdata);

                    //retrieve the new copy of the data
                    Pdata = Part.GetByID(PartNumber);

                    DataList.UpdateDatum(Pdata, "PartPlant", 0, "PrimWhse", whse_cbo.SelectedValue.ToString());

                    DataList.UpdateDatum(Pdata, "PartPlant", 0, "PrimWhseDescription", whse_cbo.Text);

                    DataList.UpdateDatum(Pdata, "PartPlant", 0, "DBRowIdent", null);

                    //Update with warehouse information
                    Part.Update(Pdata);

                    //Potential implementation of CheckPartChanges

                    DataList.EpicClose();*/
                #endregion

                itemTemplateTableAdapter.Insert(Partnumber_txt.Text, Description_txt.Text, type_cbo.Text, uomclass_cbo.Text, (double)NetWeight.Value, uomweight_cbo.Text, (double)NetVolume.Value, uomvol_cbo.Text, uom_cbo.Text, group_cbo.SelectedValue.ToString(), class_cbo.Text, plant_cbo.Text, whse_cbo.Text);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            finally
            {
                this.Close();
            }
            


        }
    }
}
