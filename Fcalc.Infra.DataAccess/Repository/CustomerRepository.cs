
using FCalc.Domain.Model.Abstractions;
using FCalc.Domain.Model.Entities;
using FCalc.Infra.DataAccess.Repository;

namespace FCalc.DataAccess.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
    }
}
