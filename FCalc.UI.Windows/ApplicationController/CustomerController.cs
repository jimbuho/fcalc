
using FCalc.Application.Service;
using FCalc.Domain.Model.Entities;
using FCalc.UI.windows.ApplicationController;
using FCalc.UI.Windows.ModelView;
using System;
using System.Collections.Generic;

namespace ACMEBodegas.UI.Windows.ApplicationController
{
    public class CustomerController:BaseController<Customer>
    {

        CustomerService service;

        public CustomerController()
        {
            service = new CustomerService();
        }

        public bool CustomerInsert(CustomerViewModel customerViewModel)
        {
            Customer customer = new Customer();

            try
            {
                customer.legalName = customerViewModel.legalName;
                customer.ruc = customerViewModel.ruc;
                this.Save(customer, service.InsertCustomer);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al guardar", e);
                return false;
            }
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return (IEnumerable<Customer>)service.GetCustomers();
        }
    }
}
