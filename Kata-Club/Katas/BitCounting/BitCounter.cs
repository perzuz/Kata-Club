using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata_Club.Katas.BitCounting
{
    public class BitCounter
    {
        public int CountBits(int number)
        {
            return Convert.ToString(number, 2).Count(x => x == '1');
        }
    }
}
