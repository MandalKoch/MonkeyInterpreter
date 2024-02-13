using System.Collections;

namespace MonkeyInterpreter.Lexer.TestCases;

public class LexerTestCases : IEnumerable<object[]>
{
    private readonly List<ILexerTestCases> m_TestCases;

    public LexerTestCases()
    {
        m_TestCases = new List<ILexerTestCases>
        {
            new LexerCase1(),
            new LexerCase2(),
        };
    }
    
    public IEnumerator<object[]> GetEnumerator()
    {
        foreach (var testcase in m_TestCases)
        {
            yield return [Path.Combine("Lexer","TestCases",testcase.FileName), testcase.AssertArray];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}