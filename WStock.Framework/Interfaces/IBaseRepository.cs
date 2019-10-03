using System.Collections.Generic;

namespace WStock.Framework.Interfaces
{
    public interface IBaseRepository<obj>
    {
        obj Save(obj entity);

        obj Insert(obj entity);

        obj Update(obj entity);

        bool Delete(obj entity);

        void Evict(obj entity);

        obj SelectById(object id);

        IEnumerable<obj> SelectAll();

        obj SelectByProperty(string property, object value);

        IEnumerable<obj> SelectAllByProperty(string property, object value);

        void Flush();
    }
}
