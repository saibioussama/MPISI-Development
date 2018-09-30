using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App1CL.Repositories
{
    interface IRepository<T>
    {
        void Insert(T item);
        void Edit(T item);
        void Remove(string id);
        T Get(string id);
        List<T> Get();
        int Count();
    }
}
