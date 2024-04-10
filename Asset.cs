using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace Asset_Tracking_with_Entity_Framework
{
    internal class Asset
    {
        //Contains the data for an asset.
        //Methods let the user input the data and validates that the information is entered correctly when creating or updating an asset
        public int Id { get; set; }
        public string Type {  get; set; }
        public string Model { get; set; }
        public int OfficeId { get; set; }
        public Office Office { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int Price { get; set; }


        public DateTime ExpiryDate
        {
            get
            {
                return PurchaseDate.AddYears(3);
            }
        }

        public static string InputType()
        {
            int selection = OptionSelector.PickOption("\nWhich type of device is the asset?", ["Phone", "Computer"]);
            switch (selection)
            {
                case 1: return "Phone";
                case 2: return "Computer";
                default: return "";
            }
        }
        public static string InputModel()
        {
            Console.WriteLine("\nWhat model is the device?");
            while (true)
            {
                string input = Console.ReadLine();
                if (input == "")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You must enter a device model");
                    Console.ResetColor();
                }
                else
                {
                    return input;
                }
            }
        }

        public static int InputOffice()
        {
            int selection = OptionSelector.PickOption("\nWhich office does the device belong to?", ["Skövde", "Boston", "Paris"]);
            return selection;
        }

        public static int InputPrice()
        {
            Console.WriteLine("\nWhat was the price of the device in US Dollars?");
            int price;
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    price = int.Parse(input);
                    break;
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You did not enter a price correctly");
                    Console.ResetColor();
                }
            }
            return price;
        }

        public static DateTime InputDate()
        {
            Console.WriteLine("\nWhen was the device purchased?");
            DateTime date;
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    date = DateTime.Parse(input);
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You did not enter a date correctly");
                    Console.ResetColor();
                }
            }
            return date;
        }





    }
}
