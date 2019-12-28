using System;

namespace OneToTen
{
    class Strip
    {
        public static void challenge()
        {
            Console.Write("Write your string:");
            Console.WriteLine(remove(Console.ReadLine()));
        }
        private static string remove(string original)
        {
            if (original.Length <= 2) return null;
            return original.Substring(1, original.Length-2);
        }
    }
}
