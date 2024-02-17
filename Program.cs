using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 生成不重复随机数

            int flag = 0; // 记录不重复的随机数的个数
            Random rand1 = new Random();
            int[] arr3 = new int[50]; 

            while(flag <= 50)
            {
                int temp = rand1.Next(1, 101);
                bool sign = true; // 指示循环是否正常结束

                for (int i = 0; i < flag; i++)
                {
                    if(temp == arr3[i])
                    {
                        sign = false;
                        break;
                    }
                }

                if(sign)
                {
                    flag++;
                    arr3[flag - 1] = temp;
                }
            }

            for (int i = 0; i < arr3.Length; i++)
            {
                Console.Write(arr3[i] + "\t");

                if(i % 10 == 0)
                {
                    Console.WriteLine();
                }
            }






        }
    }
}
