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
            Employee DEmployee = new DevelopmentEmployee { empId = 1, EmpName = "D1", EmpSalary = 12000, DateOfBirth = DateTime.Now, ProgrammingLanguage = ".NET" };
            Employee TEmployee = new TraineeEmployees { empId = 2, EmpName = "T1", EmpSalary = 12000, DateOfBirth = DateTime.Now, Subject = "C#"};
            sc.InsertEmp(DEmployee);
            sc.UpdateEmp(TEmployee);
            Console.ReadKey(); ;
        }
    }
}
