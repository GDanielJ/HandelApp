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
            // Welcome menu
            Console.WriteLine("****** Welcome to the Item store! ******");
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
            }
        }
    }
}
