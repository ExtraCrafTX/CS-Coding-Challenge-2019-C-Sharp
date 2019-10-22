using System;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        public static int Answer(double debt, double interest, double repayment)
        {
            interest = interest * 0.01 + 1;
            repayment = debt * repayment * 0.01;
            double cost = debt * 0.1;
            while(debt > repayment)
            {
                debt = debt * interest - repayment;
                cost += repayment;
            }
            return (int)(cost + debt + 0.5);
        }
    }
}
