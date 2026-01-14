using System;


namespace NetSdrClientApp {
    public static class Program {
        private static readonly string _msg = "Hello";
        public static void Main(string[] args) {
            
            try { 
                Console.WriteLine(_msg); 
            }
            catch (Exception ex) {
    Console.WriteLine(ex.Message);
}
             
                Console.WriteLine("Work");
            
        }
    }
}
