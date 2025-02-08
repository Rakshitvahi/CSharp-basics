using System.Runtime.Serialization.Formatters;

namespace com.example.rakshit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pattern 1");
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }
    }
}
