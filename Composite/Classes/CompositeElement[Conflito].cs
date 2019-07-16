using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DPComposite.Classes
{  
    /// <summary>
    /// A classe Composite
    /// </summary>
    class CompositeElement : ElementoComposto
    { 
        private List<ElementoComposto> elements =
          new List<ElementoComposto>();

        // Constructor
        public CompositeElement(string name)
            : base(name)
        {
        }

        public override void Add(ElementoComposto d)
        {
            elements.Add(d);
        }

        public override void Remove(ElementoComposto d)
        {
            elements.Remove(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
              "+ " + _name);

            // Display each child element on this node
            foreach (ElementoComposto d in elements)
            {
                d.Display(indent + 2);
            }
        }
    
 
}}
