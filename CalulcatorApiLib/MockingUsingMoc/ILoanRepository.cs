using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockingUsingMoc
{
    public interface ILoanRepository
    {
        LoanType LoanType { get; set; }
        float Rate { get; set; }
        List<LoanType> GetLoanTypes();
        List<Loan> GetCarLoans();
        List<Person> GetCarLoanDefaulters(int year);
        List<Loan> GetBadCarLoans();
    }
}
