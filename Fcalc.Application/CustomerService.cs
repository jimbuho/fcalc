
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

        public void InsertCustomer(Customer customer)
        {
            repository.Add(customer);
        }

        public void ModifyCustomer(Customer customer)
        {
            repository.Modify(customer);
        }

    }
}
