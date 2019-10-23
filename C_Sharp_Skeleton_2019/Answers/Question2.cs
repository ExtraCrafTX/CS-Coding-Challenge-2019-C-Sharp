using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        unsafe public static int Answer(int[] risk, int[] bonus, int[] trader)
        {
            fixed (int* bP = bonus, rP = risk)
            {
                Quicksort(0, bonus.Length - 1, bP, rP);
            }
            int total = 0;
            foreach(int skill in trader)
            {
                for (int i = risk.Length-1; i >= 0; i--)
                {
                    if (risk[i] <= skill)
                    {
                        total += bonus[i];
                        break;
                    }
                }
            }
            return total;
        }

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