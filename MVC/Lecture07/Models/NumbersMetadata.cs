using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Lecture06.Models
{
    [MetadataType(typeof(NumbersMetadataSource))]
    partial class Numbers
    {

    }

    public class NumbersMetadataSource
    {
        [Display(Name="ИНН")]
        public string INN { get; set; }

        [Display(Name = "ИРН ПФР")]
        public string SNILS { get; set; }
    }
}
