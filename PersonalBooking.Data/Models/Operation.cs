﻿using System;

namespace PersonalBooking.Data.Models
{
    public class Operation : BaseEntity
    {
        public decimal Summ { get; set; }
        public string Name { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}
