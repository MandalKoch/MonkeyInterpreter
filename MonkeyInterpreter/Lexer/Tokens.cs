namespace MonkeyInterpreter.Lexer;

public record class Token(string TokenType,string Literal)
{
    public const string ILLEGAL = "ILLEGAL";
    public const string EOF = "EOF";
    
    // Identifiers + literals
    public const string IDENT = "IDENT";
    public const string INT = "INT";

    // Operators
    public const string ASSIGN = "ASSIGN";
    public const string PLUS = "PLUS ";

    // Delimiters
    public const string COMMA = "COMMA";
    public const string SEMICOLON = "SEMICOLON";

    
    public const string LPAREN = "(";
    public const string RPAREN = ")";
    public const string LBRACE = "{";
    public const string RBRACE = "}";
    
    // Keywords
    public const string FUNCTION = "FUNCTION";
    public const string LET = "LET";
}
