using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loans2GoWPF
{
    class Customer
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string DOB { get; set; }
        public string PPSN { get; set; }
        public string address { get; set; }
        public double salary { get; set; }

        public Customer(string firstName, string lastName, string DOB, string PPSN,
            string address, double salary)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.DOB = DOB;
            this.PPSN = PPSN;
            this.address = address;
            this.salary = salary;
        }

        public override string ToString()
        {
            return "Customer( firstname = " + firstName + "\n"
                + "last name = " + lastName + "\n"
                + "DOB = " + DOB + "\n"
                + "PPSN = " + PPSN + "\n"
                + "address = " + address + "\n"
                + "salary = " + salary + ")";
        }
    }
}
