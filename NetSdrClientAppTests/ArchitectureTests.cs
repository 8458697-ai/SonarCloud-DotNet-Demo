using NetArchTest.Rules;
using Xunit;
using System.Linq;

namespace NetSdrClientAppTests;

public class ArchitectureTests
{
    [Fact]
    public void AllClasses_MustBeInNetSdrClientAppNamespace()
    {
        // 1. Отримуємо всі типи з вашої програми
        var allTypes = Types.InAssembly(typeof(WrongNamespace.Program).Assembly);

        // 2. Перевіряємо, щоб вони всі були ТІЛЬКИ в NetSdrClientApp
        var result = allTypes
            .Should()
            .ResideInNamespace("NetSdrClientApp")
            .GetResult();

        // 3. Тест впаде, якщо знайде хоча б один клас у WrongNamespace
        Assert.True(result.IsSuccessful, "Знайдено класи в неправильному просторі імен!");
    }
}
