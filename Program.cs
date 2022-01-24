using System;
using static System.Console;
using System.Collections.Generic;

namespace FindMaxNum
{
    class Program  // UC 5
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("\tFind max Number\n\nUC 1 : 3 Integers\n");
            WriteLine("Given Max Number at 1st Position return the Same Number : 33, 11, 22 ");
            WriteLine("Given Max Number at 2nd Position return the Same Number : 22, 33, 11 ");
            WriteLine("Given Max Number at 3rd Position return the Same Number : 22, 11, 33");
            WriteLine("");
            int output = MaximumNumberCheck.MaximumIntegerNumber(33, 11, 22);
            Console.WriteLine(output);
            int output2 = MaximumNumberCheck.MaximumIntegerNumber(22, 33, 11);
            Console.WriteLine(output2);
            int output3 = MaximumNumberCheck.MaximumIntegerNumber3(22, 11, 33);
            Console.WriteLine(output3);
            ReadKey();

            WriteLine("\n========================================================================" + "\n\n\tUC 2 : 3 Floats\n" + "\nGiven Max Number at 1st Position return the Same Floats Number : 111.2, 22.45, 78.56");
            WriteLine("Given Max Number at 2nd Position return the Same Floats Number : 22.45, 111.2, 78.56");
            WriteLine("Given Max Number at 3rd Position return the Same Floats Number : 78.56, 22.45, 111.2");
            WriteLine("");
            double doubleoutput = MaximumNumberCheck.MaximumFloatNumber(111.2, 22.45, 78.56);
            Console.WriteLine(doubleoutput);
            double doubleoutput2 = MaximumNumberCheck.MaximumFloatNumber2(22.45, 111.2, 78.56);
            Console.WriteLine(doubleoutput2);
            double doubleoutput3 = MaximumNumberCheck.MaximumFloatNumber3(78.56, 22.45, 111.2);
            Console.WriteLine(doubleoutput3);
            ReadKey();


            WriteLine("\n========================================================================" + "\n\n\tUC 3 : 3 Strings\n" + "\nGiven Max Number at 1st Position return the Same Strings Number : |''33''|,|''22''|,|''11''|");
            WriteLine("Given Max Number at 2nd Position return the Same Strings Number : |''11''|,|''33''|,|''22''|");
            WriteLine("Given Max Number at 3rd Position return the Same Strings Number : |''22''|,|''11''|,|''33''|");
            WriteLine("");
            string strigoutput = MaximumNumberCheck.MaximumStringNumber("33", "22", "11");
            Console.WriteLine(strigoutput);
            string strigoutput2 = MaximumNumberCheck.MaximumStringNumber2("11", "33", "22");
            Console.WriteLine(strigoutput2);
            string strigoutput3 = MaximumNumberCheck.MaximumStringNumber3("22", "11", "33" + "\n========================================================================");
            Console.WriteLine(strigoutput3);
            ReadKey();

            WriteLine("\n\n\tUC 3 : 3 Strings Char" + "\t E.g. Apple Peach Banana");
            WriteLine("\nGiven Max Char at 1st Position return the Same Strings Char : |''Peach''|,|''Apple''|,|''Banana''|");
            WriteLine("Given Max Char at 2nd Position return the Same Strings Char : |''Banana''|,|''Peach''|,|''Apple''|");
            WriteLine("Given Max Char at 3rd Position return the Same Strings Char : |''Banana''|,|''Apple''|,|''Peach''|");
            WriteLine("");
            string strigoutputS = MaximumNumberCheck.MaximumStringNumber("Peach", "Apple", "Banana");
            Console.WriteLine(strigoutputS);
            string strigoutputS2 = MaximumNumberCheck.MaximumStringNumber2("Banana", "Peach", "Apple");
            Console.WriteLine(strigoutputS2);
            string strigoutputS3 = MaximumNumberCheck.MaximumStringNumber3("Banana", "Apple", "Peach");
            Console.WriteLine(strigoutputS3);
            ReadKey();

            Console.WriteLine("\n========================================================================" + "\n\n\tRefactor (Interger, Float, String, Char) to One Method\n");

            WriteLine("Given Max Number Integer : 33, 11, 22 ");
            WriteLine("\nGiven Max Number Floats : 111.2, 22.45, 78.56");
            WriteLine("\nGiven Max Number Strings Number : |''22''|,|''33''|,|''44''|");
            WriteLine("\nGiven Max Char Strings Char : |''Apple''|,|''Peach''|,|''Banana''|\n");


            int op = MaximumNumberCheck.MaximumIntegerNumber4(11, 22, 33);
            Console.WriteLine(op);
            double doubleop = MaximumNumberCheck.MaximumFloatNumber4(111.2, 22.45, 78.56);
            Console.WriteLine(doubleop);
            string strigop = MaximumNumberCheck.MaximumStringNumber4("22", "33", "44");
            Console.WriteLine(strigop);
            string strigotp = MaximumNumberCheck.MaximumStringNumber4("Apple", "Peach", "Banana");
            Console.WriteLine(strigotp);
            ReadLine();


            WriteLine("\n========================================================================" + "\n\n\tUC 4 : take more then three parameters \n\nGiven Max Number Integer to take more then three parameters : 112, 344, 432, 555, 678 ");
            WriteLine("\nGiven Max Number Floats to take more then three parameters : : 11.2, 34.4, 4.32, 55.5, 6.78 ");
            WriteLine("\nGiven Max Number Strings Number to take more then three parameters : |''111''|,|''222''|,|''333''|''55''|''999''|");
            WriteLine("\nGiven Max Char Strings Char to take more then three parameters : 'A'P'P'L'E\n");

            int[] intArray = { 112, 344, 432, 555, 678 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 11.2, 34.4, 4.32, 55.5, 6.78 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "111", "222", "333", "55", "999" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            //          GenericMaximum<Employee> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            char[] charArray = { 'A', 'P', 'P', 'l', 'e' };
            GenericMaximum<char> genericChar = new GenericMaximum<char>(charArray);
            genericChar.PrintMaxValue();
            WriteLine("\n");
            Console.ReadKey();
            WriteLine("\n========================================================================");
            WriteLine("\n\t\tUC 5 : Print Max using Generic Method \n");
            WriteLine("\n\t Method 1 : Same Output as Method 2 [ using Generic Method ] \n");
            WriteLine("" +
            "Program.toPrint<int>(intArray)\n" +
            "Program.toPrint<double>(doubleArray)\n" +
            "Program.toPrint<string>(stringArray)\n" +
            "Program.toPrint<char>(charArray)\n" + ""
            );

            Program.toPrint<int>(intArray);
            Program.toPrint<double>(doubleArray);
            Program.toPrint<string>(stringArray);
            Program.toPrint<char>(charArray);
            ReadKey();

            WriteLine("\n\t Method 2 : Same Output as Method 1 \n");
            WriteLine("" +

            "Program.toPrint(intArray)\n" +
            "Program.toPrint(doubleArray)\n" +
            "Program.toPrint(stringArray)\n" +
            "Program.toPrint(charArray)\n" + ""
            );
            Program.toPrint(intArray);
            Program.toPrint(doubleArray);
            Program.toPrint(stringArray);
            Program.toPrint(charArray);

            ReadKey();
            ReadLine();
        }
        public static void toPrint<T>(T[] inputArray)
        {
            foreach (var element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------");
        }

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


        public static void toPrint(string[] inputArray)
        {
            foreach (string element in inputArray)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("-------------------------------------");
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