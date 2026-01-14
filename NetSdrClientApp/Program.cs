using System;


namespace NetSdrClientApp {
    public class Program {
        private static readonly string _msg = "Hello";
        public static void Main(string[] args) {
            
            try { 
                Console.WriteLine(_msg); 
            }
            catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
            if (true) { // Smell 6: Always true
                Console.WriteLine("Work");
            }
        }
    }
}
