namespace MonkeyInterpreter.Lexer;

public partial class Lexer
{
   
    private void ReadChar()
    {
        if (m_ReadPosition >= m_Input.Length)
        {
            m_Ch = char.MinValue;
        }
        else
        {
            m_Ch = m_Input[m_ReadPosition];
        }
        m_Position = m_ReadPosition;
        m_ReadPosition++;
    }

    private string ReadIdentifier()
    {
        var pos = m_Position;
        while (IsLetter(m_Ch))
        {
            ReadChar();
        }
        return m_Input.Substring(pos, m_Position - pos);
    }

    private string LookupIdent(string ident)
    {
        if (m_KeywordsLookUp.TryGetValue(ident,out var tokenType))
        {
            return tokenType;
        }
        return Token.IDENT;
    }
    
    private static bool IsLetter(char ch)
    {
        return ch is >= 'a' and <= 'z' or >= 'A' and <= 'Z' or '_';
    }

    private void SkipWhiteSpace()
    {
        while (IsWhiteSpace())
        {
            ReadChar(); 
        }
    }

    private bool IsWhiteSpace()
    {
        switch (m_Ch)
        {
            case ' ':
            case '\t':
            case '\n':
            case '\r':
                return true;
            default:
                return false;
        }
    }

    private static bool IsDigit(char ch)
    {
        return ch is >= '0' and <= '9';
    }

    private string ReadNumber()
    {
        var pos = m_Position;
        while (IsDigit(m_Ch))
        {
            ReadChar();
        }
        return m_Input.Substring(pos, m_Position - pos);
    }
}