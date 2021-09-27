using System;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 2, 3, 4, 5 };
            double[] doubleArray = { 1.1, 2.2, 3.3, 4.4 };
            char[] charArray = { 'H', 'E', 'L', 'L', 'O' };
            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(charArray);

            //////Program.toPrint<int>(intArray);
            //////    Program.toPrint<double>(doubleArray);
            //////    Program.toPrint<char>(charArray);
            //////    Console.ReadKey();
        }
            //Using generics for printing elements of array of different data types
            //public static void toPrint<T>(T[] inputArray)
            //{
            //    foreach (var element in inputArray)
            //    {
            //        Console.WriteLine(element);
            //    }
            //    Console.WriteLine("----------------------------------");
            //}

            public static void toPrint(int[] inputArray)
            {
                foreach (double element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("----------------------------------");
            }

            public static void toPrint(double[] inputArray)
            {
                foreach (double element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("----------------------------------");
            }

            public static void toPrint(char[] inputArray)
            {
                foreach (char element in inputArray)
                {
                    Console.WriteLine(element);
                }
                Console.WriteLine("-------------------------------------");
            }
        }

    }

