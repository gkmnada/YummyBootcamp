﻿using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public sealed class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(YummyContext context) : base(context)
        {
        }
    }
}
