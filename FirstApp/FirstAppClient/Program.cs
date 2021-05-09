using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAppClient
{
    class Program
    {
        static void Main(string[] args)
        {
            localhost.MathServiceClient mc = new localhost.MathServiceClient();
            Console.WriteLine(mc.Add(10, 20));
            localhost.Complex c1 = new FirstAppClient.localhost.Complex();
            localhost.Complex c2 = new FirstAppClient.localhost.Complex();
            c1.Real = 10; c2.Real = 20;
            c1.Imag = 20; c2.Imag = 30;
            localhost.Complex c3 = mc.AddComplex(c1, c2);
            Console.WriteLine(c3.Real + " " + c3.Imag);

            Console.ReadLine();
        }
    }
}
