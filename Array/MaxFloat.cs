using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
     public class MaxFloat
    {
        public void Toprint(float[] arr)
        {
            float max = 0.0f;
            if (arr[0] > arr[1] && arr[0] > arr[2] && arr[0] > arr[3] && arr[0] > arr[4])
            {
                max = arr[0];
            }
            if (arr[1] > arr[0] && arr[1] > arr[2] && arr[1] > arr[3] && arr[1] > arr[4])
            {
                max = arr[1];
            }
            if (arr[2] > arr[0] && arr[2] > arr[1] && arr[2] > arr[3] && arr[2] > arr[4])
            {
                max = arr[2];
            }
            if (arr[3] > arr[0] && arr[3] > arr[1] && arr[3] > arr[2] && arr[3] > arr[4])
            {
                max = arr[3];
            }
            if (arr[4] > arr[0] && arr[4] > arr[1] && arr[4] > arr[2] && arr[4] > arr[3])
            {
                max = arr[4];
            }
            Console.WriteLine("Maximum float value in an array is: " + max);
        }
    }
}
