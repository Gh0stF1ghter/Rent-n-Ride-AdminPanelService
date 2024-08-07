using AdminPanel.BLL.Models;
using Mapster;
using MediatR;
using RentGrpcService;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelById;

public sealed class GetVehicleClientHistoryByIdHandler(RentGrpcService.RentService.RentServiceClient client) : IRequestHandler<GetVehicleClientHistoryByIdQuery, VehicleClientHistoryModel>
{
    public async Task<VehicleClientHistoryModel> Handle(GetVehicleClientHistoryByIdQuery query, CancellationToken cancellationToken)
    {
        var request = new GetVehicleClientHistoryRequest
        {
            Id = query.Id.ToString()
        };

        var response = await client.GetVehicleClientHistoryAsync(request, cancellationToken: cancellationToken);

        var vehicleClientHistory = response.VehicleClientHistory.Adapt<VehicleClientHistoryModel>();

        return vehicleClientHistory;
    }
}