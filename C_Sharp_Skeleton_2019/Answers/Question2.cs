using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        public static int Answer(int[] risk, int[] bonus, int[] trader)
        {
            int total = 0;
            foreach(int skill in trader)
            {
                int best = 0;
                for (int i = 0; i < risk.Length; i++)
                {
                    if (best < bonus[i] && risk[i] <= skill)
                    {
                        best = bonus[i];
                    }
                }
                total += best;
            }
            return total;
        }
    }
}