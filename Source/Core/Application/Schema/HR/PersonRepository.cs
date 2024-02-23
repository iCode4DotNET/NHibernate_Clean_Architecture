using NHibernate;
using Application.Base;
using Domain.Concrete.Schema.HR;
using ViewModels.Schema.HR;
using Application.Contract.Schema.HR;

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
            RoleCode = x.RoleObject.Code,
        }).OrderBy(x => x.Id).ToList();

        for (var i = 0; i < people.Count; i++)
        {
            people[i].RowIndex  = i+1 ;
        }

        return people;
    }

    public override bool IsViewModelValid(Person entity)
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


public class OrderRepository : BaseIDRepository<Order, OrderViewModel>, IOrderRepository
{
    public OrderRepository(ISession session) : base(session)
    {
    }

    public long GetNextVal(OrderViewModel model)
    {
        throw new NotImplementedException();
    }

    public override List<OrderViewModel> GetViewModels()
    {
        throw new NotImplementedException();
    }

    public override bool IsViewModelValid(Order entity)
    {
        throw new NotImplementedException();
    }

    public override Order ToEntity(OrderViewModel model)
    {
        throw new NotImplementedException();
    }

    public override OrderViewModel ToViewModel(Order entity)
    {
        throw new NotImplementedException();
    }
}
