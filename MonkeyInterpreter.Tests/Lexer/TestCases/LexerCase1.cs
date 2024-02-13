namespace MonkeyInterpreter.Lexer.TestCases;

public class LexerCase1 : ILexerTestCases
{
    public string FileName => "MonkeyTestLexerCase1.monkey";

    public Token[] AssertArray =>
        new[] 
        {
            new Token(Token.ASSIGN, "="),
            new Token(Token.PLUS, "+"),
            new Token(Token.LPAREN, "("),
            new Token(Token.RPAREN, ")"),
            new Token(Token.LBRACE, "{"),
            new Token(Token.RBRACE, "}"),
            new Token(Token.COMMA, ","),
            new Token(Token.SEMICOLON, ";"),
            new Token(Token.EOF, ""),
        };
}