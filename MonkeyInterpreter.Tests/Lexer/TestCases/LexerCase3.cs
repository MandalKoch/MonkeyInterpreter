namespace MonkeyInterpreter.Lexer.TestCases;

public class LexerCase3 : ILexerTestCases
{
    public string FileName => "MonkeyTestLexerCase3.monkey";

    public Token[] AssertArray =>
        new[] 
        {
            new Token(Token.LET, "let"),
            new Token(Token.IDENT,"five"),
            new Token(Token.ASSIGN,"="),
            new Token(Token.INT,"5"),
            new Token(Token.SEMICOLON,";"),
            
            new Token(Token.LET, "let"),
            new Token(Token.IDENT,"ten"),
            new Token(Token.ASSIGN,"="),
            new Token(Token.INT,"10"),
            new Token(Token.SEMICOLON,";"),
            
            new Token(Token.LET,"let"),
            new Token(Token.IDENT,"add"),
            new Token(Token.ASSIGN,"="),
            new Token(Token.FUNCTION,"fn"),
            new Token(Token.LPAREN,"("),
            new Token(Token.IDENT,"x"),
            new Token(Token.COMMA,","),
            new Token(Token.IDENT,"y"),
            new Token(Token.RPAREN,")"),
            new Token(Token.LBRACE,"{"),
            
            new Token(Token.IDENT,"x"),
            new Token(Token.PLUS,"+"),
            new Token(Token.IDENT,"y"),
            new Token(Token.SEMICOLON,";"),
            
            new Token(Token.RBRACE,"}"),
            new Token(Token.SEMICOLON,";"),
            
            new Token(Token.LET,"let"),
            new Token(Token.IDENT,"result"),
            new Token(Token.ASSIGN,"="),
            new Token(Token.IDENT,"add"),
            new Token(Token.LPAREN,"("),
            new Token(Token.IDENT,"five"),
            new Token(Token.COMMA,","),
            new Token(Token.IDENT,"ten"),
            new Token(Token.RPAREN,")"),
            new Token(Token.SEMICOLON,";"),
            
            new Token(Token.BANG, "!"),
            new Token(Token.MINUS, "-"),
            new Token(Token.SLASH, "/"),
            new Token(Token.ASTERISK, "*"),
            new Token(Token.INT, "5"),
            new Token(Token.SEMICOLON, ";"),
            new Token(Token.INT, "5"),
            new Token(Token.LT, "<"),
            new Token(Token.INT, "10"),
            new Token(Token.GT, ">"),
            new Token(Token.INT, "5"),
            new Token(Token.SEMICOLON, ";"),
            
            new Token(Token.EOF,""),
        };
}