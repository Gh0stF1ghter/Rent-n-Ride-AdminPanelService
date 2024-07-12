using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelsInRange;

public sealed class GetVehicleClientHistoryModelsInRangeHandler : IRequestHandler<GetVehicleClientHistoriesInRangeQuery, IEnumerable<VehicleClientHistoryModel>>
{
    public Task<IEnumerable<VehicleClientHistoryModel>> Handle(GetVehicleClientHistoriesInRangeQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}