using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
namespace WCFLibrary
{
    // NOTE: If you change the class name "MathService" here, you must also update the reference to "MathService" in App.config.
    public class MathService : IMathService
    {

        #region IMathService Members

        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Sub(int a, int b)
        {
            return a - b;
        }

        public void ClientStarted(string name)
        {
            StreamWriter sw = new StreamWriter("ClientLog.txt",true);
            sw.WriteLine("Started by: " + name + "at " + DateTime.Now.ToLongTimeString());
            sw.Close();
        }

        public void ClientStopped(string name)
        {
            StreamWriter sw = new StreamWriter("ClientLog.txt", true);
            sw.WriteLine("Stopped by: " + name + "at " + DateTime.Now.ToLongTimeString());
            sw.Close();
        }

        #endregion
    }
}
