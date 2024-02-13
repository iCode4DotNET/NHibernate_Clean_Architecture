namespace Domain.Concrete.Schema.HR;

public class Company : Actor
{
    public Company()
    {
        Title = string.Empty;
        RegisterNo = string.Empty;
    }

    public virtual string Title { get; set; }

    public virtual string RegisterNo { get; set; }

    public virtual DateTime RegisterDate { get; set; }

    public override string ToString()
    {
        return $"{ID} {Title} {RegisterDate}";
    }
}