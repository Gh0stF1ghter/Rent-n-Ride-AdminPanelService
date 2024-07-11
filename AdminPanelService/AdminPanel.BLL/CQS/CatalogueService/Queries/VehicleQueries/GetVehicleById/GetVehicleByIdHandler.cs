using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.CatalogueService.Queries.VehicleQueries.GetVehicleById;

public sealed class GetVehicleByIdHandler : IRequestHandler<GetVehicleByIdQuery, VehicleModel>
{
    public Task<VehicleModel> Handle(GetVehicleByIdQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}