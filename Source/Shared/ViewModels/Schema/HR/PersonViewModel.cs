using Domain.Concrete.Schema.HR;

namespace ViewModels.Schema.HR;


public class PersonViewModel : IBaseViewModel
{
    public PersonViewModel()
    {
        FullName = string.Empty;
        RoleTitle = string.Empty;
        Mobile = string.Empty;
    }


    public static implicit operator PersonViewModel(Person entity)
    {
        return new PersonViewModel
        {
            FullName = entity.FullName,
            Id = entity.ID,
            Mobile = entity.Mobile,
            RoleCode = entity.RoleCode,
            RoleTitle = entity.RoleObject.Title,
        };
    }

    public static implicit operator Person(PersonViewModel entity)
    {
        return new Person()
        {
            ID = entity.Id,
            RoleCode = (byte)entity.RoleCode,
            Mobile = entity.Mobile

        };
    }


    public int Id { get; set; }
    public string FullName { get; set; }
    public string RoleTitle { get; set; }
    public byte RoleCode { get; set; }

    public string Mobile { get; set; }

    public override string ToString()
    {
        return $"{Id} {FullName} {RoleTitle} {Mobile}";
    }
}