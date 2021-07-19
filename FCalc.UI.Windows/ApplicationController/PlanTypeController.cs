
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
                // Copia rapida de los valores entre PlanTypeViewModel y PlanType
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
                // Permite una copia rapida de los campos entre el tipo PlanType y PlanTypeViewModel
                customerViewModelList.Add(PropertyCopier<PlanType, PlanTypeViewModel>.Copy(item, new PlanTypeViewModel()));
            }
            return customerViewModelList;
        }

        public bool PlanTypeModify(PlanTypeViewModel planTypeViewModel)
        {
            try
            {
                // Obtiene el registro que esta guardado en la base de datos dado el id
                PlanType planType = service.GetPlanById(planTypeViewModel.idPlantype);
                // Copia los valores del plan que viene desde la pantalla (planTypeViewModel) y
                // los pasa al registro consultado de la base de datos
                // Nota: Aqui, a diferencia de lo usado en el metodo Insert, se usa CopyToModify
                planType = PropertyCopier<PlanTypeViewModel, PlanType>.CopyToModify(planTypeViewModel, planType);
                // Guarda el registro final modificado en la base de datos
                service.ModifyPlanType(planType);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al actualizar", e);
                return false;
            }
        }

        public bool PlanTypeDelete(int id)
        {
            try
            {
                service.DeletePlanType(id);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al eliminar", e);
                return false;
            }
        }

        public PlanType GetPlanTypeById(int id)
        {
            return service.GetPlanById(id);
        }

        public List<PlanTypeViewModel> FindActivePlanTypeByName(string name, int except)
        {
            IEnumerable<PlanType> activePlanTypes = service.FindActivePlanTypeByName(name);
            List<PlanTypeViewModel> customerViewModelList = new List<PlanTypeViewModel>();
            foreach (PlanType item in activePlanTypes)
            {
                if (item.idPlantype != except)
                {
                    // Permite una copia rapida de los campos entre el tipo PlanType y PlanTypeViewModel
                    customerViewModelList.Add(PropertyCopier<PlanType, PlanTypeViewModel>.Copy(item, new PlanTypeViewModel()));
                }
            }
            return customerViewModelList;
        }

    }
}
