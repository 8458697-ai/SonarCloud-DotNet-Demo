using System;

namespace EchoTcpServer {
    public static class Program {
        private static readonly string _msg = "Server Echo"; // Змінили лише текст повідомлення
        public static void Main(string[] args) {
            
            // Цей блок try-catch — точна копія вашого клієнта
            try { 
                Console.WriteLine(_msg); 
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
            }
             
            // Цей рядок теж такий самий
            Console.WriteLine("Work");
        }
    }
}
