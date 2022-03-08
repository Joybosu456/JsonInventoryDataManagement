using StockAccountManagement;
using System;

namespace InventoryDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "F:/InventoryDataManagement/Stock.json";

            FetchJasonForStock fetchJsonForStock = new FetchJasonForStock();
            Stock data = fetchJsonForStock.Read(path);

            for (int i = 0; i < data.allGroup.Count; i++)
            {
                Console.WriteLine(data.allGroup[i].Stockname);
                Console.WriteLine( " " + data.allGroup[i].Shares);
                Console.WriteLine(" " + data.allGroup[i].Price);
                int dataofstock = data.allGroup[i].Shares * data.allGroup[i].Price;
                Console.WriteLine("Total Price: " + dataofstock);
                Console.WriteLine("---------***--------******--------");
            }

            for (int i = 0; i < data.telecomGroup.Count; i++)
            {
                Console.WriteLine(data.telecomGroup[i].Stockname);
                Console.WriteLine(" Number of stock: " + data.telecomGroup[i].Shares);
                Console.WriteLine("Buying Price: " + data.telecomGroup[i].Price);
                int dataofshare = data.telecomGroup[i].Shares * data.telecomGroup[i].Price;
                Console.WriteLine("Total Price: " + dataofshare);
                Console.WriteLine("---------***--------******--------");

            }

            for (int i = 0; i < data.technoIndiaBirlaGroup.Count; i++)
            {
                Console.WriteLine(data.technoIndiaGroup[i].Stockname);
                Console.WriteLine(" Number of Shares buyed: " + data.technoIndiaGroup[i].Shares);
                Console.WriteLine("Buying Price: " + data.technoIndiaGroup[i].Price);
                int dataofbirla = data.technoIndiaGroup[0].Shares * data.technoIndiaGroup[i].Price;
                Console.WriteLine("Total Price: " + dataofbirla);
                Console.WriteLine("---------***--------******--------");

            }

        }
    }
}