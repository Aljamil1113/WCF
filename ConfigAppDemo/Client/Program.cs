using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            localhosttcp1.Service1Client s = new localhosttcp1.Service1Client("NetTcpBinding_IService1");
            Console.WriteLine(s.GetData(10));
            Console.ReadKey();
        }
    }
}
