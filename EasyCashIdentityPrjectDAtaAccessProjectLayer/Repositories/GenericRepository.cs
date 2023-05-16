using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EasyCashIdentityPrject.DataAccessLayer.Cancrete;
using EasyCashIdentityProject.DataAccessLayer.Abstract;

namespace EasyCashIdentityProject.DataAccessLayer.Repositories
{
    public class GenericRepository<T> : IGenericDal<T> where T : class

    {
        public void Delete(T t)
        {
            using var context = new Context();
            context.Set<T>().Remove(t);
            context.SaveChanges();
        }

        public T GetByID(T id)
        {
            using var context = new Context();
            return context.Set<T>().Find(id);
        }

        public T GetByID(int id)
        {
            using var context = new Context();
            return context.Set<T>().Find();
        }

        public List<T> GetList()
        {
            using var context = new Context();
            return context.Set<T>().ToList();
        }

        public void Insert(T t)
        {
            using var context = new Context();
            context.Set<T>().Add(t);
            context.SaveChanges();
        }

        public void Update(T t)
        {
            using var context = new Context();
            context.Set<T>().Update(t);
            context.SaveChanges();
        }
    }
}



