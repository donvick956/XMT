using System;
namespace GroupExperiment
{
    public class AlatUser
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccountNumber { get; set; }
        public double Balance { get; set; }

        public AlatUser()
        {

        }

        public AlatUser(string email, string password)
        {
            Email = email;
            Password = password;
        }

    }

    public class Recipient : AlatUser
    {
        public string Bank { get; set; }
        public double AmountToRecieve { get; set; }

        public Recipient()
        {

        }

        public Recipient(string bank, string accountNumber, double amountToRecieve)
        {
            string[] names = {"John Akpan", "Horace Smith", "Cliff Orange", "Red Mazzi" };
            Random random = new Random();

            this.Bank = bank;
            this.AccountNumber = accountNumber;
            this.AmountToRecieve = amountToRecieve;
            this.Name = names[random.Next(names.Length)];
        }
    }
}
