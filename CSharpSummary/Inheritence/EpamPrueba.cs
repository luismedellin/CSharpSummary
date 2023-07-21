using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSummary.Inheritence
{
    public class A
    {
        public void hello(double a) => Console.WriteLine("Helo from a");
    }
    public class B : A
    {
        public void hello(int a) => Console.WriteLine("Helo from b");
    }
    public class ShowResultsTest
    {
        public void Print()
        {
            double i = 5;
            B b = new B();
            b.hello(i); //Helo from a
        }
    }

}
