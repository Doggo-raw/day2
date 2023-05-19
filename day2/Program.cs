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
                    Console.WriteLine("First section - If...else/switch" + "\n" + "Choose task (1-5)");
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("First task" + "\n" + "Write a number: ");
                            double firstTaskNumber = Convert.ToDouble(Console.ReadLine());
                                if (firstTaskNumber > 0)
                                {
                                    double plusResult = firstTaskNumber + 5;
                                    Console.WriteLine(plusResult);
                                }
                                else 
                                {
                                    double minusResult = firstTaskNumber - 5;
                                    Console.WriteLine(minusResult);
                                }
                                break;

                        case "2":
                            Console.WriteLine("Second task" + "\n" + "Write three numbers:");
                                double secondTaskFirst = Convert.ToDouble(Console.ReadLine());
                                double secondTaskSecond = Convert.ToDouble(Console.ReadLine());
                                double secondTaskThird = Convert.ToDouble(Console.ReadLine());

                                    if (secondTaskFirst > secondTaskSecond)
                                    {
                                        if (secondTaskFirst > secondTaskThird)
                                        {
                                            Console.WriteLine(secondTaskFirst);
                                        }
                                    }
                                    else if (secondTaskSecond > secondTaskFirst)
                                    {
                                        if (secondTaskSecond > secondTaskThird)
                                        {
                                            Console.WriteLine(secondTaskSecond);
                                        }
                                    }
                                    else if (secondTaskThird > secondTaskFirst)
                                    {
                                        if (secondTaskThird > secondTaskSecond)
                                        {
                                            Console.WriteLine(secondTaskThird);
                                        }
                                    }
                                    break;

                        case "3":
                            Console.WriteLine("Third task" + "\n" + "Write three positive numbers: ");
                                double thirdTaskFirst = Convert.ToDouble(Console.ReadLine());
                                double thirdTaskSecond = Convert.ToDouble(Console.ReadLine());
                                double thirdTaskThird = Convert.ToDouble(Console.ReadLine());
                                double thirdTaskSum = 0;

                                    if (thirdTaskFirst > 0)
                                    {
                                        thirdTaskSum += thirdTaskFirst;
                                    }
                                    if (thirdTaskSecond > 0)
                                    {
                                        thirdTaskSum += thirdTaskSecond;
                                    }
                                    if (thirdTaskThird > 0)
                                    {
                                        thirdTaskSum += thirdTaskThird;
                                    }
                                    Console.WriteLine(thirdTaskSum);

                                    break;

                        case "4":
                            Console.WriteLine("Fourth task" + "\n"  + "Write an X:");
                                double thirdTaskX = Convert.ToDouble(Console.ReadLine());

                                    if (thirdTaskX > 10)
                                    {
                                        thirdTaskX *= 2;
                                        Console.WriteLine(thirdTaskX);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Result isn't update, cuz X < 10" + "\n" + thirdTaskX);
                                    }
                                    break;

                        case "5":
                            Console.WriteLine("Fifth task" + "\n" + "Choose day (1-7)");
                                int thirdTaskDay = Convert.ToInt32(Console.ReadLine());

                                    switch (thirdTaskDay)
                                    {
                                        case 1:
                                            Console.WriteLine("Monday");
                                        break;
                                        case 2:
                                            Console.WriteLine("Tuesday");
                                        break;
                                        case 3:
                                            Console.WriteLine("Wednesday");
                                        break;
                                        case 4:
                                            Console.WriteLine("Thursday");
                                        break;
                                        case 5:
                                            Console.WriteLine("Friday");
                                        break;
                                        case 6:
                                            Console.WriteLine("Saturday");
                                        break;
                                        case 7:
                                            Console.WriteLine("Sunday");
                                        break;
                                    }
                                    break;
                    }

                    break;

                case "2":
                    Console.WriteLine("Second section - Циклы");

                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.WriteLine("First task" + "\n" + "min number/17");

                                int splitted = 201;
                                    while (splitted % 17 != 0)
                                    {
                                        splitted++;
                                    }
                            Console.WriteLine(splitted);
                            break;

                        case "2":
                            Console.WriteLine("Second task" + "\n" + "runner");
                                int secondTaskDay = 1;
                                double distance = 10;

                                    while (distance < 20)
                                    {
                                        distance *= 1.05;
                                        secondTaskDay++;
                                    }
                                    Console.WriteLine("20km on: " + secondTaskDay + " day");
                                    while (distance < 100)
                                    {
                                        distance *= 1.05;
                                        secondTaskDay++;
                                    }
                            Console.WriteLine("100km on: " + secondTaskDay + " day");
                            break;

                        case "3":
                            Console.WriteLine("Third task" + "\n" + "Write number what's you want:");
                                double userNumber = Convert.ToDouble(Console.ReadLine());
                                double factorial = 1;

                                    for (int i = 1; i <= userNumber; i++)
                                    {
                                        factorial *= i;
                                    }
                                     Console.WriteLine("Factorial " + userNumber + " is: " + factorial);
                           
                            break;

                        case "4":
                            Console.WriteLine("Fourth task" + "\n" + "min splitter > 1");
                            int fourthTaskSplitter = Convert.ToInt32(Console.ReadLine());

                            for (int i = 2; i <= fourthTaskSplitter; i++)
                            {
                                if (fourthTaskSplitter % i == 0)
                                {
                                    Console.WriteLine("Наименьший делитель " + fourthTaskSplitter + " is: " + i);
                                    break;
                                }
                            }

                            break;
                    }

                    break;

            }




            Console.ReadKey();
            
        }
    }
}
