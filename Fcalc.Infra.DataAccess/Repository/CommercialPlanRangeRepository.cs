using Fcalc.Infra.DataAccess;
using FCalc.Domain.Model.Abstractions;
using FCalc.Domain.Model.Entities;
using FCalc.Infra.DataAccess.Repository;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FCalc.DataAccess.Repository
{
    public class CommercialPlanRangeRepository : BaseRepository<CommercialPlanRange>, ICommercialPlanRangeRepository
    {
        IEnumerable<CommercialPlanRange> ICommercialPlanRangeRepository.FindActiveCommercialPlanRange()
        {
            try
            {

                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.CommercialPlanRange
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

        IEnumerable<CommercialPlanRange> ICommercialPlanRangeRepository.GetCommercialPlanRangeByCommecialPlan(CommercialPlan commercialPlan)
        {
            try
            {

                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.CommercialPlanRange
                                where c.idCommercialplan == commercialPlan.idCommercialplan
                                select c;

                    return query.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se puede procesar consulta", e);
            }
        }

        IEnumerable<CommercialPlanRange> ICommercialPlanRangeRepository.GetCommercialPlanRangeByCommecialPlan(int commercialPlanId)
        {
            try
            {

                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.CommercialPlanRange
                                where c.idCommercialplan == commercialPlanId
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
