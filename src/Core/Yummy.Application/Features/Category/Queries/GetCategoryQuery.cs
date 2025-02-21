using MediatR;
using Yummy.Application.Features.Category.Results;

namespace Yummy.Application.Features.Category.Queries
{
    public sealed class GetCategoryQuery : IRequest<ICollection<GetCategoryQueryResult>>
    {
    }
}
