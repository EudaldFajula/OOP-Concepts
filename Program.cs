using oopconcepts;

namespace OppConcepts
{
    public class Program
    {
        public static void Main()
        {
            Tree test1 = new Tree(203, "green");
            Console.WriteLine($"The tree is {test1.Height} meters tall and the leaves that it has are {test1.Leaves}");
            test1.GrowUp();
            PineTree test2 = new PineTree(203, "green", 5);
            Console.WriteLine($"The pinetree is {test2.Height} meters tall and the leaves that it has are {test2.Leaves} and has {test2.NumPinecone} pinecones");
            test2.GrowUp();
        }
    }
}