using System;
using System.Linq; // Зауваження 1: Невикористаний using

namespace NetSdrClientApp
{
    public class Program // Велика літера 'P' виправляє помилку збірки
    {
        public string message = "Hello"; // Зауваження 2: Публічне поле

        static void Main(string[] args)
        {
            int unusedVar = 10; // Зауваження 3: Невикористана змінна
            
            try {
                Console.WriteLine("Starting...");
            }
            catch (Exception ex) { // Зауваження 4: Порожній catch
            }

            if (1 == 1) { // Зауваження 5: Умова, яка завжди істинна
                 Console.WriteLine("Test");
            }
        }
    }
}
