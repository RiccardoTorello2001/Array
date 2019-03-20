using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ArrayTest
{
    public class Array
    {
       public static int[] IncrementoArray(int[]a)
        {
            int[] Array1 = new int[5];

            for(int i=0; i<a.Length;i++)
            {
                Array1[i] = a[i] + 10;
            }
            return Array1;
        }

    }
}
