﻿using System;
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
    public class LocalPasswordModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Текущий пароль")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Значение \"{0}\" должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Новый пароль")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("NewPassword", ErrorMessage = "Новый пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }
    }
}