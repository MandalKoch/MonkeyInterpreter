using MonkeyInterpreter.LexerImpl;

namespace MonkeyInterpreter.ReplImpl;

public static class Repl
{
    private const string c_PROMPT = ">>";
    public static async Task StartAsync(
        TextWriter writer,
        TextReader reader,
        CancellationToken cancellationToken = default)
    {
        while (!cancellationToken.IsCancellationRequested)
        {
            var line = await reader.ReadLineAsync(cancellationToken).ConfigureAwait(true);
            if (string.IsNullOrEmpty(line))
            {
                continue;
            }
            await writer.WriteLineAsync($"{c_PROMPT} {line}");
            Lexer lexer = new(line);
            var lexerToken = lexer.NextToken();
            while (lexerToken.Type != TokenType.EOF)
            {
                await writer.WriteLineAsync(lexerToken.ToString());
                lexerToken = lexer.NextToken();
            }
        }
    }
}