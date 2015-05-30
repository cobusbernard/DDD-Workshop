using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDD_Sample.Domain
{
    public class Applicant
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string SSN { get; private set; }

        public Applicant(string firstName, string lastName, string ssn)
        {
            FirstName = firstName;
            LastName = lastName;
            SSN = ssn;
        }

        public string GetApplicantFullName()
        {
            return string.Concat(FirstName, " ", LastName);
        }
    }
}
