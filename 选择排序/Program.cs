using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            //测试
            SelectNum sn = new SelectNum();
            int[] ArrayNum = { 5,8,6,12,15,13,9};
            sn.GetNum(ArrayNum);
            foreach(int n in ArrayNum)
            {
                Console.WriteLine(n + " ");
            }
            Console.ReadLine();
        }
    }



    public class SelectNum
    {
        int temp;
        int num;
        public void GetNum(int[] Array)
        {
            for(int i=0;i<Array.Length-1;i++)
            {
                num = i;
                for(int j=i+1;j<Array.Length;j++)
                {
                    if(Array[j]<Array[num])
                    {
                        num = j;
                    }
                }
                //大数后移，小数前移
                temp = Array[i];
                Array[i] = Array[num];
                Array[num] = temp;

            }
        }
    }
}
