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
    public partial class Revision_Master : Form
    {
        public Revision_Master()
        {
            InitializeComponent();

            DataList DL = new DataList();

            gid_cbo.DataSource = DL.GroupIDDataSet().Tables[0];

            gid_cbo.ValueMember = "Description";

            gid_cbo.DisplayMember = "GroupID";
        }

        public Revision_Master(string PartNumber, string Revision, string RevisionDesc, string GroupID)
        {
            InitializeComponent();

            DataList DL = new DataList();

            gid_cbo.DataSource = DL.GroupIDDataSet().Tables[0];

            gid_cbo.ValueMember = "Description";

            gid_cbo.DisplayMember = "GroupID";

            MessageBox.Show("Auto-select groupID still missing");

            Searchtxt.Text = PartNumber;

            revname_txt.Text = Revision;

            revdesc_txt.Text = RevisionDesc;
        }

        private void gid_cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            gid_desc.Text = gid_cbo.SelectedValue.ToString();
        }

        private void Revision_Master_Load(object sender, EventArgs e)
        {
            gid_cbo_SelectedIndexChanged(null, null);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            //Add revision
            Part Part = new Part(DataList.EpicConn);

            PartDataSet PartData = new PartDataSet();

            PartData = Part.GetByID(Searchtxt.Text);

            Part.GetNewPartRev(PartData, Searchtxt.Text, revname_txt.Text);

            DataList.UpdateDatum(PartData, "PartRev", 0, "RevShortDesc", revdesc_txt.Text);

            EngWorkBench EngWb = new EngWorkBench(DataList.EpicConn);

            string CheckedOutRevNum;

            string altMethodMsg;

            bool altMethodFlg;

            EngWorkBenchDataSet EngDataSet = new EngWorkBenchDataSet();

            EngDataSet =  EngWb.CheckOut(gid_cbo.SelectedValue.ToString(), Searchtxt.Text, revname_txt.Text, "", DateTime.Now, false, false,false,true,false,out CheckedOutRevNum, out altMethodMsg, out altMethodFlg);




            //Open Item_Master for changes (Need to alter to allow for edits)
            //Determine if BOO exists, if (exists) Open BOO_Master
            //Determine if BOM exists, if (exists) Open BOM_Master

            DataList.EpicClose();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            SearchPart Searchfrm = new SearchPart(Searchtxt.Text);

            Searchfrm.ShowDialog();

            if (Searchfrm.DialogResult == DialogResult.OK)
                Searchtxt.Text = Searchfrm._PartNumber;

            Searchfrm.Close();

            Searchfrm.Dispose();
                
        }
    }
}
