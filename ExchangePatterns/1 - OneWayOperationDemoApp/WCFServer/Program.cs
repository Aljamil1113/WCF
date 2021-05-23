using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using WCFLibrary;

namespace WCFServer
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost sh = new ServiceHost(typeof(MathService));
            sh.Open();
            Console.WriteLine("Server Started...");
            Console.WriteLine("Press Enter to Stop the server");
            Console.ReadLine();
            sh.Close();
            Console.WriteLine("Server Stopped");
        }
    }
}
