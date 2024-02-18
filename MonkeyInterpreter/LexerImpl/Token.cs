using System.Diagnostics.CodeAnalysis;

namespace MonkeyInterpreter.LexerImpl;

[SuppressMessage("ReSharper", "NotAccessedPositionalProperty.Global")]
public record struct Token(string Type, string Literal);