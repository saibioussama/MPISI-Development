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

        int Insert(T article);

        int Edit(T article);

        int Remove(I id);
    }
}
