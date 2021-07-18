
using Fcalc.Infra.DataAccess;
using FCalc.Domain.Model.Abstractions;
using FCalc.Domain.Model.Entities;
using FCalc.Infra.DataAccess.Repository;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FCalc.DataAccess.Repository
{
    public class CommercialPlanRepository : BaseRepository<CommercialPlan>, ICommercialPlanRepository
    {
        public IEnumerable<CommercialPlan> FindActiveCommercialPlan()
        {
            try
            {
               
                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.CommercialPlan 
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

        public IEnumerable<CommercialPlan> FindActiveCommercialPlanBYName(string name)
        {
            try
            {

                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.CommercialPlan
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
