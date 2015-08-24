using System;

namespace Classes_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("nick", "Oleg", "Zubenko", 24);
            Console.WriteLine(user1.ToString());
            Console.ReadKey();
        }
    }

    internal class User
    {
        private string Login;
        private string FirstName;
        private string LastName;
        private byte Age;
        private readonly DateTime MDate;

        public User(string login, string firstName, string lastName, byte age)
        {
            Login = login;
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            MDate = DateTime.Now;
        }


        public override string ToString()
        {
            return string.Format("login: {0}\nfirst name: {1}\nlast name: {2}\nage: {3}\ndate: {4}", Login, FirstName,
                LastName, Age, MDate);
        }
    }
}
