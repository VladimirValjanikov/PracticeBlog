﻿using System.ComponentModel.DataAnnotations;

namespace PracticeBlog.Data.Models
{
    public class Role
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Поле Имя обязательно для заполнения")]
        [DataType(DataType.Text)]
        [StringLength(100, ErrorMessage = "Поле {0} должно иметь минимум {2} и максимум {1} символов.", MinimumLength = 2)]
        [Display(Name = "Имя", Prompt = "Введите имя")]
        public string Name { get; set; }
        public string Description { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}