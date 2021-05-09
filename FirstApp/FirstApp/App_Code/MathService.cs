using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service" in code, svc and config file together.
public class MathService : IMathService
{
    public Complex AddComplex(Complex c1, Complex c2)
    {
        Complex c = new Complex();
        c.Real = c1.Real + c2.Real;
        c.Imag = c1.Imag + c2.Imag;

        return c;
    }

    public int Add(int a, int b)
    {
        return a + b;
    }
}
