using Client.EmpServiceRef;
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
            EmpServiceClient sc = new EmpServiceClient();
            sc.InsertEmp("Sandeep", 10000, new DateTime(DateTime.Now.Ticks));
            sc.UpdateEmp(new Employee() { empId = 1, EmpName = "E1", EmpSalary = 10000, DateOfBirth = DateTime.Now });
            Console.ReadKey(); ;
        }
    }
}
