using System;
using System.Collections.Generic;
using System.Linq;
using FCalc.Domain.Model.Abstractions;
using FCalc.Domain.Model.Entities;
using FCalc.Infra.DataAccess.Repository;

namespace Fcalc.Infra.DataAccess.Repository
{
    public class PlanTypeRepository : BaseRepository<PlanType>, IPlanTypeRepository
    {
        public IEnumerable<PlanType> FindActivePlanType()
        {
            try
            {

                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.PlanType
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

        public IEnumerable<PlanType> FindActivePlanTypeByName(string name)
        {
            try
            {
                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.PlanType
                                where c.status == "1" && c.name == name
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
