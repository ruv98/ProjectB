using System;

namespace ProjectB
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Dish1\nDish2\nDish3\nDish4\nDish5\nDish6\nDish7\nDish8\nDish9\nDish10");

            
            Console.Write("Enter the dishnumber you want to view: ");
            int dishNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You want to view dish: " + dishNumber);
        }

        
            
    }
}
