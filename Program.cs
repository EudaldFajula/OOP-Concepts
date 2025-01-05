using oopconcepts;

namespace OppConcepts
{
    public class Program
    {
        public static void Main()
        {
            Tree prueba = new Tree(203, "green");
            Console.WriteLine($"The tree is {prueba.Height} meters tall and the leaves that it has are {prueba.Leaves}");
        }
    }
}