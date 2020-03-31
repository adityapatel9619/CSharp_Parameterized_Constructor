using System;
using System.Collections.Generic;
using System.Text;

namespace Bike_Manufacturing_New
{
    class bike
    {
        static void Main(string[] args)
        {
            Program p = new Program("Royal Enfield","Grey","2016");
            Console.WriteLine("Bike Manufacturing Program");
            Console.WriteLine("Enter no of bikes to be manufactured:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"\nBike:{i}\nModel No:{p.Modelno}\nModel:{p.Model}\nColor:{p.Color}\nYear:{p.Year}");
            }
        }
    }
}
