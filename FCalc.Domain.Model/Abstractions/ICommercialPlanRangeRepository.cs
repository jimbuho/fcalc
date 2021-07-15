using FCalc.Domain.Model.Entities;
using System.Collections.Generic;

namespace FCalc.Domain.Model.Abstractions
{
    public interface ICommercialPlanRangeRepository:IBaseRepository<CommercialPlanRange>
    {
        IEnumerable<CommercialPlanRange> FindActiveCommercialPlanRange();

        IEnumerable<CommercialPlanRange> GetCommercialPlanRangeByCommecialPlan(CommercialPlan commercialPlan);

        IEnumerable<CommercialPlanRange> GetCommercialPlanRangeByCommecialPlan(int idCommercialPlan);
    }
}
