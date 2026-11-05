using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace AdirEf11th
{
    public class ListAndDict
    {
        public static void ListsAndDictionaries_UT()
        {
            //T1();
            //InsertExecution();
            Dictionary1();
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
            Dictionary<string, long> countries = new Dictionary<string, long>
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
                    //TODO
                }
                else if (option == 3)
                {
                    //TODO
                }
            }
        }
    }
}
