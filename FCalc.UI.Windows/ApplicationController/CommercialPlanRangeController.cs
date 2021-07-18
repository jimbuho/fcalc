
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
        CommercialPlanController commercialPlanController;

        public CommercialPlanRangeController()
        {
            service = new CommercialPlanRangeService();
            commercialPlanController = new CommercialPlanController();
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
                CommercialPlanRangeViewModel comPlanView = new CommercialPlanRangeViewModel();
                // Copio todos los campos que se llaman igual
                comPlanView = PropertyCopier<CommercialPlanRange, CommercialPlanRangeViewModel>.Copy(item,comPlanView);
                // Consulto el nombre del plan y lo lleno en el campo nuevo
                CommercialPlan planType = commercialPlanController.GetById(Convert.ToInt32(item.idCommercialplan));
                comPlanView.planType1 = planType.name;
                // Agregar el registro procesado a la lista
                customerViewModelList.Add(comPlanView);
            }
            return customerViewModelList;
        }

        public List<CommercialPlanRangeViewModel> GetCommercialPlanRangeByCommecialPlan(CommercialPlan commercialPlan)
        {
            IEnumerable<CommercialPlanRange> activeCommercialPlanRanges = service.GetCommercialPlanRangeByCommecialPlan(commercialPlan);
            List<CommercialPlanRangeViewModel> customerViewModelList = new List<CommercialPlanRangeViewModel>();
            foreach (CommercialPlanRange item in activeCommercialPlanRanges)
            {
                customerViewModelList.Add(PropertyCopier<CommercialPlanRange, CommercialPlanRangeViewModel>.Copy(item, new CommercialPlanRangeViewModel()));
            }
            return customerViewModelList;
        }

        public List<CommercialPlanRangeViewModel> GetCommercialPlanRangeByCommecialPlan(int commercialPlanId)
        {
            IEnumerable<CommercialPlanRange> activeCommercialPlanRanges = service.GetCommercialPlanRangeByCommecialPlan(commercialPlanId);
            List<CommercialPlanRangeViewModel> customerViewModelList = new List<CommercialPlanRangeViewModel>();
            foreach (CommercialPlanRange item in activeCommercialPlanRanges)
            {
                customerViewModelList.Add(PropertyCopier<CommercialPlanRange, CommercialPlanRangeViewModel>.Copy(item, new CommercialPlanRangeViewModel()));
            }
            return customerViewModelList;
        }

        public bool CommercialPlanRangeModify(CommercialPlanRangeViewModel commercialPlanRangeViewModel)
        {
            try
            {
                // Obtiene el registro que esta guardado en la base de datos dado el id
                CommercialPlanRange commercialPlanRange = service.GetCommercialPlanRangeById(commercialPlanRangeViewModel.idPlanrange);
                // Copia los valores del plan que viene desde la pantalla (planTypeViewModel) y
                // los pasa al registro consultado de la base de datos
                // Nota: Aqui, a diferencia de lo usado en el metodo Insert, se usa CopyToModify
                commercialPlanRange = PropertyCopier<CommercialPlanRangeViewModel, CommercialPlanRange>.CopyToModify(commercialPlanRangeViewModel, commercialPlanRange);
                // Guarda el registro final modificado en la base de datos
                service.ModifyCommercialPlanRange(commercialPlanRange);
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
                service.DeleteCommercialPlanRange(id);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al eliminar", e);
                return false;
            }
        }
    }
}
