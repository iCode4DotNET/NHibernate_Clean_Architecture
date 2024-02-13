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
        PersonList = [];
    }

    public virtual byte Code { get; set; }
    public virtual string Title { get; set; }

    public virtual IList<Person> PersonList { get; set; }

    public override string ToString()
    {
        return $"{Code} {Title}";
    }

}