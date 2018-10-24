using ArticlesApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArticlesApp.Repos
{
    interface IRepository<T,I>
    {
        List<T> Get();

        T Get(I id);

        int Insert(T article,SqlTransaction transaction=null);

        int Edit(T article, SqlTransaction transaction = null);

        int Remove(I id, SqlTransaction transaction = null);
    }
}
