
using System.Collections.Generic;
using System;
using FCalc.Domain.Model.Abstractions;
using FCalc.DataAccess.Repository;
using FCalc.Domain.Model.Entities;

namespace FCalc.Application.Service
{
    public class CommercialPlanService
    {
        readonly ICommercialPlanRepository repository;

        public CommercialPlanService()
        {
            repository = new CommercialPlanRepository();
        }

        public IEnumerable<CommercialPlan> GetCommercialPlan()
        {
            return repository.GetAll();
        }
        public CommercialPlan GetCommercialPlanById(int id)
        {
            return repository.GetById(id);
        }
        public IEnumerable<CommercialPlan> FindActiveCommercialPlan()
        {
            return repository.FindActiveCommercialPlan();
        }

        public void InsertCommercialPlan(CommercialPlan commercialPlan)
        {
            repository.Add(commercialPlan);
        }

        public void ModifyCommercialPlan(CommercialPlan commercialPlan)
        {
            repository.Modify(commercialPlan);
        }

        public void DeleteCommercialPlan(int itemId)
        {
            CommercialPlan item = repository.GetById(itemId);
            item.status = "0";
            repository.Modify(item);
        }

    }
}
