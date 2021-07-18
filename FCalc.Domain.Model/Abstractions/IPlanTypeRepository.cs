using FCalc.Domain.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FCalc.Domain.Model.Abstractions
{
    public interface IPlanTypeRepository : IBaseRepository<PlanType>
    {
        IEnumerable<PlanType> FindActivePlanType();
        IEnumerable<PlanType> FindActivePlanTypeByName(string name);
    }
}
