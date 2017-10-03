using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans2GoWPF
{
    class Mortgage : SecuritisedLoan
    {
        public const double RATE = 4.5;
        public Mortgage(int term, double initialLoanValue, double currentOutstandingLoanValue,
            Customer loanOwner, double currentAssetValue) :
            base(term, initialLoanValue, currentOutstandingLoanValue, loanOwner, RATE,
                currentAssetValue)
        {

        }

        public bool meetsLoanConditions()
        {
            if (term >= 240)
            {
                if (initialLoanValue <= (4 * loanOwner.salary))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else if (term >= 180 && term < 240)
            {
                if (initialLoanValue <= (3 * loanOwner.salary))
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
                if (initialLoanValue <= (2.5 * loanOwner.salary))
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
            return "Morgage( term = " + term + "\n"
                + "initialLoanValue = " + initialLoanValue + "\n"
                + "currentOutstandingLoanValue = " + currentOutstandingLoanValue + "\n"
                + "interest rate = " + RATE + "\n"
                + loanOwner.ToString()
                + "currentAssetValue = " + currentAssetValue + ")";
        }
    }
}
