using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        public static int Answer(string[] input)
        {
            char start = input[0][0];
            char end = input[0][input[0].Length - 1];
            for (int i = input.Length - 1; i >= 0; i--)
            {
                if (input[i][0] != start || input[i][input[i].Length - 1] != end)
                    continue;
                return i;
            }
            return -1;
        }
    }
}