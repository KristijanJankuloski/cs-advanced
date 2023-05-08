#region Methods
void SendMessages()
{
    Console.WriteLine("Getting ready...");
    Thread.Sleep(1000);

    Console.WriteLine("First message arrived");
    Thread.Sleep(1000);

    Console.WriteLine("Second message arrived");
    Thread.Sleep(1000);

    Console.WriteLine("Third message arrived");

    Console.WriteLine("All messages arrived!");
}

void SendMessagesWithThreads()
{
    Console.WriteLine("Getting ready...");

    Thread messageThread = new Thread(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("First message arrived");
    });
    messageThread.Start();

    new Thread(() =>
    {
        Thread.Sleep(1030);
        Console.WriteLine("Second message arrived");
    }).Start();

    new Thread(() =>
    {
        Thread.Sleep(1000);
        Console.WriteLine("Third message arrived");
    }).Start();

    Console.WriteLine("All messages are recieved");
}
#endregion

//SendMessages();
SendMessagesWithThreads();