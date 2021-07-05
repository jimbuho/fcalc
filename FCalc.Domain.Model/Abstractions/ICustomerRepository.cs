using FCalc.Domain.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FCalc.Domain.Model.Abstractions
{
    public interface ICustomerRepository:IBaseRepository<Customer>
    {
        IEnumerable<Customer> FindActiveCustomers();
        IEnumerable<Customer> FindActiveCustomersByRUC(string RUC);
    }
}
