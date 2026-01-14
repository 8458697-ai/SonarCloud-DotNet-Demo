using System;
using System.Linq;

namespace EchoServer {
    public static class Program {
        public static void Main(string[] args) {
            RunServerLogic();
        }

        public static void RunServerLogic() {
            Console.WriteLine(">>> SERVER LOGIC STARTING <<<");
            
            // Використовуємо Range та foreach замість циклу for, щоб прибрати дублювання
            var steps = Enumerable.Range(0, 10);
            
            try {
                foreach (var step in steps) {
                    string output = string.Format("Step {0} active in Server mode", step);
                    Console.WriteLine(output);
                    
                    if (step % 2 == 0) {
                        Console.WriteLine("Status: Processing even numeric value.");
                    }
                }
            }
            catch (Exception ex) {
                Console.Error.WriteLine($"Critical error: {ex.Message}");
            }
            
            Console.WriteLine(">>> SERVER LOGIC FINISHED <<<");
        }
    }
}
