using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int[] scores, int[] alice)
        {
            SortedSet<int> set = new SortedSet<int>(scores);
            set.CopyTo(scores);
            int n = set.Count;
            Array.Sort(alice);
            int lastS = n-1;
            int count = 0;
            int maxCount = 0;
            int maxVal = 0;
            for(int i = alice.Length-1; i >= 0; i--)
            {
                int s;
                for(s = lastS; s>=0 && scores[s] > alice[i]; s--){}
                if (s != lastS)
                {
                    count = 1;
                    lastS = s;
                }
                else
                {
                    count++;
                }
                if(count >= maxCount)
                {
                    maxCount = count;
                    maxVal = s;
                }
            }
            return n - maxVal;
        }

        public static int findPos(int[] leaderboard, int score)
        {
            int l = 0;
            int r = leaderboard.Length - 1;
            while (l < r)
            {
                int m = (l + r) / 2;

                if (score == leaderboard[m])
                {
                    return m;
                }
                else if (score > leaderboard[m])
                {
                    l = m + 1;
                }
                else
                {
                    r = m - 1;
                }
            }
            if (l >= r)
            {
                if (score >= leaderboard[l])
                {
                    return l;
                }
                else
                {
                    return l - 1;
                }
            }
            return 0;
        }

        private class ReverseComparer : IComparer<int>
        {
            public int Compare(int a, int b)
            {
                return b - a;
            }
        }
    }
}