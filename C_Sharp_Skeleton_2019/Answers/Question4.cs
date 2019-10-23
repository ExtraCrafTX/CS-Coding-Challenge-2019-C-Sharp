using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        unsafe public static int Answer(int[] v, int[] c, int mc)
        {
            Array.Sort(v, c);
            int total = 0;
            for(int i = v.Length-1; i >= 0; i--)
            {
                if (c[i] <= mc)
                {
                    total += v[i];
                    mc -= c[i];
                }
            }
            return total;
        }
    }
}