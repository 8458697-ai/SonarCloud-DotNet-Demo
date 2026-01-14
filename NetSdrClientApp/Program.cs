using System;


namespace NetSdrClientApp {
    public class Program {
        private string _msg = "Hello"; // Smell 2: Public field
        public static void Main(string[] args) {
            
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
