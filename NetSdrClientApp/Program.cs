using System;
using System.Linq; // 1. Smell: Невикористаний using

namespace NetSdrClientApp
{
    public class Program // 2. Smell: Назва класу має бути з великої літери (Program)
    {
        public string message = "Hello"; // 3. Smell: Публічне поле замість властивості

        static void Main(string[] args)
        {
            int unusedVariable = 10; // 4. Smell: Невикористана змінна

            try {
                Console.WriteLine("Starting program...");
            }
            catch (Exception ex) { // 5. Smell: Порожній блок catch
            }

            if (false) { // 6. Smell: Код, який ніколи не виконається
                Console.WriteLine("Unreachable");
            }
        }
    }
}
