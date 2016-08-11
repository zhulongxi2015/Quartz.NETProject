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

namespace MyQuartzArchitecture.Service
{
    public partial class QuartzService : ServiceBase
    {

        private readonly ILog logger;
        private readonly IScheduler scheduler;
        public QuartzService()
        {
            InitializeComponent();
            logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

            IQuartzRunner adoRunner = new AdoJobStoreRunner();
            scheduler = adoRunner.Run();
        }

        public QuartzService(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            logger.Info("Service Start..." + DateTime.Now);
            //scheduler.Start();
            
        }
        protected override void OnStop()
        {
            //scheduler.Shutdown(false);
            logger.Info("Service stop..." + DateTime.Now);
        }
        protected override void OnPause()
        {
            //scheduler.PauseAll();
        }
        protected override void OnContinue()
        {
            //scheduler.ResumeAll();
        }
    }
}
