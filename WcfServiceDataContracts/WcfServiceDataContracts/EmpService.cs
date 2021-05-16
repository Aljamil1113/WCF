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
            throw new NotImplementedException();
        }

        public Employee[] GetData()
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

        public void InsertEmp(string name, decimal salary, DateTime dob)
        {
            Console.WriteLine("Name: {0}, Salary: {1}, DOB: {2}", name, salary, dob);
            Console.WriteLine("Employee saved!");
        }

        public void UpdateEmp(Employee e)
        {
            Console.WriteLine("ID: {0}, Name: {1}, Salary: {2}, DOB: {3}", 
                e.empId, e.EmpName, e.EmpSalary, e.DateOfBirth);
            Console.WriteLine("Emp Updated");
        }
    }
}
