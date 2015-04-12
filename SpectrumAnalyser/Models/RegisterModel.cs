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
    //Класс модели регистрации:
    public class RegisterModel
    {
        [Required]
        [Display(Name = "Логин ")]
        public string Login { get; set; }

        [Required]
        [StringLength(256, ErrorMessage = "Значение \"{0}\" должно содержать не менее {2} символов.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Пароль")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Подтверждение пароля")]
        [Compare("Password", ErrorMessage = "Пароль и его подтверждение не совпадают.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Имя ")]
        public string UserFirstName { get; set; }

        [Required]
        [Display(Name = "Фамилия ")]
        public string UserLastName { get; set; }

        [Required]
        [Display(Name = "Отчество ")]
        public string UserMiddleName { get; set; }

        [Required]
        [Display(Name = "Email ")]
        public string UserEmail { get; set; }

        [Required]
        [Display(Name = "Телефон ")]
        public string UserPhoneNumber { get; set; }

        [Required]
        [Display(Name = "Мобильный телефон ")]
        public string UserMobilePhoneNumber { get; set; }

    }
}