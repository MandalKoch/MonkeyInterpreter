namespace MonkeyInterpreter.Lexer;

public partial class Lexer
{
    private readonly string m_Input;
    private int m_Position = default;
    private int m_ReadPosition = default;
    private char m_Ch;

    private readonly Dictionary<string, string> m_KeywordsLookUp = new()
    {
        {"fn",Token.FUNCTION},
        {"let",Token.LET},
    };
    
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
                tok = new Token(Token.EOF, "");
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
                    return new Token(Token.INT, literal);
                }
                else
                {
                    tok = new Token(Token.ILLEGAL, m_Ch.ToString());
                }
                break;
        }
        ReadChar();
        return tok;
    }
}