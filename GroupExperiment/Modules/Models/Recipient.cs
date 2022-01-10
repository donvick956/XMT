using System;
namespace GroupExperiment.Modules.Models
{
    public class Recipient : Customer
    {
        public string Bank { get; set; }
        public double AmountToRecieve { get; set; }

        public Recipient()
        {
        }

        public Recipient(string name, string bank, string accountNumber, double amountToRecieve)
        {
            this.Bank = bank;
            this.AccountNumber = accountNumber;
            this.AmountToRecieve = amountToRecieve;
            this.AccountName = name;
        }
    }

    public class RecipientDTO
    {
        public double TransactionAmount { get; set; }
        public string ReceiverAccount { get; set; }
        public string Bank { get; set; }

        public RecipientDTO(double transactionAmount, string receiverAccount, string bank)
        {
            this.TransactionAmount = transactionAmount;
            this.ReceiverAccount = receiverAccount;
            this.Bank = bank;
        }
    }
}
