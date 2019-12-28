using System;
using System.IO;
using System.Linq.Expressions;

namespace OneToTen
{
    class Diamond
{
        public static void challenge()
        {
            Console.WriteLine("Specify the diameter of the diamond: ");
            string input = Console.ReadLine();
            int diameter;
            try
            {
                diameter = int.Parse(input);
                if (diameter < 0 || IsPar(diameter))
                { 
                    throw new Exception("The data provided is not valid");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
           

            

            var numberLines = (diameter - 1) / 2;
            // Upper side
            for (var currentLine = 0; currentLine <= numberLines; currentLine++)
            {
                // Number of spaces
                var spacerLength = numberLines - currentLine;
                var starLength = 1 + currentLine * 2;

                var spacerDisplay = new string(' ', spacerLength);
                var starDisplay = new string('*', starLength);

                Console.WriteLine(spacerDisplay + starDisplay);
            }

            // Down Side
            for (int currentLine = numberLines - 1; currentLine >= 0; currentLine--)
            {
                // Number of spaces
                int spacerLength = numberLines - currentLine;
                int starLength = 1 + (currentLine * 2);

                String spacerDisplay = new String(' ', spacerLength);
                String starDisplay = new string('*', starLength);

                Console.WriteLine(spacerDisplay + starDisplay);

            }
        }

        private static bool IsPar(in int diameter)
        {
            return diameter % 2 == 0;
        }
    }
}
