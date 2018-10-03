using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListApp
{
    public class MyList<T> : IEnumerable
    {
        public Item<T> Head { get; set; }

        private static int Length;

        static MyList()
        {
            Length = 0;
        }
        public MyList() { }

        public void Add(T item)
        {
            if (Head == null)
            {
                Head = new Item<T>()
                {
                    Value = item,
                    Next = null
                };
                return;
            }
            var _Head = Head;
            while (_Head.Next != null)
            {
                _Head = _Head.Next;
            }
            _Head.Next = new Item<T>()
            {
                Value = item,
                Next = null
            };

            Length++;
        }

        public void Remove()
        {
            var _Head = Head;
            while (_Head.Next.Next != null)
            {
                _Head = _Head.Next;
            }
            _Head.Next = null;
            Length--;
        }

        public void RemoveAt(int i)
        {
            var _Head = Head;
            var _i = 1;
            while (_Head != null && _i < i - 1)
            {
                _Head = _Head.Next;
                _i++;
            }
            _Head.Next = _Head.Next.Next;
            Length--;
        }

        public T GetItem(int index)
        {
            int _index = 0;
            var _Head = Head;
            while (_Head != null && _index < index)
            {
                _Head = _Head.Next;
                _index++;
            }
            if (_index == index)
                return _Head.Value;
            return _Head.Next.Value;
        }

        public IEnumerator GetEnumerator()
        {
            var _Head = Head;
            while (_Head != null)
            {
                yield return _Head.Value;
                _Head = _Head.Next;
            }
        }

        public void Show()
        {
            var _Head = Head;
            while (_Head != null)
            {
                Console.WriteLine(_Head.Value);
                _Head = _Head.Next;
            }
        }
    }
}
