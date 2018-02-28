namespace TF.Windows.QZServer.Manager
{
    partial class frmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pTool = new System.Windows.Forms.Panel();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tripService = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tripMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.lstTrigger = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeJobs = new System.Windows.Forms.TreeView();
            this.popmenuJob = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miJobStart = new System.Windows.Forms.ToolStripMenuItem();
            this.miJobStop = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miJobAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.miJobEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miJobDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTrigger = new System.Windows.Forms.Timer(this.components);
            this.pTool.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.popmenuJob.SuspendLayout();
            this.SuspendLayout();
            // 
            // pTool
            // 
            this.pTool.Controls.Add(this.btnOpenDir);
            this.pTool.Controls.Add(this.btnUninstall);
            this.pTool.Controls.Add(this.btnInstall);
            this.pTool.Controls.Add(this.btnStop);
            this.pTool.Controls.Add(this.btnStart);
            this.pTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTool.Location = new System.Drawing.Point(0, 0);
            this.pTool.Name = "pTool";
            this.pTool.Size = new System.Drawing.Size(1228, 53);
            this.pTool.TabIndex = 0;
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(373, 12);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDir.TabIndex = 4;
            this.btnOpenDir.Text = "打开目录";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(254, 12);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnUninstall.TabIndex = 3;
            this.btnUninstall.Text = "卸载";
            this.btnUninstall.UseVisualStyleBackColor = true;
            this.btnUninstall.Click += new System.EventHandler(this.btnUninstall_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(173, 12);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Text = "安装";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(92, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tripService,
            this.toolStripStatusLabel1,
            this.tripMode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 489);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1228, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tripService
            // 
            this.tripService.Name = "tripService";
            this.tripService.Size = new System.Drawing.Size(98, 17);
            this.tripService.Text = "ServicePool.exe";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // tripMode
            // 
            this.tripMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tripMode.Name = "tripMode";
            this.tripMode.Size = new System.Drawing.Size(56, 17);
            this.tripMode.Text = "运行模式";
            this.tripMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1228, 436);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbLog);
            this.panel2.Controls.Add(this.lstTrigger);
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.treeJobs);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1228, 436);
            this.panel2.TabIndex = 0;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(232, 0);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(996, 363);
            this.tbLog.TabIndex = 13;
            // 
            // lstTrigger
            // 
            this.lstTrigger.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader1,
            this.columnHeader8,
            this.columnHeader2,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lstTrigger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstTrigger.FullRowSelect = true;
            this.lstTrigger.GridLines = true;
            this.lstTrigger.HideSelection = false;
            this.lstTrigger.Location = new System.Drawing.Point(232, 363);
            this.lstTrigger.Name = "lstTrigger";
            this.lstTrigger.Size = new System.Drawing.Size(996, 73);
            this.lstTrigger.TabIndex = 11;
            this.lstTrigger.UseCompatibleStateImageBehavior = false;
            this.lstTrigger.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "状态";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "触发计划";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "所属组";
            this.columnHeader8.Width = 129;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "执行内容";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "开始时间";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "结束时间";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "上一次执行时间";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "下一次执行时间";
            this.columnHeader7.Width = 130;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(220, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 436);
            this.splitter1.TabIndex = 10;
            this.splitter1.TabStop = false;
            // 
            // treeJobs
            // 
            this.treeJobs.ContextMenuStrip = this.popmenuJob;
            this.treeJobs.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeJobs.HideSelection = false;
            this.treeJobs.Location = new System.Drawing.Point(0, 0);
            this.treeJobs.Name = "treeJobs";
            this.treeJobs.ShowLines = false;
            this.treeJobs.Size = new System.Drawing.Size(220, 436);
            this.treeJobs.TabIndex = 9;
            this.treeJobs.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeJobs_AfterSelect);
            // 
            // popmenuJob
            // 
            this.popmenuJob.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miJobStart,
            this.miJobStop,
            this.toolStripMenuItem1,
            this.miJobAdd,
            this.miJobEdit,
            this.miJobDelete});
            this.popmenuJob.Name = "popmenuTrigger";
            this.popmenuJob.Size = new System.Drawing.Size(101, 120);
            this.popmenuJob.Opening += new System.ComponentModel.CancelEventHandler(this.popmenuJob_Opening);
            // 
            // miJobStart
            // 
            this.miJobStart.Name = "miJobStart";
            this.miJobStart.Size = new System.Drawing.Size(100, 22);
            this.miJobStart.Text = "启动";
            this.miJobStart.Click += new System.EventHandler(this.miJobStart_Click);
            // 
            // miJobStop
            // 
            this.miJobStop.Name = "miJobStop";
            this.miJobStop.Size = new System.Drawing.Size(100, 22);
            this.miJobStop.Text = "暂停";
            this.miJobStop.Click += new System.EventHandler(this.miJobStop_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // miJobAdd
            // 
            this.miJobAdd.Name = "miJobAdd";
            this.miJobAdd.Size = new System.Drawing.Size(100, 22);
            this.miJobAdd.Text = "添加";
            this.miJobAdd.Click += new System.EventHandler(this.miJobAdd_Click);
            // 
            // miJobEdit
            // 
            this.miJobEdit.Name = "miJobEdit";
            this.miJobEdit.Size = new System.Drawing.Size(100, 22);
            this.miJobEdit.Text = "修改";
            this.miJobEdit.Click += new System.EventHandler(this.miJobEdit_Click);
            // 
            // miJobDelete
            // 
            this.miJobDelete.Name = "miJobDelete";
            this.miJobDelete.Size = new System.Drawing.Size(100, 22);
            this.miJobDelete.Text = "删除";
            this.miJobDelete.Click += new System.EventHandler(this.miJobDelete_Click);
            // 
            // tmrTrigger
            // 
            this.tmrTrigger.Tick += new System.EventHandler(this.tmrTrigger_Tick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 511);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pTool);
            this.Name = "frmMain";
            this.Text = "服务管理器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.pTool.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.popmenuJob.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pTool;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.ToolStripStatusLabel tripService;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView treeJobs;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.ListView lstTrigger;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ContextMenuStrip popmenuJob;
        private System.Windows.Forms.ToolStripMenuItem miJobStart;
        private System.Windows.Forms.ToolStripMenuItem miJobStop;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Timer tmrTrigger;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miJobAdd;
        private System.Windows.Forms.ToolStripMenuItem miJobEdit;
        private System.Windows.Forms.ToolStripMenuItem miJobDelete;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.ToolStripStatusLabel tripMode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}

