using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans2GoWPF
{
    class Car : SecuritisedLoan
    {
        public const double RATE = 4.5;
        public Car(int term, double initialLoanValue, double currentOutstandingLoanValue, Customer loanOwner,
            double currentAssetValue)
            : base(term, initialLoanValue, currentOutstandingLoanValue, loanOwner,
                RATE, currentAssetValue)
        {

        }
        public bool meetsLoanConditions()
        {

            if (term >= 60)
            {
                if (initialLoanValue <= (0.75 * loanOwner.salary))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (term >= 36 && term <= 59)
            {
                if (initialLoanValue <= (0.6 * loanOwner.salary))
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
                if (initialLoanValue <= (0.5 * loanOwner.salary))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
        }

        public override string ToString()
        {
            return "Car (term = " + term + "\n"
                + "intialLoanValue = " + initialLoanValue + "\n"
                + "currentOutstandingLoanValue = " + currentOutstandingLoanValue + "\n"
                + "interest rate = " + interestRate + "\n"
                + loanOwner.ToString()
                + "currentAssetValue = " + currentAssetValue + ")";
        }
    }
}
