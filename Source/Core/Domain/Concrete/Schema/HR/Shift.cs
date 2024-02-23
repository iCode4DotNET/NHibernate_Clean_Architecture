using Domain.Concrete.Base;
using System.Data;

namespace Domain.Concrete.Schema.HR;

[NextVal(table: "Shift", schema:"dbo")]
public class Shift : BaseEntity
{
    public Shift()
    {
        Title = string.Empty;
    }

    public virtual byte Code { get; set; }
    public virtual string Title { get; set; }
    public virtual string Start { get; set; }
    public virtual string End { get; set; }

    public override bool IsEntityValid()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"{Code} {Title} {Start} {End}";
    }

}