
using System.Collections.Generic;
using System;
using FCalc.Domain.Model.Abstractions;
using FCalc.DataAccess.Repository;
using FCalc.Domain.Model.Entities;

namespace FCalc.Application.Service
{
    public class PlanTypeService
    {
        readonly IPlanTypeRepository repository;

        public PlanTypeService()
        {
            repository = new PlanTypeRepository();
        }

        public IEnumerable<PlanType> GetPlanTypes()
        {
            return repository.GetAll();
        }

        public IEnumerable<PlanType> FindActivePlanType()
        {
            return repository.FindActivePlanType();
        }

        public void InsertPlanType(PlanType planType)
        {
            repository.Add(planType);
        }

        public void ModifyPlanType(PlanType planType)
        {
            repository.Modify(planType);
        }
    }
}
