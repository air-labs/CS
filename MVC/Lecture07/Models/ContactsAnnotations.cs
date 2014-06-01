using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Lecture06.Models
{
    [MetadataType(typeof(ContactsAnnotations))]
    partial class Contacts
    {

    }

    public class ContactsAnnotations
    {
        [Required(ErrorMessage = "Название улицы обязательно для заполнения")]
        public string Street { get; set; }
        [Range(0, 1000, ErrorMessage = "Номер дома не может быть больше 1000")]
        public int House { get; set; }
        [RegularExpression(@"\w+@\w+\.\w+", ErrorMessage = "Неверный формат e-mail")]
        public string EMail { get; set; }
        [PhoneValiator(ErrorMessage = "Неверный формат телефона")]
        public string Phone { get; set; }
    }
}
