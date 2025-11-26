using System.Collections.Concurrent;

var results = new ConcurrentQueue<string>();
bool keepRunning = true;

var task = Task.Run(async () =>
{
    int counter = 0;

    while (keepRunning)
    {
        counter++;
        string value = $"Result from step {counter} at {DateTime.Now:HH:mm:ss}";
        results.Enqueue(value);
        await Task.Delay(1000);
    }
});

Console.WriteLine("Press any key to stop...\n");

// Foreground thread consumes values while task runs
while (!Console.KeyAvailable)
{
    while (results.TryDequeue(out string? value))
    {
        Console.WriteLine($"Consumed: {value}");
    }

    await Task.Delay(200); // Check periodically
}

Console.ReadKey(true);
keepRunning = false;
await task;

Console.WriteLine($"\nDone. Remaining items: {results.Count}");