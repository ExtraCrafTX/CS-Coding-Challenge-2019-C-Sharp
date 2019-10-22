using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int[] scores, int[] alice)
        {
            Array.Sort(scores);
            Array.Sort(alice);
            int currentPos = 1;
            int currentS = scores.Length - 1;
            int lastPos = 0;
            int count = 0;
            int maxCount = 0;
            int maxVal = 0;
            for (int i = alice.Length - 1; i >= 0; i--)
            {
                int score = alice[i];
                while (currentS >= 0 && score < scores[currentS])
                {
                    int lastVal = scores[currentS];
                    while(currentS >= 0 && lastVal == scores[currentS])
                    {
                        currentS--;
                    }
                    currentPos++;
                }
                if (currentPos != lastPos)
                {
                    lastPos = currentPos;
                    count = 1;
                }
                else
                {
                    count++;
                }
                if (count >= maxCount)
                {
                    maxCount = count;
                    maxVal = currentPos;
                }
            }
            return maxVal;
        }
    }
}