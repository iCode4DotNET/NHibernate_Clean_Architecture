using NHibernate;
using Application.Base;
using Domain.Concrete.Schema.HR;
using Domain.Contract.Schema.HR;
using ViewModels.Schema.HR;

namespace Application.Schema.HR;


public class PersonRepository : BaseIDRepository<Person, PersonViewModel>, IPersonRepository
{
    public PersonRepository(ISession session) : base(session)
    {
    }


    public override List<PersonViewModel> GetViewModels()
    {
        var people = _session.Query<Person>().Select(x => new PersonViewModel
        {
            Id = x.ID,
            FullName = x.FullName,
            Mobile = x.Mobile,
            RoleTitle = x.RoleObject.Title,
            RoleCode  = x.RoleObject.Code,
        }).ToList();

        return people;
    }

    public override bool IsValid(Person entity)
    {
        return entity.ID > 0;
    }

    public override Person ToEntity(PersonViewModel model)
    {
        throw new NotImplementedException();
    }

    public override PersonViewModel ToViewModel(Person entity)
    {
        throw new NotImplementedException();
    }
}
