using System;
using System.Runtime.CompilerServices;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        /**
         * This question was fairly straightforward and I found that any clever implementations with a
         * constant time formula and such didn't really yield any improvements over the simple and
         * fast nature of the loop below
         */
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int Answer(double debt, double interest, double repayment)
        {
            interest = interest * 0.01 + 1; //Interest as an increase so I can simply multiply
            repayment = debt * repayment * 0.01; //Monthly repayment
            double cost = debt * 0.1; //Cost so far
            while(debt > repayment) //While repayments still to be made
            {
                debt = debt * interest - repayment; //Apply interest and deduct repayment
                cost += repayment; //Increment cost
            }
            return (int)(cost + debt + 0.5); //Round manually to avoid overhead with Math.Round()
        }
    }
}
