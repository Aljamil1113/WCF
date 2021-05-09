using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService" in both code and config file together.
[ServiceContract]
public interface IMathService
{

	[OperationContract]
	int Add(int a, int b);

	[OperationContract]
	Complex AddComplex(Complex c1, Complex c2);

	[OperationContract]
	int GetCounter();

	// TODO: Add your service operations here
}

// Use a data contract as illustrated in the sample below to add composite types to service operations.
[DataContract]
public class Complex
{
	private int _Real, _Imag;

	[DataMember]
	public int Real
	{
		get { return _Real; }
		set { _Real = value; }
	}

	[DataMember]
	public int Imag
	{
		get { return _Imag; }
		set { _Imag = value; }
	}
}
