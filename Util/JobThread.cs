using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data;
using Oracle.DataAccess.Client;
using System.IO;



namespace MainForm.Util
{


    public abstract class BaseThread
    {
        protected Thread _thread;

        public BaseThread() { _thread = new Thread(new ThreadStart(this.RunThread)); }

        // Thread methods / properties
        public void Start() { _thread.Start(); }
        public void Join() { _thread.Join(); }
        public bool IsAlive { get { return _thread.IsAlive; } }


        public string Name
        {
            get { return _thread.Name; }
            set { _thread.Name = value; }
        }
        // Override in base class
        public abstract void RunThread();
    }



    public class SQLJobThread : BaseThread
    {

        private System.Object lockThis = new System.Object();

        private DataTable mv_Schema;
        private DataTable mv_Regex;
        private DBUtil mv_dbUtil;



        public delegate void JobProgressHandler(object sender, DetectJobProgressInfo info);

        public event JobProgressHandler EventJobProgress;


        private void RaiseEventJobProgress(DetectJobProgressInfo info)
        {
            if (EventJobProgress != null)
            {
                EventJobProgress(this, info);
            }
            
        }
        public SQLJobThread(DBUtil dbUtil)
        {
            this.mv_dbUtil = dbUtil;


        }


        public void UpdateOpeationHistory(DBUtil dbutil, string operationSeq, string dbId, string accountName, string afterPassword, string result)
        {
            try
            {


                OracleCommand command = dbutil.OracleConnection.CreateCommand();

                command.BindByName = true;

                if (string.IsNullOrEmpty(afterPassword))
                {
                    string sql = "update ornc_db_acnt_pwd_chg_hst ";
                    sql += " set   OP_RSLT = :OP_RSLT ";
                    sql += " where ACNT_NM = :ACNT_NM ";
                    sql += " and DB_ID = :DB_ID ";
                    sql += " and PWD_CHG_OPER_SEQ =:PWD_CHG_OPER_SEQ ";
                    command.CommandText = sql;

                    command.Parameters.Clear();
                    command.Parameters.Add("OP_RSLT", result);
                    command.Parameters.Add("ACNT_NM", accountName);
                    command.Parameters.Add("DB_ID", dbId);
                    command.Parameters.Add("PWD_CHG_OPER_SEQ", operationSeq);

                    command.ExecuteNonQuery();

                }
                else
                {
                    string sql = "update ornc_db_acnt_pwd_chg_hst ";
                    sql += " set   OP_RSLT = :OP_RSLT , AF_PWD = :AF_PWD ";
                    sql += " where ACNT_NM = :ACNT_NM ";
                    sql += " and DB_ID = :DB_ID ";
                    sql += " and PWD_CHG_OPER_SEQ =:PWD_CHG_OPER_SEQ ";
                    command.CommandText = sql;

                    command.Parameters.Clear();
                    command.Parameters.Add("OP_RSLT", result);
                    command.Parameters.Add("AF_PWD", afterPassword);
                    command.Parameters.Add("ACNT_NM", accountName);
                    command.Parameters.Add("DB_ID", dbId);
                    command.Parameters.Add("PWD_CHG_OPER_SEQ", operationSeq);

                    command.ExecuteNonQuery();
                }


            }
            catch (Exception ex)
            {
 
            }

        }


        public string UpdateOrncInfo(DBUtil dbutil, string operationSeq ,string dbId , string accountName,string racGroupName, string afterPassword)
        {

            try
            {


                OracleCommand command = dbutil.OracleConnection.CreateCommand();

                command.BindByName = true;

                if (string.IsNullOrEmpty(racGroupName))
                {
                    string sql = "update ornc_db_acnt ";
                    sql += " set   PWD = :PWD ";
                    sql += " where ACNT_NM = :ACNT_NM ";
                    sql += " and DB_ID = :DB_ID ";
                    sql += " and pwd_chg_obj_yn = 'Y' ";
                    command.CommandText = sql;

                    command.Parameters.Clear();
                    command.Parameters.Add("PWD", afterPassword);
                    command.Parameters.Add("ACNT_NM", accountName);
                    command.Parameters.Add("DB_ID", dbId);

                    command.ExecuteNonQuery();

                }
                else
                {
                    string sql = "update ornc_db_acnt ";
                    sql += " set   PWD = :PWD ";
                    sql += " where ACNT_NM = :ACNT_NM ";
                    sql += " and pwd_chg_obj_yn = 'Y' ";
                    sql += " and db_id in ( ";
                    sql += " select db_id from ornc_db ";
                    sql += " where rac_grp_nm = :RAC_GRP_NM ) ";
                    command.CommandText = sql;

                    command.Parameters.Clear();
                    command.Parameters.Add("PWD", afterPassword);
                    command.Parameters.Add("ACNT_NM", accountName);
                    command.Parameters.Add("RAC_GRP_NM", racGroupName);

                    command.ExecuteNonQuery();
                }






                return "Success";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


            
        }

        public string ChangePassword(string tnsinfo, string accountName, string beforePassword, string afterPassword)
        {
           
            try
            {

                DBUtil dbutil = new DBUtil();

                string connstr = dbutil.GetConnectionString("TNS", accountName, beforePassword, tnsinfo, null, null, null, "Normal");


                using (OracleConnection conn = dbutil.getOracleConnection(connstr))
                {
                    conn.Open();
                    OracleCommand command =  conn.CreateCommand();

                    command.BindByName = true;


                    string sql = string.Format(@"alter user {0} identified by ""{1}"" replace ""{2}"" ", accountName, afterPassword, beforePassword);

                    command.CommandText = sql;

                    //command.CommandText = "ALTER USER :USR IDENTIFIED BY :PWD REPLACE :OLDPWD";

                    //command.Parameters.Add("USR", accountName);
                    //command.Parameters.Add("PWD", afterPassword);
                    //command.Parameters.Add("OLDPWD", beforePassword);



                    command.ExecuteNonQuery();


                }



                return "Success";




            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            finally
            {

            }
            
        }



        public string TestConnection(string tnsinfo, string accountName, string beforePassword)
        {

            try
            {

                DBUtil dbutil = new DBUtil();

                string connstr = dbutil.GetConnectionString("TNS", accountName, beforePassword, tnsinfo, null, null, null, "Normal");


                using (OracleConnection conn = dbutil.getOracleConnection(connstr))
                {
                    conn.Open();

                    conn.Close();


                }



                return "OK!";




            }
            catch (Exception ex)
            {

                return ex.Message;
            }
            finally
            {

            }

        }


        public DataTable CreatePasswordChangeJob(DBUtil dbUtil)
        {
            DataTable dt = new DataTable();

            string sql = "select max(PWD_CHG_OPER_SEQ)+1 SEQ from ornc_db_acnt_pwd_chg_hst";



            dbUtil.OracleCommand = dbUtil.OracleConnection.CreateCommand();

            dbUtil.OracleCommand.CommandText = sql;



            string maxseq = "";

            using (OracleDataReader dr = dbUtil.OracleCommand.ExecuteReader())
            {
                dr.Read();

                maxseq = dr["SEQ"].ToString();

            }

            if (string.IsNullOrEmpty(maxseq))
            {
                maxseq = "1";
            }
            string now = DateTime.Now.ToString("yyyyMMddHHmmss");



            sql = "insert into ornc_db_acnt_pwd_chg_hst ( ";
            sql += " PWD_TYP_CL_CD,ACNT_NM,DB_ID,PWD_CHG_OPER_SEQ,OPER_STA_DTM,RAC_GRP_NM,CONN_STR_CTT,BF_PWD,AF_PWD,OP_RSLT ";
            sql += " ) ";
            sql += " select PWD_TYP_CL_CD,ACNT_NM,DB_ID,PWD_CHG_OPER_SEQ,OPER_STA_DTM,RAC_GRP_NM,CONN_STR_CTT,BF_PWD,AF_PWD,OP_RSLT ";
            sql += " from ( ";
            sql += " select a.PWD_TYP_CL_CD,a.ACNT_NM,a.DB_ID," + maxseq + " PWD_CHG_OPER_SEQ ,  to_date('" + now.ToString() + "','yyyymmddHH24MISS') OPER_STA_DTM ";
            sql += " ,b.rac_grp_nm,row_number() over(partition by a.acnt_nm , b.rac_grp_nm order by b.rep_nst_rnk) rn ";
            sql += " ,b.conn_str_ctt,a.PWD BF_PWD,'' AF_PWD ,'' OP_RSLT ";
            sql += " from ornc_db_acnt a , ornc_db b where a.db_id = b.db_id and a.PWD_CHG_OBJ_YN = 'Y' ";
            sql += " ) where rn = 1 ";

            dbUtil.OracleCommand.CommandText = sql;

            dbUtil.OracleCommand.ExecuteNonQuery();


            sql = "select 1 OPER_YN,PWD_TYP_CL_CD,OP_RSLT,ACNT_NM,DB_ID,PWD_CHG_OPER_SEQ,OPER_STA_DTM,RAC_GRP_NM,CONN_STR_CTT,BF_PWD,AF_PWD from ornc_db_acnt_pwd_chg_hst where PWD_CHG_OPER_SEQ = '" + maxseq + "'";

            dbUtil.OracleCommand.CommandText = sql;
            using (OracleDataAdapter adapter = new OracleDataAdapter(dbUtil.OracleCommand))
            {
                adapter.Fill(dt);

            }

            return dt;


        }







        // Thread methods
        public override void RunThread()
        {
            try
            {


                lock (lockThis)
                {


                    /*
                    if (this.mv_jobType == SQLJobType.RunAliasCheck_DBIO)
                    {
                        mv_dbUtil.IsStopIssued = false;


                    } 
                    else if(this.mv_jobType == SQLJobType.RunAliasCheck_V_SQL)
                    {
                        mv_dbUtil.IsStopIssued = false;

                    }
                     * */

                }

            }
            catch (Exception ex)
            {
                DetectJobProgressInfo info = new DetectJobProgressInfo();
                info.Message = ex.Message;
                RaiseEventJobProgress(info);


            }
            finally
            {
            }

        }









    }



}
