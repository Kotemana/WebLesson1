using System;

namespace PersonalBooking.ViewModels.Models
{
    public class OperationModel
    {
        public int Id { get; set; }
        public decimal Summ { get; set; }
        public string Name { get; set; }
        public DateTime DateTimeCreated { get; set; }
    }
}
