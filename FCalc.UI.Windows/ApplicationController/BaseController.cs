using FCalc.Application.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using FCalc.UI.Windows.ViewModel;
using FCalc.Domain.Model.Entities;

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
        public delegate TEntity functionGetEntity(int x);

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

    public class PropertyCopier<TParent, TChild> where TParent : class
                                            where TChild : class
    {
        public static TChild Copy(TParent parent, TChild child)
        {
            var parentProperties = parent.GetType().GetProperties();
            var childProperties = child.GetType().GetProperties();

            foreach (var parentProperty in parentProperties)
            {
                foreach (var childProperty in childProperties)
                {
                    if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                    {
                        childProperty.SetValue(child, parentProperty.GetValue(parent));
                        break;
                    }
                }
            }
            return child;
        }


        public static TChild CopyToModify(TParent parent, TChild child)
        {
            var parentProperties = parent.GetType().GetProperties();
            var childProperties = child.GetType().GetProperties();

            foreach (var parentProperty in parentProperties)
            {
                if (parentProperty.Name != "creationDate" && parentProperty.Name != "status")
                {
                    foreach (var childProperty in childProperties)
                    {
                        
                        if (parentProperty.Name == childProperty.Name && parentProperty.PropertyType == childProperty.PropertyType)
                        {
                            var value = parentProperty.GetValue(parent);
                            Console.WriteLine("Modificando valor de " + parentProperty.Name+ " a " +value);
                            childProperty.SetValue(child, value);
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Valor de "+ parentProperty.Name+" no modificado");
                }
            }
            return child;
        }
    }
}
