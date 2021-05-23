using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceDataContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class EmpService : IEmpService
    {
        public void DeleteEmp(Employee e)
        {
            Console.WriteLine("Emp deleted with following details.");
            Console.WriteLine("ID: {0}", e.empId);
        }

        public Employee[] GetEmployees()
        {
            throw new NotImplementedException();
        }

        public Employee GetEmpDetails(int empId)
        {
            return new Employee()
            {
                empId = empId,
                EmpName = "Mr/Mrs.",
                EmpSalary = 1000
            };
        }

        public void InsertEmp(Employee e)
        {
            if(e is TraineeEmployees)
            {
                Console.WriteLine("Emp Inserted (Training) with following details");
                Console.WriteLine("Name: {0}, Salary: {1}, DateOfBirth:{2:d}, Subject: {3}", e.EmpName, e.EmpSalary, e.DateOfBirth, ((TraineeEmployees)e).Subject);
            }

            else if(e is DevelopmentEmployee)
            {
                Console.WriteLine("Emp Inserted (Delelopment) with following details");
                Console.WriteLine("Name: {0}, Salary: {1}, Date Of Birth:{2:d}, Programming Language: {3}", e.EmpName, e.EmpSalary, e.DateOfBirth, ((DevelopmentEmployee)e).ProgrammingLanguage);
            }

            else
            {
                Console.WriteLine("Emp Inserted with following details");
                Console.WriteLine("Name: {0}, Salary: {1}, DOB: {2}", e.EmpName, e.EmpSalary, e.DateOfBirth);
            }
        }

        public void UpdateEmp(Employee e)
        {
            if (e is TraineeEmployees)
            {
                Console.WriteLine("Emp Updated (Training) with following details");
                Console.WriteLine("Name: {0}, Salary: {1}, DateOfBirth:{2:d}, Subject: {3}", e.EmpName, e.EmpSalary, e.DateOfBirth, ((TraineeEmployees)e).Subject);
            }

            else if (e is DevelopmentEmployee)
            {
                Console.WriteLine("Emp Updated(Delelopment) with following details");
                Console.WriteLine("Name: {0}, Salary: {1}, Date Of Birth:{2:d}, Programming Language: {3}", e.EmpName, e.EmpSalary, e.DateOfBirth, ((DevelopmentEmployee)e).ProgrammingLanguage);
            }

            else
            {
                Console.WriteLine("Emp Updated with following details");
                Console.WriteLine("Name: {0}, Salary: {1}, Date of Birth: {2}", e.EmpName, e.EmpSalary, e.DateOfBirth);
            }
        }
    }
}
