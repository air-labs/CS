using System;
namespace L2S04
{
    //паттер Disposable: 
    //1. очистка памяти по требованию и по сборке мусора
    //2. работа с управляемыми и неуправляемыми ресурсами
	class DisposableClass : IDisposable
	{ 
  	private bool isDisposed = false;

  	~DisposableClass()
  	{ 
	    Dispose(false); 
  	}  

  	public void Dispose()
  	{
	    Dispose(true);
	    GC.SuppressFinalize(this); //деструктор не будет вызываться
  	} 

  	protected virtual void Dispose(bool fromDisposeMethod)
  	{
	    if (!isDisposed)
	    {
            if (fromDisposeMethod)
      		{
        	    //очистка управляемых ресурсов
      		}
        	// очистка неуправляемых ресурсов
        	isDisposed = false;
        	// base.Dispose(isDisposing); // если унаследован от Disposable класса
		}
	}
	}
}