using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Web.Security;

namespace SpectrumAnalyser.Models
{
    public class RegisterExternalLoginModel
    {
        [Required]
        [Display(Name = "Логин ")]
        public string Login { get; set; }
    }
}