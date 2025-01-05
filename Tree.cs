using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopconcepts
{
    public class Tree : ITrees
    { 
        public decimal Height { get; set; }
        public string Leaves { get; set; }
        public Tree(decimal height, string leaves)
        {
            Height = height;
            Leaves = leaves;

        }
        public virtual void GrowUp()
        {
            Console.WriteLine("The tree grow up");
        }
        public void LeavesFalling()
        {
            Console.WriteLine("The leaves are falling");
        }
    }
}
