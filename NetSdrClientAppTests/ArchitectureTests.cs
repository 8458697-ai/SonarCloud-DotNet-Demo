using NetArchTest.Rules;
using Xunit;

namespace NetSdrClientAppTests;

public class ArchitectureTests
{
    [Fact]
    public void AllClasses_MustBeInCorrectNamespace()
    {
        // Отримуємо всі типи з вашої збірки (навіть якщо вони у WrongNamespace)
        var result = Types.InAssembly(typeof(WrongNamespace.Program).Assembly)
            .Should()
            .ResideInNamespace("NetSdrClientApp")
            .GetResult();

        // Тест впаде, якщо знайде хоча б один тип поза NetSdrClientApp
        Assert.True(result.IsSuccessful, "Архітектурна помилка: Знайдено класи у неправильному namespace!");
    }
}
