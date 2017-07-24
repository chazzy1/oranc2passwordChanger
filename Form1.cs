using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MainForm.Util;
using Oracle.DataAccess.Client;
using System.IO;

namespace MainForm
{
    public partial class Form1 : Form
    {


        private OracleConnection mv_DBConnection;

        private DBUtil mv_dbUtil;

        private bool isBatchMode;

        private string mv_BatchConnStr;
        private bool isStopIssued;

        public Form1()
        {
            InitializeComponent();

        }


        public Form1(bool isBatchmode)
        {
            isBatchMode = true;

            DBUtil dbutil = new DBUtil();

            //string id = "orncuser";
            //string pwd = "orncuser1234";
            //string tnsinfo = "(DESCRIPTION =(ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521))(CONNECT_DATA =(SERVER = DEDICATED)(SID = xe)))";

            string id = "tsql";
            string pwd = "xbsjwjsdyd";
            string tnsinfo = "(DESCRIPTION =(ADDRESS_LIST =(ADDRESS =(PROTOCOL = tcp)(HOST = 172.31.32.54)(PORT = 1524)))(CONNECT_DATA =(SID = NGMD)))";



            mv_BatchConnStr = dbutil.GetConnectionString("TNS", id, pwd, tnsinfo, null, null, null, "Normal");



            InitializeComponent();



            
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            DBEnv dbenv = new DBEnv();
            string tnsNamesFile = dbenv.GetTnsNamesOraFilePath();
            List<string> listTns = dbenv.GetTnsNames(tnsNamesFile);

            mComboBoxTNS.DataSource = listTns;
            mComboBoxTNS.SelectedIndex = 0;


            mTextBoxTNSPath.Text = tnsNamesFile;

            

            try
            {
                //mComboBoxTNS.Text = "11GHOME";
                mComboBoxTNS.Text = "NGMD";
            }
            catch (Exception ex)
            {

            }

            mTextBoxID.Text = "orncuser";
            mTextBoxPasswd.Text = "orncuser1234";


            //mTextBoxID.Text = "tsql";
            //mTextBoxPasswd.Text = "xbsjwjsdyd";




            if (isBatchMode)
            {

                mButtonConnect.Enabled = false;
                StartBatchSequence();

            }

        }

        private void StartBatchSequence()
        {
            AddLog("배치작업 시작!");
            ConnectToRuleServer();
            if (mv_DBConnection == null)
            {
                return;
            }
            else
            {
                tabControl1.SelectedTab = tabPage2;
                toolStripLabel2.Text = "배치작업 진행중...";
            }

            GenerateJobList();
            StartPasswordChangeJob();
        }

        private void AddLog(string txt)
        {
            string log = System.DateTime.Now + " : "+txt + System.Environment.NewLine;
            richTextBox1.AppendText(log);

            this.richTextBox1.SelectionLength = 0;
            this.richTextBox1.SelectionStart = this.richTextBox1.Text.Length;
            this.richTextBox1.ScrollToCaret();
        }



        #region Tab1 Event

        private void ConnectToRuleServer()
        {
            try
            {
                AddLog("RuleServer 접속시작");
                mv_dbUtil = new DBUtil();

                mTextBoxID.Text = mTextBoxID.Text.Trim();
                mTextBoxPasswd.Text = mTextBoxPasswd.Text.Trim();

                if (mTextBoxID.Text.Length == 0)
                    throw new CIDetectorException("사용자이름이 올바르지 않습니다.");
                if (mTextBoxPasswd.Text.Length == 0)
                    throw new CIDetectorException("사용자 패스워드가 올바르지 않습니다.");

                string charset = this.mTextBoxCharSet.Text;

                Environment.SetEnvironmentVariable("NLS_LANG",
                      charset,
                      EnvironmentVariableTarget.Process);

                string connstr = null;
                string host = null;
                if (this.mRadioButtonDirect.Checked)
                {

                    mTextBoxHost.Text = mTextBoxHost.Text.Trim();
                    host = mTextBoxHost.Text;
                    mTextBoxPort.Text = mTextBoxPort.Text.Trim();
                    mTextBoxSID.Text = mTextBoxSID.Text.Trim();

                    if (mTextBoxHost.Text.Length == 0)
                        throw new CIDetectorException("Host가 올바르지 않습니다.");
                    if (mTextBoxPort.Text.Length == 0)
                        throw new CIDetectorException("TCP Port가 올바르지 않습니다.");
                    if (mTextBoxSID.Text.Length == 0)
                        throw new CIDetectorException("SID가 올바르지 않습니다.");

                    connstr = mv_dbUtil.GetConnectionString("Direct",
                        mTextBoxID.Text,
                        mTextBoxPasswd.Text,
                        "",
                        mTextBoxHost.Text,
                        mTextBoxPort.Text,
                        mTextBoxSID.Text,
                        "Normal");
                }
                else
                {
                    string tnsNameDecription = DBEnv.GetTnsNameDescription(mComboBoxTNS.Text, mTextBoxTNSPath.Text);
                    host = mComboBoxTNS.Text;
                    connstr = mv_dbUtil.GetConnectionString("TNS",
                        mTextBoxID.Text,
                        mTextBoxPasswd.Text,
                        tnsNameDecription,
                        mTextBoxHost.Text,
                        mTextBoxPort.Text,
                        mTextBoxSID.Text,
                        "Normal");

                }



                if (isBatchMode)
                {
                    connstr = mv_BatchConnStr;



                }



                mv_DBConnection = mv_dbUtil.getOracleConnection(connstr);




                mv_DBConnection.Open();

                this.mToolStripLabelConnectionStatus.Text = string.Format("{0}@{1} OK", mTextBoxID.Text, host);
                this.mToolStripLabelConnectionStatus.BackColor = Color.LawnGreen;








            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                this.mToolStripLabelConnectionStatus.Text = string.Format("{0}@{1} Connection Failure", mTextBoxSID.Text, mTextBoxHost.Text);
                this.mToolStripLabelConnectionStatus.BackColor = Color.Red;
                AddLog("RuleServer 접속실패");
                AddLog(ex.Message);
            }


        }

        private void mButtonConnect_Click(object sender, EventArgs e)
        {
            ConnectToRuleServer();
            


        }











        private void mRadioButtonTNS_Click(object sender, EventArgs e)
        {
            this.mGroupBoxDirect.Enabled = false;
            this.mGroupBoxTNS.Enabled = true;
        }

        private void mRadioButtonDirect_Click(object sender, EventArgs e)
        {
            this.mGroupBoxDirect.Enabled = true;
            this.mGroupBoxTNS.Enabled = false;
        }








        #endregion



        #region LogEvent


        private System.Object ProgressLock = new System.Object();
        public void ReceiveJobProgressInfo(object sender, DetectJobProgressInfo info)
        {
            DetectJobProgressInfo e = new DetectJobProgressInfo();
            lock (ProgressLock)
            {
                e = info.Clone() as DetectJobProgressInfo;
            }
            if (this.InvokeRequired)
            {

              //  BeginInvoke(new MethodInvoker(delegate() { UpdateProgressLog(sender, e); }));
            }
            else
            {
              //  UpdateProgressLog(sender, e);
            }

        }


        #endregion


        private void mButtonStop_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_Click(object sender, EventArgs e)
        {

        }



        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.Show();
        }


        private void GenerateJobList()
        {
            try
            {
                isStopIssued = false;
                AddLog("패스워드변경대상 갖고오기 시작");
                SQLJobThread jobThread = new SQLJobThread(mv_dbUtil);


                DataTable dt = jobThread.CreatePasswordChangeJob(mv_dbUtil);

                DataColumn[] keys = new DataColumn[3];
                keys[0] = dt.Columns["PWD_CHG_OPER_SEQ"];
                keys[1] = dt.Columns["DB_ID"];
                keys[2] = dt.Columns["ACNT_NM"];

                dt.PrimaryKey = keys;


                dataGridView1.DataSource = dt;


                if (dt.Rows.Count > 0)
                {
                    textBox1.Text = dt.Rows[0]["PWD_CHG_OPER_SEQ"].ToString();

                }


                textBox2.Text = "da_" + StringUtil.GeneratePassword(14, 4, 5);


                button5.Enabled = true;
                button3.Enabled = true;


            }
            catch (Exception ex)
            {
                AddLog("패스워드변경대상 갖고오기 실패");
                AddLog(ex.Message);
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            GenerateJobList();

            //jobThread.Start();
        }


        private void StartPasswordChangeJob()
        {
            DataTable dt = (DataTable)dataGridView1.DataSource;
            isStopIssued = false;

            if (string.IsNullOrEmpty(textBox2.Text))
            {
                AddLog("새 패스워드가 정해지지 않았습니다.작업을 중지합니다.");
                return;
            }

            AddLog("패스워드 변경작업 시작!");

            backgroundWorker2.RunWorkerAsync(dt);

            button2.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StartPasswordChangeJob();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            isStopIssued = true;
            AddLog("취소버튼을 눌렀습니다.");
            if (backgroundWorker1.IsBusy)
            {
                backgroundWorker1.CancelAsync();
                MessageBox.Show("접속테스트 취소됐음.");
                AddLog("접속테스트 취소됐음.");
            }

            if (backgroundWorker2.IsBusy)
            {
                backgroundWorker2.CancelAsync();
                MessageBox.Show("패스워드 변경작업 취소됐음.");
                AddLog("패스워드 변경작업 취소됐음.");
            }

        }


        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                ((DataGridViewCheckBoxCell)row.Cells["OPER_YN"]).Value = true;

            }
            dataGridView1.Update();
        }

        private void DeselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                ((DataGridViewCheckBoxCell)row.Cells["OPER_YN"]).Value = false;

            }
            dataGridView1.Update();
        }

        private void InvertSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (((DataGridViewCheckBoxCell)row.Cells["OPER_YN"]).Value.ToString() == "1")
                {
                    ((DataGridViewCheckBoxCell)row.Cells["OPER_YN"]).Value = false;
                }
                else
                {
                    ((DataGridViewCheckBoxCell)row.Cells["OPER_YN"]).Value = true;
                }




            }
            dataGridView1.Update();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AddLog("접속테스트 시작.");
            DataTable dt = (DataTable)dataGridView1.DataSource;
            isStopIssued = false;
            backgroundWorker1.RunWorkerAsync(dt);


            button2.Enabled = false;
            button5.Enabled = false;
            button3.Enabled = false;



        }






        #region ConnectionTester
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            DataTable dt = e.Argument as DataTable;


            SQLJobThread jobThread = new SQLJobThread(mv_dbUtil);

            string af_pwd = textBox2.Text;
            string seq = textBox1.Text;

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                
                if (isStopIssued)
                {
                    isStopIssued = false;
                    break;
                }

                

                DataRow dr = dt.Rows[i];


                if (dr["OPER_YN"].ToString() != "1")
                {
                    continue;
                }

                try
                {
                    if (dr["PWD_TYP_CL_CD"].ToString() == "ENC")
                    {
                        dr["BF_PWD"] = Cipher.Decrypt(dr["BF_PWD"].ToString());
                    }

                }
                catch (Exception ex)
                {

                }


                WorkResult result = new WorkResult();
                result.PWD_CHG_OPER_SEQ = dr["PWD_CHG_OPER_SEQ"].ToString();
                result.DB_ID = dr["DB_ID"].ToString();
                result.ACNT_NM = dr["ACNT_NM"].ToString();


                result.OP_RSLT = "Connecting...";
                backgroundWorker1.ReportProgress(0, result);


                string workresult = jobThread.TestConnection(dr["CONN_STR_CTT"].ToString(), dr["ACNT_NM"].ToString(), dr["BF_PWD"].ToString());


                WorkResult result1 = new WorkResult();
                result1.PWD_CHG_OPER_SEQ = dr["PWD_CHG_OPER_SEQ"].ToString();
                result1.DB_ID = dr["DB_ID"].ToString();
                result1.ACNT_NM = dr["ACNT_NM"].ToString();

                result1.OP_RSLT = workresult;
                backgroundWorker1.ReportProgress(0, result1);
                //dr["OP_RSLT"] = result;



            }

        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            WorkResult result = e.UserState as WorkResult;

            DataTable dt = (DataTable)dataGridView1.DataSource;


            object[] searchVals = new object[3];

            searchVals[0] = result.PWD_CHG_OPER_SEQ;
            searchVals[1] = result.DB_ID;
            searchVals[2] = result.ACNT_NM;

            dt.Rows.Find(searchVals)["OP_RSLT"] = result.OP_RSLT;
            

            //dt.Rows[result.GridIndex]["OP_RSLT"] = result.OP_RSLT;
            

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            button2.Enabled = true;
            button5.Enabled = true;
            button3.Enabled = true;
            AddLog("접속테스트 종료.");
        }

        #endregion






        #region PasswordChanger

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            DataTable dt = e.Argument as DataTable;


            SQLJobThread jobThread = new SQLJobThread(mv_dbUtil);




            
            string seq = textBox1.Text;

            foreach (DataRow dr in dt.Rows)
            {
                
                if (isStopIssued)
                {
                    isStopIssued = false;
                    break;
                }
                

                if (dr["OPER_YN"].ToString() != "1")
                {
                    continue;
                }


                string af_pwd = "da_" + StringUtil.GeneratePassword(14, 4, 5);

                backgroundWorker2.ReportProgress(0, af_pwd);

                WorkResult result0 = new WorkResult();
                result0.PWD_CHG_OPER_SEQ = dr["PWD_CHG_OPER_SEQ"].ToString();
                result0.DB_ID = dr["DB_ID"].ToString();
                result0.ACNT_NM = dr["ACNT_NM"].ToString();
                result0.OP_RSLT = "Connecting...";


                backgroundWorker2.ReportProgress(10, result0);


                try
                {
                    if (dr["PWD_TYP_CL_CD"].ToString() == "ENC")
                    {
                        dr["BF_PWD"] = Cipher.Decrypt(dr["BF_PWD"].ToString());
                    }

                }
                catch (Exception ex)
                {

                }


                string workresult1 = jobThread.ChangePassword(dr["CONN_STR_CTT"].ToString(), dr["ACNT_NM"].ToString(), dr["BF_PWD"].ToString(), af_pwd);

                WorkResult result1 = new WorkResult();
                result1.PWD_CHG_OPER_SEQ = dr["PWD_CHG_OPER_SEQ"].ToString();
                result1.DB_ID = dr["DB_ID"].ToString();
                result1.ACNT_NM = dr["ACNT_NM"].ToString();
                result1.OP_RSLT = workresult1;
                result1.DisbleRow = true;

                backgroundWorker2.ReportProgress(20, result1);



                if (workresult1 == "Success")
                {
                    

                    WorkResult result2 = new WorkResult();
                    result2.PWD_CHG_OPER_SEQ = dr["PWD_CHG_OPER_SEQ"].ToString();
                    result2.DB_ID = dr["DB_ID"].ToString();
                    result2.ACNT_NM = dr["ACNT_NM"].ToString();
                    result2.AF_PWD = af_pwd;
                    backgroundWorker2.ReportProgress(30, result2);



                    string af_pwd_enc = af_pwd;
                    try
                    {
                        if (dr["PWD_TYP_CL_CD"].ToString() == "ENC")
                        {
                            af_pwd_enc = Cipher.Encrypt(af_pwd_enc);
                        }

                    }
                    catch (Exception ex)
                    {

                    }



                    string workresult2 = jobThread.UpdateOrncInfo(mv_dbUtil, dr["PWD_CHG_OPER_SEQ"].ToString(), dr["DB_ID"].ToString(), dr["ACNT_NM"].ToString(), dr["RAC_GRP_NM"].ToString(), af_pwd_enc);

                    WorkResult result3 = new WorkResult();
                    result3.PWD_CHG_OPER_SEQ = dr["PWD_CHG_OPER_SEQ"].ToString();
                    result3.DB_ID = dr["DB_ID"].ToString();
                    result3.ACNT_NM = dr["ACNT_NM"].ToString();
                    result3.OP_RSLT = workresult2;
                    backgroundWorker2.ReportProgress(40, result3);


                    jobThread.UpdateOpeationHistory(mv_dbUtil, seq, dr["DB_ID"].ToString(), dr["ACNT_NM"].ToString(), af_pwd_enc, workresult2);
                }
                else
                {
                    jobThread.UpdateOpeationHistory(mv_dbUtil, seq, dr["DB_ID"].ToString(), dr["ACNT_NM"].ToString(), "", workresult1);
                }

            }

        }


        private void backgroundWorker2_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            
            if (e.ProgressPercentage == 0)
            {
                textBox2.Text = e.UserState.ToString();


            }
            else
            {
                WorkResult result = e.UserState as WorkResult;
                DataTable dt = (DataTable)dataGridView1.DataSource;


                object[] searchVals = new object[3];

                searchVals[0] = result.PWD_CHG_OPER_SEQ;
                searchVals[1] = result.DB_ID;
                searchVals[2] = result.ACNT_NM;


                if (!string.IsNullOrEmpty(result.OP_RSLT))
                {
                    dt.Rows.Find(searchVals)["OP_RSLT"] = result.OP_RSLT;
                }

                if (!string.IsNullOrEmpty(result.AF_PWD))
                {
                    dt.Rows.Find(searchVals)["AF_PWD"] = result.AF_PWD;
                }

                if (result.DisbleRow)
                {
                    dt.Rows.Find(searchVals)["OPER_YN"] = false;


                    //((DataGridViewCheckBoxCell)dt.Rows.Find(searchVals)["OPER_YN"]).ReadOnly = true;

                }
            }

        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            AddLog("패스워드 변경작업 종료!");
            button2.Enabled = true;
            button5.Enabled = true;
            button3.Enabled = true;

            if (isBatchMode)
            {
                toolStripLabel2.Text = "배치작업 종료되었습니다.";
                AddLog("배치작업 종료.");
            }

        }








        #endregion

        private void buttonEncode_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxOriginal.Text))
                {
                    textBoxEncoded.Text = Cipher.Encrypt(textBoxOriginal.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(textBoxEncoded.Text))
                {
                    textBoxOriginal.Text = Cipher.Decrypt(textBoxEncoded.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


    }



    public class WorkResult
    {
        string mv_PWD_CHG_OPER_SEQ;
        string mv_DB_ID;
        string mv_ACNT_NM;
        string mv_OP_RSLT;
        string mv_AF_PWD;
        bool mv_DisbleRow;

        public bool DisbleRow
        {
            get { return mv_DisbleRow; }
            set { mv_DisbleRow = value; }
        }

        public string AF_PWD
        {
            get { return mv_AF_PWD; }
            set { mv_AF_PWD = value; }
        }
        public string PWD_CHG_OPER_SEQ
        {
            get { return mv_PWD_CHG_OPER_SEQ; }
            set { mv_PWD_CHG_OPER_SEQ = value; }
        }
        public string DB_ID
        {
            get { return mv_DB_ID; }
            set { mv_DB_ID = value; }
        }
        public string ACNT_NM
        {
            get { return mv_ACNT_NM; }
            set { mv_ACNT_NM = value; }
        }
        public string OP_RSLT
        {
            get { return mv_OP_RSLT; }
            set { mv_OP_RSLT = value; }
        }
    }

}
