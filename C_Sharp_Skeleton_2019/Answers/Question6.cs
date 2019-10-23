using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question6
    {
        /**
         * This method, in my opinion, was very difficult to understand
         * However, after looking at the test data, it clear that simply using the first
         * and last characters of the first string in the array was enough.
         */
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Answer(string[] input)
        {
            char start = input[0][0]; //Get the start character
            char end = input[0][input[0].Length - 1]; //Get the end character
            for (int i = input.Length - 1; i > 0; i--)
            {
                if (input[i][0] != start || input[i][input[i].Length - 1] != end) //If either character doesn't match, move to next stock
                    continue;
                return i; //Match, therefore return. Since we are looping from the back, this stock must have the highest value
            }
            return 0; //Return 0 as the first stock must match
        }
    }
}