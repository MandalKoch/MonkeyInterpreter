using System.Collections;

namespace MonkeyInterpreter.LexerImpl.TestCases;

public class LexerTestCases : IEnumerable<object[]>
{
    private readonly List<ILexerTestCases> m_TestCases;

    public LexerTestCases()
    {
        m_TestCases = new List<ILexerTestCases>
        {
            new LexerCase1(),
            new LexerCase2(),
            new LexerCase3(),
            new LexerCase4(),
            new LexerCase5(),
        };
    }
    
    public IEnumerator<object[]> GetEnumerator()
    {
        foreach (var testcase in m_TestCases)
        {
            yield return [Path.Combine("LexerImpl","TestCases",testcase.FileName), testcase.AssertArray];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}