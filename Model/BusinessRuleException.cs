namespace SalesInventory.Model;

/// <summary>A validation / business-rule failure whose message is safe to show to the user.</summary>
public class BusinessRuleException : Exception
{
    public BusinessRuleException(string message, Exception inner = null) : base(message, inner) { }
}
