using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Epicor.Mfg.BO;
using Epicor.Mfg.Core;
using Epicor.Mfg.Lib;

namespace EpicorIntegration
{
    public class DataList
    {
        public BLConnectionPool EpicConn
        {
            get
            {
                BLConnectionPool BLConnectionPool = new BLConnectionPool(Properties.Settings.Default.uname, Properties.Settings.Default.passw, "AppServerDC://" + Properties.Settings.Default.svrname + ":" + Properties.Settings.Default.svrport);

                return BLConnectionPool;
            }
        }

        public DataSet PlantDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("Plant", "", "Company,Plant,Name,Company");

            return ds;
        }

        public DataSet PartClassDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("PartClass", "", "ClassID,Description");

            TestTableViewer test = new TestTableViewer(ds);

            test.ShowDialog();

            return ds;
        }

        public DataSet ProdGrupDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("ProdGrup", "", "ProdCode,Description");

            TestTableViewer test = new TestTableViewer(ds);

            test.ShowDialog();

            return ds;
        }

        public DataSet UOMSearchDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("UOMSearch", "((Active=True) AND (UOMClassID = 'NORCO'))", "UOMCode,UOMDesc");

            return ds;
        }

        public DataSet UOMClassDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("UOMClass", "((Active=True) AND (ClassType<>'OnTheFly'))", "UOMClassID,Description");

            return ds;
        }

        public DataSet UOMWeightDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("UOMSearch", "((Active=True) AND (ClassType='Weight'))", "UOMCode,UOMDesc");

            return ds;
        }

        public DataSet UOMVolumeDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("UOMSearch", "((Active=True) AND (ClassType='Volume'))", "UOMCode,UOMDesc");

            return ds;
        }

        public DataSet WarehseDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("WarehseSearch", "MfgSys", "");

            return ds;
        }

        public DataSet GroupIDDataSet()
        {
            bool MorePages;

            EngWorkBench EngBench = new EngWorkBench(EpicConn);

            DataSet ds = (DataSet)EngBench.GetList(" BY GroupID", 100, 0, out MorePages);

            return ds;
        }

        /// <summary>
        /// Search Function for retrieving Part lists
        /// </summary>
        /// <param name="WhereStatement">Equivalent to the SQL WHERE function; Leave blank for all possiblities</param>
        /// <returns>Dataset of parts meeting the WhereStatement criteria</returns>
        public DataSet PartSearchDataSet(string WhereStatement)
        {
            Part Part = new Part(EpicConn);

            bool More;

            DataSet ds = Part.GetList(WhereStatement, 0, 0, out More);
            
            TestTableViewer test = new TestTableViewer(ds);

            test.ShowDialog();

            return ds;
        }
    }

    /// <summary>
    /// Data structure for Part with all appropriate descriptors
    /// </summary>
    public class PartData
    {
        public string PartNumber
        {
            get;
            set;
        }

        public string Description
        {
            get;
            set;
        }

        public string PMT
        {
            get;
            set;
        }

        public string UOM_Class
        {
            get;
            set;
        }

        public string Net_Weight
        {
            get;
            set;
        }

        public string Net_Vol
        {
            get;
            set;
        }

        public string Net_Weight_UM
        {
            get;
            set;
        }

        public string Net_Vol_UM
        {
            get;
            set;
        }

        public string Primary_UOM
        {
            get;
            set;
        }

        public string PartGroup
        {
            get;
            set;
        }

        public string PartClass
        {
            get;
            set;
        }

        public string PartPlant
        {
            get;
            set;
        }

        public string PlantWhse
        {
            get;
            set;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    class BOMData
    {

    }

    /// <summary>
    /// 
    /// </summary>
    class BOOData
    {

    }

    /// <summary>
    /// 
    /// </summary>
    class Operation
    {

    }

    /// <summary>
    /// 
    /// </summary>
    class PartTypeCode
    {
        private string _Code;
        private string _Description;

        public PartTypeCode(string Description, string Code)
        {
            _Code = Code;
            _Description = Description;
        }

        /// <summary>
        /// Overridden to prove correct datamember for cbo
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _Description;
        }

        public string Code
        {
            get
            {
                return _Code;
            }
        }

        public string Description
        {
            get
            {
                return _Description;
            }
        }
    }
}
