
using System.Collections.Generic;
using System;
using FCalc.Domain.Model.Abstractions;
using FCalc.DataAccess.Repository;
using FCalc.Domain.Model.Entities;

namespace FCalc.Application.Service
{
    public class CommercialPlanRange
    {
        readonly ICommercialPlanRangeRepository repository;

        public CommercialPlanRange()
        {
            repository = new CommercialPlanRangeRepository();
        }

        public IEnumerable<CommercialPlanRange> GetCommercialPlanRange()
        {
            return repository.GetAll();
        }

        public IEnumerable<CommercialPlanRange> FindActiveCommercialPlanRange()
        {
            return repository.FindActiveCommercialPlanRange();
        }

        public void InsertCommercialPlanRange(CommercialPlanRange commercialPlanRange)
        {
            repository.Add(commercialPlanRange);
        }

        public void ModifyCommercialPlanRange(CommercialPlanRange commercialPlanRange)
        {
            repository.Modify(commercialPlanRange);
        }

    }
}
