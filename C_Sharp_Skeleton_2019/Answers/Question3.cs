using System;
using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        /**
         * This problem was one where a lot of minor optimizations could be made.
         * Technically I can remove the lastPos local variable which could be better, but this difference was
         * marginal in my testing and did not affect my score at all.
         */
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        unsafe public static int Answer(int[] scores, int[] alice)
        {
            //Sort both scores arrays
            Array.Sort(scores);
            Array.Sort(alice);
            //In this case I didn't use my custom sort as it did not provide any improvement
            int currentPos = 1; //Keep track of the current leaderboard pos
            int currentS = scores.Length - 1; //Keep track of the current score
            int lastPos = 0; //Keep track of the last position that was found
            int count = 0; //Keep track of the number of times lastPos occured
            int maxCount = 0; //Keep track of the maximum count we have seen so far
            int maxVal = 0; //Keep track of the associated position
            fixed (int* sp = scores) //Again using pointers to avoid bounds checks
            {
                for (int i = alice.Length - 1; i >= 0; i--) //For every score work out the position
                {
                    //If we are not in the right position, loop till we are, keeping track of current pos
                    for (int score = alice[i]; currentS >= 0 && score < sp[currentS]; currentPos++)
                    {
                        int lastVal = sp[currentS];
                        while (currentS >= 0 && lastVal == sp[currentS])
                        {
                            currentS--;
                        }
                    }
                    //If the current pos has changed, reset count
                    if (currentPos != lastPos)
                    {
                        lastPos = currentPos;
                        count = 1;
                    }
                    else
                    {
                        count++; //Same pos as last time, so increment count
                    }
                    if (count >= maxCount) //Check and maintain maximum
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
