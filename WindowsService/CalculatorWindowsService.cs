using System.ServiceModel;
using System.ServiceProcess;

namespace WindowsService
{
    public class CalculatorWindowsService : ServiceBase
    {
        public ServiceHost serviceHost = null;
        public CalculatorWindowsService()
        {
            ServiceName = "WindowsServiceCalculator";
        }

        public static void Main()
        {
            ServiceBase.Run(new CalculatorWindowsService());
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            serviceHost = new ServiceHost(typeof(CalculatorWindowsService));
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
    }
}
