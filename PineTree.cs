using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oopconcepts
{
    public class PineTree : Tree
    {
        public int NumPinecone { get; set; }

        public PineTree(decimal height, string leaves, int numPinecone) : base(height, leaves)
        {
            NumPinecone = numPinecone;
        }
    }
}
