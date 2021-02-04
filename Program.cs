using System;

namespace Electric_meter_reading
{
    class Program
    {
        static void Main(string[] args)
        {
           // int cmr, pmr;
            Console.WriteLine("Select Consumer type: \n 1.Domestic\n 2.Commercial");
            int ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    Console.WriteLine("Enter the Current Meter Reading(CMR):");
                    double cmr = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Previos Meter Reading(PMR):");
                    double pmr = double.Parse(Console.ReadLine());
                    double result = cmr - pmr;
                    if (result <= 200)
                    {
                        double bill = result * 5;
                        Console.WriteLine("The bill amount is {0}:" + Math.Round(bill, 2) + "/-");
                    }
                    else if (result > 200 && result <= 300)

                    {
                        double bill = result * 7.20;
                        Console.WriteLine("The bill amount is {0}:" + Math.Round(bill, 2) + "/-");
                    }
                    else if (result > 300 && result <= 400)
                    {
                        double bill = result * 8.50;
                        Console.WriteLine("The bill amount is {0}:" + Math.Round(bill, 2) + "/-");
                    }
                    else if (result > 400 && result <= 800)
                    {
                        double bill = result * 9;
                        Console.WriteLine("The bill amount is {0}:" + Math.Round(bill, 2) + "/-");
                    }
                    else
                    {
                        double bill = result * 9.50;
                        Console.WriteLine("The bill amount is {0}:" + Math.Round(bill, 2) + "/-");
                    }
                    break;
                case 2:
                    Console.WriteLine("Enter the Current Meter Reading(CMR):");
                    double cmr1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the Previos Meter Reading(PMR):");
                    double pmr1 = double.Parse(Console.ReadLine());
                    double result1 = cmr1 - pmr1;
                    if (result1 <= 100)
                    {
                        double bill = result1 * 7.50;
                        Console.WriteLine("The bill amount is {0}:" + Math.Round(bill, 2) + "/-");
                    }
                    else if (result1 > 100 && result1 <= 300)

                    {
                        double bill = result1 * 8.90;
                        Console.WriteLine("The bill amount is {0}:" + Math.Round(bill, 2) + "/-");
                    }
                    else if (result1 > 300 && result1 <= 500)
                    {
                        double bill = result1 * 9.40;
                        Console.WriteLine("The bill amount is {0}:" + Math.Round(bill, 2) + "/-");
                    }
                    else
                    {
                        double bill = result1 * 10;
                        Console.WriteLine("The bill amount is {0}:" + Math.Round(bill, 2) + "/-");
                    }
                    break;
                default:
                    Console.WriteLine("invalid input");
                    break;


            }
            Console.ReadLine();
        }
    }
}
