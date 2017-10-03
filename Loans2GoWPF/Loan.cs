using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans2GoWPF
{
    abstract class Loan
    {
        public int term { get; set; }
        public double initialLoanValue { get; set; }
        public double currentOutstandingLoanValue { get; set; }
        public Customer loanOwner { get; set; }
        public double interestRate { get; set; }
        public int loanID { get; }
        static Random rand = new Random();
        public Loan(int term, double initialLoanValue, double currentOutstandingLoanValue,
            Customer loanOwner, double interestRate)
        {
            this.term = term;
            this.initialLoanValue = initialLoanValue;
            this.currentOutstandingLoanValue = currentOutstandingLoanValue;
            this.loanOwner = loanOwner;
            this.interestRate = interestRate;
            // Assigning a random loanID 
            loanID = rand.Next(1, 25000);
        }
    }
}
