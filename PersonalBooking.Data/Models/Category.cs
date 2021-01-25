using System.Collections.Generic;

namespace PersonalBooking.Data.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Operation> Operations { get; set; }
    }
}
