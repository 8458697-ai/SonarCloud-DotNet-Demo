using System;
using System.Linq; // Smell 1: Unused using

namespace NetSdrClientApp {
    public class Program {
        public string msg = "Hello"; // Smell 2: Public field
        public static void Main(string[] args) {
            int x = 5; // Smell 3: Unused variable
            try { 
                Console.WriteLine("Start"); 
            }
            catch (Exception ex) { // Smell 4: Generic exception
                // Smell 5: Empty catch
            }
            if (true) { // Smell 6: Always true
                Console.WriteLine("Work");
            }
        }
    }
}
