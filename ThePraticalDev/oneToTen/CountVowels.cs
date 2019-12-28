using System;
using System.Collections.Generic;
using System.Text;

namespace OneToTen

{
    class CountVowels
    {
        public static void challenge()
        {
            Console.Write("Write your string:");
            Console.WriteLine(count(Console.ReadLine()));
        }
        private static long count(string original)
        {
             long time = original.Length - original.ToLower().Replace("a", String.Empty).Replace("e", String.Empty).Replace("i", String.Empty).Replace("o", String.Empty).Replace("u", String.Empty).Length;
            
            return time;
        }
    }
}
