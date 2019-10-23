using System;
using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        unsafe public static int Answer(int[] scores, int[] alice)
        {
            Array.Sort(scores);
            Array.Sort(alice);
            int currentPos = 1;
            int currentS = scores.Length - 1;
            int lastPos = 0;
            int count = 0;
            int maxCount = 0;
            int maxVal = 0;
            fixed (int* sp = scores)
            {
                for (int i = alice.Length - 1; i >= 0; i--)
                {
                    for (int score = alice[i]; currentS >= 0 && score < sp[currentS]; currentPos++)
                    {
                        int lastVal = sp[currentS];
                        while (currentS >= 0 && lastVal == sp[currentS])
                        {
                            currentS--;
                        }
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
            }
            return maxVal;
        }
    }
}
