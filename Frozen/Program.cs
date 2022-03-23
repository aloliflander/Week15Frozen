using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    class Program
    {
        class Frozen
        {
            string name;
            string presents;

            public Frozen(string _name, string _presents)
            {
                name = _name;
                presents = _presents;
            }
            public string Name
            {
                get { return name; }
            }
            public string Presents
            {
                get { return presents; }
            }
        }
        static void Main(string[] args)
        {
            List<Frozen> MyFrozen = new List<Frozen>();
            string[] presentsFromFile = GetDataFromFile();
            foreach (string line in presentsFromFile)
            {

                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                Frozen newPresents = new Frozen(tempArray[0], tempArray[1]);
                MyFrozen.Add(newPresents);
            }
            foreach (Frozen presentFromList in MyFrozen)
            {
                Console.WriteLine($"{presentFromList.Name} wants {presentFromList.Presents} for Christmas!");
            }
        }
        public static void DisplayElementFromArray(string[] somearray)
        {
            foreach (string element in somearray)
            {
                Console.WriteLine($"String from array:{element}");
            }
        }
        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\Alo\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);
            return dataFromFile;
        }
    }
}
