using System;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2.Models
{
    public class Calculator
    {
        [Required(ErrorMessage = "Введите первое число")]
        public int Operand1 { get; set; }

        [Required(ErrorMessage = "Введите второе число")]
        [StringLength(10, ErrorMessage = "Слишком длинное значение (макс. 10 символов)")]
        public string Operand2 { get; set; }

        public string Operation { get; set; }

        public decimal Result { get; set; }
    }
}

