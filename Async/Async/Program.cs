async Task SendMessageAsync(string message)
{
    Console.WriteLine("Sending message...");
    await Task.Run(() =>
    {
        Thread.Sleep(4000);
        Console.WriteLine($"Message sent");
    });
    Console.WriteLine("Gettong response...");
    await Task.Run(() =>
    {
        Thread.Sleep(3000);
        Console.WriteLine($"Response to message {message}");
    });
}

void ShowAd()
{
    Console.Write("|");
    Thread.Sleep(300);
    Console.CursorLeft--;
    Console.Write('/');
    Thread.Sleep(300);
    Console.CursorLeft--;
    Console.Write('-');
    Thread.Sleep(300);
    Console.CursorLeft--;
    Console.Write('\\');
    Thread.Sleep(300);
    Console.CursorLeft--;
    Console.Write('|');
    Thread.Sleep(300);
    Console.CursorLeft--;
    Console.Write("|");
    Thread.Sleep(300);
    Console.CursorLeft--;
    Console.Write('/');
    Thread.Sleep(300);
    Console.CursorLeft--;
    Console.Write('-');
    Thread.Sleep(300);
    Console.CursorLeft--;
    Console.Write('\\');
    Thread.Sleep(300);
    Console.CursorLeft--;
    Console.Write('|');
    Console.CursorLeft--;
}

var task = SendMessageAsync("Hello from sedc");
ShowAd();

Console.ReadLine();