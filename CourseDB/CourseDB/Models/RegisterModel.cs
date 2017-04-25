using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CourseDB.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Почта не может быть пустой")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пароль не может быть пустым")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Пароль не может быть пустым")]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Имя не может быть пустым")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Имя должно быть больше 3 и меньше 30 символов")]
        [Display(Name = "Имя")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Отчество не может быть пустым")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Отчество должно быть больше 3 и меньше 30 символов")]
        [Display(Name = "Отчество")]
        public string MiddleName { get; set; }

        [Required(ErrorMessage = "Фамилия не может быть пустой")]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Фамилия должна быть больше 3 и меньше 30 символов")]
        [Display(Name = "Фамилия")]
        public string LastName { get; set; }
    }
}