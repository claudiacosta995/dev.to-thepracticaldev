using System;
using System.Collections.Generic;
using System.Text;
//4 - OneToTen.CheckbookBalancing.challenge();
namespace OneToTen
{
    class CheckbookBalancing 
    { 
        public static void challenge()
        {
            string input = "1000,00\n125 Market   125.45\n126 Hardware 34.95\n127 Video 7.45\n128 Book 14.32\n129 Gasoline 16.10";
            Console.Write(Balancing(input));
        }

        private static string Balancing(string original)
        {

            original = clean(original);

            string [] lines = original.Split('\n') ;
            string output = "Original_Balance: " + String.Format("{0:0.00}", lines[0]).Replace(',', '.') + '\n';
            double iniMoney = double.Parse(lines[0]);
            double currMoney = iniMoney;
            for (int numLine = 1; numLine < lines.Length; numLine++)
            {
                currMoney = currMoney - Double.Parse(lines[numLine].Split(' ')[2]);
                output += lines[numLine] + " Balance " + String.Format("{0:0.00}", currMoney).Replace(',', '.') + "\n";
            }
            output += "Total expense " + String.Format("{0:0.00}", iniMoney - currMoney).Replace(',', '.') + "\nAverage expense " +
                String.Format("{0:0.00}", (iniMoney - currMoney) / (lines.Length - 1)).Replace(',', '.');

            return output;
        }

        private static string clean(string original)
        {
            //do the regex to extract clean text
                                  

            return original.Replace('.', ','); ;
        }
    }
}
