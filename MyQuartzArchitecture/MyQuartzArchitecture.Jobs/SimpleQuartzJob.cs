using Common.Logging;
using Quartz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQuartzArchitecture.Jobs
{
    public class SimpleQuartzJob : IJob
    {
        private readonly ILog _logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public void Execute(IJobExecutionContext context)
        {
            try
            {
                _logger.Info("SimpleQuartzJob start... " + DateTime.Now + "");
                for (int i = 0; i < 5; i++)
                {
                    _logger.Info("SimpleQuartzJob start... "+i+" " + DateTime.Now + "");
                    Console.WriteLine("SimpleQuartzJob running..."+i);
                }
                _logger.Info("SimpleQuartzJob end... " + DateTime.Now + "");
            }
            catch (Exception ex)
            {
                _logger.Error("SimpleQuartzJob error..." + DateTime.Now + " " + ex.Message);
            }
            
        }
    }
}
