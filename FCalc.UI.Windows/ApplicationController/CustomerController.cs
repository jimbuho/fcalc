
using FCalc.Application.Service;
using FCalc.Domain.Model.Entities;
using FCalc.UI.windows.ApplicationController;
using FCalc.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;

namespace FCalc.UI.Windows.ApplicationController
{
    public class CustomerController : BaseController<Customer>
    {

        CustomerService service;
        CommercialPlanController commercialPlanController;
        PlanTypeController planTypeController;

        public CustomerController()
        {
            service = new CustomerService();
            commercialPlanController = new CommercialPlanController();
            planTypeController = new PlanTypeController();
        }

        public bool CustomerInsert(CustomerViewModel customerViewModel)
        {
            try
            {
                Customer customer = PropertyCopier<CustomerViewModel, Customer>.Copy(customerViewModel, new Customer());
                this.Save(customer, service.InsertCustomer);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al guardar", e);
                return false;
            }
        }

        public List<CustomerViewModel> FindActiveCustomers()
        {
            IEnumerable<Customer> activeCustomers = service.FindActiveCustomers();
            List<CustomerViewModel> customerViewModelList = new List<CustomerViewModel>();
            foreach (Customer item in activeCustomers)
            {
                CustomerViewModel customerViewModel = new CustomerViewModel();
                // Copio todos los campos que se llaman igual
                customerViewModel = PropertyCopier<Customer, CustomerViewModel>.Copy(item, customerViewModel);
                // Consulto el nombre del plan y lo lleno en el campo nuevo
                if (item.idCommercialplan != null)
                {
                    CommercialPlan plan = commercialPlanController.GetById(Convert.ToInt32(item.idCommercialplan));
                    customerViewModel.planName = plan.name;
                    PlanType planType = planTypeController.GetPlanTypeById(Convert.ToInt32(plan.idPlantype));
                    customerViewModel.planType = planType.name;
                }
                
                // Agregar el registro procesado a la lista
                customerViewModelList.Add(customerViewModel);
            }
            return customerViewModelList;
        }

        private PlanType GetCustomerById(int id)
        {
            return service.GetPlanById(id);
        }
    

        public List<CustomerViewModel> FindActiveCustomersByRUC(string RUC, int except)
        {
            IEnumerable<Customer> activeCustomers = service.FindActiveCustomersByRUC(RUC);
            List<CustomerViewModel> customerViewModelList = new List<CustomerViewModel>();
            foreach (Customer item in activeCustomers)
            {
                if (item.idCustomer != except)
                {
                    customerViewModelList.Add(PropertyCopier<Customer, CustomerViewModel>.Copy(item, new CustomerViewModel()));
                }
            }
            return customerViewModelList;
        }
        public bool CustomerModify(CustomerViewModel customerViewModel)
        {
            try
            {
                // Obtiene el registro que esta guardado en la base de datos dado el id
                Customer customer = service.GetCustomerById(customerViewModel.idCustomer);
                // Copia los valores del plan que viene desde la pantalla (planTypeViewModel) y
                // los pasa al registro consultado de la base de datos
                // Nota: Aqui, a diferencia de lo usado en el metodo Insert, se usa CopyToModify
                customer = PropertyCopier<CustomerViewModel, Customer>.CopyToModify(customerViewModel, customer);
                // Guarda el registro final modificado en la base de datos
                service.ModifyCustomer(customer);
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
                service.DeleteCustomer(id);
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
