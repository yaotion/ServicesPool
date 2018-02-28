using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl;
using Quartz.Impl.Triggers;



namespace RsServicesPool
{
    public class TFWinService
    {
        ISchedulerFactory sf; 
        IScheduler sched;
        public TFWinService()
        {
            sf = new StdSchedulerFactory();
            sched = sf.GetScheduler();
        }
       
        public void Start()
        {
            TFJobUtils jobUtils = new TFJobUtils("c:\\jobConfig.xml");
            jobUtils.Load();     
            foreach (var jobConfig in jobUtils.Jobs)
            {
                IJobDetail jobDetail = jobConfig.Job.ToJob();
                //ITrigger trigger = jobConfig.Trigger.ToTrigger();
                //sched.ScheduleJob(jobDetail, trigger);               
            }
            sched.Start();        
        }
        public void Stop()
        {
            sched.Shutdown();
        }

    }
}
