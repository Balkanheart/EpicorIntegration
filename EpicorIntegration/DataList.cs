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
        public DataSet PlantDataSet()
        {
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            BLConnectionPool EpicConn = new BLConnectionPool(user, passw, "AppServerDC://" + svrname + ":" + svrport);

            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("Plant", "", "Company,Plant,Name,Company");

            return ds;
        }

        public DataSet PartClassDataSet()
        {
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            BLConnectionPool EpicConn = new BLConnectionPool(user, passw, "AppServerDC://" + svrname + ":" + svrport);

            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("PartClass", "", "ClassID,Description");

            return ds;
        }

        public DataSet ProdGrupDataSet()
        {
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            BLConnectionPool EpicConn = new BLConnectionPool(user, passw, "AppServerDC://" + svrname + ":" + svrport);

            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("ProdGrup", "", "ProdCode,Description");

            return ds;
        }

        public DataSet UOMSearchDataSet()
        {
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            BLConnectionPool EpicConn = new BLConnectionPool(user, passw, "AppServerDC://" + svrname + ":" + svrport);

            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("UOMSearch", "((Active=True) AND (UOMClassID = 'NORCO'))", "UOMCode,UOMDesc");

            return ds;
        }

        public DataSet UOMClassDataSet()
        {
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            BLConnectionPool EpicConn = new BLConnectionPool(user, passw, "AppServerDC://" + svrname + ":" + svrport);

            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("UOMClass", "((Active=True) AND (ClassType<>'OnTheFly'))", "UOMClassID,Description");

            return ds;
        }

        public DataSet UOMWeightDataSet()
        {
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            BLConnectionPool EpicConn = new BLConnectionPool(user, passw, "AppServerDC://" + svrname + ":" + svrport);

            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("UOMClass", "((Active=True) AND (ClassType='Weight'))", "UOMClassID,Description");

            return ds;
        }

        public DataSet UOMVolumeDataSet()
        {
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            BLConnectionPool EpicConn = new BLConnectionPool(user, passw, "AppServerDC://" + svrname + ":" + svrport);

            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("UOMClass", "((Active=True) AND (ClassType='Volume'))", "UOMClassID,Description");

            return ds;
        }

        public DataSet WarehseDataSet()
        {
            string user = Properties.Settings.Default.uname;

            string passw = Properties.Settings.Default.passw;

            string svrname = Properties.Settings.Default.svrname;

            string svrport = Properties.Settings.Default.svrport;

            BLConnectionPool EpicConn = new BLConnectionPool(user, passw, "AppServerDC://" + svrname + ":" + svrport);

            BOReader BOReader = new BOReader(EpicConn);

            DataSet ds = (DataSet)BOReader.GetList("WarehseSearch", "MfgSys", "");

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
