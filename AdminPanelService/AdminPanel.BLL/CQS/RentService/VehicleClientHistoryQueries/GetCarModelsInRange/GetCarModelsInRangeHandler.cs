using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.CarModelQueries.GetCarModelsInRange;

public sealed class GetVehicleClientHistoryModelsInRangeHandler : IRequestHandler<GetVehicleClientHistoryModelsInRangeQuery, IEnumerable<VehicleClientHistoryModel>>
{
    public Task<IEnumerable<VehicleClientHistoryModel>> Handle(GetVehicleClientHistoryModelsInRangeQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}