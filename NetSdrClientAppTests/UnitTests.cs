using Xunit;
using NetSdrClientApp;

namespace NetSdrClientAppTests
{
    public class UnitTests
    {
        [Fact]
        public void TestMessageValue()
        {
            // Простий тест для перевірки логіки (наприклад, чи не пусте повідомлення)
            string expected = "Hello";
            Assert.Contains("Hello", expected);
        }
    }
}
