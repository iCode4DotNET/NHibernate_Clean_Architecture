using NHibernate;
using Application.Base;
using Domain.Concrete.Schema.HR;
using Domain.Contract.Schema.HR;
using ViewModels.Schema.HR;

namespace Application.Schema.HR;


public class PersonRepository : BaseRepository<Person>, IPersonRepository
{
    public PersonRepository(ISession session) : base(session)
    {
    }

    public List<PersonViewModel> GetPersonViewModels()
    {
        var people = _session.Query<Person>().Select(x => new PersonViewModel
        {
            ID = x.ID,
            FullName = x.FullName,
            Mobile = x.Mobile,
            RoleTitle = x.RoleObject.Title
        }).ToList();

        return people;  
    }
}
