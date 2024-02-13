namespace MonkeyInterpreter.Lexer.TestCases;

public class LexerCase1 : ILexerTestCases
{
    public string FileName => "MonkeyTestLexerCase1.monkey";

    public Token[] AssertArray =>
        new[] 
        {
            new Token(TokenType.ASSIGN, "="),
            new Token(TokenType.PLUS, "+"),
            new Token(TokenType.LPAREN, "("),
            new Token(TokenType.RPAREN, ")"),
            new Token(TokenType.LBRACE, "{"),
            new Token(TokenType.RBRACE, "}"),
            new Token(TokenType.COMMA, ","),
            new Token(TokenType.SEMICOLON, ";"),
            new Token(TokenType.EOF, ""),
        };
}