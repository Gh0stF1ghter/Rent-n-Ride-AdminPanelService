using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehiclesInRange;

public sealed class GetVehiclesInRangeHandler : IRequestHandler<GetVehiclesInRangeQuery, IEnumerable<VehicleModel>>
{
    public async Task<IEnumerable<VehicleModel>> Handle(GetVehiclesInRangeQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}