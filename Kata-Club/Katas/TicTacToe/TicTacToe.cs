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
            var winLines = new int[][] {
            new []{0,1,2},
            new []{3,4,5},
            new []{6,7,8},
            new []{0,3,6},
            new []{1,4,7},
            new []{2,5,8},
            new []{0,4,8},
            new []{2,4,6} };

            var flattenedBoard = board.Cast<int>().ToArray();
            bool draw = true;

            foreach (var line in winLines)
            {
                if (line.All(x => flattenedBoard[x] == 1)) return 1;
                if (line.All(x => flattenedBoard[x] == 2)) return 2;

                draw = !flattenedBoard.Contains(0);
            }

            return draw ? 0 : -1;
        }
    }
}
