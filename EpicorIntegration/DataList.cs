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

         public static BLConnectionPool EpicConn = new BLConnectionPool(Properties.Settings.Default.uname, Properties.Settings.Default.passw, "AppServerDC://" + Properties.Settings.Default.svrname + ":" + Properties.Settings.Default.svrport);


        public void EpicClose()
        {
                SessionMod SM = new SessionMod(EpicConn);
                
                SM.GracefulShutdown();

                Progress.Open4GL.DynamicAPI.Session Session = EpicConn.Get();

                EpicConn.Release(Session);

                //EpicConn.Dispose();
        }

        public BOReader BOReader
        {
            get
            {
                BOReader BOReader = new BOReader(EpicConn);

                return BOReader;
            }

        }

        public DataSet PlantDataSet()
        {
            DataSet ds = (DataSet)BOReader.GetList("Plant", "", "Company,Plant,Name,Company");

            EpicClose();

            return ds;
        }

        public DataSet PartClassDataSet()
        {
            DataSet ds = (DataSet)BOReader.GetList("PartClass", "", "ClassID,Description");

            EpicClose();

            return ds;
        }

        /// <summary>
        /// Adds data in specified column at row number and table all into PartDataSet given
        /// </summary>
        /// <param name="Part"></param>
        /// <param name="tableName"></param>
        /// <param name="rowNum"></param>
        /// <param name="colName"></param>
        /// <param name="Input"></param>
        /// <returns></returns>
        public PartDataSet AddDatum(PartDataSet Part, string tableName, int rowNum, string colName, string Input)
        {
            DataTable PartDT = Part.Tables[tableName];

            DataRow[] WorkRow = PartDT.Select(null, null, DataViewRowState.Added);

            WorkRow[0] = PartDT.Rows[rowNum];

            try
            {
                WorkRow[0][colName] = Input;
            }
            catch (System.Exception ex)
            {
                try
                {
                    WorkRow[0][colName] = double.Parse(Input);
                }
                catch (System.Exception ex1)
                {
                    try
                    {
                        WorkRow[0][colName] = (int)(double.Parse(Input));
                    }
                    catch (System.Exception ex2)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message, "Error!", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Exclamation);
                    }
                }

            }

            return Part;
        }

        public DataSet ProdGrupDataSet()
        {
            DataSet ds = (DataSet)BOReader.GetList("ProdGrup", "", "ProdCode,Description");

            EpicClose();

            return ds;
        }

        public DataSet UOMSearchDataSet()
        {
            DataSet ds = (DataSet)BOReader.GetList("UOMSearch", "((Active=True) AND (UOMClassID = 'NORCO'))", "UOMCode,UOMDesc");

            EpicClose();

            return ds;
        }

        public DataSet UOMClassDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("UOMClass", "((Active=True) AND (ClassType<>'OnTheFly'))", "UOMClassID,Description");

            EpicClose();

            return ds;
        }

        public DataSet UOMWeightDataSet()
        {
            DataSet ds = (DataSet)BOReader.GetList("UOMSearch", "((Active=True) AND (ClassType='Weight'))", "UOMCode,UOMDesc");

            EpicClose();

            return ds;
        }

        public DataSet UOMVolumeDataSet()
        {
            DataSet ds = (DataSet)BOReader.GetList("UOMSearch", "((Active=True) AND (ClassType='Volume'))", "UOMCode,UOMDesc");

            EpicClose();

            return ds;
        }

        public DataSet WarehseDataSet()
        {
            DataSet ds = (DataSet)BOReader.GetList("WarehseSearch", "MfgSys", "");

            EpicClose();

            return ds;
        }

        public DataSet GroupIDDataSet()
        {
            bool MorePages;

            EngWorkBench EngBench = new EngWorkBench(EpicConn);

            DataSet ds = (DataSet)EngBench.GetList(" BY GroupID", 100, 0, out MorePages);

            EpicClose();

            return ds;
        }

        /// <summary>
        /// Search Function for retrieving Part lists
        /// </summary>
        /// <param name="WhereStatement">Equivalent to the SQL WHERE function; Leave blank for all possiblities</param>
        /// <returns>Dataset of parts meeting the WhereStatement criteria</returns>
        public PartDataSet PartSearchDataSet(string WhereStatement)
        {
            Part Part = new Part(EpicConn);

            bool More;

            DataSet dss = ((DataSet)Part.GetList(WhereStatement, 0, 0, out More));

            PartDataSet ds = (PartDataSet)dss;

            EpicClose();

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
        /// Overridden to prove correct data member for combobox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return _Code;
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
