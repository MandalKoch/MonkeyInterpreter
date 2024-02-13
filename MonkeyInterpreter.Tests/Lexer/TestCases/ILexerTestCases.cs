namespace MonkeyInterpreter.Lexer.TestCases;

public interface ILexerTestCases
{
    public string FileName { get; }
    public Token[] AssertArray { get; }
}