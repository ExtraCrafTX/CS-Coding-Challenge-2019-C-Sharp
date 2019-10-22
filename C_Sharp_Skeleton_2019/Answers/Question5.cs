using System;
using System.Collections.Generic;
namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question5
    {
        public static int Answer(int[] input)
        {
            return input[0] < 30 ? (int)(Math.Log(input[0],1.8)+0.5) : (int)(Math.Log(input[0],1.45)+0.5);
        }
    }
}