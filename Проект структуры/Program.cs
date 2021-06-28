using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_структуры
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int x = 4;
            int y = 4;
            int[,] ara = new int[x, y];
            for (int i = 0; i <= x - 1; i++)
            {
                for (int j = 0; j <= y - 1; j++)
                {
                    ara[i, j] = ran.Next(0, 10);
                    Console.Write(ara[i, j]);
                }
                Console.WriteLine();

            }
        }
    }
}
