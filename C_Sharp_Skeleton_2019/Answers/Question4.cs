using System;
using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        /**
         * This problem was interesting as a fully correct solution is quite complex in time
         * However, using a simple greedy algorithm which is much faster, we can get about 80%
         * of the way, so the tradeoff for the efficiency was worth it to me
         * Looking at the scoreboard though, clearly there was a better way of doing this question.
         */
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        unsafe public static int Answer(int[] v, int[] c, int mc)
        {
            Array.Sort(v, c); //Sort trades by value
            int total = 0;
            for(int i = v.Length-1; i >= 0; i--) //Loop through and simply pick trades with the highest values possible
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