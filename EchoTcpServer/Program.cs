using System;

namespace EchoServer;

// Цей клас ми виносимо для тестування (Рефакторинг)
public class ChatProcessor {
    public string ProcessResponse(string input) {
        if (string.IsNullOrWhiteSpace(input)) 
            return "Error: Message is empty";
            
        return $"Echo from server: {input}";
    }
}

public class Program {
    public static void Main(string[] args) {
        var processor = new ChatProcessor();
        Console.WriteLine("Server logic initialized. Ready to process messages.");
        
        // Тут зазвичай код вашого TcpListener
    }
}
