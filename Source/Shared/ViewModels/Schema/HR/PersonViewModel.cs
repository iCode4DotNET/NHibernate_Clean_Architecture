namespace ViewModels.Schema.HR;


public class PersonViewModel : IBaseViewModel
{
    public PersonViewModel()
    {
        FullName = string.Empty;
        RoleTitle = string.Empty;
        Mobile = string.Empty;
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