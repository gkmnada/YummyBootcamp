using MediatR;
using Yummy.Application.Common.Base;

namespace Yummy.Application.Features.Category.Commands
{
    public sealed class DeleteCategoryCommand : IRequest<BaseResponse>
    {
        public int CategoryID { get; set; }

        public DeleteCategoryCommand(int id)
        {
            CategoryID = id;
        }
    }
}
