using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] input)
        {
            if (input[0] > 30)
                return input[0] / 6;
            else if (input[0] > 18)
                return input[0] / 4;
            else
                return input[0] / 3 + 1;
        }
    }
}