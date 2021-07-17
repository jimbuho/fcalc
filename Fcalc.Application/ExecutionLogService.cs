
using System.Collections.Generic;
using System;
using FCalc.Domain.Model.Abstractions;
using FCalc.DataAccess.Repository;
using FCalc.Domain.Model.Entities;

namespace FCalc.Application.Service
{
    public class ExecutionLogService
    {
        readonly IExecutionLogRepository repository;

        public ExecutionLogService()
        {
            repository = new ExecutionLogRepository();
        }

        public IEnumerable<ExecutionLog> GetExecutionLog()
        {
            return repository.GetAll();
        }

        public IEnumerable<ExecutionLog> FindActiveExecutionLog()
        {
            return repository.FindActiveExecutionLog();
        }

        public IEnumerable<ExecutionLog> FindExecutionLogByDate(string date)
        {
            return repository.FindExecutionLogByDate(date);
        }

        public void InsertExecutionLog(ExecutionLog executionLog)
        {
            repository.Add(executionLog);
        }

        public void ModifyExecutionLog(ExecutionLog executionLog)
        {
            repository.Modify(executionLog);
        }
        public void DeleteExecutionLog(int itemId)
        {
            ExecutionLog item = repository.GetById(itemId);
            item.status = "0";
            repository.Modify(item);
        }
    }
}
