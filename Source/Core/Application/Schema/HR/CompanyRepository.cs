using NHibernate;
using Application.Base;
using Domain.Concrete.Schema.HR;
using Domain.Contract.Schema.HR;
namespace Application.Schema.HR;

public class CompanyRepository : BaseRepository<Company>, ICompanyRepository
{
    public CompanyRepository(ISession session) : base(session)
    {
    }
}
