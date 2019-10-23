using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader)
        {
            Array.Sort(bonus, risk);
            int total = 0;
            foreach(int skill in trader)
            {
                for (int i = risk.Length-1; i >= 0; i--)
                {
                    if (risk[i] <= skill)
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