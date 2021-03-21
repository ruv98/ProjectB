using System;
using System.Collections.Generic;

namespace ProjectB
{
    class MainClass
    {
        static void Main(string[] args)
        {
            
            //Welcome message
            Console.WriteLine("***Welcome to the future menu page!***\n");
            Console.WriteLine("Here you can find dishes that are to be added... \n\n");

            //New dishes content 
            //Primers   
            Console.WriteLine("Appetizer");
            string[] appetizerDishes = {"1. Bruschetta", "2. Insalata con mozzarella e avocado", "3. Grissini con prosciutto crudo e parmigiano"};
            List<string> appetizerDishesList = new List<string>(appetizerDishes);
            foreach (string x in appetizerDishes)   
                Console.WriteLine(x);
            

            //Main dishes
            Console.WriteLine("\nMain dishes");
            string[] mainDishes = {"4. Risotto ai funghi", "5. Melanzane alla Parmigiana", "6. Bistecca alla Fiorentina"};
            List<string> mainDishesList = new List<string>(mainDishes);
            foreach (string x in mainDishes)
                Console.WriteLine(x);


            //Desserts
            Console.WriteLine("\nDesserts");
            string[] desserts = {"7. Tiramisu", "8. Gelato alla frutta"};
            List<string> dessertsList = new List<string>(desserts);
            foreach (string x in desserts)
                Console.WriteLine(x);


            //Drinks
            Console.WriteLine("\nDrinks");
            string[] drinks = {"9. Limoncello", "10. Disaronno", "11. Sambuca"};
            List<string> drinksList = new List<string>(drinks);
            foreach (string x in drinks)
                Console.WriteLine(x);
            {
                
            }
            

            //View dishes
            Console.Write("Enter the dishnumber you want to view: ");
            int dishNumber = Convert.ToInt32(Console.ReadLine());
            
            
            
        }
    
        
            
    }
}
