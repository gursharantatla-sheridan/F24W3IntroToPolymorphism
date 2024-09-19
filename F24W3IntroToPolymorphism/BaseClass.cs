using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F24W3IntroToPolymorphism
{
    public class BaseClass
    {
        public virtual void Show()
        {
            Console.WriteLine("Show from Base class");
        }
    }

    public class DerivedClass : BaseClass
    {
        public override void Show()
        {
            Console.WriteLine("Show from Derived class");
        }
    }
}
