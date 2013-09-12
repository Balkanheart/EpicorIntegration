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

        public Item_Master()
        {
            InitializeComponent();
        }

        private void Item_Master_Load(object sender, EventArgs e)
        {
            try
            {
                #region Fill DataLists

                type_cbo.Items.Add(new PartTypeCode("Manufactured", "M"));

                type_cbo.Items.Add(new PartTypeCode("Purchased", "P"));

                type_cbo.Items.Add(new PartTypeCode("Sales Kit", "K"));

                type_cbo.DisplayMember = "Description";

                group_cbo.DataSource = DL.ProdGrupDataSet ().Tables[0];
                
                group_cbo.DisplayMember = "Description";

                group_cbo.ValueMember = "ProdCode";

                class_cbo.DataSource = DL.PartClassDataSet().Tables[0];

                class_cbo.DisplayMember = DL.PartClassDataSet().Tables[0].Columns["Description"].ToString();

                class_cbo.ValueMember = DL.PartClassDataSet().Tables[0].Columns["ClassID"].ToString();

                uomclass_cbo.DataSource = DL.UOMClassDataSet().Tables[0];

                uomclass_cbo.DisplayMember = DL.UOMClassDataSet().Tables[0].Columns["Description"].ToString();

                plant_cbo.DataSource = DL.PlantDataSet().Tables[0];

                plant_cbo.DisplayMember = DL.PlantDataSet().Tables[0].Columns["NAME"].ToString();

                whse_cbo.DataSource = DL.WarehseDataSet().Tables[0];

                whse_cbo.DisplayMember = DL.WarehseDataSet().Tables[0].Columns["Description"].ToString();

                whse_cbo.ValueMember = DL.WarehseDataSet().Tables[0].Columns["WarehouseCode"].ToString();

                DataSet DS = DL.UOMSearchDataSet();

                DS.Tables[0].Columns.Add("FullCode", typeof(string), "UOMCode + ' - ' + UOMDesc");

                uom_cbo.DataSource = DS.Tables[0];

                uom_cbo.DisplayMember = DS.Tables[0].Columns["FullCode"].ToString();

                uom_cbo.ValueMember = "UOMCode";

                uomclass_cbo.SelectedIndex = 2;

                type_cbo.SelectedIndex = 0;

                uomvol_cbo.DataSource = DL.UOMVolumeDataSet().Tables[0];

                uomvol_cbo.DisplayMember = DL.UOMVolumeDataSet().Tables[0].Columns["UOMCode"].ToString();

                uomvol_cbo.ValueMember = "UOMCode";

                uomweight_cbo.DataSource = DL.UOMWeightDataSet().Tables[0];

                uomweight_cbo.DisplayMember = DL.UOMWeightDataSet().Tables[0].Columns["UOMCode"].ToString();

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
                //Commit Part Changes

                Part Part = new Part(DataList.EpicConn);

                PartDataSet Pdata = new PartDataSet();

                //Pdata = (PartDataSet)DL.PartSearchDataSet("");

                string serialWarning;

                string questionString;

                bool multipleMatch;

                string PartNumber = Partnumber_txt.Text;

                Part.GetPartXRefInfo(ref PartNumber, "", "", out serialWarning, out questionString, out multipleMatch);

                if (!multipleMatch)
                {
                    Part.GetNewPart(Pdata);

                    Part.ChangePartNum(PartNumber, Pdata);

                    DL.AddDatum(Pdata, "Part",  0, "PartDescription", Description_txt.Text);
            
                    //SearchWord has 8 character limit
                    if (Description_txt.Text.Length > 8)
                        DL.AddDatum(Pdata, "Part", 0, "SearchWord", Description_txt.Text.Substring(0,8));
                    else
                        DL.AddDatum(Pdata, "Part",  0, "SearchWord", Description_txt.Text);

                    DL.AddDatum(Pdata, "Part",  0, "NetWeight", NetWeight.Text);

                    DL.AddDatum(Pdata, "Part", 0, "NetWeightUOM", uomweight_cbo.SelectedValue.ToString());

                    DL.AddDatum(Pdata, "Part", 0, "NetVolume", NetVolume.Text);

                    DL.AddDatum(Pdata, "Part", 0, "NetVolumeUOM",uomvol_cbo.SelectedValue.ToString());

                    DL.AddDatum(Pdata, "Part", 0, "IUM", uom_cbo.SelectedValue.ToString());

                    DL.AddDatum(Pdata, "Part", 0, "ClassID", class_cbo.SelectedValue.ToString());

                    Part.GetNewPartPlant(Pdata, PartNumber);

                    DL.AddDatum(Pdata, "PartPlant", 0, "PrimWhse", whse_cbo.SelectedValue.ToString());

                    DL.AddDatum(Pdata, "PartPlant", 0, "Plant", plant_cbo.SelectedValue.ToString());

                    string Type_Code = type_cbo.SelectedItem.ToString();

                    Part.ChangePartTypeCode(Type_Code, Pdata);

                    Part.ChangePartProdCode(group_cbo.SelectedValue.ToString(), Pdata);

                    //Potential implementation of CheckPartChanges

                    Part.Update(Pdata);

                    DL.EpicClose();
                
                }
                else
                {
                    MessageBox.Show("Part already exists in database!  Use revision to make changes.");
                }

                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            


        }
    }
}
