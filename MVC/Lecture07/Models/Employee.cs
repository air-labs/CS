using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Lecture06.Models
{
    public class Employee
    {
        //[HiddenInput]
        //[HiddenInput(DisplayValue=false)]
        [ScaffoldColumn(false)]
        public int Id { get; set; }

        [Display(Name="Имя и фамилия")]
        public string Name { get; set; }

        [Display(Name="Дата рождения")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name="Резюме")]
        [UIHint("MultilineText")]
        public string Curriculum { get; set; }

        [Display(Name="Работает в настоящий момент?")]
        public bool Staff { get; set; }

        [Display(Name="Желаемая зарплата")]
        public decimal Salary { get; set; }

        public Numbers Numbers { get; set; }

        public override string ToString()
        {
            return string.Format(
@"
ФИО: {0} <br/> 
Работает: {1} <br/> 
Зарплата: {2} <br/>
ИНН: {3} <br/>",
                Name,
                Staff ? "штатный" : "внештатный",
                Salary.ToString("c"),
                Numbers.INN);
        }

       

        public Employee()
        {
            Numbers = new Numbers();
        }
    }
}