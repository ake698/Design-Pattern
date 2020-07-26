using System;
using System.Collections.Generic;
using System.Text;

namespace Cmposite.Pattern
{
    public class Leaf : Component
    {
        public Leaf(string name) : base(name) { }
        public override void DoSth()
        {
            Console.WriteLine("{0} Do it",Name);
        }
    }
}
