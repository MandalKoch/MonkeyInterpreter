﻿using FluentAssertions;
using MonkeyInterpreter.Lexer;
using MonkeyInterpreter.Lexer.TestCases;

namespace MonkeyInterpreter.Lexer;

public class LexerTests
{
    [Theory]
    [ClassData(typeof(LexerTestCases))]
    public void TestNextToken(string fileName,Token[] assertArray)
    {
        var input = File.ReadAllText(fileName);
        Lexer l = new(input);
        //Act
        foreach (var assertToken in assertArray)
        {
            Token tok = l.NextToken();
            tok.Should().Be(assertToken);
        }
    }
}