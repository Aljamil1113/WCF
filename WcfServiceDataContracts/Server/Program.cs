using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WcfServiceDataContracts;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(EmpService));
            sh.Open();
            Console.WriteLine("Service Started");
            Console.WriteLine("Press any key to stop the server.");
            Console.ReadKey();
            Console.WriteLine("Service Stopped");
        }
    }
}
