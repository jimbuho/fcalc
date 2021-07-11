
using System.Collections.Generic;
using System;
using FCalc.Domain.Model.Abstractions;
using FCalc.DataAccess.Repository;
using FCalc.Domain.Model.Entities;

namespace FCalc.Application.Service
{
    public class CommercialPlanRangeService
    {
        readonly ICommercialPlanRangeRepository repository;

        public CommercialPlanRangeService()
        {
            repository = new CommercialPlanRangeRepository();
        }

        public IEnumerable<CommercialPlanRange> GetCommercialPlanRange()
        {
            return repository.GetAll();
        }
        public CommercialPlanRange GetCommercialPlanRangeById(int id)
        {
            return repository.GetById(id);
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

        public void DeleteCommercialPlanRange(int itemId)
        {
            CommercialPlanRange item = repository.GetById(itemId);
            item.status = "0";
            repository.Modify(item);
        }

    }
}
