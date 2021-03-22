using System;
using System.IO;
using Newtonsoft.Json;


public class Program
{
    public static void Main()
    {
        
		var json = File.ReadAllText("details.json");
        dynamic stuff = JsonConvert.DeserializeObject(json);
        
            foreach (var s in stuff)
        {
            Console.WriteLine(s.Number + s.Name );
        }
        Console.WriteLine("\nPlease press the number of the dish you want to know more information about.");
        string Dish2 = Console.ReadLine();
		int dish = Int32.Parse(Dish2);





		if (dish == 1)
		{
			Console.WriteLine("sambai vinaigrette, sojaboontjes, sesam mayonaise, gepofte wilde rijst \n" +
				"€ 12,50");
		}
		else if (dish == 2)
		{
			Console.WriteLine("Hollands rund-truffel vinaigrette, oude kaas, rucola\n" +
				"12,50)");
		}
		else if (dish == 3)
		{
			Console.WriteLine("U get whatever u want!!!!!3");
		}
		else if (dish == 4)
		{
			Console.WriteLine("U get whatever u want!!!!!4");
		}
		else if (dish == 5)
		{
			Console.WriteLine("U get whatever u want!!!!!5");
		}
		else if (dish == 6)
		{
			Console.WriteLine("U get whatever u want!!!!!6");
		}
		else if (dish == 7)
		{
			Console.WriteLine("U get whatever u want!!!!!7");
		}
		else if (dish == 8)
		{
			Console.WriteLine("U get whatever u want!!!!!8");
		}
		else if (dish == 9)
		{
			Console.WriteLine("U get whatever u want!!!!!9");
		}
		else if (dish == 10)
		{
			Console.WriteLine("U get whatever u want!!!!!10");
		}
		else if (dish == 11)
		{
			Console.WriteLine("U get whatever u want!!!!!11");
		}
		else if (dish == 12)
		{
			Console.WriteLine("U get whatever u want!!!!!12");
		}
		else if (dish == 13)
		{
			Console.WriteLine("U get whatever u want!!!!!13");
		}
		else if (dish == 14)
		{
			Console.WriteLine("U get whatever u want!!!!!14");
		}
		else if (dish == 15)
		{
			Console.WriteLine("U get whatever u want!!!!!15");
		}
		else if (dish == 16)
		{
			Console.WriteLine("U get whatever u want!!!!!16");
		}
		else if (dish == 17)
		{
			Console.WriteLine("U get whatever u want!!!!!17");
		}
		else
		{
			Console.WriteLine("The is no such dish, please choose another dish!!!");
		}

	}
}