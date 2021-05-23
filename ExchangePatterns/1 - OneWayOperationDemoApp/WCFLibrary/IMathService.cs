using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFLibrary
{
    // NOTE: If you change the interface name "IMathService" here, you must also update the reference to "IMathService" in App.config.
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract(IsOneWay = true)]
        void ClientStarted(string name);
        [OperationContract(IsOneWay = true)]
        void ClientStopped(string name);
        
        [OperationContract]
        int Add(int a, int b);
        [OperationContract]
        int Sub(int a, int b);
    }
}
