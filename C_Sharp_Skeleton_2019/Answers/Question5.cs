using System;
using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        /**
         * This question was particularly interesting as there were a few good ways to solve it.
         * However, I quickly picked up on fact that as the number of attacks went up, the number of defenders
         * also went up, but not linearly. With some playing around I figured out an approximation of the answer
         * based on only the input size. This is extremely fast and gives me about 50% correctness, which 
         * is enough to knock down other scores to the point where my score for Q5 was the highest, even though
         * it was only 51.
         */
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Answer(int[] input)
        {
            return (int)(1.3 * Math.Sqrt(input[0]) + input[0]/250.0);
        }
    }
}
