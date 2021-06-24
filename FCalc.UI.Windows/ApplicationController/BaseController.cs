using FCalc.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace FCalc.UI.windows.ApplicationController
{
    /*  
     * Esta es la clase base para todos los Controller de esta aplicacion
     */
    public class BaseController<TEntity>
    {
        
        public BaseController()
        {
        }

        public delegate void functionDelegateType(TEntity x);

        public void Save(TEntity entity, functionDelegateType saveFunction)
        {
            Type entityType = entity.GetType();
            PropertyInfo status = entityType.GetProperty("status");
            status.SetValue(entity, "1", null);

            PropertyInfo creationDate = entityType.GetProperty("creationDate");
            creationDate.SetValue(entity, DateTime.UtcNow, null);

            saveFunction(entity);
        }
    }
}
