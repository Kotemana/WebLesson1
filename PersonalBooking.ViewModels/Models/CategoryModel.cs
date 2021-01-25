using System.Collections.Generic;

namespace PersonalBooking.ViewModels.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<OperationModel> Operations { get; set; }
    }
}
