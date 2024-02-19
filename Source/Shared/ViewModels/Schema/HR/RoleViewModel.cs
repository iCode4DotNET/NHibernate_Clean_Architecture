using Domain.Concrete.Schema.HR;

namespace ViewModels.Schema.HR;

#pragma warning disable CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
#pragma warning disable CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
public class RoleViewModel : IBaseViewModel
#pragma warning restore CS0661 // Type defines operator == or operator != but does not override Object.GetHashCode()
#pragma warning restore CS0660 // Type defines operator == or operator != but does not override Object.Equals(object o)
{
    public RoleViewModel()
    {
        Title = string.Empty;
    }

    #region [ Implicit Convert / Cast ]

    public static implicit operator Role(RoleViewModel model)
    {
        return new Role
        {
            Code = (byte)model.Id,
            Title = model.Title,
        };
    }

    public static implicit operator RoleViewModel(Role entity)
    {
        return new RoleViewModel
        {
            Title = entity.Title,
            Id = entity.Code
        };
    }

    #endregion

    #region [ Properties ]
    public string Title { get; set; }
    public int Id { get; set; }
    #endregion

    #region [ Override Methods ]
    public override string ToString()
    {
        return $"{Id} {Title}";
    }
    #endregion


    #region [ Just 4 Review and Compare 2 Implicit Casting : Operator Overloading  ]
   
    public static RoleViewModel operator +(RoleViewModel R1, RoleViewModel R2)
    {
        return new RoleViewModel()
        {
            Title = string.Join(" * ", R1.Title, R2.Title),
            Id = (byte)(R1.Id + R2.Id)
        };
    }

    public static bool operator ==(RoleViewModel R1, RoleViewModel R2)
    {
        return R1.Id == R2.Id && R1.Title == R2.Title;
    }

    public static bool operator !=(RoleViewModel R1, RoleViewModel R2)
    {
        return R1.Id != R2.Id || R1.Title != R2.Title;
    } 

    #endregion


}
