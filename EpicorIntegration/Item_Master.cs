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

                class_cbo.DisplayMember = "Description";

                uomclass_cbo.DataSource = DL.UOMClassDataSet().Tables[0];

                uomclass_cbo.DisplayMember = "Description";

                plant_cbo.DataSource = DL.PlantDataSet().Tables[0];

                plant_cbo.DisplayMember = "NAME";

                whse_cbo.DataSource = DL.WarehseDataSet().Tables[0];

                whse_cbo.DisplayMember = "Description";

                DataSet DS = DL.UOMSearchDataSet();

                DS.Tables[0].Columns.Add("FullCode", typeof(string), "UOMCode + ' - ' + UOMDesc");

                uom_cbo.DataSource = DS.Tables[0];

                uom_cbo.DisplayMember = DS.Tables[0].Columns["FullCode"].ToString();

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

                Part Part = new Part(DL.EpicConn);

                PartDataSet Pdata = new PartDataSet();

                //Pdata = (PartDataSet)DL.PartSearchDataSet("");

                string serialWarning;

                string questionString;

                bool multipleMatch;

                string PartNumber = Partnumber_txt.Text;

                Part.GetPartXRefInfo(ref PartNumber, "", "", out serialWarning, out questionString, out multipleMatch);

                if (!multipleMatch)
                {
                    //Part.GetByID(PartNumber);

                    Part.GetNewPart(Pdata);

                    Part.ChangePartNum(PartNumber, Pdata);

                    DL.AddDatum(Pdata, "Part",  0, "PartDescription", Description_txt.Text);

                    DL.AddDatum(Pdata, "Part",  0, "SearchWord", Description_txt.Text.Substring(0,8));

                    DL.AddDatum(Pdata, "Part",  0, "NetWeight", NetWeight.Text);

                    string uomweight = uomweight_cbo.SelectedValue.ToString();

                    DL.AddDatum(Pdata, "Part", 0, "NetWeightUOM", uomweight);

                    DL.AddDatum(Pdata, "Part", 0, "NetVolume", NetVolume.Text);

                    DL.AddDatum(Pdata, "Part", 0, "NetVolumeUOM",uomvol_cbo.SelectedItem.ToString());

                    //Needs Primary UOM Change

                    //Needs Change Class Code

                    //Needs Change Plant/Whse

                    string Type_Code = type_cbo.SelectedItem.ToString();

                    Part.ChangePartTypeCode(Type_Code, Pdata);

                    Part.ChangePartProdCode(group_cbo.SelectedValue.ToString(), Pdata);

                    //Potential implementation of CheckPartChanges

                    TestTableViewer test = new TestTableViewer(Pdata);

                    test.ShowDialog();

                    Part.Update(Pdata);
                
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
