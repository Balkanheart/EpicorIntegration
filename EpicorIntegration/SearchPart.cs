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
        }

        void SearchPart_ClientSizeChanged(object sender, EventArgs e)
        {
            HorizMajorContainer.SplitterDistance =  162;
            VerticalTopContainer.SplitterDistance = this.Width - 536;
        }

        private void SearchPart_Load(object sender, EventArgs e)
        {
            DL.PartClassDataSet();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
