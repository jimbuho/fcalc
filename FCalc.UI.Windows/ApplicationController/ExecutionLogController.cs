
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

        public ExecutionLogController()
        {
            service = new ExecutionLogService();
            customerService = new CustomerService();
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
                executionLogViewModelList.Add(exeLog);
            }
            return executionLogViewModelList;
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
