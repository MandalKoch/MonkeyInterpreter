using MonkeyInterpreter.ReplImpl;

var userName = Environment.UserName;
var tokenSource = new CancellationTokenSource();
Console.CancelKeyPress += (s,e) => {
    e.Cancel = true;
    tokenSource.Cancel();
};
Console.WriteLine($"Hello Mister {userName}! This is the Monkey programming language!");

var file = "MonkeyTest.monkey";

await using var writer = Console.Out;
await using var fileReader = File.OpenRead(file);
while (!tokenSource.IsCancellationRequested)
{
    
    await Repl.StartAsync(writer,new StreamReader(fileReader),tokenSource.Token);
}

Console.WriteLine("Exited gracefully");