﻿using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public sealed class ContactRepository : GenericRepository<Contact>, IContactRepository
    {
        public ContactRepository(YummyContext context) : base(context)
        {
        }
    }
}
