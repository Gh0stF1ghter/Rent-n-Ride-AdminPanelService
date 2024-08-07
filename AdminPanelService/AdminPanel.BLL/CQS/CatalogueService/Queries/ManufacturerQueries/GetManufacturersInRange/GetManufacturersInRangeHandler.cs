using AdminPanel.BLL.Models;
using CatalogGrpcService;
using Mapster;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.ManufacturerQueries.GetManufacturersInRange;

public sealed class GetManufacturersInRangeHandler(CatalogService.CatalogServiceClient client) : IRequestHandler<GetManufacturersInRangeQuery, IEnumerable<ManufacturerModel>>
{
    public async Task<IEnumerable<ManufacturerModel>> Handle(GetManufacturersInRangeQuery query, CancellationToken cancellationToken)
    {
        var request = new GetModelListRequest
        {
            PageNumber = query.Page,
            PageSize = query.PageSize,
        };

        var response = await client.GetManufacturersAsync(request, cancellationToken: cancellationToken);

        var manufacturers = response.Manufacturers.Adapt<IEnumerable<ManufacturerModel>>();

        return manufacturers;
    }
}