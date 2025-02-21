using MediatR;
using Yummy.Application.Common.Base;

namespace Yummy.Application.Features.Category.Commands
{
    public sealed class CreateCategoryCommand : IRequest<BaseResponse>
    {
        public string Name { get; set; } = string.Empty;
    }
}
