using NetArchTest.Rules;
using Xunit;

namespace NetSdrClientAppTests;

public class ArchitectureTests
{
    [Fact]
    public void Program_ShouldBeInCorrectNamespace()
    {
        // Перевіряємо, чи всі класи в проекті Клієнта знаходяться в правильному просторі імен
        var result = Types.InAssembly(typeof(NetSdrClientApp.Program).Assembly)
            .Should()
            .ResideInNamespace("NetSdrClientApp")
            .GetResult();

        Assert.True(result.IsSuccessful, "Архітектурна помилка: Знайдено класи поза межами NetSdrClientApp!");
    }
}
