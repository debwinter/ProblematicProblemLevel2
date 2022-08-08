﻿using ProblematicLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblematicProblemLevel2.Interaction
{
    internal static class ConsoleLogging
    {
        internal static void PassMessage(string message, StatusCode? statusCode = null)
        {
            switch (statusCode)
            {
                case StatusCode.Error:
                    ColorSwap(ConsoleColor.Green);                    
                    Console.WriteLine(message);
                    ResetColor();
                    break;
                case StatusCode.Success:
                    ColorSwap(ConsoleColor.Red);                    
                    Console.WriteLine(message);
                    ResetColor();
                    break;
                default:                    
                    Console.WriteLine(message);
                    break;
            }
        }

        internal static void NewLine()
        {
            Console.WriteLine();
        }

        private static void ColorSwap(ConsoleColor color)
        {
            Console.ForegroundColor = color;
        }

        private static void ResetColor()
        {
            Console.ResetColor();
        }
    }
}
