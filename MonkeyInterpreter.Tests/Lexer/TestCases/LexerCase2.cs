namespace MonkeyInterpreter.Lexer.TestCases;

public class LexerCase2 : ILexerTestCases
{
    public string FileName => "MonkeyTestLexerCase2.monkey";

    public Token[] AssertArray =>
        new[] 
        {
            new Token(TokenType.LET, "let"),
            new Token(TokenType.IDENT,"five"),
            new Token(TokenType.ASSIGN,"="),
            new Token(TokenType.INT,"5"),
            new Token(TokenType.SEMICOLON,";"),
            
            new Token(TokenType.LET, "let"),
            new Token(TokenType.IDENT,"ten"),
            new Token(TokenType.ASSIGN,"="),
            new Token(TokenType.INT,"10"),
            new Token(TokenType.SEMICOLON,";"),
            
            new Token(TokenType.LET,"let"),
            new Token(TokenType.IDENT,"add"),
            new Token(TokenType.ASSIGN,"="),
            new Token(TokenType.FUNCTION,"fn"),
            new Token(TokenType.LPAREN,"("),
            new Token(TokenType.IDENT,"x"),
            new Token(TokenType.COMMA,","),
            new Token(TokenType.IDENT,"y"),
            new Token(TokenType.RPAREN,")"),
            new Token(TokenType.LBRACE,"{"),
                       
            new Token(TokenType.IDENT,"x"),
            new Token(TokenType.PLUS,"+"),
            new Token(TokenType.IDENT,"y"),
            new Token(TokenType.SEMICOLON,";"),
            
            new Token(TokenType.RBRACE,"}"),
            new Token(TokenType.SEMICOLON,";"),
            
            new Token(TokenType.LET,"let"),
            new Token(TokenType.IDENT,"result"),
            new Token(TokenType.ASSIGN,"="),
            new Token(TokenType.IDENT,"add"),
            new Token(TokenType.LPAREN,"("),
            new Token(TokenType.IDENT,"five"),
            new Token(TokenType.COMMA,","),
            new Token(TokenType.IDENT,"ten"),
            new Token(TokenType.RPAREN,")"),
            new Token(TokenType.SEMICOLON,";"),
            
            new Token(TokenType.EOF,"")
        };
}