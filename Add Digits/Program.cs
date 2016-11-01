//https://leetcode.com/problems/add-digits/
//Status: Accepted
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            // num=0, return 0;
            // num=1~9, return num;
            // 0 1 2 3 4 5 6 7 8 9 1 2 3 4 5 6 7 8 9 1 2 3 4 5 6 7 8 9 ...
        }

        static int AddDigits(int num)
        {
            if (num == 0)
            {
                return 0;
            }
            else
            {
                if (num % 9 == 0)
                {
                    return 9;
                }
                else
                {
                    return num % 9;
                }
            }
        }
    }
}
