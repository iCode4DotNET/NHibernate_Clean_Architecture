using Domain.Concrete.Base;

namespace Domain.Concrete.Schema.HR;

/*
/// <summary>
/// موجودیت شخص 
/// </summary>
public class Person : BaseEntity
{
    public Person()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        RoleObject = null!;
    }

    public virtual int ID { get; set; }
    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }

    public virtual byte RoleCode { get; set; }

    public virtual Role RoleObject { get; set; }

    public override string ToString()
    {
        return $"{ID} {FirstName} {LastName}";
    }
}

*/

/// <summary>
/// موجودیت شخص 
/// </summary>
public class Person : Actor
{
    public Person()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        RoleObject = null!;
    }

    public virtual string FirstName { get; set; }
    public virtual string LastName { get; set; }

    public virtual DateTime BirthDate { get; set; }

    public virtual byte RoleCode { get; set; }

    public virtual Role RoleObject { get; set; }

    public virtual string FullName 
    { 
        get
        {
            return FirstName + " " + LastName;
        }       
    }

    public override string ToString()
    {
        return $"{ID} {FullName} {BirthDate}";
    }

}
