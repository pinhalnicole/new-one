using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans2GoWPF
{
    class Sundry : Loan
    {
        public const double RATE = 4;
        public const int MIN_SALARY = 20500;

        public Sundry(int term, double initialLoanValue, double currentOutstandingLoanValue,
            Customer loanOwner) : base(term, initialLoanValue, currentOutstandingLoanValue,
            loanOwner, RATE)
        {

        }

        public bool meetsLoanConditions()
        {
            if (initialLoanValue <= 3000)
            {
                if (term >= 18 && term <= 36 && loanOwner.salary >= MIN_SALARY)
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
            return "Sundry (term = " + term + "\n"
                + "intialLoanValue = " + initialLoanValue + "\n"
                + "currentOutstandingLoanValue = " + currentOutstandingLoanValue + "\n"
                + "interest rate = " + interestRate + "\n"
                + loanOwner.ToString() + ")";
        }
    }
}
