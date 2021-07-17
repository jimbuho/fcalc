
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

        public ExecutionLogController()
        {
            service = new ExecutionLogService();
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

            List<ExecutionLogViewModel> executionLogViewModelList = new List<ExecutionLogViewModel>(); 
            foreach(ExecutionLog executionLog in activeExecutionLogs)
            {
                executionLogViewModelList.Add(PropertyCopier<ExecutionLog, ExecutionLogViewModel>.Copy(executionLog, new ExecutionLogViewModel()));
            }
            return executionLogViewModelList;
        }

        public List<ExecutionLogViewModel> FindActiveExecutionLogsByDate(string date)
        {
            IEnumerable<ExecutionLog> activeExecutionLogs = service.FindExecutionLogByDate(date);

            List<ExecutionLogViewModel> executionLogViewModelList = new List<ExecutionLogViewModel>();
            foreach (ExecutionLog executionLog in activeExecutionLogs)
            {
                executionLogViewModelList.Add(PropertyCopier<ExecutionLog, ExecutionLogViewModel>.Copy(executionLog, new ExecutionLogViewModel()));
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
