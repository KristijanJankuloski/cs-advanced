Console.WriteLine("App start...");

Task task = new Task(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("Running after 1s");
});

task.Start();

Task<int> valueTask = new Task<int>(() =>
{
    Thread.Sleep(1000);
    Console.WriteLine("Got number");
    return 10;
});

valueTask.Start();
Console.WriteLine(valueTask.Result);

Task.Run(() => { 
    Thread.Sleep(2000);
    Console.WriteLine("Run task from task .run");
});

Console.WriteLine("End");

Console.ReadLine();