namespace MainForm
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.testToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mToolStripLabelConnectionStatus = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mGroupBoxConnectMethod = new System.Windows.Forms.GroupBox();
            this.mTextBoxCharSet = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.mRadioButtonDirect = new System.Windows.Forms.RadioButton();
            this.mRadioButtonTNS = new System.Windows.Forms.RadioButton();
            this.mGroupBoxTNS = new System.Windows.Forms.GroupBox();
            this.mTextBoxTNSPath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.mComboBoxTNS = new System.Windows.Forms.ComboBox();
            this.mGroupBoxDirect = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mTextBoxHost = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mTextBoxPort = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mTextBoxSID = new System.Windows.Forms.TextBox();
            this.mButtonConnect = new System.Windows.Forms.Button();
            this.mTextBoxPasswd = new System.Windows.Forms.TextBox();
            this.mTextBoxID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OPER_YN = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OP_RSLT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PWD_CHG_OPER_SEQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DB_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACNT_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONN_STR_CTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OPER_STA_DTM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RAC_GRP_NM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BF_PWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AF_PWD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InvertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDecode = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxEncoded = new System.Windows.Forms.TextBox();
            this.buttonEncode = new System.Windows.Forms.Button();
            this.textBoxOriginal = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mGroupBoxConnectMethod.SuspendLayout();
            this.mGroupBoxTNS.SuspendLayout();
            this.mGroupBoxDirect.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(814, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.testToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem1.Text = "Help";
            // 
            // testToolStripMenuItem
            // 
            this.testToolStripMenuItem.Name = "testToolStripMenuItem";
            this.testToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.testToolStripMenuItem.Text = "About";
            this.testToolStripMenuItem.Click += new System.EventHandler(this.testToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(814, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripSeparator1,
            this.mToolStripLabelConnectionStatus,
            this.toolStripSeparator2,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(814, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(69, 22);
            this.toolStripLabel1.Text = "Connection";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // mToolStripLabelConnectionStatus
            // 
            this.mToolStripLabelConnectionStatus.BackColor = System.Drawing.SystemColors.Control;
            this.mToolStripLabelConnectionStatus.Name = "mToolStripLabelConnectionStatus";
            this.mToolStripLabelConnectionStatus.Size = new System.Drawing.Size(36, 22);
            this.mToolStripLabelConnectionStatus.Text = "None";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.BackColor = System.Drawing.Color.OrangeRed;
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(0, 22);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 49);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.richTextBox1);
            this.splitContainer1.Size = new System.Drawing.Size(814, 425);
            this.splitContainer1.SplitterDistance = 370;
            this.splitContainer1.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 363);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mGroupBoxConnectMethod);
            this.tabPage1.Controls.Add(this.mGroupBoxTNS);
            this.tabPage1.Controls.Add(this.mGroupBoxDirect);
            this.tabPage1.Controls.Add(this.mButtonConnect);
            this.tabPage1.Controls.Add(this.mTextBoxPasswd);
            this.tabPage1.Controls.Add(this.mTextBoxID);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(799, 337);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "DB접속";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mGroupBoxConnectMethod
            // 
            this.mGroupBoxConnectMethod.Controls.Add(this.mTextBoxCharSet);
            this.mGroupBoxConnectMethod.Controls.Add(this.label7);
            this.mGroupBoxConnectMethod.Controls.Add(this.mRadioButtonDirect);
            this.mGroupBoxConnectMethod.Controls.Add(this.mRadioButtonTNS);
            this.mGroupBoxConnectMethod.Location = new System.Drawing.Point(21, 10);
            this.mGroupBoxConnectMethod.Name = "mGroupBoxConnectMethod";
            this.mGroupBoxConnectMethod.Size = new System.Drawing.Size(441, 51);
            this.mGroupBoxConnectMethod.TabIndex = 13;
            this.mGroupBoxConnectMethod.TabStop = false;
            this.mGroupBoxConnectMethod.Text = "접속방식";
            // 
            // mTextBoxCharSet
            // 
            this.mTextBoxCharSet.Location = new System.Drawing.Point(248, 19);
            this.mTextBoxCharSet.Name = "mTextBoxCharSet";
            this.mTextBoxCharSet.Size = new System.Drawing.Size(187, 21);
            this.mTextBoxCharSet.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Client문자셋";
            // 
            // mRadioButtonDirect
            // 
            this.mRadioButtonDirect.AutoSize = true;
            this.mRadioButtonDirect.Location = new System.Drawing.Point(83, 20);
            this.mRadioButtonDirect.Name = "mRadioButtonDirect";
            this.mRadioButtonDirect.Size = new System.Drawing.Size(71, 16);
            this.mRadioButtonDirect.TabIndex = 1;
            this.mRadioButtonDirect.Text = "직접접속";
            this.mRadioButtonDirect.UseVisualStyleBackColor = true;
            this.mRadioButtonDirect.Click += new System.EventHandler(this.mRadioButtonDirect_Click);
            // 
            // mRadioButtonTNS
            // 
            this.mRadioButtonTNS.AutoSize = true;
            this.mRadioButtonTNS.Checked = true;
            this.mRadioButtonTNS.Location = new System.Drawing.Point(27, 20);
            this.mRadioButtonTNS.Name = "mRadioButtonTNS";
            this.mRadioButtonTNS.Size = new System.Drawing.Size(48, 16);
            this.mRadioButtonTNS.TabIndex = 0;
            this.mRadioButtonTNS.TabStop = true;
            this.mRadioButtonTNS.Text = "TNS";
            this.mRadioButtonTNS.UseVisualStyleBackColor = true;
            this.mRadioButtonTNS.Click += new System.EventHandler(this.mRadioButtonTNS_Click);
            // 
            // mGroupBoxTNS
            // 
            this.mGroupBoxTNS.Controls.Add(this.mTextBoxTNSPath);
            this.mGroupBoxTNS.Controls.Add(this.label8);
            this.mGroupBoxTNS.Controls.Add(this.mComboBoxTNS);
            this.mGroupBoxTNS.Location = new System.Drawing.Point(21, 67);
            this.mGroupBoxTNS.Name = "mGroupBoxTNS";
            this.mGroupBoxTNS.Size = new System.Drawing.Size(441, 53);
            this.mGroupBoxTNS.TabIndex = 12;
            this.mGroupBoxTNS.TabStop = false;
            this.mGroupBoxTNS.Text = "TNS정보";
            // 
            // mTextBoxTNSPath
            // 
            this.mTextBoxTNSPath.Location = new System.Drawing.Point(271, 21);
            this.mTextBoxTNSPath.Name = "mTextBoxTNSPath";
            this.mTextBoxTNSPath.Size = new System.Drawing.Size(164, 21);
            this.mTextBoxTNSPath.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(206, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "TNS Path";
            // 
            // mComboBoxTNS
            // 
            this.mComboBoxTNS.FormattingEnabled = true;
            this.mComboBoxTNS.Location = new System.Drawing.Point(10, 20);
            this.mComboBoxTNS.Name = "mComboBoxTNS";
            this.mComboBoxTNS.Size = new System.Drawing.Size(172, 20);
            this.mComboBoxTNS.TabIndex = 0;
            // 
            // mGroupBoxDirect
            // 
            this.mGroupBoxDirect.Controls.Add(this.label1);
            this.mGroupBoxDirect.Controls.Add(this.mTextBoxHost);
            this.mGroupBoxDirect.Controls.Add(this.label2);
            this.mGroupBoxDirect.Controls.Add(this.mTextBoxPort);
            this.mGroupBoxDirect.Controls.Add(this.label3);
            this.mGroupBoxDirect.Controls.Add(this.mTextBoxSID);
            this.mGroupBoxDirect.Enabled = false;
            this.mGroupBoxDirect.Location = new System.Drawing.Point(21, 126);
            this.mGroupBoxDirect.Name = "mGroupBoxDirect";
            this.mGroupBoxDirect.Size = new System.Drawing.Size(441, 72);
            this.mGroupBoxDirect.TabIndex = 11;
            this.mGroupBoxDirect.TabStop = false;
            this.mGroupBoxDirect.Text = "직접접속정보";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Host";
            // 
            // mTextBoxHost
            // 
            this.mTextBoxHost.Location = new System.Drawing.Point(46, 17);
            this.mTextBoxHost.Name = "mTextBoxHost";
            this.mTextBoxHost.Size = new System.Drawing.Size(244, 21);
            this.mTextBoxHost.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "port";
            // 
            // mTextBoxPort
            // 
            this.mTextBoxPort.Location = new System.Drawing.Point(354, 17);
            this.mTextBoxPort.Name = "mTextBoxPort";
            this.mTextBoxPort.Size = new System.Drawing.Size(81, 21);
            this.mTextBoxPort.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "SID";
            // 
            // mTextBoxSID
            // 
            this.mTextBoxSID.Location = new System.Drawing.Point(46, 40);
            this.mTextBoxSID.Name = "mTextBoxSID";
            this.mTextBoxSID.Size = new System.Drawing.Size(108, 21);
            this.mTextBoxSID.TabIndex = 5;
            // 
            // mButtonConnect
            // 
            this.mButtonConnect.Location = new System.Drawing.Point(307, 204);
            this.mButtonConnect.Name = "mButtonConnect";
            this.mButtonConnect.Size = new System.Drawing.Size(114, 39);
            this.mButtonConnect.TabIndex = 10;
            this.mButtonConnect.Text = "Connect";
            this.mButtonConnect.UseVisualStyleBackColor = true;
            this.mButtonConnect.Click += new System.EventHandler(this.mButtonConnect_Click);
            // 
            // mTextBoxPasswd
            // 
            this.mTextBoxPasswd.Location = new System.Drawing.Point(76, 228);
            this.mTextBoxPasswd.Name = "mTextBoxPasswd";
            this.mTextBoxPasswd.Size = new System.Drawing.Size(142, 21);
            this.mTextBoxPasswd.TabIndex = 9;
            this.mTextBoxPasswd.UseSystemPasswordChar = true;
            // 
            // mTextBoxID
            // 
            this.mTextBoxID.Location = new System.Drawing.Point(76, 201);
            this.mTextBoxID.Name = "mTextBoxID";
            this.mTextBoxID.Size = new System.Drawing.Size(142, 21);
            this.mTextBoxID.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "Passwd";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "ID";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 337);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "패스워드변경작업";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(309, 14);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 7;
            this.button5.Text = "접속테스트";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(415, 12);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(105, 21);
            this.textBox2.TabIndex = 6;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(677, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "정지!";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(196, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 4;
            this.label6.Text = "작업차수";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(255, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(35, 21);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(526, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 27);
            this.button3.TabIndex = 2;
            this.button3.Text = "패스워드변경시작";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(158, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "패스워드변경대상갖고오기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OPER_YN,
            this.OP_RSLT,
            this.PWD_CHG_OPER_SEQ,
            this.DB_ID,
            this.ACNT_NM,
            this.CONN_STR_CTT,
            this.OPER_STA_DTM,
            this.RAC_GRP_NM,
            this.BF_PWD,
            this.AF_PWD});
            this.dataGridView1.ContextMenuStrip = this.contextMenuStrip2;
            this.dataGridView1.Location = new System.Drawing.Point(7, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(786, 288);
            this.dataGridView1.TabIndex = 0;
            // 
            // OPER_YN
            // 
            this.OPER_YN.DataPropertyName = "OPER_YN";
            this.OPER_YN.HeaderText = "작업여부";
            this.OPER_YN.Name = "OPER_YN";
            this.OPER_YN.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // OP_RSLT
            // 
            this.OP_RSLT.DataPropertyName = "OP_RSLT";
            this.OP_RSLT.HeaderText = "작업결과";
            this.OP_RSLT.Name = "OP_RSLT";
            this.OP_RSLT.ReadOnly = true;
            // 
            // PWD_CHG_OPER_SEQ
            // 
            this.PWD_CHG_OPER_SEQ.DataPropertyName = "PWD_CHG_OPER_SEQ";
            this.PWD_CHG_OPER_SEQ.HeaderText = "작업차수";
            this.PWD_CHG_OPER_SEQ.Name = "PWD_CHG_OPER_SEQ";
            this.PWD_CHG_OPER_SEQ.ReadOnly = true;
            // 
            // DB_ID
            // 
            this.DB_ID.DataPropertyName = "DB_ID";
            this.DB_ID.HeaderText = "DBID";
            this.DB_ID.Name = "DB_ID";
            this.DB_ID.ReadOnly = true;
            // 
            // ACNT_NM
            // 
            this.ACNT_NM.DataPropertyName = "ACNT_NM";
            this.ACNT_NM.HeaderText = "계정명";
            this.ACNT_NM.Name = "ACNT_NM";
            this.ACNT_NM.ReadOnly = true;
            // 
            // CONN_STR_CTT
            // 
            this.CONN_STR_CTT.DataPropertyName = "CONN_STR_CTT";
            this.CONN_STR_CTT.HeaderText = "접속문자열";
            this.CONN_STR_CTT.Name = "CONN_STR_CTT";
            this.CONN_STR_CTT.ReadOnly = true;
            // 
            // OPER_STA_DTM
            // 
            this.OPER_STA_DTM.DataPropertyName = "OPER_STA_DTM";
            this.OPER_STA_DTM.HeaderText = "작업시작일시";
            this.OPER_STA_DTM.Name = "OPER_STA_DTM";
            this.OPER_STA_DTM.ReadOnly = true;
            // 
            // RAC_GRP_NM
            // 
            this.RAC_GRP_NM.DataPropertyName = "RAC_GRP_NM";
            this.RAC_GRP_NM.HeaderText = "RAC그룹명";
            this.RAC_GRP_NM.Name = "RAC_GRP_NM";
            // 
            // BF_PWD
            // 
            this.BF_PWD.DataPropertyName = "BF_PWD";
            this.BF_PWD.HeaderText = "이전비밀번호";
            this.BF_PWD.Name = "BF_PWD";
            this.BF_PWD.ReadOnly = true;
            // 
            // AF_PWD
            // 
            this.AF_PWD.DataPropertyName = "AF_PWD";
            this.AF_PWD.HeaderText = "이후비밀번호";
            this.AF_PWD.Name = "AF_PWD";
            this.AF_PWD.ReadOnly = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SelectAllToolStripMenuItem,
            this.DeselectAllToolStripMenuItem,
            this.InvertSelectionToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(147, 70);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.SelectAllToolStripMenuItem.Text = "모두선택";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // DeselectAllToolStripMenuItem
            // 
            this.DeselectAllToolStripMenuItem.Name = "DeselectAllToolStripMenuItem";
            this.DeselectAllToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.DeselectAllToolStripMenuItem.Text = "모두선택해제";
            this.DeselectAllToolStripMenuItem.Click += new System.EventHandler(this.DeselectAllToolStripMenuItem_Click);
            // 
            // InvertSelectionToolStripMenuItem
            // 
            this.InvertSelectionToolStripMenuItem.Name = "InvertSelectionToolStripMenuItem";
            this.InvertSelectionToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.InvertSelectionToolStripMenuItem.Text = "선택반전";
            this.InvertSelectionToolStripMenuItem.Click += new System.EventHandler(this.InvertSelectionToolStripMenuItem_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDecode);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.textBoxEncoded);
            this.tabPage3.Controls.Add(this.buttonEncode);
            this.tabPage3.Controls.Add(this.textBoxOriginal);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(799, 337);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDecode
            // 
            this.buttonDecode.Location = new System.Drawing.Point(266, 67);
            this.buttonDecode.Name = "buttonDecode";
            this.buttonDecode.Size = new System.Drawing.Size(75, 23);
            this.buttonDecode.TabIndex = 4;
            this.buttonDecode.Text = "<-";
            this.buttonDecode.UseVisualStyleBackColor = true;
            this.buttonDecode.Click += new System.EventHandler(this.buttonDecode_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "original";
            // 
            // textBoxEncoded
            // 
            this.textBoxEncoded.Location = new System.Drawing.Point(371, 40);
            this.textBoxEncoded.Multiline = true;
            this.textBoxEncoded.Name = "textBoxEncoded";
            this.textBoxEncoded.Size = new System.Drawing.Size(202, 50);
            this.textBoxEncoded.TabIndex = 2;
            // 
            // buttonEncode
            // 
            this.buttonEncode.Location = new System.Drawing.Point(266, 38);
            this.buttonEncode.Name = "buttonEncode";
            this.buttonEncode.Size = new System.Drawing.Size(75, 23);
            this.buttonEncode.TabIndex = 1;
            this.buttonEncode.Text = "->";
            this.buttonEncode.UseVisualStyleBackColor = true;
            this.buttonEncode.Click += new System.EventHandler(this.buttonEncode_Click);
            // 
            // textBoxOriginal
            // 
            this.textBoxOriginal.Location = new System.Drawing.Point(31, 40);
            this.textBoxOriginal.Multiline = true;
            this.textBoxOriginal.Name = "textBoxOriginal";
            this.textBoxOriginal.Size = new System.Drawing.Size(202, 50);
            this.textBoxOriginal.TabIndex = 0;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(814, 51);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.WorkerReportsProgress = true;
            this.backgroundWorker2.WorkerSupportsCancellation = true;
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker2_ProgressChanged);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 496);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Alias사용안한SQL찾기";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.mGroupBoxConnectMethod.ResumeLayout(false);
            this.mGroupBoxConnectMethod.PerformLayout();
            this.mGroupBoxTNS.ResumeLayout(false);
            this.mGroupBoxTNS.PerformLayout();
            this.mGroupBoxDirect.ResumeLayout(false);
            this.mGroupBoxDirect.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem testToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel mToolStripLabelConnectionStatus;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox mGroupBoxConnectMethod;
        private System.Windows.Forms.TextBox mTextBoxCharSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton mRadioButtonDirect;
        private System.Windows.Forms.RadioButton mRadioButtonTNS;
        private System.Windows.Forms.GroupBox mGroupBoxTNS;
        private System.Windows.Forms.TextBox mTextBoxTNSPath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox mComboBoxTNS;
        private System.Windows.Forms.GroupBox mGroupBoxDirect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox mTextBoxHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mTextBoxPort;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox mTextBoxSID;
        private System.Windows.Forms.Button mButtonConnect;
        private System.Windows.Forms.TextBox mTextBoxPasswd;
        private System.Windows.Forms.TextBox mTextBoxID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn OPER_YN;
        private System.Windows.Forms.DataGridViewTextBoxColumn OP_RSLT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PWD_CHG_OPER_SEQ;
        private System.Windows.Forms.DataGridViewTextBoxColumn DB_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ACNT_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONN_STR_CTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn OPER_STA_DTM;
        private System.Windows.Forms.DataGridViewTextBoxColumn RAC_GRP_NM;
        private System.Windows.Forms.DataGridViewTextBoxColumn BF_PWD;
        private System.Windows.Forms.DataGridViewTextBoxColumn AF_PWD;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem InvertSelectionToolStripMenuItem;
        private System.Windows.Forms.Button button5;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxEncoded;
        private System.Windows.Forms.Button buttonEncode;
        private System.Windows.Forms.TextBox textBoxOriginal;
        private System.Windows.Forms.Button buttonDecode;
    }
}

