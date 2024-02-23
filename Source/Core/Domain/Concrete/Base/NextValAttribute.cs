namespace Domain.Concrete.Base;

/// <summary>
/// نام جدول و نام شِمای دیتابیس
/// </summary>
/// <param name="name">نام جدول</param>
/// <param name="schema">نام شِما</param>
[AttributeUsage(AttributeTargets.Class)]
public class NextValAttribute(string table, string schema , string pk = "Code") : Attribute
{
    public string Table { get; } = table;

    public string Schema { get; } = schema;
}

