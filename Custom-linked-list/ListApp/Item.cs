using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    public class Item<T>
    {
        public T Value { get; set; }
        public Item<T> Next { get; set; }
    }
}
