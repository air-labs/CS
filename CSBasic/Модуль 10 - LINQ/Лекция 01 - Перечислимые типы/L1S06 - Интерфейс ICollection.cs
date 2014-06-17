using System.Collections.Generic;
using System.Collections;
namespace L1S06
{
	public interface ICollection<T> : IEnumerable, IEnumerable<T>
	{
		int Count
		{
			get;
		}
		bool IsReadOnly
		{
			get;
		}
		void Add (T item);
		void Clear ();
		bool Contains (T item);
		void CopyTo (T[] array, int arrayIndex);
		bool Remove (T item);
	}
	
}

//!Интерфейс ICollection
