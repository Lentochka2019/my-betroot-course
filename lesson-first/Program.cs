using System;

namespace lesson_first
{
    internal class Program
    {
        public static void Main()
        {
            int numA = 4;
            // Call with an int variable.
            int productA = Square(numA);
            Console.WriteLine($"Ex1:{numA}*{numA}= {productA}");

            int numB = 32;
            // Call with another int variable.
            int productB = Square(numB);
            Console.WriteLine($"Ex2:{numB}*{numB}= {productB}");

            // Call with an integer literal.
            int productC = Square(12);

            // Call with an expression that evaulates to int.
            productC = Square(productA * 3);
            Console.WriteLine($"Ex3:{productA}*3^2= {productC}");

        }
       
        static int Square(int i)
        {      // Store input argument in a local variable.
            int input = i;
            return input * input;
        }        
       

    }
}
