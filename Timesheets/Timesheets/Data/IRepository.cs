using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Timesheets.Data
{
    public interface IRepository<T>
    {
        T GetItem(Guid id);
        IEnumerable<T> GetItems();
        void Add(T item);
        void Update();
    }
}
