using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace DemoLibrary
{
    // NOTE: If you change the class name "Service1" here, you must also update the reference to "Service1" in App.config.
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.PerCall)]
    public class Service1 : IService1
    {

        #region IService1 Members

        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }

        #endregion
    }
}
