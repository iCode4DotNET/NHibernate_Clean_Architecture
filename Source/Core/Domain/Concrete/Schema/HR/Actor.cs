using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.HR;

public class Actor : BaseEntity
{
    public Actor()
    {
        Address = string.Empty;
        Telephone = string.Empty;
        Mobile = string.Empty;
    }

    public virtual int ID { get; set; }
    public virtual string Address { get; set; }
    public virtual string Telephone { get; set; }
    public virtual string Mobile { get; set; }
}


