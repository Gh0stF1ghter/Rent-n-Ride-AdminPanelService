using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.VehicleClientHistoryQueries.GetCarModelById;

public sealed class GetVehicleClientHistoryByIdHandler : IRequestHandler<GetVehicleClientHistoryByIdQuery, VehicleClientHistoryModel>
{
    public Task<VehicleClientHistoryModel> Handle(GetVehicleClientHistoryByIdQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}