using System;
using System.Collections.Generic;

namespace PredicateDelegates
{
    internal class Program
    {
         static void Main(string[] args)
        {
            List<string> names = new List<string>();
            names.Add("Md Faysal");
            names.Add("Md Rahat");
            names.Add("Rashed Sarder");
            names.Add("Nahin Hossain");

            //Predicate<string> nameSearch = IsCheckName;
            Predicate<string> nameSearch = x => x.StartsWith("Md ");
            //var data = names.FindAll(nameSearch);
            var data = names.FindAll(x => x.StartsWith("Md "));
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }


        public static bool IsCheckName(string name)
        {
            if(name.StartsWith("Md "))
            {
                return true;
            }
            return false;
        }
    }
}
