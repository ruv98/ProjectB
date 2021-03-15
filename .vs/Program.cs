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
            bool ExistOrNot = false;
            string usernamecheck, passwordcheck = string.Empty;
            try
            {
                using (StreamReader acc = new StreamReader(File.Open($"C:\\{username.Item1}.txt", FileMode.Open)));
                ExistOrNot = true;
                return true;
            }
            catch (FileNotFoundException)
            {
                Console.Write("Account does not exist");
                return false;
            }

            if (ExistOrNot == true)
            {
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
    }


    class Program
    {

        static void Main(string[] args)
        {
            bool AdminLogin = false;
            Console.WriteLine("Press a numberkey to choose option");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: Register new account");
            Console.WriteLine("3: Back");
            string x = Console.ReadLine();
            if (x == "2")
            {
                // Register new account
                Console.Write("Enter a username: ");
                string username = Console.ReadLine();
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();

                Tuple<string, string> user = Tuple.Create(username, password);

                var newuser = new Account();
                newuser.Register(user);
            }

            else if (x == "1")
            {
                // Login
                Console.Write("Enter a username: ");
                string username = Console.ReadLine();
                Console.Write("Enter a password: ");
                string password = Console.ReadLine();

                Tuple<string, string> user = Tuple.Create(username, password);
                if (username == "Admin" && password == "Admin")
                {
                    AdminLogin = true;
                    Console.WriteLine("Logged in as Administrator");
                }
                else
                {
                    var userlogin = new Account();
                    userlogin.Login(user);
                }
            }

            else if (x == "3")
            {
                Console.WriteLine("empty for now");
            }

        }
    }
}
