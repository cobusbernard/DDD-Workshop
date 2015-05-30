using System;

namespace DDD_Sample.Domain
{
    public class CreditCard
    {
        public Guid CreditCardId { get; private set; }
        public long CreditCardNumber { get; private set; }
        public string NameOnCard { get; private set; }
        public DateTime Expiry { get; private set; }
        public string CVV { get; private set; }
        public decimal APR { get; private set; }
        public decimal CreditLimit { get; private set; }
        public decimal Balance { get; private set; }
    }

    public enum CreditCardStatus
    {
        Active,
        Inactive,
        Suspended,
        Cancelled,
        Stolen
    }
}
