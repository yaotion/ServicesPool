namespace TF.Windows.QZServer.Utils
{
    partial class frmMain_New
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrTrigger = new System.Windows.Forms.Timer(this.components);
            this.miJobEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.miJobAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.miJobStop = new System.Windows.Forms.ToolStripMenuItem();
            this.miJobStart = new System.Windows.Forms.ToolStripMenuItem();
            this.popmenuJob = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miJobDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.treeJobs = new System.Windows.Forms.TreeView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstTrigger = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tripMode = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tripService = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.btnUninstall = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.pTool = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.popmenuJob.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pTool.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(909, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            // 
            // miJobEdit
            // 
            this.miJobEdit.Name = "miJobEdit";
            this.miJobEdit.Size = new System.Drawing.Size(100, 22);
            this.miJobEdit.Text = "修改";
            // 
            // miJobAdd
            // 
            this.miJobAdd.Name = "miJobAdd";
            this.miJobAdd.Size = new System.Drawing.Size(100, 22);
            this.miJobAdd.Text = "添加";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(97, 6);
            // 
            // miJobStop
            // 
            this.miJobStop.Name = "miJobStop";
            this.miJobStop.Size = new System.Drawing.Size(100, 22);
            this.miJobStop.Text = "暂停";
            // 
            // miJobStart
            // 
            this.miJobStart.Name = "miJobStart";
            this.miJobStart.Size = new System.Drawing.Size(100, 22);
            this.miJobStart.Text = "启动";
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
            // 
            // miJobDelete
            // 
            this.miJobDelete.Name = "miJobDelete";
            this.miJobDelete.Size = new System.Drawing.Size(100, 22);
            this.miJobDelete.Text = "删除";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(220, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(12, 445);
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
            this.treeJobs.Size = new System.Drawing.Size(220, 445);
            this.treeJobs.TabIndex = 9;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "下一次执行时间";
            this.columnHeader7.Width = 130;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "上一次执行时间";
            this.columnHeader6.Width = 130;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "结束时间";
            this.columnHeader5.Width = 130;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "开始时间";
            this.columnHeader4.Width = 130;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "执行内容";
            this.columnHeader2.Width = 300;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "所属组";
            this.columnHeader8.Width = 129;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "触发计划";
            this.columnHeader1.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "状态";
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
            this.lstTrigger.Location = new System.Drawing.Point(232, 372);
            this.lstTrigger.Name = "lstTrigger";
            this.lstTrigger.Size = new System.Drawing.Size(677, 73);
            this.lstTrigger.TabIndex = 11;
            this.lstTrigger.UseCompatibleStateImageBehavior = false;
            this.lstTrigger.View = System.Windows.Forms.View.Details;
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
            this.panel2.Size = new System.Drawing.Size(909, 445);
            this.panel2.TabIndex = 0;
            // 
            // tbLog
            // 
            this.tbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbLog.Location = new System.Drawing.Point(232, 0);
            this.tbLog.Multiline = true;
            this.tbLog.Name = "tbLog";
            this.tbLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tbLog.Size = new System.Drawing.Size(677, 372);
            this.tbLog.TabIndex = 13;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(909, 445);
            this.panel1.TabIndex = 5;
            // 
            // tripMode
            // 
            this.tripMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tripMode.Name = "tripMode";
            this.tripMode.Size = new System.Drawing.Size(56, 17);
            this.tripMode.Text = "运行模式";
            this.tripMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(11, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // tripService
            // 
            this.tripService.Name = "tripService";
            this.tripService.Size = new System.Drawing.Size(98, 17);
            this.tripService.Text = "ServicePool.exe";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tripService,
            this.toolStripStatusLabel1,
            this.tripMode});
            this.statusStrip1.Location = new System.Drawing.Point(0, 523);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(909, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(373, 12);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDir.TabIndex = 4;
            this.btnOpenDir.Text = "打开目录";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            // 
            // btnUninstall
            // 
            this.btnUninstall.Location = new System.Drawing.Point(254, 12);
            this.btnUninstall.Name = "btnUninstall";
            this.btnUninstall.Size = new System.Drawing.Size(75, 23);
            this.btnUninstall.TabIndex = 3;
            this.btnUninstall.Text = "卸载";
            this.btnUninstall.UseVisualStyleBackColor = true;
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(173, 12);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(75, 23);
            this.btnInstall.TabIndex = 2;
            this.btnInstall.Text = "安装";
            this.btnInstall.UseVisualStyleBackColor = true;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(92, 12);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 1;
            this.btnStop.Text = "停止";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(11, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "启动";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // pTool
            // 
            this.pTool.Controls.Add(this.btnOpenDir);
            this.pTool.Controls.Add(this.btnUninstall);
            this.pTool.Controls.Add(this.btnInstall);
            this.pTool.Controls.Add(this.btnStop);
            this.pTool.Controls.Add(this.btnStart);
            this.pTool.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTool.Location = new System.Drawing.Point(0, 25);
            this.pTool.Name = "pTool";
            this.pTool.Size = new System.Drawing.Size(909, 53);
            this.pTool.TabIndex = 3;
            // 
            // frmMain_New
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 545);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pTool);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain_New";
            this.Text = "frmMain_New";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.popmenuJob.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pTool.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.Timer tmrTrigger;
        private System.Windows.Forms.ToolStripMenuItem miJobEdit;
        private System.Windows.Forms.ToolStripMenuItem miJobAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miJobStop;
        private System.Windows.Forms.ToolStripMenuItem miJobStart;
        private System.Windows.Forms.ContextMenuStrip popmenuJob;
        private System.Windows.Forms.ToolStripMenuItem miJobDelete;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TreeView treeJobs;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lstTrigger;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripStatusLabel tripMode;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tripService;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.Button btnUninstall;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pTool;
    }
}