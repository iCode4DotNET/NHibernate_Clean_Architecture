namespace ViewModels.Schema.HR;

public class RoleViewModel
{
    public RoleViewModel()
    {
        Title = string.Empty;
    }

    public byte Code { get; set; }
    public string Title { get; set; }

    public override string ToString()
    {
        return $"{Code} {Title}";
    }
}
