using AdminPanel.BLL.Models;
using MediatR;

namespace AdminPanel.BLL.CQS.RentService.CarModelQueries.GetCarModelById;

public sealed class GetVehicleClientHistoryByIdHandler : IRequestHandler<GetVehicleClientHistoryByIdQuery, VehicleClientHistoryModel>
{
    public Task<VehicleClientHistoryModel> Handle(GetVehicleClientHistoryByIdQuery query, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}