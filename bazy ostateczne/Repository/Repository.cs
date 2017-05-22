using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;

namespace bazy_ostateczne.Repository
{
    public class Repository<T> : IRepository<T> where T : class, IIdentity
    {
        public int Add(T entity)
        {
            using (var context = new Models.BazyDbContext())
            {
                entity.DateCreated = DateTime.Now;
                entity.DateModified = DateTime.Now;
                context.Set<T>().Add(entity);
                context.SaveChanges();
                return entity.ID;
            }
        }

        public void Add(List<T> entities)
        {
            using (var context = new Models.BazyDbContext())
            {
                foreach (var entity in entities)
                {
                    entity.DateCreated = DateTime.Now;
                    entity.DateModified = DateTime.Now;
                    context.Set<T>().Add(entity);
                }
                context.SaveChanges();
            }
        }

        public void Update(T entity)
        {
            entity.DateModified = DateTime.Now;

            using (var context = new Models.BazyDbContext())
            {
                context.Set<T>().Attach(entity);
                context.Entry<T>(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Update(List<T> entities)
        {
            using (var context = new Models.BazyDbContext())
            {
                foreach (var entity in entities)
                {
                    entity.DateModified = DateTime.Now;
                    context.Set<T>().Attach(entity);
                    context.Entry<T>(entity).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public void Delete(T entity)
        {
            using (var context = new Models.BazyDbContext())
            {
                entity.IsDeleted = true;
                context.Set<T>().Attach(entity);
                context.Entry<T>(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void Delete(List<T> entities)
        {
            using (var context = new Models.BazyDbContext())
            {
                foreach (var entity in entities)
                {
                    entity.IsDeleted = true;
                    context.Set<T>().Attach(entity);
                    context.Entry<T>(entity).State = EntityState.Modified;
                }
                context.SaveChanges();
            }
        }

        public T FindById(int id, params Expression<Func<T, object>>[] includeItems)
        {
            using (var context = new Models.BazyDbContext())
            {
                var result = context.Set<T>() as IQueryable<T>;
                foreach (var include in includeItems)
                {
                    result = result.Include(include);
                }
                return result.FirstOrDefault(x => x.ID == id && !x.IsDeleted);
            }
        }

        public List<T> Find(Func<T, bool> filter, params Expression<Func<T, object>>[] includeItems)
        {
            using (var context = new Models.BazyDbContext())
            {
                var result = context.Set<T>() as IQueryable<T>;
                foreach (var include in includeItems)
                {
                    result = result.Include(include);
                }
                return result.Where(x => !x.IsDeleted).Where(filter).ToList();
            }
        }

        public bool Any(Func<T, bool> filter, params Expression<Func<T, object>>[] includeItems)
        {
            using (var context = new Models.BazyDbContext())
            {
                var result = context.Set<T>() as IQueryable<T>;
                foreach (var include in includeItems)
                {
                    result = result.Include(include);
                }
                return result.Where(x => !x.IsDeleted).Where(filter).Any();
            }
        }

        public bool ContainsAny(params Expression<Func<T, object>>[] includeItems)
        {
            using (var context = new PGSParkingContext())
            {
                return context.Set<T>().Any();
            }
        }

        public List<T> FindAll(params Expression<Func<T, object>>[] includeItems)
        {
            using (var context = new Models.BazyDbContext())
            {
                var result = context.Set<T>() as IQueryable<T>;
                foreach (var include in includeItems)
                {
                    result = result.Include(include);
                }
                return result.Where(x => !x.IsDeleted).ToList();
            }
        }

        //public PagedData<T> FindAll(Func<T, bool> filter, Func<T, object> order, bool? desc, int page, int pageSize, params Expression<Func<T, object>>[] includeItems) {
        //    using (var context = new PGSLocatorContext()) {
        //        var result = context.Set<T>() as IQueryable<T>;
        //        foreach (var include in includeItems) {
        //            result = result.Include(include);
        //        }
        //        result = result.Where(x => !x.IsDeleted);
        //        var result2 = result.Where(filter);
        //        var count = result2.Count();
        //        return new PagedData<T>(result2, order, desc, page, pageSize, count);
        //    }
        //}
    }
}
