using System;
using System.Linq; // Smell 1: Unused using

namespace NetSdrClientApp
{
    public class Program // Виправлено: назва класу з великої літери
    {
        public string message = "Hello"; // Smell 2: Public field

        public static void Main(string[] args)
        {
            int unusedVar = 10; // Smell 3: Unused variable
            
            try {
                Console.WriteLine("System Start...");
            }
            catch (Exception ex) { // Smell 4: Catching general exception
                // Smell 5: Empty catch block
            }

            if (true) { // Smell 6: Redundant condition
                 Console.WriteLine("Running");
            }
            
            // Smell 7: String concatenation in loop (якщо додасте пізніше)
            // Smell 8: Dead code (недосяжний код)
        }
    }
}
