
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
        public bool CommercialPlanModify(CommercialPlanViewModel commercialPlanViewModel)
        {
            try
            {
                // Obtiene el registro que esta guardado en la base de datos dado el id
                CommercialPlan commercialPlan = service.GetCommercialPlanById(commercialPlanViewModel.idCommercialplan);
                // Copia los valores del plan que viene desde la pantalla (planTypeViewModel) y
                // los pasa al registro consultado de la base de datos
                // Nota: Aqui, a diferencia de lo usado en el metodo Insert, se usa CopyToModify
                commercialPlan = PropertyCopier<CommercialPlanViewModel, CommercialPlan>.CopyToModify(commercialPlanViewModel, commercialPlan);
                // Guarda el registro final modificado en la base de datos
                service.ModifyCommercialPlan(commercialPlan);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al actualizar", e);
                return false;
            }
        }

        public bool CustomerDelete(int id)
        {
            try
            {
                service.DeleteCommercialPlan(id);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al eliminar", e);
                return false;
            }
        }

        public CommercialPlan GetById(int id)
        {
            return service.GetCommercialPlanById(id);
        }
    }
}
