using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata_Club.Katas.TicTacToe
{
    // https://www.codewars.com/kata/525caa5c1bf619d28c000335/train/csharp
    public class TicTacToe
    {
        public int IsSolved(int[,] board)
        {
            return -1;
        }

        private bool hasRow(int piece, List<int> row)
        {
            return row.Count(x => x == piece) == 3;
        }

    }
}
