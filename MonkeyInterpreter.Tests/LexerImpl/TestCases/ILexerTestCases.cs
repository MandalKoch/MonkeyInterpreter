namespace MonkeyInterpreter.LexerImpl;

public interface ILexerTestCases
{
    public string FileName { get; }
    public Token[] AssertArray { get; }
}