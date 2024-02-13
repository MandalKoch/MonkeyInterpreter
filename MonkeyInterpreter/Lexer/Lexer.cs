namespace MonkeyInterpreter.Lexer;

public partial class Lexer
{
    public string Input { get; }
    private int m_Position = default;
    private int m_ReadPosition = default;
    private char m_Ch;
    
    public Lexer(string input)
    {
        Input = input;
        ReadChar();
    }

    private void ReadChar()
    {
        if (m_ReadPosition >= Input.Length)
        {
            m_Ch = char.MinValue;
        }
        else
        {
            m_Ch = Input[m_ReadPosition];
        }
        m_Position = m_ReadPosition;
        m_ReadPosition++;
    }
    
    
}