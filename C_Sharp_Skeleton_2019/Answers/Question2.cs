using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader)
        {
            Array.Sort(bonus, risk);
            Array.Sort(trader);
            int total = 0;
            int i = risk.Length - 1;
            for (int t = trader.Length - 1; t >= 0; t--)
            {
                for (; i >= 0; i--)
                {
                    if (risk[i] <= trader[t])
                    {
                        total += bonus[i];
                        break;
                    }
                }
            }
            return total;
        }
    }
}