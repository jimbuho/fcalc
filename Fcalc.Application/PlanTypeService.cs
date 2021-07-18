
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

        public PlanType GetPlanById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<PlanType> FindActivePlanType()
        {
            return repository.FindActivePlanType();
        }

        public IEnumerable<PlanType> FindActivePlanTypeByName(string name)
        {
            return repository.FindActivePlanTypeByName(name);
        }

        public void InsertPlanType(PlanType planType)
        {
            repository.Add(planType);
        }

        public void ModifyPlanType(PlanType planType)
        {
            repository.Modify(planType);
        }

        public void DeletePlanType(int itemId)
        {
            // Consulta el registro de la base de datos por su id, le cambia el estado a 0
            // y con ello el registro se muestra como eliminado
            PlanType item = repository.GetById(itemId);
            item.status = "0";
            repository.Modify(item);
        }
    }
}
