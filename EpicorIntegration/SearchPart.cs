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
    public partial class SearchPart : Form
    {
        public static PartData PartDatum
        {
            get
            {
                PartData PartDatum = new PartData();

                return PartDatum;
            }
        }

        public SearchPart()
        {
            InitializeComponent();

            this.SearchResultGrid.DoubleClick += SearchResultGrid_DoubleClick;

            this.ClientSizeChanged += SearchPart_ClientSizeChanged;

            DataSet ds = DataList.PartClassDataSet();

            DataRow dr = ds.Tables[0].NewRow();

            dr[0] = "";

            dr[1] = "Any";

            ds.Tables[0].Rows.InsertAt(dr,0);

            group_cbo.DataSource = ds.Tables[0];

            group_cbo.ValueMember = "ClassID";

            group_cbo.DisplayMember = "Description";

            type_cbo.Items.Add(new PartTypeCode("Any", "%"));

            type_cbo.Items.Add(new PartTypeCode("Manufactured", "M"));

            type_cbo.Items.Add(new PartTypeCode("Purchased", "P"));

            type_cbo.Items.Add(new PartTypeCode("Sales Kit", "K"));

            type_cbo.DisplayMember = "Description";

            type_cbo.SelectedIndex = 0;

            group_cbo.SelectedIndex = 0;

            sortby_cbo.SelectedIndex = 0;

            status_cbo.SelectedIndex = 0;
        }

        public SearchPart(string initial)
        {
            InitializeComponent();

            PartNumber.Text = initial;

            this.SearchResultGrid.DoubleClick += SearchResultGrid_DoubleClick;

            this.ClientSizeChanged += SearchPart_ClientSizeChanged;

            DataSet ds = DataList.PartClassDataSet();

            DataRow dr = ds.Tables[0].NewRow();

            dr[0] = "";

            dr[1] = "Any";

            ds.Tables[0].Rows.InsertAt(dr, 0);

            group_cbo.DataSource = ds.Tables[0];

            group_cbo.ValueMember = "ClassID";

            group_cbo.DisplayMember = "Description";

            type_cbo.Items.Add(new PartTypeCode("Any", "%"));

            type_cbo.Items.Add(new PartTypeCode("Manufactured", "M"));

            type_cbo.Items.Add(new PartTypeCode("Purchased", "P"));

            type_cbo.Items.Add(new PartTypeCode("Sales Kit", "K"));

            type_cbo.DisplayMember = "Description";

            type_cbo.SelectedIndex = 0;

            group_cbo.SelectedIndex = 0;

            sortby_cbo.SelectedIndex = 0;

            status_cbo.SelectedIndex = 0;
        }

        void SearchResultGrid_DoubleClick(object sender, EventArgs e)
        {
            //Pass selected part number on
            int y = SearchResultGrid.Rows.IndexOf(SearchResultGrid.SelectedRows[0]);

            _PartNumber = SearchResultGrid["PartNum", y].Value.ToString();

            _Description = SearchResultGrid["PartDescription", y].Value.ToString();

            DialogResult = DialogResult.OK;

            this.Close();
        }

        void SearchPart_ClientSizeChanged(object sender, EventArgs e)
        {
            //HorizMajorContainer.SplitterDistance = 162;
            //VerticalTopContainer.SplitterDistance = this.Width - 536;
        }

        private void SearchPart_Load(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            
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

            status_cbo.SelectedIndex = 0;

            SearchResultGrid.DataSource = "";
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            Part Part = new Part(DataList.EpicConn);

            PartListDataSet PartList = new PartListDataSet();

            string WhereClause = PartNo() + Desc() + OfType() + Activity() + OnHold() + NonStock() + TrackLots() + SortBy();

            int pageSize;

            if (Properties.Settings.Default.allresults)
                pageSize = 0;
            else
                pageSize = Properties.Settings.Default.linelimit;

            bool morePages;

            PartList = Part.GetList(WhereClause, pageSize, 0, out morePages);

            DataList.EpicClose();

            SearchResultGrid.AutoGenerateColumns = false;

            SearchResultGrid.DataSource = PartList.Tables[0];

            if (PartList.Tables[0].Rows.Count < 1)
                SearchResultGrid.DataSource = "";
        }

        public string PartNo()
        {       
            string PartNum = PartNumber.Text.Replace('*','%');

            if (PartNumber.Text != "")
                return "PartNum >= '" + PartNum + "'";

            return null;
        }

        public string TrackLots()
        {
            if (AdvSearch.Checked)
            {
                if (serial_chk.Checked)
                    return " AND TrackSerialNum = true";
                else
                    return " AND TrackSerialNum = false";
            }
            return null;
        }

        public string Desc()
        {
            if (!(Description.Text == ""))
            {
                if (PartNo() != "")
                return "PartDescription CONTAINS '" + Description.Text + "'";

                return " AND PartDescription CONTAINS '" + Description.Text + "'";
            }
            return null;
        }

        public string NonStock()
        {
            if (AdvSearch.Checked)
            {
                if (nonstock_chk.Checked)
                    return "AND NonStock = true";

                return "AND NonStock = false";
            }
            else
                return null;
        }

        public string OnHold()
        {
            if (AdvSearch.Checked)
            {
                if (onhold_chk.Checked)
                    return "AND OnHold = true";

                return "AND OnHold = false";
            }
            return null;
        }

        public string OfType()
        {
            if (!type_cbo.Text.Contains("Any"))
                return " AND TypeCode = '" + type_cbo.SelectedItem.ToString() + "'";

            return null;
        }

        public string SortBy()
        {
            if (sortby_cbo.Text == "Part Number")
                return " BY PartNum";

            if (sortby_cbo.Text == "Search Word")
                return " BY SearchWord";

            if (sortby_cbo.Text == "Description")
                return " BY PartDescription";

            return null;
        }

        public string Activity()
        {
            if (status_cbo.SelectedIndex == 1)
                return  "AND InActive = false";

            if (status_cbo.SelectedIndex == 2)
                return " AND InActive = true";

            return null;
        }

        private void OptionsBtn_Click(object sender, EventArgs e)
        {
            SearchOptions SearchOpt = new SearchOptions();

            SearchOpt.ShowDialog();
        }

        private void AdvSearch_CheckedChanged(object sender, EventArgs e)
        {
            advgroup.Enabled = AdvSearch.Checked;
        }

        public string _PartNumber;

        public string _Description;

    }
}
