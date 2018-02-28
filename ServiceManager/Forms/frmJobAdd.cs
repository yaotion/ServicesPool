using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Quartz;
using Quartz.Impl.Triggers;
using Quartz.Impl;
using Quartz.Spi;
using Quartz.Simpl;
using System.Reflection;


namespace TF.Windows.QZServer.Manager
{
    public partial class frmJobAdd : Form
    {
        public frmJobAdd()
        {
            InitializeComponent();
        }
        private IJobDetail RetJobDetail;
        private ITrigger RetTrigger;

        private void frmJobAdd_Load(object sender, EventArgs e)
        {

        }

        private void radioTriggerSimple_Click(object sender, EventArgs e)
        {
            tbTriggerPeriod.Enabled = false;
            tbTriggerExpression.Enabled = false;
            if (radioTriggerSimple.Checked)
            {
                tbTriggerPeriod.Enabled = true;
            }
            else {
                tbTriggerExpression.Enabled = true;
            }
        }

        public static bool Show(ref IJobDetail JobDetail,ref ITrigger Trigger)
        {
            frmJobAdd jobAdd = new frmJobAdd();
            jobAdd.RetJobDetail = JobDetail;
            jobAdd.RetTrigger = Trigger;
            jobAdd.Init();
            if (jobAdd.ShowDialog() == DialogResult.OK)
            {
                JobDetail = jobAdd.RetJobDetail;
                Trigger = jobAdd.RetTrigger;
                return true;
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            JobDetailImpl tempJobDetail = new JobDetailImpl();
            tempJobDetail.Description = tbJobDescription.Text;
            tempJobDetail.Durable = checkDurable.Checked;
            tempJobDetail.Group = tbJobGroup.Text;
            ITypeLoadHelper typeLoadHelper = new SimpleTypeLoadHelper();
            typeLoadHelper.Initialize();
            tempJobDetail.JobType = typeLoadHelper.LoadType(comboJobType.Text);
            tempJobDetail.Name = tbJobKey.Text;
            tempJobDetail.RequestsRecovery = checkCover.Checked;
            tempJobDetail.Key = new JobKey(tbJobKey.Text, tbJobGroup.Text);
            for (int i = 0; i < tbJobData.Lines.Length; i++)
			{
                string lineData = tbJobData.Lines[i];
                string[] dataDic = lineData.Split(new char[]{'='},2,StringSplitOptions.RemoveEmptyEntries);
                if (dataDic.Length < 2) continue;
                tempJobDetail.JobDataMap.Add(dataDic[0], dataDic[1]);
			}
            
            RetJobDetail = tempJobDetail;            
            ITrigger tempTrigger;
            string triggerGroup = tempJobDetail.Group;
            string triggerName = tempJobDetail.Name + "_Trigger";
            if (radioTriggerSimple.Checked)
            {
                TimeSpan ts = new TimeSpan(long.Parse(tbTriggerPeriod.Text) * 10000);                
                tempTrigger = new SimpleTriggerImpl(triggerName, triggerGroup, -1, ts);                
            }
            else {
                tempTrigger = new CronTriggerImpl(triggerName, triggerGroup, tbTriggerExpression.Text);
            }

            RetTrigger = tempTrigger;
            this.DialogResult = DialogResult.OK;
        }

        private void Init()
        {
            if (RetJobDetail != null)
            {
                tbJobAssembly.Enabled = false;
                comboJobType.Enabled = false;
                tbJobGroup.Enabled = false;
                tbJobKey.Enabled = false;
                btnSelectFile.Enabled = false;

                comboJobType.Text = RetJobDetail.JobType.AssemblyQualifiedName;
                tbJobKey.Text = RetJobDetail.Key.Name;
                tbJobGroup.Text = RetJobDetail.Key.Group;
                tbJobDescription.Text = RetJobDetail.Description;
                checkDurable.Checked = RetJobDetail.Durable;
                checkCover.Checked = RetJobDetail.RequestsRecovery;
                string[] lines = new string[RetJobDetail.JobDataMap.Count];
                tbJobData.Text = "";
                int nIndex = 0;
                foreach (var item in RetJobDetail.JobDataMap)
                {
                    lines[nIndex] = string.Format("{0}={1}",item.Key,item.Value);
                    nIndex ++;                    
                }
                tbJobData.Lines = lines;
                if (RetTrigger != null)
                {
                    if (RetTrigger is ISimpleTrigger)
                    {
                        radioTriggerSimple.Checked = true;
                        tbTriggerPeriod.Text =Math.Round( (RetTrigger as ISimpleTrigger).RepeatInterval.TotalMilliseconds).ToString();
                    }
                    else
                    {
                        radioCron.Checked = true;
                        tbTriggerExpression.Text = (RetTrigger as ICronTrigger).CronExpressionString;
                    }
                }
            }
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Environment.CurrentDirectory;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            tbJobAssembly.Text = openFileDialog1.FileName;
            InitJobTypes();
        }

        private void InitJobTypes()
        {
            comboJobType.Items.Clear();
            comboJobType.Text = "";
            Assembly assembly = Assembly.LoadFile(tbJobAssembly.Text);
            foreach (Type type in assembly.GetTypes())
            {
                if (typeof(IJob).IsAssignableFrom(type) && type.IsClass)
                {
                    comboJobType.Items.Add(type.AssemblyQualifiedName);
                }
            }
        }
    }
}
