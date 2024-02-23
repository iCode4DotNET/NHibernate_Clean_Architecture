using Domain.Concrete.Schema.HR;

namespace ViewModels.Schema.HR;

public class ShiftViewModel : IBaseViewModel
{
    public ShiftViewModel()
    {
        Title = string.Empty;
    }

    #region [ Implicit Convert / Cast ]

    public static implicit operator Shift(ShiftViewModel model)
    {
        return new Shift
        {
            Code = (byte)model.Id,
            Title = model.Title,
            End = model.EndTime,
            Start = model.StartTime
        };
    }

    public static implicit operator ShiftViewModel(Shift entity)
    {
        return new ShiftViewModel
        {
            Title = entity.Title,
            Id = entity.Code,
            StartTime = entity.Start,
            EndTime = entity.End,
        };
    }

    #endregion

    #region [ Properties ]
    public string Title { get; set; }
    public int Id { get; set; }

    public int RowIndex { get; set; }

    public string StartTime { get; set; }
    public string EndTime { get; set; }

    #endregion

    #region [ Override Methods ]
    public override string ToString()
    {
        return $"{Id} {Title} {StartTime} {EndTime}";
    }
    #endregion





}