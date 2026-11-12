using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using System.Transactions;

namespace AdirEf11th
{
    public class ListAndDict
    {
        public static async Task ListsAndDictionaries_UT()
        {
            //T1();
            //InsertExecution();

            //Dictionary1();
            //DictionaryMenu();

            //TryCatch();
            //TryCatchGradeAverage();

            //LongProcess();
            //ShortProcess();

            //The program adds every number between 0-99999, 100000 times, then prints the number.
            //Then prints every digit, which took less than a second.

            //Output:
            //Long Process Started
            //677203456
            //Long Process Completed
            //Short Process Started
            //0123456789
            //Short Process Completed

            //Task.Run(LongProcess2);
            //Task.Run(ShortProcess2);
            //Console.ReadKey();

            //Output:
            //Long Process Started
            //Short Process Started
            //0123456789
            //Short Process Completed
            //1066784512
            //Long Process Completed

            //The program does the same thing as the last one, but runs both functions at the same time.
            //Also the LongProcess function adds number between 0-49999 instead of 0-99999.
            //The ShortProcess function took less than a second to run.

            //Task.Run(PrintRed);
            //Task.Run(PrintGreen);
            //Console.ReadKey();
            //PrintColor(ConsoleColor.DarkMagenta);
            //Task.Run(() => PrintColor(ConsoleColor.Cyan));
            //Task.Run(() => PrintColor(ConsoleColor.Yellow));
            //Console.ReadKey();

            //Task.Run(() => PrintColor2(ConsoleColor.DarkBlue, 30));
            //Task.Run(() => PrintColor2(ConsoleColor.DarkRed, 35));
            //Console.ReadKey();

            //int x = await Task.Run(() => LongProcess3(1000));
            //Console.WriteLine(x);
        }

        public static void T1()
        {
            ArrayList arr1 = new ArrayList();
            arr1.Add(18);
            arr1.Add("Tal");
            arr1.Add(" ");
            arr1.Add(true);
            arr1.Add(3.14);
            arr1.Add(null);

            ArrayList arr2 = new ArrayList()
            {
                2, "Gal", " ", true, 9.8, null
            };

            List<int> arr3 = new List<int>();
            arr3.Add(1);
            arr3.Add(3);
            arr3.Add(5);

            List<string> arr4 = new List<string>();
            arr4.Add("New York");
            arr4.Add("London");
            arr4.Add("Tel Aviv");

            List<string> arr5 = new List<string>()
            {
                "New York",
                "London",
                "Tel Aviv"
            };

            for (int i = 0; i < arr1.Count; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            foreach (var item in arr2)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < arr2.Count; i++)
            //{
            //    Console.WriteLine(arr2[i]);
            //}
            for (int i = 0; i < arr3.Count; i++)
            {
                Console.WriteLine(arr3[i]);
            }
            for (int i = 0; i < arr4.Count; i++)
            {
                Console.WriteLine(arr4[i]);
            }
            foreach (string item in arr5)
            {
                Console.WriteLine(item);
            }
            //for (int i = 0; i < arr5.Count; i++)
            //{
            //    Console.WriteLine(arr5[i]);
            //}
        }

        public static void InsertExecution()
        {
            List<int> lst = new List<int>() { 5, 17, 12 };
            Console.WriteLine("Before Insert:");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }
            lst.Insert(2, 26);
            Console.WriteLine("After Insert(2, 26):");
            for (int i = 0; i < lst.Count; i++)
            {
                Console.WriteLine(lst[i]);
            }
        }

        public static void Dictionary1()
        {
            Dictionary<int, int> likeArray = new Dictionary<int, int>();
            for (int i = 0; i < 100; i++)
            {
                likeArray[i] = i + 100;
            }
            foreach (var item in likeArray)
            {
                Console.WriteLine(item);
            }
        }

        public static void DictionaryMenu()
        {
            Dictionary<string, int> countries = new Dictionary<string, int>
            {
                {"United States", 331002651},
                {"China", 1439323776},
                {"India", 1380004385},
                {"Brazil", 212559417},
                {"Russia", 145934462},
                {"Japan", 126476461},
                {"Mexico", 128932753},
                {"Philippines", 109581078},
                {"Egypt", 102334404},
                {"Vietnam", 97338579},
                {"Germany", 83783942},
                {"Turkey", 84339067},
                {"United Kingdom", 67886011},
                {"France", 65273511},
                {"Italy", 60461826},
                {"South Africa", 59308690},
                {"South Korea", 51269185},
                {"Canada", 37742154},
                {"Australia", 25499884},
                {"Argentina", 45195774}
            };

            string countryName = "";
            bool countryFound = false;
            int countryPop = 0;

            int option = 0;
            Console.WriteLine("1 - Search country population");
            Console.WriteLine("2 - Update population in a country");
            Console.WriteLine("3 - Add new country");
            Console.WriteLine("4 - Exit");
            Console.Write("Choose option: ");
            option = int.Parse(Console.ReadLine());
            while (option != 4)
            {
                if (option == 1)
                {
                    Console.Write("Enter country name: ");
                    countryName = Console.ReadLine();
                    countryFound = false;
                    foreach (var item in countries)
                    {
                        if (item.Key == countryName)
                        {
                            countryFound = true;
                            Console.WriteLine($"{countryName}'s population: {item.Value}");
                        }
                    }
                    if (!countryFound)
                    {
                        Console.WriteLine("Country not found.");
                    }
                }
                else if (option == 2)
                {
                    Console.Write("Enter country name: ");
                    countryName = Console.ReadLine();
                    countryFound = false;
                    foreach (var item in countries)
                    {
                        if (item.Key == countryName)
                        {
                            countryFound = true;
                        }
                    }
                    if (countryFound)
                    {
                        Console.Write("Enter the updated population: ");
                        countryPop = int.Parse(Console.ReadLine());
                        countries[countryName] = countryPop;
                    }
                    else
                    {
                        Console.WriteLine("Country not found.");
                    }
                }
                else if (option == 3)
                {
                    Console.Write("Enter country name: ");
                    countryName = Console.ReadLine();
                    countryFound = false;
                    foreach (var item in countries)
                    {
                        if (item.Key == countryName)
                        {
                            countryFound = true;
                        }
                    }
                    if (!countryFound)
                    {
                        Console.Write("Enter the new country's population: ");
                        countryPop = int.Parse(Console.ReadLine());
                        countries[countryName] = countryPop;
                    }
                    else
                    {
                        Console.WriteLine("Country already exists in the dictionary.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid option, try again.");
                }
                Console.WriteLine("1 - Search country population");
                Console.WriteLine("2 - Update population in a country");
                Console.WriteLine("3 - Add new country");
                Console.WriteLine("4 - Exit");
                Console.Write("Choose option: ");
                option = int.Parse(Console.ReadLine());
            }
        }

        public static void TryCatch()
        {
            Console.WriteLine("Please enter your age:");
            string input = Console.ReadLine();

            try
            {
                int age = int.Parse(input);
                Console.WriteLine($"Your age is: {age}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: You entered an input that is not a valid number.");
                Console.WriteLine("The program will continue without crashing.");
            }

            Console.WriteLine("End of program.");
        }

        public static void TryCatchGradeAverage()
        {
            int grade1 = 0, grade2 = 0;
            double average;

            Console.Write("Enter grade 1: ");
            try
            {
                grade1 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't enter a whole number.");
            }
            Console.Write("Enter grade 2: ");
            try
            {
                grade2 = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("You didn't enter a whole number.");
            }

            average = (grade1 + grade2) / 2;
            Console.WriteLine($"The average of both grades is {average}");
        }

        public static void LongProcess()
        {
            Console.WriteLine("Long Process Started");
            int x = 0;
            for (int i = 0; i < 100000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    x = x + i;
                }
            }
            Console.WriteLine(x);
            Console.WriteLine("Long Process Completed");
        }
        public static void ShortProcess()
        {
            Console.WriteLine("Short Process Started");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("Short Process Completed");
        }
        public static void LongProcess2()
        {
            Console.WriteLine("Long Process Started");
            int x = 0;
            for (int i = 0; i < 50000; i++)
            {
                for (int j = 0; j < 100000; j++)
                {
                    x = x + i;
                }
            }
            Console.WriteLine(x);
            Console.WriteLine("Long Process Completed");
        }
        public static void ShortProcess2()
        {
            Console.WriteLine("Short Process Started");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(i);
            }
            Console.WriteLine();
            Console.WriteLine("Short Process Completed");
        }

        public static void PrintRed()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(i + " ");
            }
        }
        public static void PrintGreen()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(i + " ");
            }
        }
        public static void PrintColor(ConsoleColor color)
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.ForegroundColor = color;
                Console.Write(i + " ");
            }
        }
        public static void PrintColor2(ConsoleColor color, int num)
        {
            for (int i = 1; i <= num; i++)
            {
                Console.ForegroundColor = color;
                Console.Write(i + " ");
            }
        }
        public static int LongProcess3(int num)
        {
            Console.WriteLine("Long Process Started");
            int x = 0;
            for (int i = 0; i < num; i++)
            {
                for (int j = 0; j < num; j++)
                {
                    x = x + i;
                }
            }
            Console.WriteLine(x);
            return x;
        }
    }
}