using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceDataContracts
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(Name = "IEmpService", Namespace = "http://www.deccansoft.com/wcf")]
    public interface IEmpService
    {
        [OperationContract]
        void InsertEmp(string name, decimal salary, DateTime dob);

        [OperationContract]
        void UpdateEmp(Employee e);

        [OperationContract]
        void DeleteEmp(Employee e);

        [OperationContract]
        Employee[] GetData();

        [OperationContract]
        Employee GetEmpDetails(int empId); 

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServiceDataContracts.ContractType".
    [DataContract]
    public class Employee
    {
      [DataMember()]
      public int empId { get; set; }

      [DataMember()]
      public string EmpName { get; set; }

      [DataMember]
        public decimal EmpSalary { get; set; }

      [DataMember(IsRequired =true)]
        public DateTime DateOfBirth { get; set; }
    }
}
