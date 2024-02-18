using MonkeyInterpreter.ReplImpl;

var userName = Environment.UserName;
var tokenSource = new CancellationTokenSource();
Console.CancelKeyPress += (s,e) => {
    e.Cancel = true;
    tokenSource.Cancel();
};
Console.WriteLine($"Hello Mister {userName}! This is the Monkey programming language!");

await using var writer = Console.Out;
using var fileReader = GetFileStream();
while (!tokenSource.IsCancellationRequested)
{
    await Repl.StartAsync(writer,fileReader,tokenSource.Token);
}

Console.WriteLine("Exited gracefully");


static TextReader GetFileStream()
{
    var file = "MonkeyTest.monkey";
    Console.WriteLine($"Reading from file: {file}.");
    var fileReader = new FileStream(file,FileMode.Open,FileAccess.Read,FileShare.ReadWrite);
    return new StreamReader(fileReader);
}


static TextReader GetConsoleStream()
{
    Console.WriteLine("Accepting console input.");
    return Console.In;
}