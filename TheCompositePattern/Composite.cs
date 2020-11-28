using System;
using System.Collections.Generic;

namespace TheCompositePattern
{
    public class Composite : IComponent
    {
        private readonly List<IComponent> _children = new List<IComponent>();
        private readonly String name = String.Empty;

        public Composite(String sname)
        {
            this.name = sname;
        }
        public void Add(IComponent component)
        {

            _children.Add(component);

        }


        public void Remove(IComponent component)
        {

            _children.Remove(component);

        }
        public void DisplayDepth(int depth)
        {

            Console.WriteLine(new String('-', depth) + "  " + name);
            foreach (IComponent component in _children)
            {
                component.DisplayDepth(depth + 2);
            }

        }

    }
}
