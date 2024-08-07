using AdminPanel.BLL.Models;
using CatalogGrpcService;
using Mapster;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.ManufacturerQueries.GetManufacturerById;

public sealed class GetManufacturerByIdHandler(CatalogService.CatalogServiceClient client) : IRequestHandler<GetManufacturerByIdQuery, ManufacturerModel>
{
    public async Task<ManufacturerModel> Handle(GetManufacturerByIdQuery query, CancellationToken cancellationToken)
    {
        var request = new GetModelRequest
        {
            Id = query.Id.ToString()
        };

        var response = await client.GetManufacturerAsync(request, cancellationToken: cancellationToken);

        var manufacturer = response.Manufacturer.Adapt<ManufacturerModel>();

        return manufacturer;
    }
}