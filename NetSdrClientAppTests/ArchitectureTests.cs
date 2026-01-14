using NetArchTest.Rules;
using Xunit;

namespace NetSdrClientAppTests;

public class ArchitectureTests
{
    [Fact]
    public void AllClasses_ShouldBeInCorrectNamespace()
    {
        // Беремо всі типи з проекту Клієнта
        var result = Types.InAssembly(typeof(NetSdrClientApp.Program).Assembly)
            .Should()
            .ResideInNamespace("NetSdrClientApp")
            .GetResult();

        // Якщо хоча б один клас (як ваш з WrongNamespace) не там — тест впаде
        Assert.True(result.IsSuccessful, "Архітектурна помилка: Знайдено класи поза межами NetSdrClientApp!");
    }
}
