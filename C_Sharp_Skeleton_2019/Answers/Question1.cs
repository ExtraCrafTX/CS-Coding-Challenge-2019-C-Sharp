using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Threading.Tasks;

namespace C_Sharp_Challenge_Skeleton.Answers
{
    public class Question1
    {
        public static int Answer(double initialLevelOfDebt, double interestPercentage, double repaymentPercentage)
        {
            interestPercentage = interestPercentage * 0.01 + 1;
            repaymentPercentage *= 0.01;
            double repayment = initialLevelOfDebt * repaymentPercentage;
            double debt = initialLevelOfDebt;
            double deposit = initialLevelOfDebt * 0.1;
            double totalCost = 0;
            while (debt > repayment)
            {
                debt *= interestPercentage;
                debt -= repayment;
                totalCost += repayment;
            }
            totalCost += debt + deposit;
            return (int)Math.Round(totalCost);
        }
    }
}
