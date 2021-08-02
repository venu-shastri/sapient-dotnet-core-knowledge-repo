using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace MockingUsingMoc
{
    public class LoanServiceTest
    {
        private Mock<ILoanRepository> loanRepository;
        private LoanService loanService;
        public LoanServiceTest()
        {
            loanRepository = new Mock<ILoanRepository>();
            List<Person> people = new List<Person>
            {
            new Person { FirstName = "Donald", LastName = "Duke", Age =30},
            new Person { FirstName = "Ayobami", LastName = "Adewole", Age=20}
            };
            loanRepository.Setup(x => x.GetCarLoanDefaulters(It.IsInRange<int>(1, 12, Moq.Range.Inclusive))).Returns(() => people);
            List<Loan> loans = new List<Loan>
            {
            new Loan{Amount = 120000, Rate = 12.5, ServiceYear = 5,
            HasDefaulted = false },
            new Loan {Amount = 150000, Rate = 12.5, ServiceYear = 4,
            HasDefaulted = true },
            new Loan { Amount = 200000, Rate = 12.5, ServiceYear = 5,
            HasDefaulted = false }
            };
            loanRepository.Setup(x => x.GetCarLoans()).Returns(loans);
            loanRepository.Setup(x => x.GetBadCarLoans()).Returns(loans);
            loanService = new LoanService(loanRepository.Object);


            //            var loanRepository = new Mock<ILoanRepository>
            //            {
            //                DefaultValueProvider = new
            //TestDefaultValueProvider()
            //            };
            //            var objectName = loanRepository.Object.Name;
        }

        [Fact]
        public void Test_GetBadCarLoans_ShouldReturnLoans()
        {
            List<Loan> badLoans = loanService.GetBadCarLoans();
            Assert.NotNull(badLoans);
        }

        //Interaction Testing 
        [Fact]
        public void Test_GetOlderCarLoanDefaulters_ShouldReturnList()
        {
            List<Person> defaulters = loanService.GetOlderCarLoanDefaulters(12);
            Assert.NotNull(defaulters);
            Assert.All(defaulters, x => Assert.Contains("Donald", x.FirstName));
           
            loanRepository.Verify(x => x.GetCarLoanDefaulters(It.IsInRange<int>(1, 12, Moq.Range.Inclusive)), Times.Once());
        }


   


    }

}
