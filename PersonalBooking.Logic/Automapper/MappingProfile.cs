using AutoMapper;
using PersonalBooking.Data.Models;
using PersonalBooking.ViewModels.Models;

namespace PersonalBooking.Logic.Automapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, CategoryModel>().ReverseMap();
            CreateMap<Operation, OperationModel>().ReverseMap();

        }
    }
}
