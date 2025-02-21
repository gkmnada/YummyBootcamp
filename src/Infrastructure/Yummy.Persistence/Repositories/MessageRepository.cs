using Yummy.Application.Interfaces.Repositories;
using Yummy.Domain.Entities;
using Yummy.Persistence.Context;

namespace Yummy.Persistence.Repositories
{
    public sealed class MessageRepository : GenericRepository<Message>, IMessageRepository
    {
        public MessageRepository(YummyContext context) : base(context)
        {
        }
    }
}
