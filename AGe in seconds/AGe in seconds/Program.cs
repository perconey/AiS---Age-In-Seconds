using AGe_in_seconds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Age_in_seconds
{
    class Program
    {
        /// <summary>
        /// This simple algorythm calculates how many seconds havae you lived for
        ///. $p4
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var res = new Resources();

            while(true)
            {
                Console.WriteLine($"Enter your birth date (format: dd/mm/yyyy:");
                var cinput = Console.ReadLine();
                res.FieldSetConvert(cinput);

                Console.WriteLine($"\nYour age in seconds is equal to: {res.Seconds} seconds!");

            }

        }
    }
}
