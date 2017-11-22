using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paixu
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 12,15,5,4,2,7,16,18 };
            int i, j,num;
            int temp;
            try
            {
                for (j = 1; j < a.Length; j++)
                {
                    num = a[j];
                    i = j - 1;
                    while (i >=0 && a[i] < num)
                    {
                        temp = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = temp;
                        i = i - 1;
                    }



                }
                foreach (int str in a)
                    Console.WriteLine(str);
                Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
    }
}
