namespace Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("     ");
            for (int i = 1; i < 10; i++)
            {
                Console.Write("{0,4}", i);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 40));
            for (int i = 1; i < 10; i++)
            {
                Console.Write("{0,4}|", i);

                for (int j = 1; j < 10; j++)
                {
                    Console.Write("{0,4}", i * j);
                }

                Console.WriteLine();
            }
        }
    }
}
