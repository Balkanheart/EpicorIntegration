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

            Searchtxt.Leave += Searchtxt_TextChanged;
        }

        void Searchtxt_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currev_txt.Text = DataList.GetCurrentRev(Searchtxt.Text);

                newrev_txt.Text = DataList.AdvanceRevision(currev_txt.Text);
            }
            catch
            {
            }
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

            newrev_txt.Text = Revision;

            currev_txt.Text = DataList.GetCurrentRev(PartNumber);

            revdesc_txt.Text = RevisionDesc;

            Searchtxt.Leave += Searchtxt_TextChanged;
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

            bool valid = DataList.CreatePartRevision(Searchtxt.Text, currev_txt.Text, newrev_txt.Text, revdesc_txt.Text);

            EngWorkBench EngWb = new EngWorkBench(DataList.EpicConn);

            string CheckedOutRevNum;

            string altMethodMsg;

            bool altMethodFlg;

            EngWorkBenchDataSet EngDataSet = new EngWorkBenchDataSet();

            EngWb.CheckOut(gid_cbo.Text.ToString(), Searchtxt.Text, newrev_txt.Text, "", DateTime.Today, false, false,false,true,false,out CheckedOutRevNum, out altMethodMsg, out altMethodFlg);

            EngDataSet = EngWb.GetDatasetForTree(gid_cbo.Text.ToString(), Searchtxt.Text, newrev_txt.Text, "", DateTime.Now, false, false);
            
            string opMessage;

            EngDataSet.Tables["ECORev"].Rows[0]["Approved"] = true;
            
            EngWb.CheckECORevApproved(true, false, EngDataSet);

            EngWb.Update(EngDataSet);

            EngWb.CheckIn(gid_cbo.Text.ToString(), Searchtxt.Text, newrev_txt.Text, "", DateTime.Now, false, false, true, true, false, "FOR EPICOR INTEGRATION MODULE", out opMessage);

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
