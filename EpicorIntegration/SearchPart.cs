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
    public partial class SearchPart : Form
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

        public SearchPart()
        {
            InitializeComponent();

            this.ClientSizeChanged += SearchPart_ClientSizeChanged;

            DataSet ds = DL.PartClassDataSet();

            DataRow dr = ds.Tables[0].NewRow();

            dr[0] = "";

            dr[1] = "Any";

            ds.Tables[0].Rows.InsertAt(dr,0);

            group_cbo.DataSource = ds.Tables[0];

            group_cbo.ValueMember = "ClassID";

            group_cbo.DisplayMember = "Description";

            type_cbo.Items.Add(new PartTypeCode("Any", ""));

            type_cbo.Items.Add(new PartTypeCode("Manufactured", "M"));

            type_cbo.Items.Add(new PartTypeCode("Purchased", "P"));

            type_cbo.Items.Add(new PartTypeCode("Sales Kit", "K"));

            type_cbo.DisplayMember = "Description";

            type_cbo.SelectedIndex = 0;

            group_cbo.SelectedIndex = 0;

            sortby_cbo.SelectedIndex = 0;
        }

        void SearchPart_ClientSizeChanged(object sender, EventArgs e)
        {
            HorizMajorContainer.SplitterDistance = 162;
            VerticalTopContainer.SplitterDistance = this.Width - 536;
        }

        private void SearchPart_Load(object sender, EventArgs e)
        {


            
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in basicgroup.Controls)
            {
                try
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ctrl.Text = "";

                    if (ctrl.GetType() == typeof(CheckBox))
                    {
                        CheckBox ctrlcb = (CheckBox)ctrl;

                        ctrlcb.Checked = false;
                    }
                    if (ctrl.GetType() == typeof(ComboBox))
                    {
                        ComboBox ctrlcbo = (ComboBox)ctrl;

                        ctrlcbo.SelectedIndex = 0;
                    }
                }
                catch //(System.Exception ex)
                {

                }
            }

            foreach (Control ctrl in advgroup.Controls)
            {
                try
                {
                    if (ctrl.GetType() == typeof(TextBox))
                        ctrl.Text = "";

                    if (ctrl.GetType() == typeof(CheckBox))
                    {
                        CheckBox ctrlcb = (CheckBox)ctrl;

                        ctrlcb.Checked = false;
                    }
                }
                catch //(System.Exception ex)
                {

                }
            }

            type_cbo.SelectedIndex = 0;

            group_cbo.SelectedIndex = 0;
        }

    }
}
