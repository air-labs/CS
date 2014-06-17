using System.Collections.Generic;
namespace L2S01
{
    public class MyList<T>
    {
        List<T> innerList=new List<T>();

        public void Add(T arg) { innerList.Add(arg); }

        public T this[int index]
        {
            get
            {
                return innerList[index];
            }
            set
            {
                innerList[index] = value;
            }
        }
    }
}

//!Создаем наш собственный List - генерик-класс с генерик-аргументом T