using NetArchTest.Rules;
using Xunit;

namespace NetSdrClientAppTests;

public class ArchitectureTests
{
    [Fact]
    public void NoClassesShouldBeInWrongNamespace()
    {
        // Перевіряємо, щоб у проекті НЕ БУЛО простору імен WrongNamespace
        var result = Types.InAssembly(typeof(WrongNamespace.Program).Assembly)
            .ShouldNot()
            .ResideInNamespace("WrongNamespace")
            .GetResult();

        // Оскільки у вас в Program.cs саме WrongNamespace, тест ПРОВАЛИТЬСЯ
        Assert.True(result.IsSuccessful, "Помилка! Знайдено заборонений простір імен WrongNamespace");
    }
}
