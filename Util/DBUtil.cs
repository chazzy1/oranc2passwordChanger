using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;


namespace MainForm.Util
{

    public class DBUtil
    {
        private OracleConnection mv_oracleConnection;
        private string mv_ResultFileName;
        private OracleCommand mv_oracleCommand;
        private bool mv_isStopIssued;
        private bool mv_isRunning;
        private bool mv_useParallel;
        private int mv_parallelCount;
        private bool mv_useRowLimit;
        private int mv_rowLimit;
        private bool mv_useVervoseMode;
        private bool mv_useColumnLimit;

        public bool UseColumnLimit
        {
            get { return mv_useColumnLimit; }
            set { mv_useColumnLimit = value; }
        }
        public bool UseVervoseMode
        {
            get { return mv_useVervoseMode; }
            set { mv_useVervoseMode = value; }
        }

        public int RowLimit
        {
            get { return mv_rowLimit; }
            set { mv_rowLimit = value; }
        }
        public bool UseRowLimit
        {
            get { return mv_useRowLimit; }
            set { mv_useRowLimit = value; }
        }
        public int ParallelCount
        {
            get { return mv_parallelCount; }
            set { mv_parallelCount = value; }
        }
        public bool UseParallel
        {
            get { return mv_useParallel; }
            set { mv_useParallel = value; }
        }
        public bool IsRunning
        {
            get { return mv_isRunning; }
            set { mv_isRunning = value; }
        }
        public bool IsStopIssued
        {
            get { return mv_isStopIssued; }
            set { mv_isStopIssued = value; }
        }

        public string ResultFileName
        {
            get { return mv_ResultFileName; }
            set { mv_ResultFileName = value; }
        }

        public OracleCommand OracleCommand
        {
            get { return mv_oracleCommand; }
            set { mv_oracleCommand = value; }
        }

        public OracleConnection OracleConnection
        {
            get { return mv_oracleConnection; }
            set { mv_oracleConnection = value; }
        }



        public string GetConnectionString(string type,
                   string userid,
                   string password,
                   string tnsNameDecription,
                   string serverIp,
                   string serverPort,
                   string serverSID,
                   string authmode)
        {


            if (type.Equals("TNS"))
            {
                if (authmode == "Normal")
                    return String.Format("Pooling=false; user id={0};password={1}; data source={2};",
                            userid,
                            password,
                            tnsNameDecription,
                            authmode);
                else
                    return String.Format("user id={0};password={1}; data source={2}; DBA Privilege={3};",
                            userid,
                            password,
                            tnsNameDecription,
                            authmode);

            }

            if (authmode == "Normal")
                authmode = "";
            else
                authmode = String.Format("DBA Privilege={0};", authmode);

            return String.Format("User Id={0};Password={1}; {2} Data Source=(DESCRIPTION=" +
                        "(ADDRESS=(PROTOCOL=TCP)(HOST={3})(PORT={4}))" +
                        "(CONNECT_DATA=(SID={5})));",
                        userid,
                        password,
                        authmode,
                        serverIp,
                        serverPort,
                        serverSID);
        }


        public OracleConnection getOracleConnection(string connstr)
        {
            mv_oracleConnection = new OracleConnection(connstr);
            return mv_oracleConnection;

        }






    }
}
