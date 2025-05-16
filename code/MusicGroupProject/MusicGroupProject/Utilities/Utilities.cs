using System;
using System.Collections.Generic;
using System.Linq;

namespace MusicGroupProject.Utilities

{
    public static class Utilities
    {
        public static int PromptInt(string message)
        {
            int result;
            do
            {
                Console.Write(message);
            } while (!int.TryParse(Console.ReadLine(), out result));
            return result;
        }

        public static string PromptString(string message, bool allowEmpty = false)
        {
            string input;
            do
            {
                Console.Write(message);
                input = Console.ReadLine() ?? "";
                if (allowEmpty) break;
            }
            while (string.IsNullOrEmpty(input));
            return input;
        }
        
        public static List<string> PromptCsv(string message)
        {
            Console.Write(message);
            return (Console.ReadLine() ?? "")
                .Split(',', StringSplitOptions.RemoveEmptyEntries)
                .Select(s => s.Trim())
                .Where(s => s.Length > 0)
                .ToList();
        }
    }
}