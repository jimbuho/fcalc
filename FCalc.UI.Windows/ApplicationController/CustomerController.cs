
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

        public CustomerController()
        {
            service = new CustomerService();
            commercialPlanController = new CommercialPlanController();
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
                CustomerViewModel comPlanView = new CustomerViewModel();
                // Copio todos los campos que se llaman igual
               comPlanView = PropertyCopier<Customer, CustomerViewModel>.Copy(item, comPlanView);
                // Consulto el nombre del plan y lo lleno en el campo nuevo
                CommercialPlan planType = commercialPlanController.GetById(Convert.ToInt32(item.idCommercialplan));
                comPlanView.plantype = planType.name;
                // Agregar el registro procesado a la lista
               customerViewModelList.Add(comPlanView);
            }
            return customerViewModelList;
        }

        private PlanType GetCustomerById(int id)
        {
            return service.GetPlanById(id);
        }
    

        public List<CustomerViewModel> FindActiveCustomersByRUC(string RUC)
        {
            IEnumerable<Customer> activeCustomers = service.FindActiveCustomersByRUC(RUC);
            List<CustomerViewModel> customerViewModelList = new List<CustomerViewModel>();
            foreach (Customer item in activeCustomers)
            {
             customerViewModelList.Add(PropertyCopier<Customer, CustomerViewModel>.Copy(item, new CustomerViewModel()));
                
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
