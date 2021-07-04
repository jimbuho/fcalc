using FCalc.Domain.Model.Entities;
using System.Collections.Generic;
using System.Linq;

namespace FCalc.Domain.Model.Abstractions
{
    public interface ICommercialPlanRangeRepository:IBaseRepository<CommercialPlanRange>
    {
        IEnumerable<CommercialPlanRange> FindActiveCommercialPlanRange();
    }
}
