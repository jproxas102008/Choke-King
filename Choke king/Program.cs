using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Globalization;

class FoodMenu
{
    static void Main()
    {
        int[] itemNumbers = { 1, 2, 3, 4, 5, 6 };

        string[] menuNames =
        {
            "Pork Chao Fan",
            "Beef Chao Fan",
            "Chinese-Style Chicken",
            "Pancit Canton",
            "Pork Siomai (4 pcs)",
            "Halo-Halo"
        };

        decimal[] menuPrices =
        {
            79.00m, 89.00m, 99.00m,
            89.00m, 55.00m, 79.00m
        };

        Console.WriteLine("==================================");
        Console.WriteLine("       CHOKE KING");
        Console.WriteLine("==================================");

        Console.WriteLine("{0,-10} {1,-20} {2,10}",
            "Item No.", "Food Name", "Price");

        for (int i = 0; i < menuNames.Length; i++)
        {
            Console.WriteLine("{0,-10} {1,-20} PHP {2,7:F2}",
                itemNumbers[i], menuNames[i], menuPrices[i]);
        }

        Console.WriteLine("----------------------------------");
    }
}