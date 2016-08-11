using Common.Logging;
using Quartz;
using QuartzRunner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace QuartzArchitecture.Service
{
    public partial class MyQuartzService1 : ServiceBase
    {

        private readonly ILog logger;
        private readonly IScheduler scheduler;
        public MyQuartzService1()
        {
            InitializeComponent();
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            IQuartzRunner adoRunner = new AdoJobStoreRunner();
            scheduler = adoRunner.Run();
        }

        public MyQuartzService1(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            
            scheduler.Start();
            logger.Info("Service Start..." + DateTime.Now);
        }
        protected override void OnStop()
        {
            scheduler.Shutdown(false);
            logger.Info("Service stop..." + DateTime.Now);
        }
        protected override void OnPause()
        {
            scheduler.PauseAll();
        }
        protected override void OnContinue()
        {
            scheduler.ResumeAll();
        }
    }
}
