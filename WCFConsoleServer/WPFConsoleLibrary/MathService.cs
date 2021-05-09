using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WPFConsoleLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MathService" in both code and config file together.
    public class MathService : IMathService
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }
    }
}
