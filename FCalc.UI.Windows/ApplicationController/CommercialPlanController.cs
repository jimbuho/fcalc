
using FCalc.Application.Service;
using FCalc.Domain.Model.Entities;
using FCalc.UI.windows.ApplicationController;
using FCalc.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;

namespace FCalc.UI.Windows.ApplicationController
{
    public class CommercialPlanController:BaseController<CommercialPlan>
    {
        CommercialPlanService service;

        public CommercialPlanController()
        {
            service = new CommercialPlanService();
        }

        public bool CommercialPlanInsert(CommercialPlanViewModel commercialPlanViewModel)
        {
            try
            {
                CommercialPlan commercialPlan = PropertyCopier<CommercialPlanViewModel, CommercialPlan>.Copy(commercialPlanViewModel, new CommercialPlan());
                this.Save(commercialPlan, service.InsertCommercialPlan);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al guardar", e);
                return false;
            }
        }

        public List<CommercialPlanViewModel> FindActiveCommercialPlan()
        {
            IEnumerable<CommercialPlan> activeCommercialPlans = service.FindActiveCommercialPlan();
            List<CommercialPlanViewModel> customerViewModelList = new List<CommercialPlanViewModel>(); 
            foreach(CommercialPlan item in activeCommercialPlans)
            {
                customerViewModelList.Add(PropertyCopier<CommercialPlan, CommercialPlanViewModel>.Copy(item, new CommercialPlanViewModel()));
            }
            return customerViewModelList;
        }
    }
}
