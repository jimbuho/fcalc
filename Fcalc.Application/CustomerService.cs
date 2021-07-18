
using System.Collections.Generic;
using System;
using FCalc.Domain.Model.Abstractions;
using FCalc.DataAccess.Repository;
using FCalc.Domain.Model.Entities;

namespace FCalc.Application.Service
{
    public class CustomerService
    {
        readonly ICustomerRepository repository;

        public CustomerService()
        {
            repository = new CustomerRepository();
            
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return repository.GetAll();
        }
        public Customer GetCustomerById(int id)
        {
            return repository.GetById(id);
        }

        public IEnumerable<Customer> FindActiveCustomers()
        {
            return repository.FindActiveCustomers();
        }
        public IEnumerable<Customer> FindActiveCustomersByRUC(string RUC)
        {
            return repository.FindActiveCustomersByRUC(RUC);
        }

        public void InsertCustomer(Customer customer)
        {
            repository.Add(customer);
        }

        public void ModifyCustomer(Customer customer)
        {
            repository.Modify(customer);
        }

        public void DeleteCustomer(int itemId)
        {
            Customer item = repository.GetById(itemId);
            item.status = "0";
            repository.Modify(item);
        }

        public PlanType GetPlanById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
