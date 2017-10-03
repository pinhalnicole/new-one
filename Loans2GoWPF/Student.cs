using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans2GoWPF
{
    class Student : SecuritisedLoan
    {
        public const double RATE = 1.5;
        public const int MIN_SALARY = 22500;
        public Student(int term, double initialLoanValue, double currentOutstandingLoanValue, Customer loanOwner,
            double currentAssetValue)
            : base(term, initialLoanValue, currentOutstandingLoanValue, loanOwner,
                RATE, currentAssetValue)
        {
        }

        public bool meetsLoanConditions()
        {
            if (loanOwner.salary >= MIN_SALARY)
            {
                if (initialLoanValue > 20000 || term > 360)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return "Student (term = " + term + "\n"
                + "intialLoanValue = " + initialLoanValue + "\n"
                + "currentOutstandingLoanValue = " + currentOutstandingLoanValue + "\n"
                + "interest rate = " + interestRate + "\n"
                + loanOwner.ToString()
                + "currentAssetValue = " + currentAssetValue + ")";
        }
    }
}
