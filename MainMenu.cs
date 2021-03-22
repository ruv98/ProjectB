using System;

namespace MainMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu(); 
        }
        static void MainMenu()
        {
            Console.WriteLine("1. Log in\n2. Current Menu\n3. Future Menu\n4. Information about the Restaurant\n5. Exit");
            string x = Console.ReadLine();
            if(x == "1")
            {
                LogIn();
            }
            if(x == "2")
            {
                CurrentMenu();
            }
            if(x == "3")
            {
                FutureMenu();
            }
            if(x == "4")
            {
                Info();
            }
            if(x == "5")
            {
                Exit();
            }
        }
        static void LogIn()
        {
            Console.WriteLine("\nLogin Page\n");
            Console.WriteLine("0. Previous Page");
            string x = Console.ReadLine();
            if(x == "0")
            {
                MainMenu();
            }
            else
            {
                LogIn();
            }

        }
        static void CurrentMenu()
        {
            Console.WriteLine("\nCurrent Menu\n");
            Console.WriteLine("0. Previous Page");
            string x = Console.ReadLine();
            if(x == "0")
            {
                MainMenu();
            }
            else
            {
                CurrentMenu();
            }
        }
        static void FutureMenu()
        {
            Console.WriteLine("\nFuture Menu\n");
            Console.WriteLine("0. Previous Page");
            string x = Console.ReadLine();
            if (x == "0")
            {
                MainMenu();
            }
            else
            {
                FutureMenu();
            }
        }
        static void Info()
        {
            Console.WriteLine("_________________________\n\nOpening Hours\n\nMonday:     CLOSED\nTuesday:    16:00-20:00\n" +
            "Wednesday:  16:00-20:00\nThursday:   16:00-20:00\nFriday:     16:00-21:00\nSatuday:    16:00-21:00\nSunday:     " +
            "16:00-21:00\n_________________________\n\nContact Us\n\nPhone Number: 071-5119113\n_________________________\n");
            Console.WriteLine("0. Previous Page");
            string x = Console.ReadLine();
            if(x == "0")
            {
                MainMenu();
            }
            else
            {
                Info();
            }
        }
        static void Exit()
        {
            Console.WriteLine("Exit");
        }
    }
}
