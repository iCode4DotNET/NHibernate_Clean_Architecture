using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.HR;

/// <summary>
/// نقش های سیستم
/// </summary>
public class Role : BaseEntity
{
    public Role()
    {
        Title = string.Empty;
    }

    public virtual byte Code { get; set; }
    public virtual string Title { get; set; }


    public override string ToString()
    {
        return $"{Code} {Title}";
    }

}