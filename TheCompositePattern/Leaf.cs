using System;

namespace TheCompositePattern
{
    public class Leaf : IComponent
    {
        private String _name = string.Empty;
        public Leaf(string name)
        {
            _name = name;
        }
        public void DisplayDepth(int depth)
        {
            Console.WriteLine(new String('-', depth) + ' ' + _name);
        }
    }
}
