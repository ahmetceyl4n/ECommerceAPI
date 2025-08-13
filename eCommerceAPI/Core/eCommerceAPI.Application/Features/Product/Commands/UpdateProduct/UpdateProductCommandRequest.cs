using MediatR;

namespace eCommerceAPI.Application.Features.Product.Commands.UpdateProduct;

public class UpdateProductCommandRequest  : IRequest<UpdateProductCommandResponse>
{
    public string id { get; set; }
    public string Name { get; set; }
    public int Stock { get; set; }
    public long Price { get; set; }
}