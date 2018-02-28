using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Triggers;

namespace RsServicesPool
{
    public class TFJobDetail
    {
        //任务名称，需要唯一
        public string Key = "";
        //实际任务所在程序集,格式为"job-type",例如"Quartz.Server.SampleJob, Quartz.Server"
        public string JobType = "";
        //任务描述，可为空
        public string Description = "";
        //任务是否持久化，具体用处未知，默认为true
        //持久性，如果 Job 是非持久性的，那么执行完 Job 后，如果没有任何活动的 Trigger 与之关联，
        //那么将会被调度器自动删除。换句话说，非持久性的 Job 的生命周期与它关联的 Trigger 相关
        public bool Durable = true;
        //是否自动恢复，具体用处位置，默认值false;
        // 如果任务设置了 RequestsRecovery，那么它在调度器发生硬停止（例如，当前进程 crash，或者机器宕机）后，
        //当调度器再次启动的时候将会重新执行。这种情况下，JobExecutionContext.isRecovering() 方法将会返回
        public bool RequestsRecovery = false;
        //为了避免数据错误此功能默认false;
        //添加到 Job 类后，表示 Quartz 将会在成功执行 execute() 方法后（没有抛出异常）更新 JobDetail 的 JobDataMap，
        //下一次执行相同的任务（JobDetail）将会得到更新后的值，而不是原始的值。就像
        public bool PersistJobDataAfterExecution = false;
        //添加到 Job 类后，Quartz 将不会同时执行多个 Job 实例可以说这个约束是基于 JobDetail 的而不是基于 Job 的。
        public bool DisallowConcurrentExecution = false;

        public IJobDetail ToJob()
        {
            return null;
        }
    }
    //<Trigger Type="Sinmple" Name="" BeginTime="" EndTime="" RepeatCount = "" RepeatInterval="">
    //<Trigger Type="CronTrigger" Name="" BeginTime="" EndTime="" CronExpression="">
    public  class TFJobTriggerBase
    {
        public DateTime BeginTime;
        public DateTime EndTime;
        public string Name;
        public virtual void UpdateXml(XmlNode Node)
        {
 
        }
        public virtual void FromXML(XmlNode Node)
        {
 
        }
       
    }
    public class TFJobTriggerSimple
    {
        //重复次数
        public int RepeatCount = 0;
        //单位毫秒
        public int RepeatInterval = 0;
    }
    public class TFJobTriggerCron
    {
        //Cron表达式
        public string CronExpression = "";
    }
    //<Job Key="" JobType="" JobDataMap="" Key="" Description="" Durable="" RequestsRecovery = "" PersistJobDataAfterExecution ="">
    public class TFJobConfig
    {
        public TFJobDetail Job;
        public TFJobTriggerBase Trigger;
    }

    public class TFJobUtils
    {
        public List<TFJobConfig> Jobs = new List<TFJobConfig>();
        public TFJobUtils(string ConfigName)
        {
 
        }
        public void Load() 
        {
        }
        public void Save() { 
        }
        public void AddJob(TFJobConfig Job)
        {}
        public void DeleteJob(TFJobConfig Job)
        {}
        public void UpdateJob(TFJobConfig Job)
        { }
    }
}
