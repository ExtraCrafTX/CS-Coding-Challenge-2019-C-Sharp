namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        public static int Answer(double initialLevelOfDebt, double interestPercentage, double repaymentPercentage)
        {
            interestPercentage = interestPercentage * 0.01 + 1;
            repaymentPercentage *= 0.01;
            double repayment = initialLevelOfDebt * repaymentPercentage;
            double deposit = initialLevelOfDebt * 0.1;
            double totalCost = 0;
            while (initialLevelOfDebt > repayment)
            {
                initialLevelOfDebt = initialLevelOfDebt * interestPercentage - repayment;
                totalCost += repayment;
            }
            totalCost += initialLevelOfDebt + deposit;
            return (int)(totalCost+0.5);
        }
    }
}
