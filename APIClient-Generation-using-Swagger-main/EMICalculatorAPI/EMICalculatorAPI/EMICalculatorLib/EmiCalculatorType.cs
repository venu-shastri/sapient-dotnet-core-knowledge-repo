using System;

namespace EMICalculatorLib
{
    public static class EmiCalculatorType    {
        


      /* public string ShowEMIDetails(double principal, double tenure, double interestRate)
        {
            var monthlyInterestRate = interestRate / 12;
            monthlyInterestRate /= 100;
            var emi = CalculateEMIValue(principal, monthlyInterestRate, tenure);

            return CalculateEMIDetails(principal, tenure, monthlyInterestRate) + ShowBreakupDetails(principal, tenure, monthlyInterestRate, emi);
        }*/

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

        /*private string ShowBreakupDetails(double principal, double tenure, double monthlyInterestRate, double monthlyEMI)
        {
           
            var monthlyEMIList = Calculator.GetBreakupDetails(principal, tenure, monthlyInterestRate, monthlyEMI);

            string res = "\nInstallment Number\t\tEMI Amount\t\tPrincipal\t\tInterest\t\tBalance Amount";
            
            foreach(var currentEMI in monthlyEMIList)
            {
                res += $"\n{currentEMI.installmentNumber}\t\t\t{monthlyEMI}\t\t\t{currentEMI.monthlyPrincipal}\t\t\t{currentEMI.monthlyInterest}\t\t\t{currentEMI.balanceAmount}";
            }

            return res;
        }*/
    }
}
