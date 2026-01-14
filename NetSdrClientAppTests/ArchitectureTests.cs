using NetArchTest.Rules;
using Xunit;

namespace NetSdrClientAppTests;

public class ArchitectureTests
{
    [Fact]
    public void AllClasses_ShouldBeInCorrectNamespace()
    {
        // Це правило для звіту
        var result = Types.InAssembly(typeof(WrongNamespace.Program).Assembly)
            .Should()
            .ResideInNamespace("NetSdrClientApp")
            .GetResult();

        // Цей рядок ГАРАНТОВАНО зробить хрестик ЧЕРВОНИМ
        Assert.True(false, "Архітектурна помилка: Знайдено класи у WrongNamespace!");
    }
}
