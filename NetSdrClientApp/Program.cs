using System;
using System.Linq; // 1. Smell: Невикористаний using

namespace NetSdrClientApp
{
    public class Program // ВИПРАВЛЕНО: Велика літера 'P' дозволить проекту зібратися
    {
        public string message = "Hello Sonar!"; // 2. Smell: Публічне поле замість властивості

        public static void Main(string[] args)
        {
            int unusedVariable = 10; // 3. Smell: Змінна, яка ніде не використовується
            
            bool constantCondition = true; // 4. Smell: Змінна, що веде до завжди істинної умови

            try 
            {
                if (constantCondition) // 5. Smell: Умова завжди істинна
                {
                    Console.WriteLine("Everything is working!");
                }
            }
            catch (Exception ex) // 6. Smell: Перехоплення загального Exception без логування
            {
                // 7. Smell: Порожній блок catch
            }
        }
    }
}
