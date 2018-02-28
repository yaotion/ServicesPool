using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quartz;
using TF.Windows;
using Quartz.Impl.Matchers;
using Quartz.Impl.Triggers;
using Quartz.Impl;
using System.Xml.Serialization;
using Quartz.Xml.JobSchedulingData20;
using System.IO;
using Quartz.Util;
using Quartz.Spi;
using System.ServiceProcess;
using System.Text.RegularExpressions;


namespace TF.Windows.QZServer.Manager
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            Init();            
        }
        private TF.Windows.QZServer.Manager.QuartzScheduler scheduler;        
        private TFTriggerListener triggerListener = new TFTriggerListener();        
        public static string ServiceName = "TF.Windows.QZServer.exe";
        public static string ServerIP = "127.0.0.1";
        public static int ServerPort = 555;
        public static string QuartzScheduler = "QuartzScheduler";
        private static string JobConfigFile = "quartz_jobs.xml";
        private static string LogRegex = @"(\d{2}:\d{2}:\d{2})\[(.+)\]\{(.+)\}-(.+)";
        private TFLog4UdpClient _TFUdp;
        private bool _InServicePath = false;
        public bool InServicePath
        {
            get
            {
                return _InServicePath;
            }
        }
        private void InitEnvironment()
        {
            string servicePath = TFSC.GetWindowsServiceInstallPath(ServiceName);
            string currentPath = Environment.CurrentDirectory;
            _InServicePath = servicePath.ToLower() == currentPath.ToLower();
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            DisableServiceBtns();
            TF.Windows.TFCommand.Exec(ServiceName + " start");
            RefreshServiceUI(true);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            DisableServiceBtns();
            TF.Windows.TFCommand.Exec(ServiceName + " stop");
            RefreshServiceUI(true);
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            DisableServiceBtns();
            TF.Windows.TFCommand.Exec(ServiceName + " install");
            RefreshServiceUI(false);
        }

        private void btnUninstall_Click(object sender, EventArgs e)
        {
            DisableServiceBtns();
            TF.Windows.TFCommand.Exec(ServiceName + " uninstall");
            RefreshServiceUI(false);        
        }
        private void ShowServiceInfo()
        {
            tripService.Text = ServiceName;
            ServiceController s = TFSC.GetService(ServiceName);
            if (s == null)
            {
                tripService.Text = "[未安装]" + ServiceName;
            }
            else {
                tripService.Text = "[" +s.DisplayName+ "]" + ServiceName;
            }
            if (InServicePath)
            {
                tripMode.Text = "编辑模式";
            }
            else
            {
                tripMode.Text = "控制模式";
            }
            
        }
        private void Init()
        {
            ShowServiceInfo();
            _TFUdp = new TFLog4UdpClient("127.0.0.1", 8080, 8080);
            _TFUdp.OnMsg = ReceiveLog;
            InitEnvironment();
            RefreshServiceUI(true); 
           
        }
        public void ReceiveLog(string Msg)
        {
            if (this.tbLog.InvokeRequired)
            {
                TFTlog4UDPEvent md = new TFTlog4UDPEvent(this.ReceiveLog);
                this.Invoke(md, new object[] { Msg });
            }
            else
            {
                
                Regex r = new Regex(LogRegex);//构造表达式
                Match m = r.Match(Msg);//匹配源文本                
                if (m.Groups.Count > 3)
                {
                    string matchString =m.Groups[3].Value.ToLower()  ;
                    string jobName = "";
                    if (treeJobs.SelectedNode != null)
                        jobName = treeJobs.SelectedNode.Text.ToLower();
                    string level = m.Groups[2].Value.Trim().ToLower();
                    if ((matchString == jobName) || (treeJobs.SelectedNode == null) || (treeJobs.SelectedNode.Level == 0))
                    {
                        tbLog.AppendText(Msg + "\r\n");
                        if (tbLog.Lines.Length > 200)
                        {
                            tbLog.Text = "";
                        }
                    }
                }
            }
        }
        private void DisableServiceBtns()
        {
             btnInstall.Enabled = false;
            btnUninstall.Enabled = false;
            btnStart.Enabled = false;
            btnStop.Enabled = false;
        }
        private void RefreshServiceUI(bool RefreshData)
        {
            TF.Windows.TFServiceState serviceState= TF.Windows.TFSC.GetServiceState(ServiceName);
            DisableServiceBtns();
            switch (serviceState)
            {
                case TF.Windows.TFServiceState.Uninstall:
                    btnInstall.Enabled = true;
                    break;
                case TF.Windows.TFServiceState.Stopped:
                    btnStart.Enabled = true;
                    btnUninstall.Enabled = true;
                    if (RefreshData)
                    {
                        ClearJobs();
                        tmrTrigger.Enabled = false;
                    }
                    break;
                case TF.Windows.TFServiceState.StartPending:
                    break;
                case TF.Windows.TFServiceState.StopPending:
                    break;
                case TF.Windows.TFServiceState.Running:                    
                    btnStop.Enabled = true;
                    if ((scheduler == null))
                    {
                        scheduler = new TF.Windows.QZServer.Manager.QuartzScheduler(ServerIP, ServerPort, QuartzScheduler);                        
                    }
                    if (RefreshData)
                    {
                        InitJobs();
                        tmrTrigger.Enabled = true;
                    }
                    break;
                case TF.Windows.TFServiceState.ContinuePending:
                    break;
                case TF.Windows.TFServiceState.PausePending:
                    break;
                case TF.Windows.TFServiceState.Paused:
                    break;
                default:
                    break;
            }
           
        }
        private void InitJobs()
        {
            treeJobs.Nodes.Clear();                    
            var jobGroups = scheduler.GetScheduler().GetJobGroupNames();
            foreach (string item in jobGroups)
            {
                TreeNode nodeJobGroup = new TreeNode(item);
                nodeJobGroup.Tag = item;
                treeJobs.Nodes.Add(nodeJobGroup);
                var matcher = GroupMatcher<JobKey>.GroupEquals(item);
                var jobKeys = scheduler.GetScheduler().GetJobKeys(matcher);
                foreach (var jobKey in jobKeys)
                {
                    TreeNode nodeJob = new TreeNode(jobKey.Name);
                    nodeJobGroup.Nodes.Add(nodeJob);
                    nodeJob.Tag = jobKey.Name;                                           
                }
            }                        
        }
        private void ClearJobs()
        {
            treeJobs.Nodes.Clear();
            lstTrigger.Items.Clear();
        }
        public string FormatTime(DateTimeOffset TimeOffset)
        {
            if (TimeOffset == null)
                return "null";
            return TimeOffset.ToLocalTime().ToString("yy-MM-dd HH:mm:ss");
        }
        public string FormatTime2(DateTimeOffset? TimeOffset)
        {
            if (TimeOffset == null)
                return "null";
            return TimeOffset.Value.ToLocalTime().ToString("yy-MM-dd HH:mm:ss");
        }
        public void InitTrigger(ListViewItem Item,ITrigger Trigger)
        {
            Item.SubItems.Clear();
            TriggerState ts = scheduler.GetScheduler().GetTriggerState(Trigger.Key);
            Item.Text = ts.ToString();
            Item.SubItems.Add(Trigger.Key.Name);
            Item.SubItems.Add(Trigger.Key.Group);
            string express = "";
            if (Trigger is SimpleTriggerImpl)
            {
                express = string.Format("repeate {0} times;repeat-interval {1}ms", (Trigger as ISimpleTrigger).RepeatCount,
                    (Trigger as ISimpleTrigger).RepeatInterval);
            }
            else
            {
                express = (Trigger as ICronTrigger).CronExpressionString;
            }
            
            Item.SubItems.Add(express);
            Item.SubItems.Add(FormatTime(Trigger.StartTimeUtc));
            Item.SubItems.Add(FormatTime2(Trigger.EndTimeUtc));
            Item.SubItems.Add(FormatTime2(Trigger.GetPreviousFireTimeUtc()));
            Item.SubItems.Add(FormatTime2(Trigger.GetNextFireTimeUtc()));
        }
        public void InitJobTriggers(string Key, string GroupName)
        {
            lstTrigger.Items.Clear();        
            var triggers = scheduler.GetScheduler().GetTriggersOfJob(new JobKey(Key,GroupName));
            foreach (ITrigger trigger in triggers)
            {                                             
                ListViewItem item = new ListViewItem();
                lstTrigger.Items.Add(item);
                InitTrigger(item,trigger);
            }
        }
        /// <summary>
        /// 刷新已有触发器的状态和时间
        /// </summary>
        public void RefreshTriggers()
        {
            foreach (ListViewItem item in lstTrigger.Items)
            {
                string triggerName = item.SubItems[1].Text;
                string groupName = item.SubItems[2].Text;
                ITrigger trigger = scheduler.GetScheduler().GetTrigger(new TriggerKey(triggerName, groupName));
                InitTrigger(item, trigger);
            }
        }
        private void treeJobs_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode node = e.Node;
            if (node == null) return;
            if (node.Level != 1) return;
            if (scheduler == null)
            {
                MessageBox.Show("未连接到服务");
                return;
            }
            InitJobTriggers((string)node.Tag, (string)node.Parent.Tag);
        }
       
        private void miJobStop_Click(object sender, EventArgs e)
        {            
            JobKey jobkey;
            if (!GetSelectedJob(out jobkey)) return;
            scheduler.GetScheduler().PauseJob(jobkey);             
        }

        private void tmrTrigger_Tick(object sender, EventArgs e)
        {
            ((Timer)sender).Enabled = false;
            try
            {
                RefreshTriggers();
            }
            finally
            {
                if (btnStart.Enabled == false)
                {
                    ((Timer)sender).Enabled = true;
                }
            }
        }

        private bool GetSelectedJob(out JobKey jKey)
        {
            jKey = null;
            TreeNode selectedNode = treeJobs.SelectedNode;
            if (selectedNode == null) return false;
            if (selectedNode.Level != 1) return false;

            jKey = new JobKey((string)selectedNode.Tag,(string)selectedNode.Parent.Tag);
            return true;

        }

        private void miJobStart_Click(object sender, EventArgs e)
        {
            JobKey jobkey;
            if (!GetSelectedJob(out jobkey)) return;
            scheduler.GetScheduler().ResumeJob(jobkey);
            
        }

        private void popmenuJob_Opening(object sender, CancelEventArgs e)
        {
            miJobAdd.Enabled = false;
            miJobEdit.Enabled = false;
            miJobDelete.Enabled = false;
            if (InServicePath)
            {
                miJobAdd.Enabled = true;
                miJobEdit.Enabled = true;
                miJobDelete.Enabled = true;
            }

            miJobStart.Enabled = false;
            miJobStop.Enabled = false;
            JobKey jobkey;
            if (!GetSelectedJob(out jobkey)) return;

            miJobStart.Enabled = true;
            miJobStop.Enabled = true;
            IList<ITrigger> triggersForJob = scheduler.GetScheduler().GetTriggersOfJob(jobkey);
            bool allPause = true;
            bool allNormal = true;
            foreach (IOperableTrigger trigger in triggersForJob)
            {
                if (scheduler.GetScheduler().GetTriggerState(trigger.Key) == TriggerState.Normal)
                {
                    allPause = false;
                }
                if (scheduler.GetScheduler().GetTriggerState(trigger.Key) == TriggerState.Paused)
                {
                    allNormal = false;
                }
            }
            if (allNormal) miJobStart.Enabled = false;
            if (allPause) miJobStop.Enabled = false;            
        }
        
        private void miJobAdd_Click(object sender, EventArgs e)
        {
            IJobDetail jobDetail = null;
            ITrigger trigger = null;

            if (frmJobAdd.Show(ref jobDetail,ref trigger))
            {
                TFQuartzXml.AddJob(JobConfigFile, jobDetail, trigger);
                scheduler.GetScheduler().ScheduleJob(jobDetail, trigger);
                InitJobs();
                lstTrigger.Items.Clear();
            }            
        }

        private void miJobDelete_Click(object sender, EventArgs e)
        {
            JobKey job;
            if (!GetSelectedJob(out job)) return;
            if ((MessageBox.Show("您确定要删除此任务吗?")) == DialogResult.Cancel) return;
            TFQuartzXml.DeleteJob(JobConfigFile,job);
            IList<ITrigger> triggers = scheduler.GetScheduler().GetTriggersOfJob(job);
            foreach (ITrigger t in triggers)
            {
                scheduler.GetScheduler().PauseTrigger(t.Key);// 停止触发器  
                scheduler.GetScheduler().UnscheduleJob(t.Key);// 移除触发器  
            }            
            scheduler.GetScheduler().DeleteJob(job);// 删除任务  
            InitJobs();
            lstTrigger.Items.Clear();
        }

        private void miJobEdit_Click(object sender, EventArgs e)
        {
            JobKey job;
            if (!GetSelectedJob(out job)) return;
            IJobDetail jobDetail = scheduler.GetScheduler().GetJobDetail(job);
            ITrigger trigger = null;
            IList<ITrigger> triggers = scheduler.GetScheduler().GetTriggersOfJob(job);
            if (triggers.Count > 0)
            {
                trigger = triggers[0];
            }
            IJobDetail jobDetail_Old = jobDetail;
            ITrigger triggerOld = trigger;
            if (frmJobAdd.Show(ref jobDetail,ref trigger))
            {
                //先停止删除
                scheduler.GetScheduler().PauseTrigger(triggerOld.Key);// 停止触发器  
                scheduler.GetScheduler().UnscheduleJob(triggerOld.Key);// 移除触发器  
                scheduler.GetScheduler().DeleteJob(jobDetail_Old.Key);// 删除任务  
                //后启动
                scheduler.GetScheduler().ScheduleJob(jobDetail,trigger);// 删除任务  
                TFQuartzXml.EditJob(JobConfigFile,jobDetail,trigger);
                treeJobs.SelectedNode.Tag = jobDetail.Key.Name;
                InitJobTriggers(jobDetail.Key.Name,jobDetail.Key.Group);
            }


        }


        public Control RelationCtrl()
        {
            return this;
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            _TFUdp.Start();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            _TFUdp.OnMsg = null;
            _TFUdp.Stop();
            e.Cancel = false;
        }

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Explorer.exe", Environment.CurrentDirectory);
        }
    }
}
