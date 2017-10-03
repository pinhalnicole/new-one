using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans2GoWPF
{
        abstract class SecuritisedLoan : Loan
        {
            public double currentAssetValue { get; set; }
            private int currentMarketValue;

            public SecuritisedLoan(int term, double initialLoanValue, double currentOutstandingLoanValue,
                Customer loanOwner, double interestRate, double currentAssetValue) : base(term, initialLoanValue, currentOutstandingLoanValue,
                loanOwner, interestRate)
            {
                this.currentAssetValue = currentAssetValue;
            }

            public string CurrentMarketValue
            {
                get { return "CMV to be determined"; }
            }
        }
    }

