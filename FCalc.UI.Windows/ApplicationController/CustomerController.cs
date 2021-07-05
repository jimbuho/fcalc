
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

        public CustomerController()
        {
            service = new CustomerService();
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
            foreach (Customer customer in activeCustomers)
            {
                customerViewModelList.Add(PropertyCopier<Customer, CustomerViewModel>.Copy(customer, new CustomerViewModel()));
            }
            return customerViewModelList;
        }
    }
}
