using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace WebApplication2lab2.Models
{
    public class Book
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }

        [DisplayName("Название книги")]
        public string Title { get; set; }

        [DisplayName("Автор")]
        public string Author { get; set; }

        [DisplayName("Год издания")]
        public int Year { get; set; }

        [DisplayName("Цена")]
        public double Price { get; set; }

        [DisplayName("Дата поступления")]
        [DataType(DataType.Date)]
        public DateTime ArrivalDate { get; set; }
    }
}
