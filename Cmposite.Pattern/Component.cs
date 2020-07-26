using System;
using System.Collections.Generic;
using System.Text;

namespace Cmposite.Pattern
{
    public abstract class Component
    {
        public string Name { get; }
        public Component(string name)
        {
            this.Name = name;
        }
        public virtual void DoSth() { Console.WriteLine("{0} parents do sth",Name); }
    }
}
