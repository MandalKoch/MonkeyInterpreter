using FluentAssertions;
using MonkeyInterpreter.Lexer;

namespace MonkeyInterpreter.Lexer;

public class LexerTests
{
    [Fact]
    public void TestNextToken_Fundamenta()
    {
        var input = File.ReadAllText(Path.Combine("Lexer","MonkeyTestLexer.monkey"));

        Token[] assert = new Token[]
        {
            new Token(Token.ASSIGN, "="),
            new Token(Token.PLUS, "+"),
            new Token(Token.LPAREN, "("),
            new Token(Token.RPAREN, ")"),
            new Token(Token.LBRACE, "{"),
            new Token(Token.RBRACE, "}"),
            new Token(Token.COMMA, ","),
            new Token(Token.SEMICOLON, ";"),
        };

        Lexer l = new(input);
        //Act
        for (int i = 0; i < input.Length; i++)
        {
            Token tok = l.NextToken();
            tok.Should().Be(assert[i]);
        }
    }
}