using System;

namespace InventoryDataManagement
{
    class Program
    {
        /// <summary>
    /// 
    /// UC2
    /// </summary>
    /// <param name="args"></param>



        static void Main(string[] args)
        {
            Console.WriteLine("Hello inventory management system");
            string path = "F:/InventoryDataManagement/Rice.json";

            FetchJsonForRice fetchJsonForRice = new FetchJsonForRice();
            Rice data = fetchJsonForRice.Read(path);

            for (int i = 0; i < data.typesofRice.Count; i++)
            {
                Console.WriteLine(data.typesofRice[i].name);
                Console.WriteLine(data.typesofRice[i].weight);
                Console.WriteLine(data.typesofRice[i].Price);
                int dataofrice = data.typesofRice[i].weight * data.typesofRice[i].Price;
                Console.WriteLine("Total Price: " + dataofrice);
                Console.WriteLine("---------***--------******--------");
            }

            for (int i = 0; i < data.typesofPulse.Count; i++)
            {
                Console.WriteLine(data.typesofPulse[i].name);
                Console.WriteLine(data.typesofPulse[i].weight);
                Console.WriteLine(data.typesofPulse[i].Price);
                int dataofpulse = data.typesofPulse[i].weight * data.typesofPulse[i].Price;
                Console.WriteLine("Total Price: " + dataofpulse);
                Console.WriteLine("---------***--------******--------");

            }

            for (int i = 0; i < data.typesofWheat.Count; i++)
            {
                Console.WriteLine(data.typesofWheat[i].name);
                Console.WriteLine(data.typesofWheat[i].weight);
                Console.WriteLine(data.typesofWheat[i].Price);
                int wheat = data.typesofWheat[0].weight * data.typesofWheat[i].Price;
                Console.WriteLine("Total Price: " + wheat);
                Console.WriteLine("---------***--------******--------");

            }

            //Console.WriteLine(data.name);
            //Console.WriteLine(data.);





        }
    }
}