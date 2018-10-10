using ArticlesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Repos
{
    interface IRepository<T,I>
    {
        List<T> Get();

        T Get(I id);

        void Insert(T article);

        void Edit(T article);

        void Remove(I id);
    }
}
