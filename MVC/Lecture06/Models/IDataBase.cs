using System.Collections;
using System.Collections.Generic;
namespace Lecture05.Models
{
    public interface IDataBase
    {
        IEnumerable<Department> GetDepartments();
    }

}