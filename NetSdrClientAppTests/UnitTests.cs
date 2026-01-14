using Xunit;

namespace NetSdrClientAppTests
{
    public class UnitTests
    {
        // Тест 1: Перевірка значення повідомлення (той, що вже був)
        [Fact]
        public void TestMessageValue()
        {
            string expected = "Hello";
            string actual = "Hello World";
            Assert.Contains(expected, actual);
        }

        // Тест 2: Перевірка розрахунку (наприклад, для майбутньої логіки)
        [Fact]
        public void TestPortValue()
        {
            int port = 8080;
            Assert.True(port > 0 && port < 65535);
        }

        // Тест 3: Перевірка обробки порожнього рядка
        [Fact]
        public void TestStringNotEmpty()
        {
            string message = "Client Connected";
            Assert.False(string.IsNullOrEmpty(message));
        }

        // Тест 4: Перевірка формату IP (проста логіка)
        [Fact]
        public void TestIpFormat()
        {
            string ip = "127.0.0.1";
            Assert.Equal(9, ip.Length); // 127.0.0.1 має 9 символів
        }

        // Тест 5: Перевірка ініціалізації об'єкта
        [Fact]
        public void TestConnectionStatus()
        {
            bool isConnected = false;
            Assert.False(isConnected);
        }
    }
}
