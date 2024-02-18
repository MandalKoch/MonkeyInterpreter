namespace MonkeyInterpreter.Lexer;

public partial class Lexer
{
    private readonly string m_Input;
    private int m_Position;
    private int m_ReadPosition;
    private char m_Ch;
    
    public Lexer(string input)
    {
        m_Input = input;
        ReadChar();
    }
    public Token NextToken()
    {
        SkipWhiteSpace();
        Token tok;
        switch (m_Ch)
        {
            case '=':
                if (PeekChar() == '=')
                {
                    var ch = m_Ch;
                    ReadChar();
                    var literal = $"{ch}{m_Ch}";
                    tok = new Token(TokenType.EQ, literal);
                }
                else
                {
                    tok = new Token(TokenType.ASSIGN, m_Ch.ToString());
                }
                break;
            case '+':
                tok = new Token(TokenType.PLUS, m_Ch.ToString());
                break;
            case '-':
                tok = new Token(TokenType.MINUS, m_Ch.ToString());
                break;
            case '!':
                
                if (PeekChar() == '=')
                {
                    var ch = m_Ch;
                    ReadChar();
                    var literal = $"{ch}{m_Ch}";
                    tok = new Token(TokenType.NOT_EQ, literal);
                }
                else
                {
                    tok = new Token(TokenType.BANG, m_Ch.ToString());
                }
                break;
            case '/':
                tok = new Token(TokenType.SLASH, m_Ch.ToString());
                break;
            case '*':
                tok = new Token(TokenType.ASTERISK, m_Ch.ToString());
                break;
            case '<':
                tok = new Token(TokenType.LT, m_Ch.ToString());
                break;
            case '>':
                tok = new Token(TokenType.GT, m_Ch.ToString());
                break;
            case ';':
                tok = new Token(TokenType.SEMICOLON, m_Ch.ToString());
                break;
            case ',':
                tok = new Token(TokenType.COMMA, m_Ch.ToString());
                break;
            case '(':
                tok = new Token(TokenType.LPAREN, m_Ch.ToString());
                break;
            case ')':
                tok = new Token(TokenType.RPAREN, m_Ch.ToString());
                break;
            case '{':
                tok = new Token(TokenType.LBRACE, m_Ch.ToString());
                break;
            case '}':
                tok = new Token(TokenType.RBRACE, m_Ch.ToString());
                break;
            case Char.MinValue:
                tok = new Token(TokenType.EOF, "");
                break;
            default:
                if (IsLetter(m_Ch))
                {
                    var literal = ReadIdentifier(); 
                    return new Token(LookupIdent(literal), literal);
                }
                else if ( IsDigit(m_Ch))
                {
                    var literal = ReadNumber();
                    return new Token(TokenType.INT, literal);
                }
                else
                {
                    tok = new Token(TokenType.ILLEGAL, m_Ch.ToString());
                }
                break;
        }
        ReadChar();
        return tok;
    }
}