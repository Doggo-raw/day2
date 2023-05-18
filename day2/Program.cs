using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select section (1/2)");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("First section - If...else/switch");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("First");
                            break;

                        case "2":
                            Console.WriteLine("second");
                            break;

                        case "3":
                            Console.WriteLine("Third");
                            break;

                        case "4":
                            Console.WriteLine("Fourth");
                            break;

                        case "5":
                            Console.WriteLine("Fifth");
                            break;
                    }

                    break;

                case "2":
                    Console.WriteLine("Second section - Циклы");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("First");
                            break;

                        case "2":
                            Console.WriteLine("second");
                            break;

                        case "3":
                            Console.WriteLine("Third");
                            break;

                        case "4":
                            Console.WriteLine("Fourth");
                            break;
                    }

                    break;

            }




            Console.ReadKey();
            
        }
    }
}
