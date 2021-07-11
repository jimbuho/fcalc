using Fcalc.Infra.DataAccess;
using FCalc.Domain.Model.Abstractions;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;

namespace FCalc.Infra.DataAccess.Repository
{
    public class BaseRepository<TEntity>: IDisposable, IBaseRepository<TEntity> where TEntity: class
    {
       
        void IBaseRepository<TEntity>.Add(TEntity entity)
        {
            try
            {
                using (var context = new FcalcDBEntities1())
                {
                    context.Set<TEntity>().Add(entity);
                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (DbEntityValidationResult eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("{ADD} Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (DbValidationError ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("{ADD} - Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

        void IBaseRepository<TEntity>.Dispose()
        {
            throw new NotImplementedException();
        }

        IEnumerable<TEntity> IBaseRepository<TEntity>.GetAll()
        {
            using (var context = new FcalcDBEntities1())
            {
                return context.Set<TEntity>().ToList();
            }
        }

        TEntity IBaseRepository<TEntity>.GetById(int id)
        {
            using (var context = new FcalcDBEntities1())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        void IBaseRepository<TEntity>.Modify(TEntity entity)
        {
            try
            {
                using (var context = new FcalcDBEntities1())
                {
                    context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (DbEntityValidationException e)
            {
                foreach (DbEntityValidationResult eve in e.EntityValidationErrors)
                {
                    Console.WriteLine("{MODIFY} Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (DbValidationError ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("{MODIFY} - Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: "+e);
                throw;
            }
        }
    }
}
