using ProblematicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicProblemLevel2.Interaction
{
    public static class ConsoleLogging
    {
        public static void PassMessage(string message, StatusCode? statusCode = null)
        {
            switch (statusCode)
            {
                case StatusCode.Error:
                    ColorSwap(ConsoleColor.Red);                    
                    Console.WriteLine(message);
                    ResetColor();
                    break;
                case StatusCode.Success:
                    ColorSwap(ConsoleColor.Green);                    
                    Console.WriteLine(message);
                    ResetColor();
                    break;
                default:                    
                    Console.WriteLine(message);
                    break;
            }
        }

        public static void NewLine()
        {
            Console.WriteLine();
        }

        public static void ColorSwap(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        public static void ResetColor()
        {
            Console.ResetColor();
        }
    }
}
