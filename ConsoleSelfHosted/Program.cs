using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Web;

namespace ConsoleSelfHosted
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CalculatorService)))
            {
                host.Open();

                Console.WriteLine("The service is running");
                Console.WriteLine("Press <Enter> to terminate service.");
                Console.WriteLine();
                Console.ReadLine();

                host.Close();
            }
        }
    }
}