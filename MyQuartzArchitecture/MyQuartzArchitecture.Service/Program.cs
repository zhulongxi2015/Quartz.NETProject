using QuartzRunner;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyQuartzArchitecture.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            //AdoJobStoreRunner runner = new AdoJobStoreRunner();
            //runner.Run().Start();
            //Console.ReadKey();
            ServiceBase[] servicesToRun;
            servicesToRun = new ServiceBase[] {
                new QuartzService()
            };
            ServiceBase.Run(servicesToRun);
        }
    }
}
