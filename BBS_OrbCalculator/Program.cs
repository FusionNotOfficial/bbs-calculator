using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BBS_OrbCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int[] orbs = new int[6] { 5, 10, 25, 35, 50, 75 };
            for(int i = 0; i < 6; i++)
            {
                for(int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"{i + 1}* + {j + 1}* - {orbs[i] + orbs[j]} орбов");
                }
            }
            Console.ReadLine();
        }
    }
}
