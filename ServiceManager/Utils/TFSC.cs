using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using Microsoft.Win32;
using System.IO;

namespace TF.Windows
{
    public enum TFServiceState
    {
        //摘要:
        //服务未安装，此状态为在标准服务状态上的扩展，利于判断
        Uninstall = 0,
        // 摘要: 
        //     服务未运行。这对应于 Win32 SERVICE_STOPPED 常数，该常数定义为 0x00000001。
        Stopped = 1,
        //
        // 摘要: 
        //     服务正在启动。这对应于 Win32 SERVICE_START_PENDING 常数，该常数定义为 0x00000002。
        StartPending = 2,
        //
        // 摘要: 
        //     服务正在停止。这对应于 Win32 SERVICE_STOP_PENDING 常数，该常数定义为 0x00000003。
        StopPending = 3,
        //
        // 摘要: 
        //     服务正在运行。这对应于 Win32 SERVICE_RUNNING 常数，该常数定义为 0x00000004。
        Running = 4,
        //
        // 摘要: 
        //     服务即将继续。这对应于 Win32 SERVICE_CONTINUE_PENDING 常数，该常数定义为 0x00000005。
        ContinuePending = 5,
        //
        // 摘要: 
        //     服务即将暂停。这对应于 Win32 SERVICE_PAUSE_PENDING 常数，该常数定义为 0x00000006。
        PausePending = 6,
        //
        // 摘要: 
        //     服务已暂停。这对应于 Win32 SERVICE_PAUSED 常数，该常数定义为 0x00000007。
        Paused = 7,
    }
    public class TFSC
    {
        public static TFServiceState GetServiceState(string ServiceName)
        {
            ServiceController[] services = ServiceController.GetServices();
            bool bInstalled = false;
            foreach (ServiceController s in services)
            {
                if (s.ServiceName.ToLower() == ServiceName.ToLower())
                {
                    bInstalled = true;
                }
            }
            if (!bInstalled)
            { 
                return TFServiceState.Uninstall;
            }
            ServiceController sc = new ServiceController(ServiceName);
            return (TFServiceState)sc.Status;                  
        }
        public static ServiceController GetService(string ServiceName)
        {
            ServiceController[] services = ServiceController.GetServices();            
            foreach (ServiceController s in services)
            {
                if (s.ServiceName.ToLower() == ServiceName.ToLower())
                {
                    return s;
                }
            }
            return null;                          
        }

        // <summary>
        /// 获取服务安装路径
        /// </summary>
        /// <param name="ServiceName"></param>
        /// <returns></returns>
        public static string GetWindowsServiceInstallPath(string ServiceName)
        {
            string key = @"SYSTEM\CurrentControlSet\Services\" + ServiceName;
            RegistryKey rKey = Registry.LocalMachine.OpenSubKey(key);
            if (rKey == null) return "";
            string path = rKey.GetValue("ImagePath").ToString();
            //替换掉双引号   
            path = path.Replace("\"", string.Empty);
            FileInfo fi = new FileInfo(path);
            return fi.Directory.ToString();
        }
    }
}
