using System;
using System.Collections.Generic;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question3
    {
        public static int Answer(int[] scores, int[] alice)
        {
            SortedSet<int> set = new SortedSet<int>(scores, new ReverseComparer());
            int[] leaderboard = new int[set.Count];
            set.CopyTo(leaderboard);
            Dictionary<int, int> pos = new Dictionary<int, int>();
            int maxVal = 0;
            int maxCount = 0;
            for (int i = 0; i < alice.Length; i++)
            {
                int res = findPos(leaderboard, alice[i]);
                if (pos.ContainsKey(res))
                {
                    int count = pos[res] + 1;
                    pos[res] = count;
                    if (count > maxCount || (count == maxCount && res > maxVal))
                    {
                        maxVal = res;
                        maxCount = count;
                    }
                }
                else
                {
                    pos[res] = 1;
                    if (1 > maxCount || (1 == maxCount && res > maxVal))
                    {
                        maxVal = res;
                        maxCount = 1;
                    }
                }
            }
            return maxVal + 1;
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
                else if (score < leaderboard[m])
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
                    return l + 1;
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