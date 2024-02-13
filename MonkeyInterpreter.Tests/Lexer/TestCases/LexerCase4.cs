namespace MonkeyInterpreter.Lexer.TestCases;

public class LexerCase4 : ILexerTestCases
{
    public string FileName => "MonkeyTestLexerCase4.monkey";

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
            
            new Token(TokenType.BANG, "!"),
            new Token(TokenType.MINUS, "-"),
            new Token(TokenType.SLASH, "/"),
            new Token(TokenType.ASTERISK, "*"),
            new Token(TokenType.INT, "5"),
            new Token(TokenType.SEMICOLON, ";"),
            new Token(TokenType.INT, "5"),
            new Token(TokenType.LT, "<"),
            new Token(TokenType.INT, "10"),
            new Token(TokenType.GT, ">"),
            new Token(TokenType.INT, "5"),
            new Token(TokenType.SEMICOLON, ";"),

            /*new Token(TokenTypes.IF, "if"),
            new Token(TokenTypes.LPAREN, "("),
            new Token(TokenTypes.INT, "5"),
            new Token(TokenTypes.LT, "<"),
            new Token(TokenTypes.INT, "10"),
            new Token(TokenTypes.RPAREN, ")"),
            new Token(TokenTypes.LBRACE, "{"),
            new Token(TokenTypes.RETURN, "return"),
            new Token(TokenTypes.TRUE, "true"),
            new Token(TokenTypes.SEMICOLON, ";"),
            new Token(TokenTypes.RBRACE, "}"),
            new Token(TokenTypes.ELSE, "else"),
            new Token(TokenTypes.LBRACE, "{"),
            new Token(TokenTypes.RETURN, "return"),
            new Token(TokenTypes.FALSE, "false"),
            new Token(TokenTypes.SEMICOLON, ";"),
            new Token(TokenTypes.RBRACE, "}"),
            new Token(TokenTypes.INT, "10"),
            new Token(TokenTypes.EQ, "=="),
            new Token(TokenTypes.INT, "10"),
            new Token(TokenTypes.SEMICOLON, ";"),
            new Token(TokenTypes.INT, "10"),
            new Token(TokenTypes.NOT_EQ, "!="),
            new Token(TokenTypes.INT, "9"),
            new Token(TokenTypes.SEMICOLON, ";"),*/
            
            new Token(TokenType.EOF,""),
        };
}