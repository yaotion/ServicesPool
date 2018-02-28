using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;

namespace TF.Windows.QZServer.Manager
{
    public class TFTriggerListener : ITriggerListener              
    {
        public string Name
        {
            get { throw new NotImplementedException(); }
        }

        public void TriggerComplete(ITrigger trigger, IJobExecutionContext context, SchedulerInstruction triggerInstructionCode)
        {
            throw new NotImplementedException();
        }

        public void TriggerFired(ITrigger trigger, IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }

        public void TriggerMisfired(ITrigger trigger)
        {
            throw new NotImplementedException();
        }

        public bool VetoJobExecution(ITrigger trigger, IJobExecutionContext context)
        {
            throw new NotImplementedException();
        }
    }
}
