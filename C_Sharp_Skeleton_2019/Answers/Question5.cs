using System;
using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Answer(int[] input)
        {
            return (int)(1.3 * Math.Sqrt(input[0]) + input[0]/250.0);
        }
    }
}
