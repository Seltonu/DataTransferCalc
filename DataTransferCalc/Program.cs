using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            ConvertDown cdown = new ConvertDown();

            Console.WriteLine("\t\t\t\t\\\\\\\\\\ Data-Transfer Time Calculator v1.0 /////");
            Console.WriteLine("Type help for help.\n");
            Console.Write("Amount of Data: ");
            string input = Console.ReadLine();
            string numbersAsString = cdown.retrieveNumbers(input);
            string typeOfFile = cdown.findType(input);

            if ((input.ToLower()) == "help")
            {
                Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
                Console.WriteLine("Utilizing the Data-Transfer program is easy. Just type in a number and corresponding file type when prompted.");
                Console.WriteLine("\nSupported File types are: \nKb \tKB \nMb \tMB \nGb \tGB \nTb \tTB\n");
                Console.WriteLine("If your results seem off, you may be using the wrong capitalization in your file type.");
                Console.WriteLine("Lowercase 'b' is bits, uppercase 'B' is bytes.");
                Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            }   

            while (numbersAsString == "" || typeOfFile == "")
            {
                Console.WriteLine("Please enter a valid file size and type.");
                input = Console.ReadLine();
                numbersAsString = cdown.retrieveNumbers(input);
                typeOfFile = cdown.findType(input);
            }
            double fileSizeInBytes = cdown.ConvertToBytes(numbersAsString, typeOfFile);




            Console.Write("Transfer Speed (per second): ");
            input = Console.ReadLine();

            numbersAsString = cdown.retrieveNumbers(input); //these variables were declared above. We're re-using them to avoid creating new ones.
            typeOfFile = cdown.findType(input);

            if ((input.ToLower()) == "help")
            {
                Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
                Console.WriteLine("Utilizing the Data-Transfer program is easy. Just type in a number and corresponding file type when prompted.");
                Console.WriteLine("Supported File types are: Kb, KB, Mb, MB, Gb, GB, Tb, TB");
                Console.WriteLine("If your results seem off, you may be using the wrong capitalization in your file type.");
                Console.WriteLine("Lowercase 'b' is bits, uppercase 'B' is bytes. Both lower, we assume bytes.");
                Console.WriteLine("\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\");
            }

            while (numbersAsString == "" || typeOfFile == "")
            {
                Console.WriteLine("Please enter a valid file size and type.");
                input = Console.ReadLine();
                numbersAsString = cdown.retrieveNumbers(input);
                typeOfFile = cdown.findType(input);
            }
            double transferSpeedInBytes = cdown.ConvertToBytes(numbersAsString, typeOfFile);


            

            int timeInSeconds = Convert.ToInt32(fileSizeInBytes / transferSpeedInBytes);

            if (timeInSeconds > 0)
            {
                int hours = 0;
                int minutes = timeInSeconds / 60;
                int seconds = timeInSeconds % 60;

                if (minutes >= 60)
                {
                    hours = minutes / 60;
                    minutes = minutes % 60;
                }

                if (hours >= 1)
                {
                    Console.WriteLine("\n.....Will take " + Convert.ToString(hours) + " hours " + Convert.ToString(minutes) + " minutes and " + Convert.ToString(seconds) + " seconds.");
                }
                else if (minutes >= 1)
                {
                    Console.WriteLine("\n.....Will take " + Convert.ToString(minutes) + " minutes and " + Convert.ToString(seconds) + " seconds.");
                }
                else
                {
                    Console.WriteLine("\n.....Will take " + Convert.ToString(seconds) + " seconds.");
                }
            }
            else
            {
                Console.WriteLine("\n.....It would take less than a second.");
            }
            Console.ReadLine();
        }
    }
}
