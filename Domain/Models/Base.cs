﻿using System.ComponentModel.DataAnnotations;

namespace Domain.Models
{
    public class Base
    {
        [Key]
        public int Id { get; set; }
    }
}
