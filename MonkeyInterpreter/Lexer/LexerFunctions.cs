namespace MonkeyInterpreter.Lexer;

public partial class Lexer
{
    public Token NextToken()
    {
        Token tok;
        switch (m_Ch)
        {
            case '=':
                tok = new Token(Token.ASSIGN, m_Ch.ToString());
                break;
            case '+':
                tok = new Token(Token.PLUS, m_Ch.ToString());
                break;
            case ';':
                tok = new Token(Token.SEMICOLON, m_Ch.ToString());
                break;
            case ',':
                tok = new Token(Token.COMMA, m_Ch.ToString());
                break;
            case '(':
                tok = new Token(Token.LPAREN, m_Ch.ToString());
                break;
            case ')':
                tok = new Token(Token.RPAREN, m_Ch.ToString());
                break;
            case '{':
                tok = new Token(Token.LBRACE, m_Ch.ToString());
                break;
            case '}':
                tok = new Token(Token.RBRACE, m_Ch.ToString());
                break;
            case Char.MinValue:
                tok = new Token(Token.EOF, m_Ch.ToString());
                break;
            default:
                tok = new Token(Token.ILLEGAL, "");
                break;
        }
        ReadChar();
        return tok;
    }
}