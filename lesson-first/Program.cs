using System;

namespace lesson_first
{
    internal class Program
    {
        
        public void Caller()
        {
            int numA = 4;
            // Call with an int variable.
            int productA = Square(numA);
            Console.WriteLine($"Ex1: {productA}");

            int numB = 32;
            // Call with another int variable.
            int productB = Square(numB);

            // Call with an integer literal.
            int productC = Square(12);

            // Call with an expression that evaulates to int.
            productC = Square(productA * 3);
            Console.WriteLine($"Ex1: {productC}");
        }
        
        int Square(int i)
        {      // Store input argument in a local variable.
            int input = i;
            return input * input;
        }

    }
}
