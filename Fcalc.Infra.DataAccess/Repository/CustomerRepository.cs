
using Fcalc.Infra.DataAccess;
using FCalc.Domain.Model.Abstractions;
using FCalc.Domain.Model.Entities;
using FCalc.Infra.DataAccess.Repository;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FCalc.DataAccess.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, IPlanTypeRepository
    {
        public IEnumerable<Customer> FindActiveCustomers()
        {
            try
            {
               
                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.Customer 
                                where c.status == "1" 
                                select c;

                    return query.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se puede procesar consulta", e);
            }
        }
    }
}
