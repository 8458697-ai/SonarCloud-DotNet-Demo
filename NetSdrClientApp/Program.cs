using System;
using System.Linq; // Smell 1: Unused using

namespace NetSdrClientApp
{
    public class Program // Виправлено: Велика літера 'P'
    {
        public string message = "Hello"; // Smell 2: Public field

        static void Main(string[] args)
        {
            int unusedVariable = 10; // Smell 3: Unused variable
            
            try {
                Console.WriteLine("Starting...");
            }
            catch (Exception ex) { // Smell 4: Empty catch
            }

            if (true) { // Smell 5: Always true condition
                 Console.WriteLine("Test");
            }
        }
    }
}
