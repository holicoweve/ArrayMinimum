using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMinimum
{
    class Program
    {
        /// <summary>
        /// 利用三層巢狀迴圈來找出2x3x3 三維陣列中所儲存數值中的最小值
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int[,,] num = { { { 33, 45, 67 },
                              { 23, 71, 56 },
                              { 55, 38, 66 }},
                              {{21, 9, 15 },
                              {38, 69, 18 },
                              {90, 101, 89 } } };

            int min = num[0, 0, 0];

            for (int i = 0; i < num.GetLength(0); i++)
            {
                for (int j = 0; j < num.GetLength(1); j++)
                {
                    for (int k = 0; k < num.GetLength(2); k++)
                    {
                        if (min > num[i, j, k])
                        {
                            min = num[i, j, k];
                        }
                    }
                }
            }
            Console.WriteLine($"最小數字為 {min}");

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
