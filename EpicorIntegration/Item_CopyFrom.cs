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
    public partial class Item_CopyFrom : Form
    {
        public PartData _Pdata = new PartData();
        
        private string _PartNumber;

        public Item_CopyFrom(string PartNumber)
        {
            InitializeComponent();

            partnumber_txt.Leave += partnumber_txt_Leave;

            _PartNumber = PartNumber;
        }

        public Item_CopyFrom()
        {
            InitializeComponent();

            partnumber_txt.Leave += partnumber_txt_Leave;

            template_cbo.SelectedIndexChanged += template_cbo_SelectedIndexChanged;
        }

        void template_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            partnumber_txt.Enabled = template_cbo.Text.Contains("Other");

            rev_txt.Enabled = template_cbo.Text.Contains("Other");

            desc_txt.Enabled = template_cbo.Text.Contains("Other");
        }

        void partnumber_txt_Leave(object sender, EventArgs e)
        {
            //Fill in description and revision

            rev_txt.Text = DataList.GetCurrentRev(partnumber_txt.Text);

            desc_txt.Text = DataList.GetCurrentDesc(partnumber_txt.Text);
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void useselected_btn_Click(object sender, EventArgs e)
        {
            if (template_cbo.Text == "Other")
            {
                try
                {
                    //Use text box part number
                    Part Part = new Part(DataList.EpicConn);

                    PartDataSet PData = new PartDataSet();

                    PData = Part.DuplicatePart(partnumber_txt.Text, _PartNumber, desc_txt.Text);

                    Part.Update(PData);

                    this.DialogResult = DialogResult.Ignore;
                }
                catch { }
            }
            else
            {
                //Use Listed Template

                DataRow dr = eNGDataDataSet.Tables[0].Rows[template_cbo.SelectedIndex + 1];

                _Pdata.Description = dr["Desc"].ToString();

                _Pdata.PMT = dr["Type"].ToString();

                _Pdata.UOM_Class = dr["UOMClass"].ToString();

                _Pdata.Net_Weight = decimal.Parse(dr["NetWeight"].ToString());

                _Pdata.Net_Weight_UM = dr["UOMWeight"].ToString();

                _Pdata.Net_Vol = decimal.Parse(dr["NetVol"].ToString());

                _Pdata.Net_Vol_UM = dr["UOMVol"].ToString();

                _Pdata.Primary_UOM = dr["UOM"].ToString();

                _Pdata.PartGroup = dr["Group"].ToString();

                _Pdata.PartClass = dr["Class"].ToString();

                _Pdata.PartPlant = dr["Plant"].ToString();

                _Pdata.PlantWhse = dr["Whse"].ToString();
            }

            this.Close();
        }

        private void Item_CopyFrom_Load(object sender, EventArgs e)
        {
            this.itemTemplateTableAdapter.Fill(this.eNGDataDataSet.ItemTemplate);

            eNGDataDataSet.Tables[0].Rows.Add("Other");

            template_cbo.DataSource = eNGDataDataSet.Tables[0];

            template_cbo.DisplayMember = "Title";

            template_cbo.ValueMember = "Title";

        }

        private void newtemplate_btn_Click(object sender, EventArgs e)
        {
            Item_Template frm = new Item_Template();

            frm.ShowDialog();

            this.itemTemplateTableAdapter.Fill(this.eNGDataDataSet.ItemTemplate);

            eNGDataDataSet.Tables[0].Rows.Add("Other");

            template_cbo.DataSource = eNGDataDataSet.Tables[0];

            template_cbo.DisplayMember = "Title";

            template_cbo.ValueMember = "Title";
        }
    }
}
