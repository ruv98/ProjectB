using System;
using System.IO;

namespace Project_B
{
    public class Account
    {
        public string Name;
        public void Register(Tuple<string, string> username)
        {
            using (StreamWriter text = new StreamWriter(File.Create($"C:\\{username.Item1}.txt")))
            {
                text.WriteLine(username.Item1);
                text.WriteLine(username.Item2);
                text.Close();
            }

            Console.WriteLine("Account succesfuly made");
        }

        public bool Login(Tuple<string, string> username)
        {
            string usernamecheck, passwordcheck = string.Empty;
            using (StreamReader acc = new StreamReader(File.Open($"C:\\{username.Item1}.txt", FileMode.Open)))
            {
                usernamecheck = acc.ReadLine();
                passwordcheck = acc.ReadLine();
                acc.Close();
            }

            if (username.Item1 == usernamecheck && username.Item2 == passwordcheck)
            {
                Console.WriteLine("Login successful");
                return true;
            }
            else
            {
                Console.WriteLine("Incorrect username or password");
                return false;
            }
        }
    }


    class Program
    {

        static void Main(string[] args)
        {
            int x = 1;
            if (x == 0)
            {
                Console.Write("Enter a username: ");
                string username = Console.ReadLine();
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();

                Tuple<string, string> user = Tuple.Create(username, password);

                var newuser = new Account();
                newuser.Register(user);
            }

            else if (x == 1)
            {
                Console.Write("Enter a username: ");
                string username = Console.ReadLine();
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();

                Tuple<string, string> user = Tuple.Create(username, password);

                var userlogin = new Account();
                userlogin.Login(user);
            }


        }
    }
}
