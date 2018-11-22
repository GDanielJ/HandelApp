using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandelU
{
    class Program
    {
        static void Main(string[] args)
        {
            // For test: dictionary with items. -- Ersätt lämpligen med class. Lagra värden fysiskt och hämta upp och visa i UI istället
            Dictionary<int, string> dItems = new Dictionary<int, string>();
            dItems.Add(1, "Shoes");
            dItems.Add(2, "Pants");
            dItems.Add(3, "Jacket");
            dItems.Add(4, "Shirt");
            dItems.Add(5, "Socks");

            // Welcome menu
            Console.WriteLine("****** Welcome to the Item store! ******");

            // Instructions -- This could be a metod called by typing "help"
            Console.WriteLine("\n- To list available items, press \"i\"");
            Console.WriteLine("- To buy, write the number of the item you want");
            Console.WriteLine("- To exit the store, press \"q\"\n");

            // Promt user for input
            while (true)
            {
                string uInput = Console.ReadLine();

                // Exit programme
                if (uInput.ToLower() == "q")
                {
                    break;
                }

                // Print items in the store
                if (uInput.ToLower() == "i")
                {
                    foreach (KeyValuePair<int, string> pair in dItems)
                    {
                        Console.WriteLine("{0}. {1}", pair.Key, pair.Value);
                    }
                }

                // Buy item -- Detta borde vara en metod
                int numValue;
                Int32.TryParse(uInput, out numValue);

                if (dItems.ContainsKey(numValue))
                {
                    string value = dItems[numValue];
                    Console.WriteLine(value);
                }
            }
        }
    }
}
