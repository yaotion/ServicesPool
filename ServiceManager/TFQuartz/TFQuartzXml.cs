using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Quartz;
using Quartz.Impl.Matchers;
using Quartz.Impl.Triggers;
using Quartz.Impl;
using System.Xml.Serialization;
using Quartz.Xml.JobSchedulingData20;
using System.IO;
using Quartz.Util;
using Quartz.Spi;

namespace TF.Windows.QZServer.Manager
{
    public class TFQuartzXml
    {    
        public TFQuartzXml()
        {
            
        }
        public static void AddJob(string XMLFile,IJobDetail JobDetail,ITrigger Trigger)
        {
            string fileName = FileUtil.ResolveFile(XMLFile);

            using (StreamReader sr = new StreamReader(fileName))
            {
                string xmlContent = sr.ReadToEnd();
                XmlSerializer xs = new XmlSerializer(typeof(QuartzXmlConfiguration20));
                QuartzXmlConfiguration20 data = (QuartzXmlConfiguration20)xs.Deserialize(new StringReader(xmlContent));
                if (data.schedule.Length > 0)
                {
                    //将IJobDetail添加到XML中的JobDetailType中
                    jobdetailType[] newJobDetails;
                    if (data.schedule[0].job == null)
                    {
                        newJobDetails = new jobdetailType[1];
                    }
                    else
                    {
                        newJobDetails = new jobdetailType[data.schedule[0].job.Length + 1];
                        data.schedule[0].job.CopyTo(newJobDetails, 0);

                    }                    
                      
                    jobdetailType type = new jobdetailType();
                    type.name = JobDetail.Key.Name;
                    type.group = JobDetail.Key.Group;
                    type.description = JobDetail.Description;
                    type.jobtype = JobDetail.JobType.AssemblyQualifiedName;
                    type.durable = JobDetail.Durable; ;
                    type.recover = JobDetail.RequestsRecovery;
                    newJobDetails[newJobDetails.Length - 1] = type;
                    data.schedule[0].job = newJobDetails;
                    if (JobDetail.JobDataMap.Count > 0)
                    {
                        type.jobdatamap = new jobdatamapType();
                        type.jobdatamap.entry = new entryType[JobDetail.JobDataMap.Count];
                        IList<string> keys = JobDetail.JobDataMap.GetKeys();

                        int i = 0;
                        foreach (string item in keys)
                        {
                            type.jobdatamap.entry[i] = new entryType();
                            type.jobdatamap.entry[i].key = item;
                            type.jobdatamap.entry[i].value = JobDetail.JobDataMap[item].ToString();
                            i++;

                        }
                    }
                    triggerType[] newTriggerTypes;
                    if (data.schedule[0].trigger != null)
                    {
                        newTriggerTypes = new triggerType[data.schedule[0].trigger.Length + 1];
                        data.schedule[0].trigger.CopyTo(newTriggerTypes, 0);
                    }
                    else { 
                        newTriggerTypes = new triggerType[1];
                    }
                    
                    triggerType tType = new triggerType();
                    if (Trigger is ISimpleTrigger)
                    {
                        tType.Item = new simpleTriggerType();
                        ((simpleTriggerType)tType.Item).repeatcount = (Trigger as ISimpleTrigger).RepeatCount.ToString();
                        ((simpleTriggerType)tType.Item).repeatinterval = (Trigger as ISimpleTrigger).RepeatInterval.TotalMilliseconds.ToString();
                        ((simpleTriggerType)tType.Item).jobname = JobDetail.Key.Name;
                        ((simpleTriggerType)tType.Item).jobgroup = JobDetail.Key.Group;
                        ((simpleTriggerType)tType.Item).name = Trigger.Key.Name;
                        ((simpleTriggerType)tType.Item).group = Trigger.Key.Group;
                        ((simpleTriggerType)tType.Item).description = Trigger.Description;
                        ((simpleTriggerType)tType.Item).misfireinstruction = "RescheduleNowWithExistingRepeatCount";

                    }
                    else
                    {
                        tType.Item = new cronTriggerType();
                        ((cronTriggerType)tType.Item).cronexpression = (Trigger as ICronTrigger).CronExpressionString.ToString();

                        ((simpleTriggerType)tType.Item).jobname = JobDetail.Key.Name;
                        ((simpleTriggerType)tType.Item).jobgroup = JobDetail.Key.Group;
                        ((simpleTriggerType)tType.Item).name = Trigger.Key.Name;
                        ((simpleTriggerType)tType.Item).group = Trigger.Key.Group;
                        ((simpleTriggerType)tType.Item).description = Trigger.Description;
                        ((simpleTriggerType)tType.Item).misfireinstruction = "RescheduleNowWithExistingRepeatCount";

                    }

                    newTriggerTypes[newTriggerTypes.Length - 1] = tType;
                    data.schedule[0].trigger = newTriggerTypes;
                }
                sr.Close();
                StringBuilder xmlBuild = new StringBuilder();
                xs.Serialize(new StringWriter(xmlBuild), data);
                StreamWriter sw = new StreamWriter(fileName);

                sw.Write(xmlBuild.ToString());
                sw.Flush();
                sw.Close();
            }
        }
        public static void EditJob(string XMLFile, IJobDetail JobDetail, ITrigger Trigger)
        {
            DeleteJob(XMLFile,JobDetail.Key);
            AddJob(XMLFile, JobDetail, Trigger);
        }
        public static void DeleteJob(string XMLFile,JobKey Job)
        {
            string fileName = FileUtil.ResolveFile(XMLFile);

            using (StreamReader sr = new StreamReader(fileName))
            {
                string xmlContent = sr.ReadToEnd();
                XmlSerializer xs = new XmlSerializer(typeof(QuartzXmlConfiguration20));
                QuartzXmlConfiguration20 data = (QuartzXmlConfiguration20)xs.Deserialize(new StringReader(xmlContent));
                if (data.schedule.Length > 0)
                {

                    List<jobdetailType> jobdetailTypeList = new List<jobdetailType>();
                    if (data.schedule[0].job == null) return;
                    jobdetailTypeList.AddRange(data.schedule[0].job);
                    for (int i = 0; i < jobdetailTypeList.Count; i++)
                    {
                        if ((jobdetailTypeList[i].name == Job.Name) && (jobdetailTypeList[i].group == Job.Group))
                        {
                            jobdetailTypeList.RemoveAt(i);
                            break;
                        }

                    }
                    data.schedule[0].job = jobdetailTypeList.ToArray();

                    List<triggerType> triggerTypeList = new List<triggerType>();
                    triggerTypeList.AddRange(data.schedule[0].trigger);
                    for (int i = triggerTypeList.Count - 1; i >= 0; i--)
                    {
                        if ((triggerTypeList[i].Item.jobname == Job.Name) && (triggerTypeList[i].Item.jobgroup == Job.Group))
                        {
                            triggerTypeList.RemoveAt(i);
                        }
                    }
                    data.schedule[0].trigger = triggerTypeList.ToArray();

                }
                sr.Close();
                StringBuilder xmlBuild = new StringBuilder();
                xs.Serialize(new StringWriter(xmlBuild), data);
                StreamWriter sw = new StreamWriter(fileName);

                sw.Write(xmlBuild.ToString());
                sw.Flush();
                sw.Close();
            }
        }

    }
}
