using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        /**
         * For this problem, technically sorting the trader array could yield a better efficiency
         * especially for larger arrays, but with the sizes we are concerned with, the additional
         * sort was just an extra overhead.
         * There was clearly more optimizations to be made here, looking at the scoreboard.
         */
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        unsafe public static int Answer(int[] risk, int[] bonus, int[] trader)
        {
            fixed (int* bP = bonus, rP = risk) //To avoid bounds checks, access array using a pointer
            {
                Quicksort(0, bonus.Length - 1, bP, rP); //Sort the trades by bonus
            }
            int total = 0; //The total bonus of all trades made
            foreach(int skill in trader) //Every trader should try to make a trade
            {
                for (int i = risk.Length-1; i >= 0; i--) //Loop over trades backwards
                {
                    /*Since the trades are sorted by bonus, simply picking the first available trade will be optimal
                     */
                    if (risk[i] <= skill)
                    {
                        total += bonus[i];
                        break;
                    }
                }
            }
            return total;
        }

        /**
         * The reason I implemented a custom sort function is that I could then use unsafe pointers to access
         * values in the array, eliminating bounds checks. I could also have potentially flipped the sorting
         * order, but I decided against this in the end as there really was no difference in performance
         */
        unsafe public static void Quicksort(int left, int right, int* keys, int* vals)
        {
            int first = left;
            int last = right;
            if (right - left < 1)
                return;
            int pivot = keys[(left + right) / 2];
            while (left <= right)
            {
                while (keys[left] < pivot)
                    left++;
                while (keys[right] > pivot)
                    right--;
                if(left <= right)
                {
                    int t = keys[left];
                    keys[left] = keys[right];
                    keys[right] = t;
                    t = vals[left];
                    vals[left] = vals[right];
                    vals[right] = t;
                    left++;
                    right--;
                }
            }
            Quicksort(first, right, keys, vals);
            Quicksort(left, last, keys, vals);
        }
    }
}