using AdminPanel.BLL.Models;
using CatalogGrpcService;
using Mapster;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehiclesInRange;

public sealed class GetVehiclesInRangeHandler(CatalogService.CatalogServiceClient client) : IRequestHandler<GetVehiclesInRangeQuery, IEnumerable<VehicleModel>>
{
    public async Task<IEnumerable<VehicleModel>> Handle(GetVehiclesInRangeQuery query, CancellationToken cancellationToken)
    {
        var request = new GetModelListRequest
        {
            PageNumber = query.Page,
            PageSize = query.PageSize,
        };

        var response = await client.GetVehiclesAsync(request, cancellationToken: cancellationToken);

        var vehicles = response.Vehicles.Adapt<IEnumerable<VehicleModel>>();

        return vehicles;
    }
}