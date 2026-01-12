using System;
using System.Linq; // Smell 1

namespace NetSdrClientApp
{
    public class Program // Виправлено на велику 'P' для успішного Build
    {
        public string message = "Hello"; // Smell 2
        static void Main(string[] args)
        {
            int unusedVar = 10; // Smell 3
            try { Console.WriteLine("Build success"); }
            catch (Exception ex) { } // Smell 4
            if (true) { Console.WriteLine("Test"); } // Smell 5
        }
    }
}
