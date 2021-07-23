using System;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            
            int output = MaximumNumberCheck.MaximumIntegerNumber(23, 43, 65);
            Console.WriteLine(output);
            
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            Console.WriteLine(doubleoutput);
        }
    }
}
