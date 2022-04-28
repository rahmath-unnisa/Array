using System;
namespace Array
{
    class program
    {
        static void Main(string[] args)
        {
            int[] intArr = { 54,890,111,67,45};
            float[] floatArr = { 12.6f, 33.8f, 12.06f, 9.32f, 5f };
            MaxInt array = new MaxInt();
            Console.WriteLine("Maximum value in an Array is:");
            array.Toprint(intArr);
            MaxFloat array2 = new MaxFloat();
            Console.WriteLine("Maximum value in a float is:");
            array2.Toprint(floatArr);
        }
    }
}