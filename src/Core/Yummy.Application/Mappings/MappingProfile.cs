using AutoMapper;
using Yummy.Application.Features.Booking.Commands;
using Yummy.Application.Features.Booking.Results;
using Yummy.Domain.Entities;

namespace Yummy.Application.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            // Booking mappings
            CreateMap<Booking, CreateBookingCommand>().ReverseMap();
            CreateMap<Booking, UpdateBookingCommand>().ReverseMap();
            CreateMap<Booking, GetBookingQueryResult>().ReverseMap();
            CreateMap<Booking, GetBookingByIdQueryResult>().ReverseMap();
        }
    }
}
