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
            type_cbo.Items.Add(new PartTypeCode("Manufactured","M"));
            type_cbo.Items.Add(new PartTypeCode("Purchased", "P"));
            type_cbo.Items.Add(new PartTypeCode("Sales Kit", "K"));

            try
            {
                #region Fill DataLists

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

                uom_cbo.DisplayMember = "FullCode";

                uomclass_cbo.SelectedIndex = 2;

                type_cbo.SelectedIndex = 0;

                uomvol_cbo.DataSource = DL.UOMVolumeDataSet().Tables[0];

                uomvol_cbo.DisplayMember = "UOMCode";

                uomweight_cbo.DataSource = DL.UOMWeightDataSet().Tables[0];

                uomweight_cbo.DisplayMember = "UOMCode";

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

                Epicor.Mfg.BO.PartDataSet Pdata = new Epicor.Mfg.BO.PartDataSet();

                Pdata = (Epicor.Mfg.BO.PartDataSet)DL.PartSearchDataSet("");

                Part.GetNewPart(Pdata);

                Part.ChangePartNum(Partnumber_txt.Text, Pdata);

                Part.ChangePartTypeCode(type_cbo.SelectedItem.ToString(), Pdata);

                Part.ChangePartProdCode(group_cbo.SelectedItem.ToString(), Pdata);

                //Potential implementation of CHeckPartChanges

                Part.Update(Pdata);

                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            


        }
    }
}
