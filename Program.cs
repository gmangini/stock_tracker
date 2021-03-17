// Project Prolog
// Name: Gino Mangini
// CS3260 Section X01
// Project: Lab_06
// Date: 03/05/2021 09:44:44 PM
// Purpose: Tracks historical data for a stock and calculates if it trends up or down.
//
// I declare that the following code was written by me or provided
// by the instructor for this project. I understand that copying source
// code from any other source constitutes plagiarism, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.IO;

namespace Stock_Tracker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter absolute path of file: ");
            var path = Console.ReadLine().Trim();
            //var path = args[0]; /if entered from command line. 

            try
            {

                using (StreamReader sr = new StreamReader(path))
                {
                    List<string[]> stockDates = new List<string[]>();

                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        var values = line.Split(',');

                        stockDates.Add(values);
                    }

                    string[][] stockArr = stockDates.ToArray(); 
                    
                    for (int i = 1; i < stockArr.Length - 2; i++)
                    {
                        IAsset current = new Stock(stockDates[i]);
                        IAsset previous = new Stock(stockDates[i+1]);
                        Calculate c = new Calculate();
                        
                        if (c.reversalDown(current, previous))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"Reversed down on {current.getDate()} 12:00:00 AM");
                        }

                        if (c.reversalUp(current, previous))
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Reversed up on {current.getDate()} 12:00:00 AM");
                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine("The file could not be read.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
