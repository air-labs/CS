using System.Collections.Generic;
using System.Collections;
class L1S01
{
    public static void Main() { }

	static void ProcessEnumerable(IEnumerable enumerable)
	{
		int sum=0;
		foreach(int e in enumerable)
			sum+=e;
	}	
	
	static void ProcessGenericEnumerable(IEnumerable<int> enumerable)
	{
		int sum=0;
		foreach(var e in enumerable)
			sum+=e;
	}
}

//!Перечислимый тип: все, что с ним можно сделать - это перечислить foreach 