using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading;

namespace Fantastic
{
    public class Solution
    {
        public int DungeonGame(int[][] dungeon)
        {
            int[] dp = new int[dungeon[0].Length];
            Array.Fill(dp, int.MaxValue);
            dp[^1] = 1;
            for (int i = dungeon.Length - 1; i >= 0; i--)
            {
                dp[^1] = Math.Max(dp[^1] - dungeon[i][^1], 1);
                for (int j = dungeon[i].Length - 2; j >= 0; j--)
                {
                    int min_HP_on_exit = Math.Min(dp[j], dp[j + 1]);
                    dp[j] = Math.Max(min_HP_on_exit - dungeon[i][j], 1);
                }
            }
            return dp[0];
        }
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            int[][] numbers = {
            new int[] { -2, -3, 3 },
            new int[] { -5, -10, 1 },
            new int[] { 10, 30, -5}
            };
            Console.WriteLine(solution.DungeonGame(numbers));
        }
    }

    
            //int HeroHealth = 3;
            //int[,] labirint = new int[3, 3] { {-1,2,-4 }, {-5,-2,1 }, {5,3,-1} };
            //List<string> list = new List<string>();
            //for (int i = 0; i < labirint.GetLength(0); i++)
            //{
            //    for (int j = 0; j < labirint.GetLength(1);j++)
            //    {
            //        Console.Write(labirint[i,j] + " ");
            //    }
            //    Console.WriteLine("");
            //}
            //    for(int i = 0;i < labirint.GetLength(0); i++)
            //    {
            //        for(int j = 0;j < labirint.GetLength(1); j++) 
            //        {
            //            if (labirint[i+1,j]-3<=0&&i!= labirint.GetLength(0)-1)
            //            {

            //            }
            //            if(labirint[i, j] - 3 <= 0)
            //            {

            //            }
            //        }
            //    }
}
