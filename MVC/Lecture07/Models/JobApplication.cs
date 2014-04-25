using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lecture06.Models
{
    public enum Status
    {
        //[Display(Name="Получено")]
        Received,
        //[Display(Name="Скрыто")]
        Hidden,
        //[Display(Name="Активно")]
        Active,
        //[Display(Name="Отклонено")]
        Rejected
    }

    public enum Priority
    {
        //[Display(Name="Высокий")]
        High,
        //[Display(Name = "Средний")]
        Medium,
        //[Display(Name = "Низкий")]
        Low,
    }

        

    public class JobApplication
    {
    
        //[UIHint("Enum1")]
        public Status Status { get; set; }
        //[UIHint("Enum1")]
        public Priority Priority { get; set; }

        //[UIHint("City")]
        public int City { get; set; }

        //[Display(Name="Приложение закончено")]
        public bool ApplicationComplete { get; set; }
    }
}
