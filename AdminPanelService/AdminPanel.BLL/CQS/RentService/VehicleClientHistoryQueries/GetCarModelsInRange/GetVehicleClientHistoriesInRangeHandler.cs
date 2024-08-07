using AdminPanel.BLL.Models;
using Mapster;
using MediatR;
using RentGrpcService;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelsInRange;

public sealed class GetVehicleClientHistoryModelsInRangeHandler(RentGrpcService.RentService.RentServiceClient client) : IRequestHandler<GetVehicleClientHistoriesInRangeQuery, IEnumerable<VehicleClientHistoryModel>>
{
    public async Task<IEnumerable<VehicleClientHistoryModel>> Handle(GetVehicleClientHistoriesInRangeQuery query, CancellationToken cancellationToken)
    {
        var request = new GetVehicleClientHistoriesInRangeRequest
        {
            PageNumber = query.Page,
            PageSize = query.PageSize,
        };

        var response = await client.GetVehicleClientHistoriesAsync(request, cancellationToken: cancellationToken);

        var vehicleClientHistories = response.VehicleClientHistories.Adapt<IEnumerable<VehicleClientHistoryModel>>();

        return vehicleClientHistories;
    }
}