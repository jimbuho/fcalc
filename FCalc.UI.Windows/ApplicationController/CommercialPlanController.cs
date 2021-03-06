
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
        PlanTypeController planTypeController;

        public CommercialPlanController()
        {
            service = new CommercialPlanService();
            planTypeController = new PlanTypeController();
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
                CommercialPlanViewModel comPlanView = new CommercialPlanViewModel();
                // Copio todos los campos que se llaman igual
                comPlanView = PropertyCopier<CommercialPlan, CommercialPlanViewModel>.Copy(item, comPlanView);
                // Consulto el nombre del plan y lo lleno en el campo nuevo
                if (item.idPlantype != null)
                {
                    PlanType planType = planTypeController.GetPlanTypeById(Convert.ToInt32(item.idPlantype));
                  comPlanView.planType = planType.name;
                }
                // Agregar el registro procesado a la lista
                customerViewModelList.Add(comPlanView);
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

        public List<CommercialPlanViewModel> FindActiveCommercialPlanByName(string name, int except)
        {
            IEnumerable<CommercialPlan> activeCommercialPlans = service.FindActiveCommercialPlanBYName(name);
            List<CommercialPlanViewModel> customerViewModelList = new List<CommercialPlanViewModel>();
            foreach (CommercialPlan item in activeCommercialPlans)
            {
                if(item.idCommercialplan != except) { 
                    // Copio todos los campos que se llaman igual
                    customerViewModelList.Add(PropertyCopier<CommercialPlan, CommercialPlanViewModel>.Copy(item, new CommercialPlanViewModel()));
                }
            }
            return customerViewModelList;
        }
    }
}
