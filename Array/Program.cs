using System;
namespace Array
{
    class program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 54,890,111,67,45};
            MaxInt array = new MaxInt();
            Console.WriteLine("Maximum value in an Array is:");
            array.Toprint(intArr);
        }
    }
}