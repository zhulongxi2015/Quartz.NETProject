using QuartzRunner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace QuartzArchitecture.Service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
            //AdoJobStoreRunner runner = new AdoJobStoreRunner();
            //runner.Run().Start();
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new MyQuartzService1()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
