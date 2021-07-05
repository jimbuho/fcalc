﻿
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

        public void InsertExecutionLog(ExecutionLog executionLog)
        {
            repository.Add(executionLog);
        }

        public void ModifyExecutionLog(ExecutionLog executionLog)
        {
            repository.Modify(executionLog);
        }
    }
}
