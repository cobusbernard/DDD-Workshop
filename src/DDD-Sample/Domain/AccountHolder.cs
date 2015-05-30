using System;
using System.Collections.Generic;

namespace DDD_Sample.Domain
{
    public class AccountHolder
    {
        public Guid AccountHolderId { get; private set; }
        public List<CreditCard> CreditCard { get; private set; }
        public DateTime JoinDate { get; private set; }
        public AccountHolderName Name { get; private set; }
        public List<AccountHolderName> PreviousNames { get; private set; }

        public List<Application> Applications { get; private set; }

        public Application SuccessfulApplication { get; private set; }


        public void ChangeName(string firstName, string lastName)
        {
            //Log something.
            //Check if they are allowed to change.
            if (PreviousNames == null) 
                PreviousNames = new List<AccountHolderName>();

            PreviousNames.Add(Name);
            Name = new AccountHolderName(firstName, lastName);
        }
    }

    public class AccountHolderName
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        public AccountHolderName(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
