using System;
using System.IO;


namespace Project_B
{
   class Program
   { 
        public static void Register(Tuple<string, string> username) // Function to register an account using a tuple that consists of a username and password.
        {
            using (StreamWriter text = new StreamWriter(File.Create($"C:\\{username.Item1}.json")))
            {
                text.WriteLine(username.Item1);
                text.WriteLine(username.Item2);
                text.Close();
            }

            Console.WriteLine("Account succesfuly made");
        }

        public static bool Login(Tuple<string, string> username) // Function to login using a tuple that consists of a username and password.
        {
            string usernamecheck, passwordcheck = string.Empty;
            try
            {
                using (StreamReader acc = new StreamReader(File.Open($"C:\\{username.Item1}.json", FileMode.Open)))
                {
                    usernamecheck = acc.ReadLine();
                    passwordcheck = acc.ReadLine();
                    acc.Close();
                }

                if (usernamecheck == username.Item1 && passwordcheck == username.Item2)
                {
                    return true;
                }

                else
                {
                    Console.WriteLine("Incorrect username or password");
                    Console.WriteLine(" ");
                    return false;
                }
            }
            catch (FileNotFoundException)
            {
                Console.Write("Account does not exist");
                Console.WriteLine(" ");
                return false;
            }
        }
    
        public static Tuple<string,string> inputUsernamePassword()
        {
            Console.Write("Enter a username: ");
            string username = Console.ReadLine();
            Console.Write("Enter a password: ");
            string password = Console.ReadLine();

            return Tuple.Create(username, password);
        }


        static void Main(string[] args)
        {
            bool adminLogin = false;
            bool userLogin = false;
            Console.WriteLine("Press a numberkey to choose option");
            Console.WriteLine("1: Login");
            Console.WriteLine("2: Register new account");
            Console.WriteLine("3: Back");
            string x = Console.ReadLine();
            if (x == "2") // Register
            {
                var user = inputUsernamePassword();

                Register(user);
            }

            else if (x == "1") // Login
            {
                var user = inputUsernamePassword();

                if (user.Item1 == "Admin" && user.Item2 == "Admin")
                {
                    adminLogin = true;
                }

                else
                {
                    var login = Login(user);
                    while (login == false && userLogin == false)
                    {
                        Console.WriteLine("Enter 0 to cancel, or press enter to retry");
                        var quit = Console.ReadLine();
                        if (quit == "0")
                        {
                            break;
                        }
                        user = inputUsernamePassword();
                        login = Login(user);
                        if (login == true)
                        {
                            Console.WriteLine("Login succesful");
                            userLogin = true;
                        }
                    }
                }
            }

            else if (x == "3") // Back
            {
                Console.WriteLine("empty for now");
            }

        }
    }
}
