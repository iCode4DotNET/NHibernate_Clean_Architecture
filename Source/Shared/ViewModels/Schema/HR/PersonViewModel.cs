namespace ViewModels.Schema.HR;

public class PersonViewModel
{
    public PersonViewModel()
    {
        FullName = string.Empty;
        RoleTitle = string.Empty;
        Mobile = string.Empty;
    }

    public int ID { get; set; }
    public string FullName { get; set; }
    public string RoleTitle { get; set; }
    public string Mobile { get; set; }

    public override string ToString()
    {
        return $"{ID} {FullName} {RoleTitle} {Mobile}";
    }
}