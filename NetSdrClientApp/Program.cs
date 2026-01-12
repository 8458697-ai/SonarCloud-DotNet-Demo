using System;
using System.Linq; // Зауваження для Sonar (Smell)

namespace NetSdrClientApp
{
    public class Program
    {
        public string message = "Lab 2 Start"; // Зауваження для Sonar (Smell)

        public static void Main(string[] args)
        {
            Console.WriteLine("Build fixed!");
            
            try {
                // Пустий блок
            }
            catch (Exception ex) { 
                // Зауваження для Sonar: порожній catch і невикористаний ex
            }
        }
    }
}
