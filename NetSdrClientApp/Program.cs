using System;


namespace NetSdrClientApp {
    public class Program {
        private static readonly string _msg = "Hello";
        public static void Main(string[] args) {
            
            try { 
                Console.WriteLine(_msg); 
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
