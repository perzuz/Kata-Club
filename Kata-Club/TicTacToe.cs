﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata_Club
{
    public class TicTacToe
    {
        public int IsSolved(int[,] board)
        {
            var stuffToCheck = new List<(int[] firstCell, int[] secondCell, int[] thirdCell)>() {
                (new int[]{ 0, 0}, new int[]{ 0, 1}, new int[]{ 0, 2}),
                (new int[]{ 1, 0}, new int[]{ 1, 1}, new int[]{ 1, 2}),
                (new int[]{ 2, 0}, new int[]{ 2, 1}, new int[]{ 2, 2}),
                (new int[]{ 0, 0}, new int[]{ 1, 0}, new int[]{ 2, 0}),
                (new int[]{ 0, 1}, new int[]{ 1, 1}, new int[]{ 2, 1}),
                (new int[]{ 0, 2}, new int[]{ 1, 2}, new int[]{ 2, 2}),
                (new int[]{ 0, 0}, new int[]{ 1, 1}, new int[]{ 2, 2}),
                (new int[]{ 0, 2}, new int[]{ 1, 1}, new int[]{ 2, 0})
            };

            var foundZero = false;

            foreach (var lines in stuffToCheck)
            {
                var elements = new List<int> {
                    board[lines.firstCell[0], lines.firstCell[1]],
                    board[lines.secondCell[0], lines.secondCell[1]],
                    board[lines.thirdCell[0], lines.thirdCell[1]]
                };
                if (elements.Distinct().Count() == 1)
                {
                    return elements.First() == 0 ? -1 : elements.First();
                }
                if (elements.Any(x => x == 0))
                {
                    foundZero = true;
                }
                //var firstVal = board[lines.firstCell[0], lines.firstCell[1]];
                //var secondVal = board[lines.secondCell[0], lines.secondCell[1]];
                //var thirdVal = board[lines.thirdCell[0], lines.thirdCell[1]];
                //if (firstVal == secondVal && secondVal == thirdVal)
                //{
                //    return firstVal == 0 ? -1 : firstVal;
                //}
                //if (firstVal == 0 || secondVal == 0 || thirdVal == 0)
                //{
                //    foundZero = true;
                //}
            }

            // If there's no zeros we are in stalemate
            return foundZero ? -1 : 0;
        }
    }
}
