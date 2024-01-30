using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atkartojums_1_MGr_ITIA3
{
    internal class Program
    {
        static void Main()
        {

            Random rand = new Random();
            int skaitlis = rand.Next(1, 101);

            Console.WriteLine(skaitlis);    

        Start:

            Console.WriteLine("Ievadi skaitli: ");
            int skaitlis2 = int.Parse(Console.ReadLine());

            if (skaitlis2 < skaitlis)
            {
                Console.WriteLine("Lielāks");
                goto Start;
            }
            else if (skaitlis2 > skaitlis)
            {
                Console.WriteLine("Mazāks");
                goto Start;
            }
            else 
            {
                Console.WriteLine("Skaitlis ir uzminēts!");  
            }           
        }
    }
}
