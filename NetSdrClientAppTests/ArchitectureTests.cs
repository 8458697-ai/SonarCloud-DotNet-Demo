using NetArchTest.Rules;
using Xunit;

namespace NetSdrClientAppTests;

public class ArchitectureTests
{
    [Fact]
    public void Client_ShouldNotReferenceServer()
    {
        // Перевіряємо, що Клієнт НЕ залежить від Сервера
        var result = Types.InAssembly(typeof(NetSdrClientApp.Program).Assembly)
            .ShouldNot()
            .HaveDependencyOn("EchoServer")
            .GetResult();

        Assert.True(result.IsSuccessful, "Архітектурна помилка: Клієнт має пряму залежність від Сервера!");
    }
}
