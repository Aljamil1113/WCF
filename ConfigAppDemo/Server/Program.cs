using System;
using WcfLibrary;
using System.ServiceModel;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(Service1));

            //System.ServiceModel.Description.ServiceEndpoint sep;
            //sep = sh.AddServiceEndpoint(typeof(IService1), new WSHttpBinding(), "");

            sh.Open();
            Console.WriteLine("Service has started.");
            Console.WriteLine("Press any key to stop the server.");
            System.Console.ReadKey();
            sh.Close();
        }
    }
}
