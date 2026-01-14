using EchoServer;
using Xunit;

namespace EchoTcpServerTests;

public class ServerTests {
    [Fact]
    public void ProcessResponse_ReturnsCorrectEcho() {
        var processor = new ChatProcessor();
        var result = processor.ProcessResponse("Hello");
        Assert.Equal("Echo from server: Hello", result);
    }
}
