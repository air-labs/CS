using System.Collections.Generic;
namespace L2S02
{
    public class MyList<T>
    {
        List<T> innerList=new List<T>();

        public void Add(T arg) { innerList.Add(arg); }

        public T this[int index]
        {
            get
            {
                // if (index >= innerList.Count) return null; //ошибка: вдруг T - это int?
                if (index >= innerList.Count) return default(T);
                return innerList[index];
            }
            set
            {
                innerList[index] = value;
            }
        }
    }
}

//!default(T) - значение по умолчанию