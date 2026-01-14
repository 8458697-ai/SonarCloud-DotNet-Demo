using System;

namespace NetSdrClientApp {
    public static class Program {
        public static void Main(string[] args) {
            ExecuteSharedLogic("Client");
        }

        public static void ExecuteSharedLogic(string context) {
            Console.WriteLine("--- Start of Shared Logic ---");
            try {
                for (int i = 0; i < 10; i++) {
                    Console.WriteLine($"Action {i} in context: {context}");
                    if (i % 2 == 0) Console.WriteLine("Processing even step...");
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error occurred: " + ex.Message);
            }
            Console.WriteLine("--- End of Shared Logic ---");
        }
    }
}
