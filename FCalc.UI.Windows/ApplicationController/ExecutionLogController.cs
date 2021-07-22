
using FCalc.Application.Service;
using FCalc.Domain.Model.Entities;
using FCalc.UI.windows.ApplicationController;
using FCalc.UI.Windows.ViewModel;
using System;
using System.Collections.Generic;

namespace FCalc.UI.Windows.ApplicationController
{
    public class ExecutionLogController:BaseController<ExecutionLog>
    {

        ExecutionLogService service;
        CustomerService customerService;
        PlanTypeController planTypeController;
        CommercialPlanController commercialPlanController;

        public ExecutionLogController()
        {
            service = new ExecutionLogService();
            customerService = new CustomerService();
            planTypeController = new PlanTypeController();
            commercialPlanController = new CommercialPlanController();
        }

        public bool ExecutionLogInsert(ExecutionLogViewModel executionLogViewModel)
        {
            try
            {
                ExecutionLog executionLog = PropertyCopier<ExecutionLogViewModel, ExecutionLog>.Copy(executionLogViewModel, new ExecutionLog());
                this.Save(executionLog, service.InsertExecutionLog);
                return true;
            }
            catch (Exception e)
            {
                Console.Write("Error al guardar", e);
                return false;
            }
        }

        public List<ExecutionLogViewModel> FindActiveExecutionLogs()
        {
            IEnumerable<ExecutionLog> activeExecutionLogs = service.FindActiveExecutionLog();
            return BindItemsExecutionLog(activeExecutionLogs);
        }

        public List<ExecutionLogViewModel> FindActiveExecutionLogsByDate(string date)
        {
            IEnumerable<ExecutionLog> activeExecutionLogs = service.FindExecutionLogByDate(date);
            return BindItemsExecutionLog(activeExecutionLogs);
        }

        private List<ExecutionLogViewModel> BindItemsExecutionLog(IEnumerable<ExecutionLog> activeExecutionLogs)
        {
            List<ExecutionLogViewModel> executionLogViewModelList = new List<ExecutionLogViewModel>();
            Customer customer = null;
            foreach (ExecutionLog executionLog in activeExecutionLogs)
            {
                ExecutionLogViewModel exeLog = new ExecutionLogViewModel();
                PropertyCopier<ExecutionLog, ExecutionLogViewModel>.Copy(executionLog, exeLog);
                customer = customerService.GetCustomerById((int)executionLog.idCustomer);
                exeLog.ruc = customer.ruc;
                exeLog = BindExtraInfo(exeLog, customer);
                executionLogViewModelList.Add(exeLog);
            }
            return executionLogViewModelList;
        }

        private ExecutionLogViewModel BindExtraInfo(ExecutionLogViewModel executionLogViewModel, Customer customer)
        {
            CommercialPlan commercialPlan = commercialPlanController.GetById(Convert.ToInt32(customer.idCommercialplan));
            PlanType planType = planTypeController.GetPlanTypeById(Convert.ToInt32(commercialPlan.idPlantype));
            executionLogViewModel.planType = planType.name;
            executionLogViewModel.planName = commercialPlan.name;
            executionLogViewModel.isDinamic = planType.isDynamic == true? "Si":"No";
            executionLogViewModel.isRange = planType.requireRange == true? "Si" : "No";

            return executionLogViewModel;
        }

        public void DisableExcecutionLogByDate(string date)
        {
            IEnumerable<ExecutionLog> activeExecutionLogs = service.FindExecutionLogByDate(date);

            foreach (ExecutionLog executionLog in activeExecutionLogs)
            {
                service.DeleteExecutionLog(executionLog.idExecutionlog);
            }            
        }

        public Boolean ThereAreExecutionLogsInThisMonth()
        {
            string date = DateTime.Now.ToString("yyyy-MM");
            List<ExecutionLogViewModel> executionLogs = FindActiveExecutionLogsByDate(date);
            return executionLogs.Count > 0;
        }
    }
}
