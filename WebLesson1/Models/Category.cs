using System.Collections.Generic;

namespace WebLesson1.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public List<Operation> Operations { get; set; }
    }
}
