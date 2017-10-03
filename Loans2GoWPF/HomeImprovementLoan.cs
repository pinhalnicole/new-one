using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans2GoWPF
{
    class HomeImprovementLoan : Loan
    {
        public const double RATE = 3.5;
        public const int MIN_SALARY = 20500;

        public HomeImprovementLoan(int term, double initialLoanValue, double currentOutstandingLoanValue,
            Customer loanOwner) : base(term, initialLoanValue, currentOutstandingLoanValue,
            loanOwner, RATE)
        {

        }

        public bool meetsLoanConditions()
        {
            if (initialLoanValue <= 9000)
            {
                if (term >= 48 && term <= 90 && loanOwner.salary >= MIN_SALARY)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Home Improvement (term = " + term + "\n"
                + "intialLoanValue = " + initialLoanValue + "\n"
                + "currentOutstandingLoanValue = " + currentOutstandingLoanValue + "\n"
                + "interest rate = " + interestRate + "\n"
                + loanOwner.ToString() + ")";
        }
    }
}
