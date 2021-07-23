using System;

namespace FindMaximumNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Finding max Number :");
            
            string maximum = MaximumNumberCheck.FindMaximum<int>(29, 76, 94);
            string maximum1 = MaximumNumberCheck.FindMaximum<float>(231.2f,112.45f,32.56f);
            string maximum2 = MaximumNumberCheck.FindMaximum<string>("202", "323", "441");

            Console.WriteLine(maximum);
            Console.WriteLine(maximum1);
            Console.WriteLine(maximum2);
            
            
        }
    }
}
