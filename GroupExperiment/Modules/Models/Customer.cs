using System;
namespace GroupExperiment
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AccountName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string AccountType { get; set; }
        public string AccountNumber { get; set; }
        public double AccountBalance { get; set; }


        public Customer()
        {

        }

        public Customer(string email, string password)
        {
            Email = email;
            Password = password;
        }

    }
}
