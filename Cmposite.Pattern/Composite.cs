using System;
using System.Collections.Generic;
using System.Text;

namespace Cmposite.Pattern
{
    //树枝
    public class Composite : Component
    {
        public Composite(string name) : base(name) { }

        private List<Component> components = new List<Component>();
        public void Add(Component component)
        {
            components.Add(component);
        }

        public void Remove(Component component)
        {
            components.Remove(component);
        }

        public List<Component> GetChildren()
        {
            return this.components;
        }
    }
}
