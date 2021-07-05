
using FCalc.Application.Service;
using FCalc.Domain.Model.Entities;
using FCalc.UI.windows.ApplicationController;
using FCalc.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;

namespace FCalc.UI.Windows.ApplicationController
{
    public class CommercialPlanRangeController:BaseController<CommercialPlanRange>
    {
        CommercialPlanRangeService service;

        public CommercialPlanRangeController()
        {
            service = new CommercialPlanRangeService();
        }

        public bool CommercialPlanRangeInsert(CommercialPlanRangeViewModel commercialPlanRangeViewModel)
        {
            try
            {
                CommercialPlanRange commercialPlanRange = PropertyCopier<CommercialPlanRangeViewModel, CommercialPlanRange>.Copy(commercialPlanRangeViewModel, new CommercialPlanRange());
                this.Save(commercialPlanRange, service.InsertCommercialPlanRange);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al guardar", e);
                return false;
            }
        }

        public List<CommercialPlanRangeViewModel> FindActiveCommercialPlanRange()
        {
            IEnumerable<CommercialPlanRange> activeCommercialPlanRanges = service.FindActiveCommercialPlanRange();
            List<CommercialPlanRangeViewModel> customerViewModelList = new List<CommercialPlanRangeViewModel>(); 
            foreach(CommercialPlanRange item in activeCommercialPlanRanges)
            {
                customerViewModelList.Add(PropertyCopier<CommercialPlanRange, CommercialPlanRangeViewModel>.Copy(item, new CommercialPlanRangeViewModel()));
            }
            return customerViewModelList;
        }
    }
}
