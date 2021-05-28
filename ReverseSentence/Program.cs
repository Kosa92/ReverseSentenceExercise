using System;

namespace ReverseSentence
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input sentence:\n");
            string input = Console.ReadLine();
            string output = Text.ReverseByLinq(input);
            Console.WriteLine(output);


            Console.WriteLine("\nInput sentence:\n");
            input = Console.ReadLine();
            output = Text.Reverse(input);
            Console.WriteLine(output);
        }
    }
}
