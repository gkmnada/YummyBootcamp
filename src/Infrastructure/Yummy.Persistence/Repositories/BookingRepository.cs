﻿using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public sealed class BookingRepository : GenericRepository<Booking>, IBookingRepository
    {
        public BookingRepository(YummyContext context) : base(context)
        {
        }
    }
}
