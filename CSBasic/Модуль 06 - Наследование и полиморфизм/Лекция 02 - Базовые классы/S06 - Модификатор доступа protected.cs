using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace L1S06
{
    public class BaseClass
    {
        private void PrivateMethod() { }
        protected void ProtectedMethod() { }
        internal protected void InternalProtectedMethod() { }
        public void PublicMethod() { }
    }

    public class InheritedClass : BaseClass
    {
        void SomeMethod()
        {
            //PrivateMethod(); // Нельзя обращаться к private-методам
            ProtectedMethod();
            InternalProtectedMethod();
            PublicMethod();
        }
    }

    public class OtherClass
    {
        void SomeMethod()
        {
            var obj = new BaseClass();
            obj.PublicMethod();
            //obj.ProtectedMethod(); // Обращаться к protected-методам можно только из наследников
            obj.InternalProtectedMethod(); // Не будет работать из другой сборки
            //PrivateMethod(); // Нельзя обращаться к private-методам
        }
    }

}