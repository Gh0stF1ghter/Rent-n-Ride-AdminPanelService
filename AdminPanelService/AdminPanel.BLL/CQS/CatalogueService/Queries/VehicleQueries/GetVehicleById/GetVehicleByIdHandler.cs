using AdminPanel.BLL.Models;
using CatalogGrpcService;
using Mapster;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehicleById;

public sealed class GetVehicleByIdHandler(CatalogService.CatalogServiceClient client) : IRequestHandler<GetVehicleByIdQuery, VehicleModel>
{
    public async Task<VehicleModel> Handle(GetVehicleByIdQuery query, CancellationToken cancellationToken)
    {
        var request = new GetModelRequest
        {
            Id = query.Id.ToString()
        };

        var response = await client.GetVehicleAsync(request, cancellationToken: cancellationToken);

        var vehicle = response.Vehicle.Adapt<VehicleModel>();

        return vehicle;
    }
}