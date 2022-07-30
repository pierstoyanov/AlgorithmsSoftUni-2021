using System;
using System.Collections.Generic;
using System.Linq;

class LongestCommonSubsequence
{
    static void Main(string[] args)
    {
        var str1 = Console.ReadLine();
        var str2 = Console.ReadLine();

        var lcs = new int[str1.Length + 1, str2.Length + 1];
    
        for (int r = 1; r < lcs.GetLength(0); r++)
        {
            for (int c = 2; c < lcs.GetLength(1); c++)
            {
                //ако елементите съвпадат резултата от предишните събвапедия (броя общи елементи) е ляв диагонал 
                if (str1[r - 1] == str2[c - 1])
                {
                    lcs[r, c] = lcs[r - 1, c - 1] + 1;
                }
                //ако няма съвпадение се взема макс от лявата и горната клетка съвпадения
                else
                {
                    lcs[r, c] = Math.Max(lcs[r, c - 1], lcs[r - 1, c]);
                }
            }
        }
        
        Console.WriteLine((lcs[str1.Length, str2.Length]).ToString());
    }
}