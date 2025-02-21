using AutoMapper;
using Yummy.Application.Features.Booking.Commands;
using Yummy.Application.Features.Booking.Results;
using Yummy.Application.Features.Category.Commands;
using Yummy.Application.Features.Category.Results;
using Yummy.Domain.Entities;

namespace Yummy.Application.Mappings
{
    public sealed class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Booking mappings
            CreateMap<Booking, CreateBookingCommand>().ReverseMap();
            CreateMap<Booking, UpdateBookingCommand>().ReverseMap();
            CreateMap<Booking, GetBookingQueryResult>().ReverseMap();
            CreateMap<Booking, GetBookingByIdQueryResult>().ReverseMap();

            // Category mappings
            CreateMap<Category, CreateCategoryCommand>().ReverseMap();
            CreateMap<Category, UpdateCategoryCommand>().ReverseMap();
            CreateMap<Category, GetCategoryQueryResult>().ReverseMap();
            CreateMap<Category, GetCategoryByIdQueryResult>().ReverseMap();
        }
    }
}
