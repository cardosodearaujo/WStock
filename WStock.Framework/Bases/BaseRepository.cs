using WStock.Framework.Conversion;
using WStock.Framework.Interfaces;
using NHibernate;
using NHibernate.Criterion;
using System.Collections.Generic;
using WStock.Framework.NHibernate;

namespace WStock.Framework.Bases
{
    public class BaseRepository<obj> : IBaseRepository<obj>
    {
        public ISession session { get; set; }

        public BaseRepository()
        {
            StartSession();
        }

        public void StartSession()
        {
            session = NHibernateGetSession.Session();
        }   

        public obj Save(obj entity)
        {
            session.SaveOrUpdate(entity);
            session.Flush();
            return entity;
        }

        public obj Insert(obj entity)
        {
            session.Save(entity);
            session.Flush();
            return entity;
        }

        public obj Update(obj entity)
        {
            session.Update(entity);
            session.Flush();
            return entity;
        }

        public bool Delete(obj entity)
        {
            session.Delete(entity);
            session.Flush();
            return true;
        }

        public void Evict(obj entity)
        {
            session.Evict(entity);
        }
        public obj SelectById(object id)
        {
            return session.Get<obj>(id);
        }

        public IEnumerable<obj> SelectAll()
        {
            return session
                .CreateCriteria(typeof(obj))
                .List<obj>();
        }
        
        public obj SelectByProperty(string property, object value)
        {
            value = VerifyType.ConvertProperty(property, value, typeof(obj));
            return session
                .CreateCriteria(typeof(obj))
                .Add(Expression.Eq(property, value))
                .UniqueResult<obj>();
        }
        public IEnumerable<obj> SelectAllByProperty(string property, object value)
        {
            value = VerifyType.ConvertProperty(property, value, typeof(obj));
            return session
                .CreateCriteria(typeof(obj))
                .Add(Expression.Eq(property, value))
                .List<obj>();
        } 
        
        public void Flush()
        {
            if (session != null && session.IsOpen) session.Flush();           
        }
    }
}
