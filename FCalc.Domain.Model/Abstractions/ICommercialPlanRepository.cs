using FCalc.Domain.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FCalc.Domain.Model.Abstractions
{
    public interface ICommercialPlanRepository:IBaseRepository<CommercialPlan>
    {
        IEnumerable<CommercialPlan> FindActiveCommercialPlan();

        IEnumerable<CommercialPlan> FindActiveCommercialPlanBYName(string name);
    }
}
