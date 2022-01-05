using System;
namespace GroupExperiment
{
    public class AlatUser
    {
        String Name { get; set; }
        String Email { get; set; }
        String Password { get; set; }

        public AlatUser(String name, String email, String password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

    }
}
