using DataModelsLib;
using System;

namespace EmiCalculatorLib
{
    public static class EmiCalculatorType
    {




        public static EMIInfo CalculateEMIDetails(double principal, double tenure, double interestRate)
        {
            var monthlyInterestRate = interestRate / 12;
            monthlyInterestRate /= 100;

            var emiValue = CalculateEMIValue(principal, monthlyInterestRate, tenure);
            var totalAmountPayable = emiValue * tenure;
            var totalInterestAmount = totalAmountPayable - principal;

            return new EMIInfo()
            {
                emiValue = emiValue,
                payableAmount = totalAmountPayable,
                interestAmount = totalInterestAmount
            };
        }

        private static double CalculateEMIValue(double principal, double monthlyInterestRate, double tenure)
        {
            return Math.Round((principal * monthlyInterestRate * Math.Pow((1 + monthlyInterestRate), tenure)) / (Math.Pow((1 + monthlyInterestRate), tenure) - 1));
        }

    }
}
