using System.Diagnostics.CodeAnalysis;

namespace MonkeyInterpreter.Lexer;

[SuppressMessage("ReSharper", "NotAccessedPositionalProperty.Global")]
public record struct Token(string Type, string Literal);