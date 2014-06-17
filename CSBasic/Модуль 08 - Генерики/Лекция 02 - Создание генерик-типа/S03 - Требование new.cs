using System.Collections.Generic;
namespace L2S03
{
    public class MyList<T>
        where T : new()
    {
        List<T> innerList=new List<T>();

        public void Add(T arg) { innerList.Add(arg); }

        public T this[int index]
        {
            get
            {
                if (index >= innerList.Count) return default(T);
                return innerList[index];
            }
            set
            {
                while (index >= innerList.Count)
                    innerList.Add(new T());
                innerList[index] = value;
            }
        }
    }
}
//!new T() - конструктор по умолчанию