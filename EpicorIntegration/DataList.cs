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
    class DataList
    {
        BLConnectionPool EpicConn = new BLConnectionPool(Properties.Settings.Default.uname, Properties.Settings.Default.passw, "AppServerDC://" + Properties.Settings.Default.svrname + ":" + Properties.Settings.Default.svrport);

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

            return ds;
        }

        public DataSet ProdGrupDataSet()
        {
            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("ProdGrup", "", "ProdCode,Description");

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
    }

    /// <summary>
    /// Data structure for Part with all appropriate descriptors
    /// </summary>
    class PartData
    {

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
}
