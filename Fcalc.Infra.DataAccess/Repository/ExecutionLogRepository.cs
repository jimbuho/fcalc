
using Fcalc.Infra.DataAccess;
using FCalc.Domain.Model.Abstractions;
using FCalc.Domain.Model.Entities;
using FCalc.Infra.DataAccess.Repository;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FCalc.DataAccess.Repository
{
    public class ExecutionLogRepository : BaseRepository<ExecutionLog>, IExecutionLogRepository
    {
        public IEnumerable<ExecutionLog> FindActiveExecutionLog()
        {
            try
            {

                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.ExecutionLog
                                where c.status == "1"
                                select c;

                    return query.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se puede procesar consulta", e);
            }
        }

        public IEnumerable<ExecutionLog> FindExecutionLogByDate(string date)
        {
            try
            {
                DateTime startDate = Convert.ToDateTime(date + "-01");
                DateTime endDate = Convert.ToDateTime(date + "-28");

                using (FcalcDBEntities1 context = new FcalcDBEntities1())
                {
                    var query = from c in context.ExecutionLog
                                where c.creationDate >= startDate && c.creationDate <= endDate
                                select c;

                    return query.ToList();
                }
            }
            catch (Exception e)
            {
                throw new Exception("No se puede procesar consulta", e);
            }
        }

    }
}
