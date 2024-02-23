namespace Domain.Concrete.Schema.HR;

public class VW_AllActor
{
    public VW_AllActor()
    {
        ActorName = string.Empty;
    }

    public virtual int ActorID { get; set; }
    public virtual string ActorName { get; set; }
    public virtual DateTime ActorDate { get; set; }

    public override string ToString()
    {
        return $"{ActorID} {ActorName} {ActorDate}";
    }
}
