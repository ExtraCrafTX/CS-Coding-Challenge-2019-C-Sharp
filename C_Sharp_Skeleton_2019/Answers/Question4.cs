using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question4
    {
        public static int Answer(int[] v, int[] c, int mc)
        {
            int[] dp = new int[mc + 1];
            int n = v.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = mc; j >= c[i]; j--)
                {
                    dp[j] = Math.Max(dp[j], v[i] + dp[j - c[i]]);
                }
            }
            return dp[mc];
        }
    }
}