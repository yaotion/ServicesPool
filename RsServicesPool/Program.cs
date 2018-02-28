
using Topshelf;
using System.IO;

namespace TF.Windows.QZServer
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {   
            // change from service account's dir to more logical one
            Directory.SetCurrentDirectory(System.AppDomain.CurrentDomain.BaseDirectory);
            
            HostFactory.Run(x =>
            {
                x.RunAsLocalSystem();

                x.SetDescription(Configuration.ServiceDescription);
                x.SetDisplayName(Configuration.ServiceDisplayName);
                x.SetServiceName(Configuration.ServiceName);

                x.Service(factory =>
                {
                    QuartzServer server = QuartzServerFactory.CreateServer();
                    server.Initialize();
                    return server;
                });
            });
        }
    }
}
