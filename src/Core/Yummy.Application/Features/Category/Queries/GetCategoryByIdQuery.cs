using MediatR;
using Yummy.Application.Features.Category.Results;

namespace Yummy.Application.Features.Category.Queries
{
    public sealed class GetCategoryByIdQuery : IRequest<GetCategoryByIdQueryResult>
    {
        public int CategoryID { get; set; }

        public GetCategoryByIdQuery(int id)
        {
            CategoryID = id;
        }
    }
}
