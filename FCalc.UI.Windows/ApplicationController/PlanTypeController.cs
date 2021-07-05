
using FCalc.Application.Service;
using FCalc.Domain.Model.Entities;
using FCalc.UI.windows.ApplicationController;
using FCalc.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;

namespace FCalc.UI.Windows.ApplicationController
{
    public class PlanTypeController:BaseController<PlanType>
    {
        PlanTypeService service;

        public PlanTypeController()
        {
            service = new PlanTypeService();
        }

        public bool PlanTypeInsert(PlanTypeViewModel planTypeViewModel)
        {
            try
            {
                PlanType planType = PropertyCopier<PlanTypeViewModel, PlanType>.Copy(planTypeViewModel, new PlanType());
                this.Save(planType, service.InsertPlanType);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al guardar", e);
                return false;
            }
        }

        public List<PlanTypeViewModel> FindActivePlanType()
        {
            IEnumerable<PlanType> activePlanTypes = service.FindActivePlanType();
            List<PlanTypeViewModel> customerViewModelList = new List<PlanTypeViewModel>(); 
            foreach(PlanType item in activePlanTypes)
            {
                customerViewModelList.Add(PropertyCopier<PlanType, PlanTypeViewModel>.Copy(item, new PlanTypeViewModel()));
            }
            return customerViewModelList;
        }
    }
}
